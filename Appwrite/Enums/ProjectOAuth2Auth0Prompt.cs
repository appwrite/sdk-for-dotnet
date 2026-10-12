using System;

namespace Appwrite.Enums
{
    public class ProjectOAuth2Auth0Prompt : IEnum
    {
        public string Value { get; private set; }

        public ProjectOAuth2Auth0Prompt(string value)
        {
            Value = value;
        }

        public static ProjectOAuth2Auth0Prompt None => new ProjectOAuth2Auth0Prompt("none");
        public static ProjectOAuth2Auth0Prompt Login => new ProjectOAuth2Auth0Prompt("login");
        public static ProjectOAuth2Auth0Prompt Consent => new ProjectOAuth2Auth0Prompt("consent");
    }
}
