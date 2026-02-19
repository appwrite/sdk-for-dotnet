using System;

namespace Appwrite.Enums
{
    public class Runtime : IEnum
    {
        public string Value { get; private set; }

        public Runtime(string value)
        {
            Value = value;
        }

        public static Runtime Node145 => new Runtime("node-14.5");
        public static Runtime Node160 => new Runtime("node-16.0");
        public static Runtime Node180 => new Runtime("node-18.0");
        public static Runtime Node190 => new Runtime("node-19.0");
        public static Runtime Node200 => new Runtime("node-20.0");
        public static Runtime Node210 => new Runtime("node-21.0");
        public static Runtime Node22 => new Runtime("node-22");
        public static Runtime Node23 => new Runtime("node-23");
        public static Runtime Node24 => new Runtime("node-24");
        public static Runtime Node25 => new Runtime("node-25");
        public static Runtime Php80 => new Runtime("php-8.0");
        public static Runtime Php81 => new Runtime("php-8.1");
        public static Runtime Php82 => new Runtime("php-8.2");
        public static Runtime Php83 => new Runtime("php-8.3");
        public static Runtime Php84 => new Runtime("php-8.4");
        public static Runtime Ruby30 => new Runtime("ruby-3.0");
        public static Runtime Ruby31 => new Runtime("ruby-3.1");
        public static Runtime Ruby32 => new Runtime("ruby-3.2");
        public static Runtime Ruby33 => new Runtime("ruby-3.3");
        public static Runtime Ruby34 => new Runtime("ruby-3.4");
        public static Runtime Ruby40 => new Runtime("ruby-4.0");
        public static Runtime Python38 => new Runtime("python-3.8");
        public static Runtime Python39 => new Runtime("python-3.9");
        public static Runtime Python310 => new Runtime("python-3.10");
        public static Runtime Python311 => new Runtime("python-3.11");
        public static Runtime Python312 => new Runtime("python-3.12");
        public static Runtime Python313 => new Runtime("python-3.13");
        public static Runtime Python314 => new Runtime("python-3.14");
        public static Runtime PythonMl311 => new Runtime("python-ml-3.11");
        public static Runtime PythonMl312 => new Runtime("python-ml-3.12");
        public static Runtime PythonMl313 => new Runtime("python-ml-3.13");
        public static Runtime Deno140 => new Runtime("deno-1.40");
        public static Runtime Deno146 => new Runtime("deno-1.46");
        public static Runtime Deno20 => new Runtime("deno-2.0");
        public static Runtime Deno25 => new Runtime("deno-2.5");
        public static Runtime Deno26 => new Runtime("deno-2.6");
        public static Runtime Dart215 => new Runtime("dart-2.15");
        public static Runtime Dart216 => new Runtime("dart-2.16");
        public static Runtime Dart217 => new Runtime("dart-2.17");
        public static Runtime Dart218 => new Runtime("dart-2.18");
        public static Runtime Dart219 => new Runtime("dart-2.19");
        public static Runtime Dart30 => new Runtime("dart-3.0");
        public static Runtime Dart31 => new Runtime("dart-3.1");
        public static Runtime Dart33 => new Runtime("dart-3.3");
        public static Runtime Dart35 => new Runtime("dart-3.5");
        public static Runtime Dart38 => new Runtime("dart-3.8");
        public static Runtime Dart39 => new Runtime("dart-3.9");
        public static Runtime Dart310 => new Runtime("dart-3.10");
        public static Runtime Dotnet60 => new Runtime("dotnet-6.0");
        public static Runtime Dotnet70 => new Runtime("dotnet-7.0");
        public static Runtime Dotnet80 => new Runtime("dotnet-8.0");
        public static Runtime Dotnet10 => new Runtime("dotnet-10");
        public static Runtime Java80 => new Runtime("java-8.0");
        public static Runtime Java110 => new Runtime("java-11.0");
        public static Runtime Java170 => new Runtime("java-17.0");
        public static Runtime Java180 => new Runtime("java-18.0");
        public static Runtime Java210 => new Runtime("java-21.0");
        public static Runtime Java22 => new Runtime("java-22");
        public static Runtime Java25 => new Runtime("java-25");
        public static Runtime Swift55 => new Runtime("swift-5.5");
        public static Runtime Swift58 => new Runtime("swift-5.8");
        public static Runtime Swift59 => new Runtime("swift-5.9");
        public static Runtime Swift510 => new Runtime("swift-5.10");
        public static Runtime Swift62 => new Runtime("swift-6.2");
        public static Runtime Kotlin16 => new Runtime("kotlin-1.6");
        public static Runtime Kotlin18 => new Runtime("kotlin-1.8");
        public static Runtime Kotlin19 => new Runtime("kotlin-1.9");
        public static Runtime Kotlin20 => new Runtime("kotlin-2.0");
        public static Runtime Kotlin23 => new Runtime("kotlin-2.3");
        public static Runtime Cpp17 => new Runtime("cpp-17");
        public static Runtime Cpp20 => new Runtime("cpp-20");
        public static Runtime Bun10 => new Runtime("bun-1.0");
        public static Runtime Bun11 => new Runtime("bun-1.1");
        public static Runtime Bun12 => new Runtime("bun-1.2");
        public static Runtime Bun13 => new Runtime("bun-1.3");
        public static Runtime Go123 => new Runtime("go-1.23");
        public static Runtime Go124 => new Runtime("go-1.24");
        public static Runtime Go125 => new Runtime("go-1.25");
        public static Runtime Go126 => new Runtime("go-1.26");
        public static Runtime Static1 => new Runtime("static-1");
        public static Runtime Flutter324 => new Runtime("flutter-3.24");
        public static Runtime Flutter327 => new Runtime("flutter-3.27");
        public static Runtime Flutter329 => new Runtime("flutter-3.29");
        public static Runtime Flutter332 => new Runtime("flutter-3.32");
        public static Runtime Flutter335 => new Runtime("flutter-3.35");
        public static Runtime Flutter338 => new Runtime("flutter-3.38");
    }
}
