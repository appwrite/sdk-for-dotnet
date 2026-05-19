using System;

namespace Appwrite.Enums
{
    public class OAuth2GooglePrompt : IEnum
    {
        public string Value { get; private set; }

        public OAuth2GooglePrompt(string value)
        {
            Value = value;
        }

        public static OAuth2GooglePrompt None => new OAuth2GooglePrompt("none");
        public static OAuth2GooglePrompt Consent => new OAuth2GooglePrompt("consent");
        public static OAuth2GooglePrompt SelectAccount => new OAuth2GooglePrompt("select_account");
    }
}
