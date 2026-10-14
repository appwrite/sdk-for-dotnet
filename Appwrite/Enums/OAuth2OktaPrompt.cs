using System;

namespace Appwrite.Enums
{
    public class OAuth2OktaPrompt : IEnum
    {
        public string Value { get; private set; }

        public OAuth2OktaPrompt(string value)
        {
            Value = value;
        }

        public static OAuth2OktaPrompt None => new OAuth2OktaPrompt("none");
        public static OAuth2OktaPrompt Login => new OAuth2OktaPrompt("login");
        public static OAuth2OktaPrompt Consent => new OAuth2OktaPrompt("consent");
    }
}
