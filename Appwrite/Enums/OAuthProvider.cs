using System;

namespace Appwrite.Enums
{
    public class OAuthProvider : IEnum
    {
        public string Value { get; private set; }

        public OAuthProvider(string value)
        {
            Value = value;
        }

        public static OAuthProvider Amazon => new OAuthProvider("amazon");
        public static OAuthProvider Apple => new OAuthProvider("apple");
        public static OAuthProvider Auth0 => new OAuthProvider("auth0");
        public static OAuthProvider Authentik => new OAuthProvider("authentik");
        public static OAuthProvider Autodesk => new OAuthProvider("autodesk");
        public static OAuthProvider Bitbucket => new OAuthProvider("bitbucket");
        public static OAuthProvider Bitly => new OAuthProvider("bitly");
        public static OAuthProvider Box => new OAuthProvider("box");
        public static OAuthProvider Dailymotion => new OAuthProvider("dailymotion");
        public static OAuthProvider Discord => new OAuthProvider("discord");
        public static OAuthProvider Disqus => new OAuthProvider("disqus");
        public static OAuthProvider Dropbox => new OAuthProvider("dropbox");
        public static OAuthProvider Etsy => new OAuthProvider("etsy");
        public static OAuthProvider Facebook => new OAuthProvider("facebook");
        public static OAuthProvider Figma => new OAuthProvider("figma");
        public static OAuthProvider Github => new OAuthProvider("github");
        public static OAuthProvider Gitlab => new OAuthProvider("gitlab");
        public static OAuthProvider Google => new OAuthProvider("google");
        public static OAuthProvider Linkedin => new OAuthProvider("linkedin");
        public static OAuthProvider Microsoft => new OAuthProvider("microsoft");
        public static OAuthProvider Notion => new OAuthProvider("notion");
        public static OAuthProvider Oidc => new OAuthProvider("oidc");
        public static OAuthProvider Okta => new OAuthProvider("okta");
        public static OAuthProvider Paypal => new OAuthProvider("paypal");
        public static OAuthProvider PaypalSandbox => new OAuthProvider("paypalSandbox");
        public static OAuthProvider Podio => new OAuthProvider("podio");
        public static OAuthProvider Salesforce => new OAuthProvider("salesforce");
        public static OAuthProvider Slack => new OAuthProvider("slack");
        public static OAuthProvider Spotify => new OAuthProvider("spotify");
        public static OAuthProvider Stripe => new OAuthProvider("stripe");
        public static OAuthProvider Tradeshift => new OAuthProvider("tradeshift");
        public static OAuthProvider TradeshiftBox => new OAuthProvider("tradeshiftBox");
        public static OAuthProvider Twitch => new OAuthProvider("twitch");
        public static OAuthProvider Wordpress => new OAuthProvider("wordpress");
        public static OAuthProvider Yahoo => new OAuthProvider("yahoo");
        public static OAuthProvider Yammer => new OAuthProvider("yammer");
        public static OAuthProvider Yandex => new OAuthProvider("yandex");
        public static OAuthProvider Zoho => new OAuthProvider("zoho");
        public static OAuthProvider Zoom => new OAuthProvider("zoom");
        public static OAuthProvider Mock => new OAuthProvider("mock");
    }
}
