using System.IO;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class InputFile
    {
        public string Path { get; set; }
        public string Filename { get; set; }
        public string MimeType { get; set; }
        public string SourceType { get; set; }
        public object Data { get; set; }

        public static InputFile FromPath(string path) => new InputFile
        {
            Path = path,
            Filename = System.IO.Path.GetFileName(path),
            MimeType = path.GetMimeType(),
            SourceType = "path"
        };

        public static InputFile FromFileInfo(FileInfo fileInfo) =>
            InputFile.FromPath(fileInfo.FullName);

        public static InputFile FromStream(Stream stream, string filename, string mimeType) => new InputFile
        {
            Data = stream,
            Filename = filename,
            MimeType = mimeType,
            SourceType = "stream"
        };

        public static InputFile FromBytes(byte[] bytes, string filename, string mimeType) => new InputFile
        {
            Data = bytes,
            Filename = filename,
            MimeType = mimeType,
            SourceType = "bytes"
        };
    }
}