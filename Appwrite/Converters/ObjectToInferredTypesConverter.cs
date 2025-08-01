using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Converters
{
    public class ObjectToInferredTypesConverter : JsonConverter<object>
    {
        public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.True:
                    return true;
                case JsonTokenType.False:
                    return false;
                case JsonTokenType.Number:
                    if (reader.TryGetInt64(out long l))
                    {
                        return l;
                    }
                    return reader.GetDouble();
                case JsonTokenType.String:
                    if (reader.TryGetDateTime(out DateTime datetime))
                    {
                        return datetime;
                    }
                    return reader.GetString()!;
                case JsonTokenType.StartObject:
                    return JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options)!;
                case JsonTokenType.StartArray:
                    return JsonSerializer.Deserialize<object[]>(ref reader, options)!;
                default:
                    return JsonDocument.ParseValue(ref reader).RootElement.Clone();
            }
        }

        public override void Write(Utf8JsonWriter writer, object objectToWrite, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, objectToWrite, objectToWrite.GetType(), options);
        }
    }
}
