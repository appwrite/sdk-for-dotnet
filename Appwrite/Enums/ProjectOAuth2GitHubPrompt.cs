using System;

namespace Appwrite.Enums
{
    public class ProjectOAuth2GitHubPrompt : IEnum
    {
        public string Value { get; private set; }

        public ProjectOAuth2GitHubPrompt(string value)
        {
            Value = value;
        }

        public static ProjectOAuth2GitHubPrompt SelectAccount => new ProjectOAuth2GitHubPrompt("select_account");
    }
}
