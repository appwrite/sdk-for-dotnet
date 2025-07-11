using System;

namespace Appwrite.Enums
{
    public class PlatformType : IEnum
    {
        public string Value { get; private set; }

        public PlatformType(string value)
        {
            Value = value;
        }

        public static PlatformType Web => new PlatformType("web");
        public static PlatformType FlutterWeb => new PlatformType("flutter-web");
        public static PlatformType FlutterIos => new PlatformType("flutter-ios");
        public static PlatformType FlutterAndroid => new PlatformType("flutter-android");
        public static PlatformType FlutterLinux => new PlatformType("flutter-linux");
        public static PlatformType FlutterMacos => new PlatformType("flutter-macos");
        public static PlatformType FlutterWindows => new PlatformType("flutter-windows");
        public static PlatformType AppleIos => new PlatformType("apple-ios");
        public static PlatformType AppleMacos => new PlatformType("apple-macos");
        public static PlatformType AppleWatchos => new PlatformType("apple-watchos");
        public static PlatformType AppleTvos => new PlatformType("apple-tvos");
        public static PlatformType Android => new PlatformType("android");
        public static PlatformType Unity => new PlatformType("unity");
        public static PlatformType ReactNativeIos => new PlatformType("react-native-ios");
        public static PlatformType ReactNativeAndroid => new PlatformType("react-native-android");
    }
}
