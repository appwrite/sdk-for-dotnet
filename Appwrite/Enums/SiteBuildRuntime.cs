using System;

namespace Appwrite.Enums
{
    public class SiteBuildRuntime : IEnum
    {
        public string Value { get; private set; }

        public SiteBuildRuntime(string value)
        {
            Value = value;
        }

        public static SiteBuildRuntime Node145 => new SiteBuildRuntime("node-14.5");
        public static SiteBuildRuntime Node160 => new SiteBuildRuntime("node-16.0");
        public static SiteBuildRuntime Node180 => new SiteBuildRuntime("node-18.0");
        public static SiteBuildRuntime Node190 => new SiteBuildRuntime("node-19.0");
        public static SiteBuildRuntime Node200 => new SiteBuildRuntime("node-20.0");
        public static SiteBuildRuntime Node210 => new SiteBuildRuntime("node-21.0");
        public static SiteBuildRuntime Node22 => new SiteBuildRuntime("node-22");
        public static SiteBuildRuntime Node23 => new SiteBuildRuntime("node-23");
        public static SiteBuildRuntime Node24 => new SiteBuildRuntime("node-24");
        public static SiteBuildRuntime Node25 => new SiteBuildRuntime("node-25");
        public static SiteBuildRuntime Php80 => new SiteBuildRuntime("php-8.0");
        public static SiteBuildRuntime Php81 => new SiteBuildRuntime("php-8.1");
        public static SiteBuildRuntime Php82 => new SiteBuildRuntime("php-8.2");
        public static SiteBuildRuntime Php83 => new SiteBuildRuntime("php-8.3");
        public static SiteBuildRuntime Php84 => new SiteBuildRuntime("php-8.4");
        public static SiteBuildRuntime Ruby30 => new SiteBuildRuntime("ruby-3.0");
        public static SiteBuildRuntime Ruby31 => new SiteBuildRuntime("ruby-3.1");
        public static SiteBuildRuntime Ruby32 => new SiteBuildRuntime("ruby-3.2");
        public static SiteBuildRuntime Ruby33 => new SiteBuildRuntime("ruby-3.3");
        public static SiteBuildRuntime Ruby34 => new SiteBuildRuntime("ruby-3.4");
        public static SiteBuildRuntime Ruby40 => new SiteBuildRuntime("ruby-4.0");
        public static SiteBuildRuntime Python38 => new SiteBuildRuntime("python-3.8");
        public static SiteBuildRuntime Python39 => new SiteBuildRuntime("python-3.9");
        public static SiteBuildRuntime Python310 => new SiteBuildRuntime("python-3.10");
        public static SiteBuildRuntime Python311 => new SiteBuildRuntime("python-3.11");
        public static SiteBuildRuntime Python312 => new SiteBuildRuntime("python-3.12");
        public static SiteBuildRuntime Python313 => new SiteBuildRuntime("python-3.13");
        public static SiteBuildRuntime Python314 => new SiteBuildRuntime("python-3.14");
        public static SiteBuildRuntime PythonMl311 => new SiteBuildRuntime("python-ml-3.11");
        public static SiteBuildRuntime PythonMl312 => new SiteBuildRuntime("python-ml-3.12");
        public static SiteBuildRuntime PythonMl313 => new SiteBuildRuntime("python-ml-3.13");
        public static SiteBuildRuntime Deno121 => new SiteBuildRuntime("deno-1.21");
        public static SiteBuildRuntime Deno124 => new SiteBuildRuntime("deno-1.24");
        public static SiteBuildRuntime Deno135 => new SiteBuildRuntime("deno-1.35");
        public static SiteBuildRuntime Deno140 => new SiteBuildRuntime("deno-1.40");
        public static SiteBuildRuntime Deno146 => new SiteBuildRuntime("deno-1.46");
        public static SiteBuildRuntime Deno20 => new SiteBuildRuntime("deno-2.0");
        public static SiteBuildRuntime Deno25 => new SiteBuildRuntime("deno-2.5");
        public static SiteBuildRuntime Deno26 => new SiteBuildRuntime("deno-2.6");
        public static SiteBuildRuntime Dart215 => new SiteBuildRuntime("dart-2.15");
        public static SiteBuildRuntime Dart216 => new SiteBuildRuntime("dart-2.16");
        public static SiteBuildRuntime Dart217 => new SiteBuildRuntime("dart-2.17");
        public static SiteBuildRuntime Dart218 => new SiteBuildRuntime("dart-2.18");
        public static SiteBuildRuntime Dart219 => new SiteBuildRuntime("dart-2.19");
        public static SiteBuildRuntime Dart30 => new SiteBuildRuntime("dart-3.0");
        public static SiteBuildRuntime Dart31 => new SiteBuildRuntime("dart-3.1");
        public static SiteBuildRuntime Dart33 => new SiteBuildRuntime("dart-3.3");
        public static SiteBuildRuntime Dart35 => new SiteBuildRuntime("dart-3.5");
        public static SiteBuildRuntime Dart38 => new SiteBuildRuntime("dart-3.8");
        public static SiteBuildRuntime Dart39 => new SiteBuildRuntime("dart-3.9");
        public static SiteBuildRuntime Dart310 => new SiteBuildRuntime("dart-3.10");
        public static SiteBuildRuntime Dart311 => new SiteBuildRuntime("dart-3.11");
        public static SiteBuildRuntime Dart312 => new SiteBuildRuntime("dart-3.12");
        public static SiteBuildRuntime Dotnet60 => new SiteBuildRuntime("dotnet-6.0");
        public static SiteBuildRuntime Dotnet70 => new SiteBuildRuntime("dotnet-7.0");
        public static SiteBuildRuntime Dotnet80 => new SiteBuildRuntime("dotnet-8.0");
        public static SiteBuildRuntime Dotnet10 => new SiteBuildRuntime("dotnet-10");
        public static SiteBuildRuntime Java80 => new SiteBuildRuntime("java-8.0");
        public static SiteBuildRuntime Java110 => new SiteBuildRuntime("java-11.0");
        public static SiteBuildRuntime Java170 => new SiteBuildRuntime("java-17.0");
        public static SiteBuildRuntime Java180 => new SiteBuildRuntime("java-18.0");
        public static SiteBuildRuntime Java210 => new SiteBuildRuntime("java-21.0");
        public static SiteBuildRuntime Java22 => new SiteBuildRuntime("java-22");
        public static SiteBuildRuntime Java25 => new SiteBuildRuntime("java-25");
        public static SiteBuildRuntime Swift55 => new SiteBuildRuntime("swift-5.5");
        public static SiteBuildRuntime Swift58 => new SiteBuildRuntime("swift-5.8");
        public static SiteBuildRuntime Swift59 => new SiteBuildRuntime("swift-5.9");
        public static SiteBuildRuntime Swift510 => new SiteBuildRuntime("swift-5.10");
        public static SiteBuildRuntime Swift62 => new SiteBuildRuntime("swift-6.2");
        public static SiteBuildRuntime Kotlin16 => new SiteBuildRuntime("kotlin-1.6");
        public static SiteBuildRuntime Kotlin18 => new SiteBuildRuntime("kotlin-1.8");
        public static SiteBuildRuntime Kotlin19 => new SiteBuildRuntime("kotlin-1.9");
        public static SiteBuildRuntime Kotlin20 => new SiteBuildRuntime("kotlin-2.0");
        public static SiteBuildRuntime Kotlin23 => new SiteBuildRuntime("kotlin-2.3");
        public static SiteBuildRuntime Cpp17 => new SiteBuildRuntime("cpp-17");
        public static SiteBuildRuntime Cpp20 => new SiteBuildRuntime("cpp-20");
        public static SiteBuildRuntime Bun10 => new SiteBuildRuntime("bun-1.0");
        public static SiteBuildRuntime Bun11 => new SiteBuildRuntime("bun-1.1");
        public static SiteBuildRuntime Bun12 => new SiteBuildRuntime("bun-1.2");
        public static SiteBuildRuntime Bun13 => new SiteBuildRuntime("bun-1.3");
        public static SiteBuildRuntime Go123 => new SiteBuildRuntime("go-1.23");
        public static SiteBuildRuntime Go124 => new SiteBuildRuntime("go-1.24");
        public static SiteBuildRuntime Go125 => new SiteBuildRuntime("go-1.25");
        public static SiteBuildRuntime Go126 => new SiteBuildRuntime("go-1.26");
        public static SiteBuildRuntime Rust183 => new SiteBuildRuntime("rust-1.83");
        public static SiteBuildRuntime Static1 => new SiteBuildRuntime("static-1");
        public static SiteBuildRuntime Flutter324 => new SiteBuildRuntime("flutter-3.24");
        public static SiteBuildRuntime Flutter327 => new SiteBuildRuntime("flutter-3.27");
        public static SiteBuildRuntime Flutter329 => new SiteBuildRuntime("flutter-3.29");
        public static SiteBuildRuntime Flutter332 => new SiteBuildRuntime("flutter-3.32");
        public static SiteBuildRuntime Flutter335 => new SiteBuildRuntime("flutter-3.35");
        public static SiteBuildRuntime Flutter338 => new SiteBuildRuntime("flutter-3.38");
        public static SiteBuildRuntime Flutter341 => new SiteBuildRuntime("flutter-3.41");
        public static SiteBuildRuntime Flutter344 => new SiteBuildRuntime("flutter-3.44");
    }
}
