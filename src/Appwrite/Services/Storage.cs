
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Storage : Service
    {
        public Storage(Client client) : base(client) { }

        /// <summary>
        /// List Files
        /// <para>
        /// Get a list of all the user files. You can use the query params to filter
        /// your results. On admin mode, this endpoint will return a list of all of the
        /// project's files. [Learn more about different API modes](/docs/admin).
        /// </para>
        /// </summary>
        public Task<Models.FileList> ListFiles(string? search = null, int? limit = null, int? offset = null, OrderType orderType = OrderType.ASC)
        {
            var path = "/storage/files";

            var parameters = new Dictionary<string, object?>()
            {
                { "search", search },
                { "limit", limit },
                { "offset", offset },
                { "orderType", orderType.ToString() }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.FileList convert(Dictionary<string, object> it)
            {
                return Models.FileList.From(map: it);
            }

            return _client.Call<Models.FileList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.FileList));
        }

        /// <summary>
        /// Create File
        /// <para>
        /// Create a new file. The user who creates the file will automatically be
        /// assigned to read and write access unless he has passed custom values for
        /// read and write arguments.
        /// </para>
        /// </summary>
        public Task<Models.File> CreateFile(FileInfo file, List<object>? read = null, List<object>? write = null)
        {
            var path = "/storage/files";

            var parameters = new Dictionary<string, object?>()
            {
                { "file", file },
                { "read", read },
                { "write", write }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "multipart/form-data" }
            };


            static Models.File convert(Dictionary<string, object> it)
            {
                return Models.File.From(map: it);
            }

            return _client.Call<Models.File>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.File));
        }

        /// <summary>
        /// Get File
        /// <para>
        /// Get a file by its unique ID. This endpoint response returns a JSON object
        /// with the file metadata.
        /// </para>
        /// </summary>
        public Task<Models.File> GetFile(string fileId)
        {
            var path = "/storage/files/{fileId}"
                .Replace("{fileId}", fileId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.File convert(Dictionary<string, object> it)
            {
                return Models.File.From(map: it);
            }

            return _client.Call<Models.File>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.File));
        }

        /// <summary>
        /// Update File
        /// <para>
        /// Update a file by its unique ID. Only users with write permissions have
        /// access to update this resource.
        /// </para>
        /// </summary>
        public Task<Models.File> UpdateFile(string fileId, List<object> read, List<object> write)
        {
            var path = "/storage/files/{fileId}"
                .Replace("{fileId}", fileId);

            var parameters = new Dictionary<string, object?>()
            {
                { "read", read },
                { "write", write }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.File convert(Dictionary<string, object> it)
            {
                return Models.File.From(map: it);
            }

            return _client.Call<Models.File>(
                method: "PUT",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.File));
        }

        /// <summary>
        /// Delete File
        /// <para>
        /// Delete a file by its unique ID. Only users with write permissions have
        /// access to delete this resource.
        /// </para>
        /// </summary>
        public Task<object> DeleteFile(string fileId)
        {
            var path = "/storage/files/{fileId}"
                .Replace("{fileId}", fileId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Get File for Download
        /// <para>
        /// Get a file content by its unique ID. The endpoint response return with a
        /// 'Content-Disposition: attachment' header that tells the browser to start
        /// downloading the file to user downloads directory.
        /// </para>
        /// </summary>
        public Task<byte[]> GetFileDownload(string fileId)
        {
            var path = "/storage/files/{fileId}/download"
                .Replace("{fileId}", fileId);

            var parameters = new Dictionary<string, object?>()
            {
                { "project", _client.Config["project"] },
                { "key", _client.Config["key"] },
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return _client.Call<byte[]>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                responseType: typeof(byte[]));
        }

        /// <summary>
        /// Get File Preview
        /// <para>
        /// Get a file preview image. Currently, this method supports preview for image
        /// files (jpg, png, and gif), other supported formats, like pdf, docs, slides,
        /// and spreadsheets, will return the file icon image. You can also pass query
        /// string arguments for cutting and resizing your preview image.
        /// </para>
        /// </summary>
        public Task<byte[]> GetFilePreview(string fileId, int? width = null, int? height = null, string? gravity = null, int? quality = null, int? borderWidth = null, string? borderColor = null, int? borderRadius = null, double? opacity = null, int? rotation = null, string? background = null, string? output = null)
        {
            var path = "/storage/files/{fileId}/preview"
                .Replace("{fileId}", fileId);

            var parameters = new Dictionary<string, object?>()
            {
                { "width", width },
                { "height", height },
                { "gravity", gravity },
                { "quality", quality },
                { "borderWidth", borderWidth },
                { "borderColor", borderColor },
                { "borderRadius", borderRadius },
                { "opacity", opacity },
                { "rotation", rotation },
                { "background", background },
                { "output", output },
                { "project", _client.Config["project"] },
                { "key", _client.Config["key"] },
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return _client.Call<byte[]>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                responseType: typeof(byte[]));
        }

        /// <summary>
        /// Get File for View
        /// <para>
        /// Get a file content by its unique ID. This endpoint is similar to the
        /// download method but returns with no  'Content-Disposition: attachment'
        /// header.
        /// </para>
        /// </summary>
        public Task<byte[]> GetFileView(string fileId)
        {
            var path = "/storage/files/{fileId}/view"
                .Replace("{fileId}", fileId);

            var parameters = new Dictionary<string, object?>()
            {
                { "project", _client.Config["project"] },
                { "key", _client.Config["key"] },
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return _client.Call<byte[]>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                responseType: typeof(byte[]));
        }
    };
}