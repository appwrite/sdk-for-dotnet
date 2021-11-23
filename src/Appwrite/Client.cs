using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Client
    {
        public string EndPoint => _endPoint;
        public Dictionary<string, string> Config => _config;

        private HttpClient _http;
        private readonly Dictionary<string, string> _headers;
        private readonly Dictionary<string, string> _config;
        private string _endPoint;

        private JsonSerializerSettings _serializerSettings = new JsonSerializerSettings {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            Converters = new List<JsonConverter> {
                new Int32JsonConverter()
            }
        };

        public Client(
            string endPoint = "https://appwrite.io/v1",
            bool selfSigned = false,
            HttpClient? http = null)
        {
            _endPoint = endPoint;
            _http = http ?? new HttpClient();
            _headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" },
                { "x-sdk-version", "appwrite:dotnet:0.3.0" },
                { "X-Appwrite-Response-Format", "0.11.0" }
            };
            _config = new Dictionary<string, string>();


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

        public Client SetEndPoint(string endPoint)
        {
            _endPoint = endPoint;

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

        public Client AddHeader(string key, string value)
        {
            _headers.Add(key, value);

            return this;
        }

        public Task Call(
            string method,
            string path,
            Dictionary<string, string> headers,
            Dictionary<string, object> parameters)
        {
            return Call<object>(method, path, headers, parameters);
        }

        public async Task<T> Call<T>(
            string method,
            string path,
            Dictionary<string, string> headers,
            Dictionary<string, object> parameters,
            Func<Dictionary<string, object>, T>? convert = null,
            Type? responseType = null) where T : class
        {
            var methodGet = "GET".Equals(method, StringComparison.OrdinalIgnoreCase);

            var queryString = methodGet ? "?" + parameters.ToQueryString() : string.Empty;

            var request = new HttpRequestMessage(new HttpMethod(method), _endPoint + path + queryString);

            if ("multipart/form-data".Equals(headers["content-type"], StringComparison.OrdinalIgnoreCase))
            {
                var form = new MultipartFormDataContent();

                foreach (var parameter in parameters)
                {
                    if (parameter.Key == "file")
                    {
                        var fi = (FileInfo)parameters["file"];
                        var file = File.ReadAllBytes(fi.FullName);

                        form.Add(new ByteArrayContent(file, 0, file.Length), "file", fi.Name);
                    }
                    else if (parameter.Value is IEnumerable<object> enumerable)
                    {
                        var list = new List<object>(enumerable);
                        for (int index = 0; index < list.Count; index++)
                        {
                            form.Add(new StringContent(list[index].ToString()!), $"{parameter.Key}[{index}]");
                        }
                    }
                    else
                    {
                        form.Add(new StringContent(parameter.Value.ToString()!), parameter.Key);
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
                else
                {
                    if (request.Headers.Contains(header.Key)) {
                        request.Headers.Remove(header.Key);
                    }
                    request.Headers.Add(header.Key, header.Value);
                }
            }
            try
            {
                var response = await _http.SendAsync(request);
                var code = (int)response.StatusCode;
                var contentType = response.Content.Headers
                    .GetValues("Content-Type")
                    .FirstOrDefault() ?? string.Empty;

                var isJson = contentType.Contains("application/json");
                var isBytes = contentType.Contains("application/octet-stream");

                if (code >= 400) {
                    var message = await response.Content.ReadAsStringAsync();

                    if (isJson) {
                        message = JObject.Parse(message)["message"]!.ToString();
                    }

                    throw new AppwriteException(message, code);
                }

                if (isJson)
                {
                    var responseString = await response.Content.ReadAsStringAsync();

                    var dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(
                        responseString,
                        _serializerSettings);

                    if (convert != null)
                    {
                        return convert(dict!);
                    }

                    return (dict as T)!;
                }
                else if (isBytes)
                {
                    return ((await response.Content.ReadAsByteArrayAsync()) as T)!;
                }
                else
                {
                    return default!;
                }
            }
            catch (System.Exception e)
            {
                throw new AppwriteException(e.Message, e);
            }
        }
    }
}
