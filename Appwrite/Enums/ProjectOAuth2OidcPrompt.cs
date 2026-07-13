using System;

namespace Appwrite.Enums
{
    public class ProjectOAuth2OidcPrompt : IEnum
    {
        public string Value { get; private set; }

        public ProjectOAuth2OidcPrompt(string value)
        {
            Value = value;
        }

        public static ProjectOAuth2OidcPrompt None => new ProjectOAuth2OidcPrompt("none");
        public static ProjectOAuth2OidcPrompt Login => new ProjectOAuth2OidcPrompt("login");
        public static ProjectOAuth2OidcPrompt Consent => new ProjectOAuth2OidcPrompt("consent");
        public static ProjectOAuth2OidcPrompt SelectAccount => new ProjectOAuth2OidcPrompt("select_account");
    }
}
