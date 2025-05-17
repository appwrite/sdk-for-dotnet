using System;

namespace Appwrite.Enums
{
    public class Framework : IEnum
    {
        public string Value { get; private set; }

        public Framework(string value)
        {
            Value = value;
        }

        public static Framework Analog => new Framework("analog");
        public static Framework Angular => new Framework("angular");
        public static Framework Nextjs => new Framework("nextjs");
        public static Framework React => new Framework("react");
        public static Framework Nuxt => new Framework("nuxt");
        public static Framework Vue => new Framework("vue");
        public static Framework Sveltekit => new Framework("sveltekit");
        public static Framework Astro => new Framework("astro");
        public static Framework Remix => new Framework("remix");
        public static Framework Lynx => new Framework("lynx");
        public static Framework Flutter => new Framework("flutter");
        public static Framework ReactNative => new Framework("react-native");
        public static Framework Vite => new Framework("vite");
        public static Framework Other => new Framework("other");
    }
}
