using System;

namespace Appwrite.Enums
{
    public class ProjectOAuth2DiscordPrompt : IEnum
    {
        public string Value { get; private set; }

        public ProjectOAuth2DiscordPrompt(string value)
        {
            Value = value;
        }

        public static ProjectOAuth2DiscordPrompt None => new ProjectOAuth2DiscordPrompt("none");
        public static ProjectOAuth2DiscordPrompt Consent => new ProjectOAuth2DiscordPrompt("consent");
    }
}
