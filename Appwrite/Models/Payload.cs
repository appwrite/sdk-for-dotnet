using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Payload
    {
        public string Path { get; set; }
        public string Filename { get; set; }
        public string SourceType { get; set; }
        public object Data { get; set; }

        public static Payload FromFile(string path, string filename = null) => new Payload
        {
            Path = path,
            Filename = filename == null ? System.IO.Path.GetFileName(path) : filename,
            SourceType = "path"
        };

        public static Payload FromFileInfo(FileInfo fileInfo, string filename = null) =>
            FromFile(fileInfo.FullName, filename);

        public static Payload FromStream(Stream stream, string filename = null) => new Payload
        {
            Data = stream,
            Filename = filename,
            SourceType = "stream"
        };

        public static Payload FromBinary(byte[] bytes, string filename = null) => new Payload
        {
            Data = bytes,
            Filename = filename,
            SourceType = "bytes"
        };

        public static Payload FromString(string multipart, string filename = null)
        {
            return FromBinary(System.Text.Encoding.UTF8.GetBytes(multipart), filename);
        }

        public static Payload FromJson(object json, string filename = null)
        {
            return FromString(JsonConvert.SerializeObject(json), filename);
        }

        public byte[] ToBinary()
        {
            return Data as byte[] ?? Array.Empty<byte>();
        }

        public override string ToString()
        {
            var binary = ToBinary();
            return System.Text.Encoding.UTF8.GetString(binary, 0, binary.Length);
        }

        public Dictionary<string, object?> ToJson()
        {
            return JsonConvert.DeserializeObject<Dictionary<string, object?>>(ToString()) ?? new Dictionary<string, object?>();
        }

        public void ToFile(string path)
        {
            System.IO.File.WriteAllBytes(path, ToBinary());
        }

    }
}
