using System;

namespace Appwrite.Enums
{
    public class OAuth2GithubPrompt : IEnum
    {
        public string Value { get; private set; }

        public OAuth2GithubPrompt(string value)
        {
            Value = value;
        }

        public static OAuth2GithubPrompt SelectAccount => new OAuth2GithubPrompt("select_account");
    }
}
