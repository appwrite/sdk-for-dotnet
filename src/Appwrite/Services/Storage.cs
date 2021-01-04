
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Storage : Service
    {

        public Storage(Client client) : base(client) { }


    
        /// List Files
            /*
         * Get a list of all the user files. You can use the query params to filter
     * your results. On admin mode, this endpoint will return a list of all of the
     * project files. [Learn more about different API modes](/docs/admin).
        */
        public async Task<HttpResponseMessage> ListFiles(string search, int limit, int offset, OrderType orderType) 
        {
            string path = "/storage/files";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "search", search },
                    
                { "limit", limit },
                    
                { "offset", offset },
                    
                { "orderType", orderType.ToString() }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Create File
            /*
         * Create a new file. The user who creates the file will automatically be
     * assigned to read and write access unless he has passed custom values for
     * read and write arguments.
        */
        public async Task<HttpResponseMessage> CreateFile(FileInfo file, List<object> read, List<object> write) 
        {
            string path = "/storage/files";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "file", file },
                    
                { "read", read },
                    
                { "write", write }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "multipart/form-data" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }
    
        /// Get File
            /*
         * Get file by its unique ID. This endpoint response returns a JSON object
     * with the file metadata.
        */
        public async Task<HttpResponseMessage> GetFile(string fileId) 
        {
            string path = "/storage/files/{fileId}".Replace("{fileId}", fileId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Update File
            /*
         * Update file by its unique ID. Only users with write permissions have access
     * to update this resource.
        */
        public async Task<HttpResponseMessage> UpdateFile(string fileId, List<object> read, List<object> write) 
        {
            string path = "/storage/files/{fileId}".Replace("{fileId}", fileId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "read", read },
                    
                { "write", write }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("PUT", path, headers, parameters);
        }
    
        /// Delete File
            /*
         * Delete a file by its unique ID. Only users with write permissions have
     * access to delete this resource.
        */
        public async Task<HttpResponseMessage> DeleteFile(string fileId) 
        {
            string path = "/storage/files/{fileId}".Replace("{fileId}", fileId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }
    
        /// Get File for Download
            /*
         * Get file content by its unique ID. The endpoint response return with a
     * 'Content-Disposition: attachment' header that tells the browser to start
     * downloading the file to user downloads directory.
        */
        public async Task<string> GetFileDownload(string fileId) 
        {
            string path = "/storage/files/{fileId}/download".Replace("{fileId}", fileId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //     //     //     //             { "project", _client.GetConfig().get("project") },    //     //             { "key", _client.GetConfig().get("key") }    //     //     //             
    
                
            return _client.GetEndPoint() + path + "?" + parameters.ToQueryString();
        }
    
        /// Get File Preview
            /*
         * Get a file preview image. Currently, this method supports preview for image
     * files (jpg, png, and gif), other supported formats, like pdf, docs, slides,
     * and spreadsheets, will return the file icon image. You can also pass query
     * string arguments for cutting and resizing your preview image.
        */
        public async Task<string> GetFilePreview(string fileId, int width, int height, int quality, string background, string output) 
        {
            string path = "/storage/files/{fileId}/preview".Replace("{fileId}", fileId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "width", width },
                    
                { "height", height },
                    
                { "quality", quality },
                    
                { "background", background },
                    
                { "output", output },
            };

    //     //     //     //             { "project", _client.GetConfig().get("project") },    //     //             { "key", _client.GetConfig().get("key") }    //     //     //             
    
                
            return _client.GetEndPoint() + path + "?" + parameters.ToQueryString();
        }
    
        /// Get File for View
            /*
         * Get file content by its unique ID. This endpoint is similar to the download
     * method but returns with no  'Content-Disposition: attachment' header.
        */
        public async Task<string> GetFileView(string fileId, string xas) 
        {
            string path = "/storage/files/{fileId}/view".Replace("{fileId}", fileId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "as", xas },
            };

    //     //     //     //             { "project", _client.GetConfig().get("project") },    //     //             { "key", _client.GetConfig().get("key") }    //     //     //             
    
                
            return _client.GetEndPoint() + path + "?" + parameters.ToQueryString();
        }
        };
}