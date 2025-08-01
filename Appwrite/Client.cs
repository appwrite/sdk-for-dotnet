using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Appwrite.Converters;
using Appwrite.Extensions;
using Appwrite.Models;

namespace Appwrite
{
    public class Client
    {
        public string Endpoint => _endpoint;
        public Dictionary<string, string> Config => _config;

        private HttpClient _http;
        private HttpClient _httpForRedirect;
        private readonly Dictionary<string, string> _headers;
        private readonly Dictionary<string, string> _config;
        private string _endpoint;

        private static readonly int ChunkSize = 5 * 1024 * 1024;

        public static JsonSerializerOptions DeserializerOptions { get; set; } = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            PropertyNameCaseInsensitive = true,
            Converters =
            {
                new JsonStringEnumConverter(JsonNamingPolicy.CamelCase),
                new ValueClassConverter(),
                new ObjectToInferredTypesConverter()
            }
        };

        public static JsonSerializerOptions SerializerOptions { get; set; } = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Converters =
            {
                new JsonStringEnumConverter(JsonNamingPolicy.CamelCase),
                new ValueClassConverter(),
                new ObjectToInferredTypesConverter()
            }
        };

        public Client(
            string endpoint = "https://cloud.appwrite.io/v1",
            bool selfSigned = false,
            HttpClient? http = null,
            HttpClient? httpForRedirect = null)
        {
            _endpoint = endpoint;
            _http = http ?? new HttpClient();

            _httpForRedirect = httpForRedirect ?? new HttpClient(
                new HttpClientHandler(){
                    AllowAutoRedirect = false
                });

            _headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" },
                { "user-agent" , $"AppwriteDotNetSDK/0.15.0 ({Environment.OSVersion.Platform}; {Environment.OSVersion.VersionString})"},
                { "x-sdk-name", ".NET" },
                { "x-sdk-platform", "server" },
                { "x-sdk-language", "dotnet" },
                { "x-sdk-version", "0.15.0"},
                { "X-Appwrite-Response-Format", "1.7.0" }
            };

            _config = new Dictionary<string, string>();

            if (selfSigned)
            {
                SetSelfSigned(true);
            }
        }

        public Client SetSelfSigned(bool selfSigned)
        {
            var handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (request, cert, chain, errors) => true
            };

            _http = selfSigned
                ? new HttpClient(handler)
                : new HttpClient();

            return this;
        }

        public Client SetEndpoint(string endpoint)
        {
            if (!endpoint.StartsWith("http://") && !endpoint.StartsWith("https://")) {
                throw new AppwriteException("Invalid endpoint URL: " + endpoint);
            }

            _endpoint = endpoint;
            return this;
        }

        /// <summary>Your project ID</summary>
        public Client SetProject(string value) {
            _config.Add("project", value);
            AddHeader("X-Appwrite-Project", value);

            return this;
        }

        /// <summary>Your secret API key</summary>
        public Client SetKey(string value) {
            _config.Add("key", value);
            AddHeader("X-Appwrite-Key", value);

            return this;
        }

        /// <summary>Your secret JSON Web Token</summary>
        public Client SetJWT(string value) {
            _config.Add("jWT", value);
            AddHeader("X-Appwrite-JWT", value);

            return this;
        }

        public Client SetLocale(string value) {
            _config.Add("locale", value);
            AddHeader("X-Appwrite-Locale", value);

            return this;
        }

        /// <summary>The user session to authenticate with</summary>
        public Client SetSession(string value) {
            _config.Add("session", value);
            AddHeader("X-Appwrite-Session", value);

            return this;
        }

        /// <summary>The user agent string of the client that made the request</summary>
        public Client SetForwardedUserAgent(string value) {
            _config.Add("forwardedUserAgent", value);
            AddHeader("X-Forwarded-User-Agent", value);

            return this;
        }

        public Client AddHeader(string key, string value)
        {
            _headers.Add(key, value);

            return this;
        }

        private HttpRequestMessage PrepareRequest(
            string method,
            string path,
            Dictionary<string, string> headers,
            Dictionary<string, object?> parameters)
        {
            var methodGet = "GET".Equals(method, StringComparison.OrdinalIgnoreCase);

            var queryString = methodGet ?
                "?" + parameters.ToQueryString() :
                string.Empty;

            var request = new HttpRequestMessage(
                new HttpMethod(method),
                _endpoint + path + queryString);

            if (headers.TryGetValue("content-type", out var contentType) && 
                "multipart/form-data".Equals(contentType, StringComparison.OrdinalIgnoreCase))
            {
                var form = new MultipartFormDataContent();

                foreach (var parameter in parameters)
                {
                    if (parameter.Key == "file")
                    {
                        var fileContent = parameters["file"] as MultipartFormDataContent;
                        if (fileContent != null)
                        {
                            form.Add(fileContent.First()!);
                        }
                    }
                    else if (parameter.Value is IEnumerable<object> enumerable)
                    {
                        var list = new List<object>(enumerable);
                        for (int index = 0; index < list.Count; index++)
                        {
                            form.Add(new StringContent(list[index]?.ToString() ?? string.Empty), $"{parameter.Key}[{index}]");
                        }
                    }
                    else
                    {
                        form.Add(new StringContent(parameter.Value?.ToString() ?? string.Empty), parameter.Key);
                    }
                }
                request.Content = form;

            }
            else if (!methodGet)
            {
                string body = parameters.ToJson();

                request.Content = new StringContent(body, Encoding.UTF8, "application/json");
            }

            foreach (var header in _headers)
            {
                if (header.Key.Equals("content-type", StringComparison.OrdinalIgnoreCase))
                {
                    _http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(header.Value));
                }
                else
                {
                    if (_http.DefaultRequestHeaders.Contains(header.Key)) {
                        _http.DefaultRequestHeaders.Remove(header.Key);
                    }
                    _http.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
            }

            foreach (var header in headers)
            {
                if (header.Key.Equals("content-type", StringComparison.OrdinalIgnoreCase))
                {
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(header.Value));
                }
                else if (header.Key.Equals("content-range", StringComparison.OrdinalIgnoreCase))
                {
                    request.Content.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
                else
                {
                    if (request.Headers.Contains(header.Key)) {
                        request.Headers.Remove(header.Key);
                    }
                    request.Headers.Add(header.Key, header.Value);
                }
            }

            return request;
        }

        public async Task<String> Redirect(
            string method,
            string path,
            Dictionary<string, string> headers,
            Dictionary<string, object?> parameters)
        {
            var request = this.PrepareRequest(method, path, headers, parameters);

            var response = await _httpForRedirect.SendAsync(request);
            var code = (int)response.StatusCode;

            if (code >= 400) {
                var text = await response.Content.ReadAsStringAsync();
                var message = "";
                var type = "";

                string contentType = string.Empty;
                if (response.Content.Headers.TryGetValues("Content-Type", out var contentTypes))
                {
                    contentType = contentTypes.FirstOrDefault() ?? string.Empty;
                }

                if (contentType.Contains("application/json")) {
                    try 
                    {
                        using var errorDoc = JsonDocument.Parse(text);
                        message = errorDoc.RootElement.GetProperty("message").GetString() ?? "";
                        if (errorDoc.RootElement.TryGetProperty("type", out var typeElement))
                        {
                            type = typeElement.GetString() ?? "";
                        }
                    }
                    catch
                    {
                        message = text;
                    }
                } else {
                    message = text;
                }

                throw new AppwriteException(message, code, type, text);
            }

            return response.Headers.Location?.OriginalString ?? string.Empty;
        }

        public Task<Dictionary<string, object?>> Call(
            string method,
            string path,
            Dictionary<string, string> headers,
            Dictionary<string, object?> parameters)
        {
            return Call<Dictionary<string, object?>>(method, path, headers, parameters);
        }

        public async Task<T> Call<T>(
            string method,
            string path,
            Dictionary<string, string> headers,
            Dictionary<string, object?> parameters,
            Func<Dictionary<string, object>, T>? convert = null) where T : class
        {
            var request = this.PrepareRequest(method, path, headers, parameters);

            var response = await _http.SendAsync(request);
            var code = (int)response.StatusCode;

            if (response.Headers.TryGetValues("x-appwrite-warning", out var warnings))
            {
                foreach (var warning in warnings)
                {
                    Console.WriteLine("Warning: " + warning);
                }
            }

            string contentType = string.Empty;
            if (response.Content.Headers.TryGetValues("Content-Type", out var contentTypes))
            {
                contentType = contentTypes.FirstOrDefault() ?? string.Empty;
            }

            var isJson = contentType.Contains("application/json");

            if (code >= 400) {
                var text = await response.Content.ReadAsStringAsync();
                var message = "";
                var type = "";

                if (isJson) {
                    try 
                    {
                        using var errorDoc = JsonDocument.Parse(text);
                        message = errorDoc.RootElement.GetProperty("message").GetString() ?? "";
                        if (errorDoc.RootElement.TryGetProperty("type", out var typeElement))
                        {
                            type = typeElement.GetString() ?? "";
                        }
                    }
                    catch
                    {
                        message = text;
                    }
                } else {
                    message = text;
                }

                throw new AppwriteException(message, code, type, text);
            }

            if (isJson)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                var dict = JsonSerializer.Deserialize<Dictionary<string, object>>(
                    responseString,
                    DeserializerOptions);

                if (convert != null && dict != null)
                {
                    return convert(dict);
                }

                return (dict as T)!;
            }
            else
            {
                return ((await response.Content.ReadAsByteArrayAsync()) as T)!;
            }
        }

        public async Task<T> ChunkedUpload<T>(
            string path,
            Dictionary<string, string> headers,
            Dictionary<string, object?> parameters,
            Func<Dictionary<string, object>, T> converter,
            string paramName,
            string? idParamName = null,
            Action<UploadProgress>? onProgress = null) where T : class
        {
            if (string.IsNullOrEmpty(paramName))
                throw new ArgumentException("Parameter name cannot be null or empty", nameof(paramName));
                
            if (!parameters.ContainsKey(paramName))
                throw new ArgumentException($"Parameter {paramName} not found", nameof(paramName));
                
            var input = parameters[paramName] as InputFile;
            if (input == null)
                throw new ArgumentException($"Parameter {paramName} must be an InputFile", nameof(paramName));
                
            var size = 0L;
            switch(input.SourceType)
            {
                case "path":
                    var info = new FileInfo(input.Path);
                    input.Data = info.OpenRead();
                    size = info.Length;
                    break;
                case "stream":
                    var stream = input.Data as Stream;
                    if (stream == null)
                        throw new InvalidOperationException("Stream data is null");
                    size = stream.Length;
                    break;
                case "bytes":
                    var bytes = input.Data as byte[];
                    if (bytes == null)
                        throw new InvalidOperationException("Byte array data is null");
                    size = bytes.Length;
                    break;
            };

            var offset = 0L;
            var buffer = new byte[Math.Min(size, ChunkSize)];
            var result = new Dictionary<string, object?>();

            if (size < ChunkSize)
            {
                switch(input.SourceType)
                {
                    case "path":
                    case "stream":
                        var dataStream = input.Data as Stream;
                        if (dataStream == null)
                            throw new InvalidOperationException("Stream data is null");
                        await dataStream.ReadAsync(buffer, 0, (int)size);
                        break;
                    case "bytes":
                        var dataBytes = input.Data as byte[];
                        if (dataBytes == null)
                            throw new InvalidOperationException("Byte array data is null");
                        buffer = dataBytes;
                        break;
                }

                var content = new MultipartFormDataContent {
                    { new ByteArrayContent(buffer), paramName, input.Filename }
                };

                parameters[paramName] = content;

                return await Call(
                    method: "POST",
                    path,
                    headers,
                    parameters,
                    converter
                );
            }

            if (!string.IsNullOrEmpty(idParamName))
            {
                try
                {
                // Make a request to check if a file already exists
                var current = await Call<Dictionary<string, object?>>(
                    method: "GET",
                    path: $"{path}/{parameters[idParamName!]}",
                    new Dictionary<string, string> { { "content-type", "application/json" } },
                    parameters: new Dictionary<string, object?>()
                );
                if (current.TryGetValue("chunksUploaded", out var chunksUploadedValue) && chunksUploadedValue != null)
                {
                    offset = Convert.ToInt64(chunksUploadedValue) * ChunkSize;
                }
            }
                catch
                {
                    // ignored as it mostly means file not found
                }
            }

            while (offset < size)
            {
                switch(input.SourceType)
                {
                    case "path":
                    case "stream":
                        var stream = input.Data as Stream;
                        if (stream == null)
                            throw new InvalidOperationException("Stream data is null");
                        stream.Seek(offset, SeekOrigin.Begin);
                        await stream.ReadAsync(buffer, 0, ChunkSize);
                        break;
                    case "bytes":
                        buffer = ((byte[])input.Data)
                            .Skip((int)offset)
                            .Take((int)Math.Min(size - offset, ChunkSize - 1))
                            .ToArray();
                        break;
                }

                var content = new MultipartFormDataContent {
                    { new ByteArrayContent(buffer), paramName, input.Filename }
                };

                parameters[paramName] = content;

                headers["Content-Range"] =
                    $"bytes {offset}-{Math.Min(offset + ChunkSize - 1, size - 1)}/{size}";

                result = await Call<Dictionary<string, object?>>(
                    method: "POST",
                    path,
                    headers,
                    parameters
                );

                offset += ChunkSize;

                var id = result.ContainsKey("$id")
                    ? result["$id"]?.ToString() ?? string.Empty
                    : string.Empty;
                var chunksTotal = result.TryGetValue("chunksTotal", out var chunksTotalValue) && chunksTotalValue != null
                    ? Convert.ToInt64(chunksTotalValue)
                    : 0L;
                var chunksUploaded = result.TryGetValue("chunksUploaded", out var chunksUploadedValue) && chunksUploadedValue != null
                    ? Convert.ToInt64(chunksUploadedValue)
                    : 0L;

                headers["x-appwrite-id"] = id;

                onProgress?.Invoke(
                    new UploadProgress(
                        id: id,
                        progress: Math.Min(offset, size) / size * 100,
                        sizeUploaded: Math.Min(offset, size),
                        chunksTotal: chunksTotal,
                        chunksUploaded: chunksUploaded));
            }

            // Convert to non-nullable dictionary for converter
            var nonNullableResult = result.Where(kvp => kvp.Value != null)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value!);
            
            return converter(nonNullableResult);
        }
    }
}
