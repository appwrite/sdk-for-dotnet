using System;

namespace Appwrite.Enums
{
    public class ProjectOAuth2SalesforcePrompt : IEnum
    {
        public string Value { get; private set; }

        public ProjectOAuth2SalesforcePrompt(string value)
        {
            Value = value;
        }

        public static ProjectOAuth2SalesforcePrompt Login => new ProjectOAuth2SalesforcePrompt("login");
        public static ProjectOAuth2SalesforcePrompt Consent => new ProjectOAuth2SalesforcePrompt("consent");
    }
}
