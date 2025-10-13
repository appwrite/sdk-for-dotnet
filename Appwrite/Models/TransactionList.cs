
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class TransactionList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("transactions")]
        public List<Transaction> Transactions { get; private set; }

        public TransactionList(
            long total,
            List<Transaction> transactions
        ) {
            Total = total;
            Transactions = transactions;
        }

        public static TransactionList From(Dictionary<string, object> map) => new TransactionList(
            total: Convert.ToInt64(map["total"]),
            transactions: map["transactions"].ConvertToList<Dictionary<string, object>>().Select(it => Transaction.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "transactions", Transactions.Select(it => it.ToMap()) }
        };
    }
}
