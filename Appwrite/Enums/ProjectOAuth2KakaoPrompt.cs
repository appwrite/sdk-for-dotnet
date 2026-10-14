using System;

namespace Appwrite.Enums
{
    public class ProjectOAuth2KakaoPrompt : IEnum
    {
        public string Value { get; private set; }

        public ProjectOAuth2KakaoPrompt(string value)
        {
            Value = value;
        }

        public static ProjectOAuth2KakaoPrompt None => new ProjectOAuth2KakaoPrompt("none");
        public static ProjectOAuth2KakaoPrompt Login => new ProjectOAuth2KakaoPrompt("login");
        public static ProjectOAuth2KakaoPrompt Create => new ProjectOAuth2KakaoPrompt("create");
        public static ProjectOAuth2KakaoPrompt SelectAccount => new ProjectOAuth2KakaoPrompt("select_account");
    }
}
