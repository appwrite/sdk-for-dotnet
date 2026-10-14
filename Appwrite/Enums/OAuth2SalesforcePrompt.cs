using System;

namespace Appwrite.Enums
{
    public class OAuth2SalesforcePrompt : IEnum
    {
        public string Value { get; private set; }

        public OAuth2SalesforcePrompt(string value)
        {
            Value = value;
        }

        public static OAuth2SalesforcePrompt Login => new OAuth2SalesforcePrompt("login");
        public static OAuth2SalesforcePrompt Consent => new OAuth2SalesforcePrompt("consent");
    }
}
