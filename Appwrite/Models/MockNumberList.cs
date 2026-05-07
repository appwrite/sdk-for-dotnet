
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class MockNumberList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("mockNumbers")]
        public List<MockNumber> MockNumbers { get; private set; }

        public MockNumberList(
            long total,
            List<MockNumber> mockNumbers
        )
        {
            Total = total;
            MockNumbers = mockNumbers;
        }

        public static MockNumberList From(Dictionary<string, object> map) => new MockNumberList(
            total: Convert.ToInt64(map["total"]),
            mockNumbers: map["mockNumbers"].ConvertToList<Dictionary<string, object>>().Select(it => MockNumber.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "mockNumbers", MockNumbers.Select(it => it.ToMap()) }
        };
    }
}
