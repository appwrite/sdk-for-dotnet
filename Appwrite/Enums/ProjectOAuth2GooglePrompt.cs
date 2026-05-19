using System;

namespace Appwrite.Enums
{
    public class ProjectOAuth2GooglePrompt : IEnum
    {
        public string Value { get; private set; }

        public ProjectOAuth2GooglePrompt(string value)
        {
            Value = value;
        }

        public static ProjectOAuth2GooglePrompt None => new ProjectOAuth2GooglePrompt("none");
        public static ProjectOAuth2GooglePrompt Consent => new ProjectOAuth2GooglePrompt("consent");
        public static ProjectOAuth2GooglePrompt SelectAccount => new ProjectOAuth2GooglePrompt("select_account");
    }
}
