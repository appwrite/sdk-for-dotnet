using System;

namespace Appwrite.Enums
{
    public class SiteFramework : IEnum
    {
        public string Value { get; private set; }

        public SiteFramework(string value)
        {
            Value = value;
        }

        public static SiteFramework Analog => new SiteFramework("analog");
        public static SiteFramework Angular => new SiteFramework("angular");
        public static SiteFramework Nextjs => new SiteFramework("nextjs");
        public static SiteFramework React => new SiteFramework("react");
        public static SiteFramework Nuxt => new SiteFramework("nuxt");
        public static SiteFramework Vue => new SiteFramework("vue");
        public static SiteFramework Sveltekit => new SiteFramework("sveltekit");
        public static SiteFramework Astro => new SiteFramework("astro");
        public static SiteFramework TanstackStart => new SiteFramework("tanstack-start");
        public static SiteFramework Remix => new SiteFramework("remix");
        public static SiteFramework Lynx => new SiteFramework("lynx");
        public static SiteFramework Flutter => new SiteFramework("flutter");
        public static SiteFramework ReactNative => new SiteFramework("react-native");
        public static SiteFramework Vite => new SiteFramework("vite");
        public static SiteFramework Other => new SiteFramework("other");
    }
}
