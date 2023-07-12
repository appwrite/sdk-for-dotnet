using System;

namespace Appwrite
{
    public class AppwriteException : Exception
    {
        public int? Code { get; set; }
        public string? Type { get; set; } = null;
        public string? Response { get; set; } = null;

        public AppwriteException(
            string? message = null,
            int? code = null,
            string? type = null,
            string? response = null) : base(message)
        {
            this.Code = code;
            this.Type = type;
            this.Response = response;
        }
        public AppwriteException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}

