using System;

namespace Appwrite.Enums
{
    public class OAuth2Auth0Prompt : IEnum
    {
        public string Value { get; private set; }

        public OAuth2Auth0Prompt(string value)
        {
            Value = value;
        }

        public static OAuth2Auth0Prompt None => new OAuth2Auth0Prompt("none");
        public static OAuth2Auth0Prompt Login => new OAuth2Auth0Prompt("login");
        public static OAuth2Auth0Prompt Consent => new OAuth2Auth0Prompt("consent");
    }
}
