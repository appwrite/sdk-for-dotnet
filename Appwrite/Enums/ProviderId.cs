using System;

namespace Appwrite.Enums
{
    public class ProviderId : IEnum
    {
        public string Value { get; private set; }

        public ProviderId(string value)
        {
            Value = value;
        }

        public static ProviderId Amazon => new ProviderId("amazon");
        public static ProviderId Apple => new ProviderId("apple");
        public static ProviderId Auth0 => new ProviderId("auth0");
        public static ProviderId Authentik => new ProviderId("authentik");
        public static ProviderId Autodesk => new ProviderId("autodesk");
        public static ProviderId Bitbucket => new ProviderId("bitbucket");
        public static ProviderId Bitly => new ProviderId("bitly");
        public static ProviderId Box => new ProviderId("box");
        public static ProviderId Dailymotion => new ProviderId("dailymotion");
        public static ProviderId Discord => new ProviderId("discord");
        public static ProviderId Disqus => new ProviderId("disqus");
        public static ProviderId Dropbox => new ProviderId("dropbox");
        public static ProviderId Etsy => new ProviderId("etsy");
        public static ProviderId Facebook => new ProviderId("facebook");
        public static ProviderId Figma => new ProviderId("figma");
        public static ProviderId Fusionauth => new ProviderId("fusionauth");
        public static ProviderId Github => new ProviderId("github");
        public static ProviderId Gitlab => new ProviderId("gitlab");
        public static ProviderId Google => new ProviderId("google");
        public static ProviderId Keycloak => new ProviderId("keycloak");
        public static ProviderId Kick => new ProviderId("kick");
        public static ProviderId Linkedin => new ProviderId("linkedin");
        public static ProviderId Microsoft => new ProviderId("microsoft");
        public static ProviderId Notion => new ProviderId("notion");
        public static ProviderId Oidc => new ProviderId("oidc");
        public static ProviderId Okta => new ProviderId("okta");
        public static ProviderId Paypal => new ProviderId("paypal");
        public static ProviderId PaypalSandbox => new ProviderId("paypalSandbox");
        public static ProviderId Podio => new ProviderId("podio");
        public static ProviderId Salesforce => new ProviderId("salesforce");
        public static ProviderId Slack => new ProviderId("slack");
        public static ProviderId Spotify => new ProviderId("spotify");
        public static ProviderId Stripe => new ProviderId("stripe");
        public static ProviderId Tradeshift => new ProviderId("tradeshift");
        public static ProviderId TradeshiftBox => new ProviderId("tradeshiftBox");
        public static ProviderId Twitch => new ProviderId("twitch");
        public static ProviderId Wordpress => new ProviderId("wordpress");
        public static ProviderId X => new ProviderId("x");
        public static ProviderId Yahoo => new ProviderId("yahoo");
        public static ProviderId Yammer => new ProviderId("yammer");
        public static ProviderId Yandex => new ProviderId("yandex");
        public static ProviderId Zoho => new ProviderId("zoho");
        public static ProviderId Zoom => new ProviderId("zoom");
        public static ProviderId Mock => new ProviderId("mock");
        public static ProviderId MockUnverified => new ProviderId("mock-unverified");
        public static ProviderId GithubImagine => new ProviderId("githubImagine");
        public static ProviderId GoogleImagine => new ProviderId("googleImagine");
    }
}
