using System;

namespace Appwrite.Enums
{
    public class OAuth2DiscordPrompt : IEnum
    {
        public string Value { get; private set; }

        public OAuth2DiscordPrompt(string value)
        {
            Value = value;
        }

        public static OAuth2DiscordPrompt None => new OAuth2DiscordPrompt("none");
        public static OAuth2DiscordPrompt Consent => new OAuth2DiscordPrompt("consent");
    }
}
