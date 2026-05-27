using System;

namespace Appwrite.Enums
{
    public class ProjectOAuthProviderId : IEnum
    {
        public string Value { get; private set; }

        public ProjectOAuthProviderId(string value)
        {
            Value = value;
        }

        public static ProjectOAuthProviderId Amazon => new ProjectOAuthProviderId("amazon");
        public static ProjectOAuthProviderId Apple => new ProjectOAuthProviderId("apple");
        public static ProjectOAuthProviderId Auth0 => new ProjectOAuthProviderId("auth0");
        public static ProjectOAuthProviderId Authentik => new ProjectOAuthProviderId("authentik");
        public static ProjectOAuthProviderId Autodesk => new ProjectOAuthProviderId("autodesk");
        public static ProjectOAuthProviderId Bitbucket => new ProjectOAuthProviderId("bitbucket");
        public static ProjectOAuthProviderId Bitly => new ProjectOAuthProviderId("bitly");
        public static ProjectOAuthProviderId Box => new ProjectOAuthProviderId("box");
        public static ProjectOAuthProviderId Dailymotion => new ProjectOAuthProviderId("dailymotion");
        public static ProjectOAuthProviderId Discord => new ProjectOAuthProviderId("discord");
        public static ProjectOAuthProviderId Disqus => new ProjectOAuthProviderId("disqus");
        public static ProjectOAuthProviderId Dropbox => new ProjectOAuthProviderId("dropbox");
        public static ProjectOAuthProviderId Etsy => new ProjectOAuthProviderId("etsy");
        public static ProjectOAuthProviderId Facebook => new ProjectOAuthProviderId("facebook");
        public static ProjectOAuthProviderId Figma => new ProjectOAuthProviderId("figma");
        public static ProjectOAuthProviderId Fusionauth => new ProjectOAuthProviderId("fusionauth");
        public static ProjectOAuthProviderId Github => new ProjectOAuthProviderId("github");
        public static ProjectOAuthProviderId Gitlab => new ProjectOAuthProviderId("gitlab");
        public static ProjectOAuthProviderId Google => new ProjectOAuthProviderId("google");
        public static ProjectOAuthProviderId Keycloak => new ProjectOAuthProviderId("keycloak");
        public static ProjectOAuthProviderId Kick => new ProjectOAuthProviderId("kick");
        public static ProjectOAuthProviderId Linkedin => new ProjectOAuthProviderId("linkedin");
        public static ProjectOAuthProviderId Microsoft => new ProjectOAuthProviderId("microsoft");
        public static ProjectOAuthProviderId Notion => new ProjectOAuthProviderId("notion");
        public static ProjectOAuthProviderId Oidc => new ProjectOAuthProviderId("oidc");
        public static ProjectOAuthProviderId Okta => new ProjectOAuthProviderId("okta");
        public static ProjectOAuthProviderId Paypal => new ProjectOAuthProviderId("paypal");
        public static ProjectOAuthProviderId PaypalSandbox => new ProjectOAuthProviderId("paypalSandbox");
        public static ProjectOAuthProviderId Podio => new ProjectOAuthProviderId("podio");
        public static ProjectOAuthProviderId Salesforce => new ProjectOAuthProviderId("salesforce");
        public static ProjectOAuthProviderId Slack => new ProjectOAuthProviderId("slack");
        public static ProjectOAuthProviderId Spotify => new ProjectOAuthProviderId("spotify");
        public static ProjectOAuthProviderId Stripe => new ProjectOAuthProviderId("stripe");
        public static ProjectOAuthProviderId Tradeshift => new ProjectOAuthProviderId("tradeshift");
        public static ProjectOAuthProviderId TradeshiftBox => new ProjectOAuthProviderId("tradeshiftBox");
        public static ProjectOAuthProviderId Twitch => new ProjectOAuthProviderId("twitch");
        public static ProjectOAuthProviderId Wordpress => new ProjectOAuthProviderId("wordpress");
        public static ProjectOAuthProviderId X => new ProjectOAuthProviderId("x");
        public static ProjectOAuthProviderId Yahoo => new ProjectOAuthProviderId("yahoo");
        public static ProjectOAuthProviderId Yammer => new ProjectOAuthProviderId("yammer");
        public static ProjectOAuthProviderId Yandex => new ProjectOAuthProviderId("yandex");
        public static ProjectOAuthProviderId Zoho => new ProjectOAuthProviderId("zoho");
        public static ProjectOAuthProviderId Zoom => new ProjectOAuthProviderId("zoom");
    }
}
