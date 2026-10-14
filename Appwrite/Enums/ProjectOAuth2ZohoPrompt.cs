using System;

namespace Appwrite.Enums
{
    public class ProjectOAuth2ZohoPrompt : IEnum
    {
        public string Value { get; private set; }

        public ProjectOAuth2ZohoPrompt(string value)
        {
            Value = value;
        }

        public static ProjectOAuth2ZohoPrompt Consent => new ProjectOAuth2ZohoPrompt("consent");
    }
}
