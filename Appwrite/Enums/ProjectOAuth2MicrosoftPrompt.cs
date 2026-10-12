using System;

namespace Appwrite.Enums
{
    public class ProjectOAuth2MicrosoftPrompt : IEnum
    {
        public string Value { get; private set; }

        public ProjectOAuth2MicrosoftPrompt(string value)
        {
            Value = value;
        }

        public static ProjectOAuth2MicrosoftPrompt None => new ProjectOAuth2MicrosoftPrompt("none");
        public static ProjectOAuth2MicrosoftPrompt Login => new ProjectOAuth2MicrosoftPrompt("login");
        public static ProjectOAuth2MicrosoftPrompt Consent => new ProjectOAuth2MicrosoftPrompt("consent");
        public static ProjectOAuth2MicrosoftPrompt SelectAccount => new ProjectOAuth2MicrosoftPrompt("select_account");
    }
}
