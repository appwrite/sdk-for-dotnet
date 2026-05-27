using System;

namespace Appwrite.Enums
{
    public class RedirectStatusCode : IEnum
    {
        public string Value { get; private set; }

        public RedirectStatusCode(string value)
        {
            Value = value;
        }

        public static RedirectStatusCode MovedPermanently => new RedirectStatusCode("301");
        public static RedirectStatusCode Found => new RedirectStatusCode("302");
        public static RedirectStatusCode TemporaryRedirect => new RedirectStatusCode("307");
        public static RedirectStatusCode PermanentRedirect => new RedirectStatusCode("308");
    }
}
