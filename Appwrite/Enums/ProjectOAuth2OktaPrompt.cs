using System;

namespace Appwrite.Enums
{
    public class ProjectOAuth2OktaPrompt : IEnum
    {
        public string Value { get; private set; }

        public ProjectOAuth2OktaPrompt(string value)
        {
            Value = value;
        }

        public static ProjectOAuth2OktaPrompt None => new ProjectOAuth2OktaPrompt("none");
        public static ProjectOAuth2OktaPrompt Login => new ProjectOAuth2OktaPrompt("login");
        public static ProjectOAuth2OktaPrompt Consent => new ProjectOAuth2OktaPrompt("consent");
    }
}
