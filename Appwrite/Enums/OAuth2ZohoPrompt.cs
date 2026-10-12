using System;

namespace Appwrite.Enums
{
    public class OAuth2ZohoPrompt : IEnum
    {
        public string Value { get; private set; }

        public OAuth2ZohoPrompt(string value)
        {
            Value = value;
        }

        public static OAuth2ZohoPrompt Consent => new OAuth2ZohoPrompt("consent");
    }
}
