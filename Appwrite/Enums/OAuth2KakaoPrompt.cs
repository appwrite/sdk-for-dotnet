using System;

namespace Appwrite.Enums
{
    public class OAuth2KakaoPrompt : IEnum
    {
        public string Value { get; private set; }

        public OAuth2KakaoPrompt(string value)
        {
            Value = value;
        }

        public static OAuth2KakaoPrompt None => new OAuth2KakaoPrompt("none");
        public static OAuth2KakaoPrompt Login => new OAuth2KakaoPrompt("login");
        public static OAuth2KakaoPrompt Create => new OAuth2KakaoPrompt("create");
        public static OAuth2KakaoPrompt SelectAccount => new OAuth2KakaoPrompt("select_account");
    }
}
