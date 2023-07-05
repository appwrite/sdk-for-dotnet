
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;

namespace Appwrite.Services
{
    public class Storage : Service
    {
        public Storage(Client client) : base(client)
        {
        }

        /// <summary>
        /// List buckets
        /// <para>
        /// Get a list of all the storage buckets. You can use the query params to
        /// filter your results.
        /// </para>
        /// </summary>
        public Task<Models.BucketList> ListBuckets(List<string>? queries = null, string? search = null)
        {
            var path = "/storage/buckets";

            var parameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.BucketList Convert(Dictionary<string, object> it) =>
                Models.BucketList.From(map: it);


            return _client.Call<Models.BucketList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create bucket
        /// <para>
        /// Create a new storage bucket.
        /// </para>
        /// </summary>
        public Task<Models.Bucket> CreateBucket(string bucketId, string name, List<string>? permissions = null, bool? fileSecurity = null, bool? enabled = null, long? maximumFileSize = null, List<string>? allowedFileExtensions = null, string? compression = null, bool? encryption = null, bool? antivirus = null)
        {
            var path = "/storage/buckets";

            var parameters = new Dictionary<string, object?>()
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

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Bucket Convert(Dictionary<string, object> it) =>
                Models.Bucket.From(map: it);


            return _client.Call<Models.Bucket>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get Bucket
        /// <para>
        /// Get a storage bucket by its unique ID. This endpoint response returns a
        /// JSON object with the storage bucket metadata.
        /// </para>
        /// </summary>
        public Task<Models.Bucket> GetBucket(string bucketId)
        {
            var path = "/storage/buckets/{bucketId}"
                .Replace("{bucketId}", bucketId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Bucket Convert(Dictionary<string, object> it) =>
                Models.Bucket.From(map: it);


            return _client.Call<Models.Bucket>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Bucket
        /// <para>
        /// Update a storage bucket by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Bucket> UpdateBucket(string bucketId, string name, List<string>? permissions = null, bool? fileSecurity = null, bool? enabled = null, long? maximumFileSize = null, List<string>? allowedFileExtensions = null, string? compression = null, bool? encryption = null, bool? antivirus = null)
        {
            var path = "/storage/buckets/{bucketId}"
                .Replace("{bucketId}", bucketId);

            var parameters = new Dictionary<string, object?>()
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

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Bucket Convert(Dictionary<string, object> it) =>
                Models.Bucket.From(map: it);


            return _client.Call<Models.Bucket>(
                method: "PUT",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete Bucket
        /// <para>
        /// Delete a storage bucket by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteBucket(string bucketId)
        {
            var path = "/storage/buckets/{bucketId}"
                .Replace("{bucketId}", bucketId);

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
        /// List Files
        /// <para>
        /// Get a list of all the user files. You can use the query params to filter
        /// your results.
        /// </para>
        /// </summary>
        public Task<Models.FileList> ListFiles(string bucketId, List<string>? queries = null, string? search = null)
        {
            var path = "/storage/buckets/{bucketId}/files"
                .Replace("{bucketId}", bucketId);

            var parameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.FileList Convert(Dictionary<string, object> it) =>
                Models.FileList.From(map: it);


            return _client.Call<Models.FileList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

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
        public Task<Models.File> CreateFile(string bucketId, string fileId, InputFile file, List<string>? permissions = null, Action<UploadProgress>? onProgress = null)
        {
            var path = "/storage/buckets/{bucketId}/files"
                .Replace("{bucketId}", bucketId);

            var parameters = new Dictionary<string, object?>()
            {
                { "fileId", fileId },
                { "file", file },
                { "permissions", permissions }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "multipart/form-data" }
            };



            static Models.File Convert(Dictionary<string, object> it) =>
                Models.File.From(map: it);

            string? idParamName = "fileId";

            var paramName = "file";

            return _client.ChunkedUpload(
                path,
                headers,
                parameters,
                Convert,
                paramName,
                idParamName,
                onProgress);
        }

        /// <summary>
        /// Get File
        /// <para>
        /// Get a file by its unique ID. This endpoint response returns a JSON object
        /// with the file metadata.
        /// </para>
        /// </summary>
        public Task<Models.File> GetFile(string bucketId, string fileId)
        {
            var path = "/storage/buckets/{bucketId}/files/{fileId}"
                .Replace("{bucketId}", bucketId)
                .Replace("{fileId}", fileId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.File Convert(Dictionary<string, object> it) =>
                Models.File.From(map: it);


            return _client.Call<Models.File>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update File
        /// <para>
        /// Update a file by its unique ID. Only users with write permissions have
        /// access to update this resource.
        /// </para>
        /// </summary>
        public Task<Models.File> UpdateFile(string bucketId, string fileId, List<string>? permissions = null)
        {
            var path = "/storage/buckets/{bucketId}/files/{fileId}"
                .Replace("{bucketId}", bucketId)
                .Replace("{fileId}", fileId);

            var parameters = new Dictionary<string, object?>()
            {
                { "permissions", permissions }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.File Convert(Dictionary<string, object> it) =>
                Models.File.From(map: it);


            return _client.Call<Models.File>(
                method: "PUT",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete File
        /// <para>
        /// Delete a file by its unique ID. Only users with write permissions have
        /// access to delete this resource.
        /// </para>
        /// </summary>
        public Task<object> DeleteFile(string bucketId, string fileId)
        {
            var path = "/storage/buckets/{bucketId}/files/{fileId}"
                .Replace("{bucketId}", bucketId)
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
        public Task<byte[]> GetFileDownload(string bucketId, string fileId)
        {
            var path = "/storage/buckets/{bucketId}/files/{fileId}/download"
                .Replace("{bucketId}", bucketId)
                .Replace("{fileId}", fileId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            return _client.Call<byte[]>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
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
        public Task<byte[]> GetFilePreview(string bucketId, string fileId, long? width = null, long? height = null, string? gravity = null, long? quality = null, long? borderWidth = null, string? borderColor = null, long? borderRadius = null, double? opacity = null, long? rotation = null, string? background = null, string? output = null)
        {
            var path = "/storage/buckets/{bucketId}/files/{fileId}/preview"
                .Replace("{bucketId}", bucketId)
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
                { "output", output }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            return _client.Call<byte[]>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Get File for View
        /// <para>
        /// Get a file content by its unique ID. This endpoint is similar to the
        /// download method but returns with no  'Content-Disposition: attachment'
        /// header.
        /// </para>
        /// </summary>
        public Task<byte[]> GetFileView(string bucketId, string fileId)
        {
            var path = "/storage/buckets/{bucketId}/files/{fileId}/view"
                .Replace("{bucketId}", bucketId)
                .Replace("{fileId}", fileId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            return _client.Call<byte[]>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

    }
}
