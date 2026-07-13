using System;

namespace Appwrite.Enums
{
    public class OAuth2OidcPrompt : IEnum
    {
        public string Value { get; private set; }

        public OAuth2OidcPrompt(string value)
        {
            Value = value;
        }

        public static OAuth2OidcPrompt None => new OAuth2OidcPrompt("none");
        public static OAuth2OidcPrompt Login => new OAuth2OidcPrompt("login");
        public static OAuth2OidcPrompt Consent => new OAuth2OidcPrompt("consent");
        public static OAuth2OidcPrompt SelectAccount => new OAuth2OidcPrompt("select_account");
    }
}
