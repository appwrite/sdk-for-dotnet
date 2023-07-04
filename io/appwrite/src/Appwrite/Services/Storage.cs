
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Storage : Service
    {
        public Storage(Client client) : base(client) { }

        /// <summary>
        /// List buckets
        /// <para>
        /// Get a list of all the storage buckets. You can use the query params to
        /// filter your results.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> ListBuckets(List<string> queries = null, string search = "") 
        {
            string path = "/storage/buckets";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "queries", queries },
                { "search", search }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Create bucket
        /// <para>
        /// Create a new storage bucket.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateBucket(string bucketId, string name, List<string> permissions = null, bool? fileSecurity = false, bool? enabled = true, int? maximumFileSize = 30000000, List<string> allowedFileExtensions = null, string compression = "none", bool? encryption = true, bool? antivirus = true) 
        {
            string path = "/storage/buckets";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "bucketId", bucketId },
                { "name", name },
                { "permissions", permissions },
                { "fileSecurity", fileSecurity },
                { "enabled", enabled },
                { "maximumFileSize", maximumFileSize },
                { "allowedFileExtensions", allowedFileExtensions },
                { "compression", compression },
                { "encryption", encryption },
                { "antivirus", antivirus }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Get Bucket
        /// <para>
        /// Get a storage bucket by its unique ID. This endpoint response returns a
        /// JSON object with the storage bucket metadata.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> GetBucket(string bucketId) 
        {
            string path = "/storage/buckets/{bucketId}".Replace("{bucketId}", bucketId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Update Bucket
        /// <para>
        /// Update a storage bucket by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateBucket(string bucketId, string name, List<string> permissions = null, bool? fileSecurity = false, bool? enabled = true, int? maximumFileSize = null, List<string> allowedFileExtensions = null, string compression = "none", bool? encryption = true, bool? antivirus = true) 
        {
            string path = "/storage/buckets/{bucketId}".Replace("{bucketId}", bucketId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "name", name },
                { "permissions", permissions },
                { "fileSecurity", fileSecurity },
                { "enabled", enabled },
                { "maximumFileSize", maximumFileSize },
                { "allowedFileExtensions", allowedFileExtensions },
                { "compression", compression },
                { "encryption", encryption },
                { "antivirus", antivirus }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PUT", path, headers, parameters);
        }

        /// <summary>
        /// Delete Bucket
        /// <para>
        /// Delete a storage bucket by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> DeleteBucket(string bucketId) 
        {
            string path = "/storage/buckets/{bucketId}".Replace("{bucketId}", bucketId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }

        /// <summary>
        /// List Files
        /// <para>
        /// Get a list of all the user files. You can use the query params to filter
        /// your results.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> ListFiles(string bucketId, List<string> queries = null, string search = "") 
        {
            string path = "/storage/buckets/{bucketId}/files".Replace("{bucketId}", bucketId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "queries", queries },
                { "search", search }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Create File
        /// <para>
        /// Create a new file. Before using this route, you should create a new bucket
        /// resource using either a [server
        /// integration](/docs/server/storage#storageCreateBucket) API or directly from
        /// your Appwrite console.
        /// 
        /// Larger files should be uploaded using multiple requests with the
        /// [content-range](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Range)
        /// header to send a partial request with a maximum supported chunk of `5MB`.
        /// The `content-range` header values should always be in bytes.
        /// 
        /// When the first request is sent, the server will return the **File** object,
        /// and the subsequent part request must include the file's **id** in
        /// `x-appwrite-id` header to allow the server to know that the partial upload
        /// is for the existing file and not for a new one.
        /// 
        /// If you're creating a new file using one of the Appwrite SDKs, all the
        /// chunking logic will be managed by the SDK internally.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateFile(string bucketId, string fileId, FileInfo file, List<string> permissions = null) 
        {
            string path = "/storage/buckets/{bucketId}/files".Replace("{bucketId}", bucketId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "fileId", fileId },
                { "file", file },
                { "permissions", permissions }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "multipart/form-data" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Get File
        /// <para>
        /// Get a file by its unique ID. This endpoint response returns a JSON object
        /// with the file metadata.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> GetFile(string bucketId, string fileId) 
        {
            string path = "/storage/buckets/{bucketId}/files/{fileId}".Replace("{bucketId}", bucketId).Replace("{fileId}", fileId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Update File
        /// <para>
        /// Update a file by its unique ID. Only users with write permissions have
        /// access to update this resource.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateFile(string bucketId, string fileId, List<string> permissions = null) 
        {
            string path = "/storage/buckets/{bucketId}/files/{fileId}".Replace("{bucketId}", bucketId).Replace("{fileId}", fileId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "permissions", permissions }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PUT", path, headers, parameters);
        }

        /// <summary>
        /// Delete File
        /// <para>
        /// Delete a file by its unique ID. Only users with write permissions have
        /// access to delete this resource.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> DeleteFile(string bucketId, string fileId) 
        {
            string path = "/storage/buckets/{bucketId}/files/{fileId}".Replace("{bucketId}", bucketId).Replace("{fileId}", fileId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }

        /// <summary>
        /// Get File for Download
        /// <para>
        /// Get a file content by its unique ID. The endpoint response return with a
        /// 'Content-Disposition: attachment' header that tells the browser to start
        /// downloading the file to user downloads directory.
        /// </para>
        /// </summary>
        public string GetFileDownload(string bucketId, string fileId) 
        {
            string path = "/storage/buckets/{bucketId}/files/{fileId}/download".Replace("{bucketId}", bucketId).Replace("{fileId}", fileId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };
            // { "project", _client.GetConfig().get("project") },
            // { "key", _client.GetConfig().get("key") }
            
            return _client.GetEndPoint() + path + "?" + parameters.ToQueryString();
        }

        /// <summary>
        /// Get File Preview
        /// <para>
        /// Get a file preview image. Currently, this method supports preview for image
        /// files (jpg, png, and gif), other supported formats, like pdf, docs, slides,
        /// and spreadsheets, will return the file icon image. You can also pass query
        /// string arguments for cutting and resizing your preview image. Preview is
        /// supported only for image files smaller than 10MB.
        /// </para>
        /// </summary>
        public string GetFilePreview(string bucketId, string fileId, int? width = 0, int? height = 0, string gravity = "center", int? quality = 100, int? borderWidth = 0, string borderColor = "", int? borderRadius = 0, number opacity = , int? rotation = 0, string background = "", string output = "") 
        {
            string path = "/storage/buckets/{bucketId}/files/{fileId}/preview".Replace("{bucketId}", bucketId).Replace("{fileId}", fileId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
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
            };
            // { "project", _client.GetConfig().get("project") },
            // { "key", _client.GetConfig().get("key") }
            
            return _client.GetEndPoint() + path + "?" + parameters.ToQueryString();
        }

        /// <summary>
        /// Get File for View
        /// <para>
        /// Get a file content by its unique ID. This endpoint is similar to the
        /// download method but returns with no  'Content-Disposition: attachment'
        /// header.
        /// </para>
        /// </summary>
        public string GetFileView(string bucketId, string fileId) 
        {
            string path = "/storage/buckets/{bucketId}/files/{fileId}/view".Replace("{bucketId}", bucketId).Replace("{fileId}", fileId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };
            // { "project", _client.GetConfig().get("project") },
            // { "key", _client.GetConfig().get("key") }
            
            return _client.GetEndPoint() + path + "?" + parameters.ToQueryString();
        }
    };
}