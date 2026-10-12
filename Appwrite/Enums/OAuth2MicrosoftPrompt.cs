using System;

namespace Appwrite.Enums
{
    public class OAuth2MicrosoftPrompt : IEnum
    {
        public string Value { get; private set; }

        public OAuth2MicrosoftPrompt(string value)
        {
            Value = value;
        }

        public static OAuth2MicrosoftPrompt None => new OAuth2MicrosoftPrompt("none");
        public static OAuth2MicrosoftPrompt Login => new OAuth2MicrosoftPrompt("login");
        public static OAuth2MicrosoftPrompt Consent => new OAuth2MicrosoftPrompt("consent");
        public static OAuth2MicrosoftPrompt SelectAccount => new OAuth2MicrosoftPrompt("select_account");
    }
}
