
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Oauth2Introspection
    {
        [JsonPropertyName("active")]
        public bool Active { get; private set; }

        [JsonPropertyName("token_use")]
        public string? TokenUse { get; private set; }

        [JsonPropertyName("token_type")]
        public string? TokenType { get; private set; }

        [JsonPropertyName("scope")]
        public string? Scope { get; private set; }

        [JsonPropertyName("client_id")]
        public string? ClientId { get; private set; }

        [JsonPropertyName("sub")]
        public string? Sub { get; private set; }

        [JsonPropertyName("aud")]
        public List<string>? Aud { get; private set; }

        [JsonPropertyName("iss")]
        public string? Iss { get; private set; }

        [JsonPropertyName("exp")]
        public long? Exp { get; private set; }

        [JsonPropertyName("iat")]
        public long? Iat { get; private set; }

        [JsonPropertyName("jti")]
        public string? Jti { get; private set; }

        [JsonPropertyName("authorization_details")]
        public List<object>? AuthorizationDetails { get; private set; }

        public Oauth2Introspection(
            bool active,
            string? tokenUse,
            string? tokenType,
            string? scope,
            string? clientId,
            string? sub,
            List<string>? aud,
            string? iss,
            long? exp,
            long? iat,
            string? jti,
            List<object>? authorizationDetails
        )
        {
            Active = active;
            TokenUse = tokenUse;
            TokenType = tokenType;
            Scope = scope;
            ClientId = clientId;
            Sub = sub;
            Aud = aud;
            Iss = iss;
            Exp = exp;
            Iat = iat;
            Jti = jti;
            AuthorizationDetails = authorizationDetails;
        }

        public static Oauth2Introspection From(Dictionary<string, object> map) => new Oauth2Introspection(
            active: (bool)(map.ContainsKey("active") ? map["active"] : false),
            tokenUse: map.TryGetValue("token_use", out var tokenUse) ? tokenUse?.ToString() : null,
            tokenType: map.TryGetValue("token_type", out var tokenType) ? tokenType?.ToString() : null,
            scope: map.TryGetValue("scope", out var scope) ? scope?.ToString() : null,
            clientId: map.TryGetValue("client_id", out var clientId) ? clientId?.ToString() : null,
            sub: map.TryGetValue("sub", out var sub) ? sub?.ToString() : null,
            aud: map.TryGetValue("aud", out var arrayRaw7) && arrayRaw7 != null
                                ? arrayRaw7.ConvertToList<string>()
                                : null,
            iss: map.TryGetValue("iss", out var iss) ? iss?.ToString() : null,
            exp: map.TryGetValue("exp", out var numberRaw9) && numberRaw9 != null
                                    ? Convert.ToInt64(numberRaw9)
                                    : null,
            iat: map.TryGetValue("iat", out var numberRaw10) && numberRaw10 != null
                                    ? Convert.ToInt64(numberRaw10)
                                    : null,
            jti: map.TryGetValue("jti", out var jti) ? jti?.ToString() : null,
            authorizationDetails: map.TryGetValue("authorization_details", out var arrayRaw12) && arrayRaw12 != null
                                ? arrayRaw12.ConvertToList<object>()
                                : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "active", Active },
            { "token_use", TokenUse },
            { "token_type", TokenType },
            { "scope", Scope },
            { "client_id", ClientId },
            { "sub", Sub },
            { "aud", Aud },
            { "iss", Iss },
            { "exp", Exp },
            { "iat", Iat },
            { "jti", Jti },
            { "authorization_details", AuthorizationDetails }
        };
    }
}
