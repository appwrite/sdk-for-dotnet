using System;

namespace Appwrite.Enums
{
    public class FunctionRuntime : IEnum
    {
        public string Value { get; private set; }

        public FunctionRuntime(string value)
        {
            Value = value;
        }

        public static FunctionRuntime Node145 => new FunctionRuntime("node-14.5");
        public static FunctionRuntime Node160 => new FunctionRuntime("node-16.0");
        public static FunctionRuntime Node180 => new FunctionRuntime("node-18.0");
        public static FunctionRuntime Node190 => new FunctionRuntime("node-19.0");
        public static FunctionRuntime Node200 => new FunctionRuntime("node-20.0");
        public static FunctionRuntime Node210 => new FunctionRuntime("node-21.0");
        public static FunctionRuntime Node22 => new FunctionRuntime("node-22");
        public static FunctionRuntime Node23 => new FunctionRuntime("node-23");
        public static FunctionRuntime Node24 => new FunctionRuntime("node-24");
        public static FunctionRuntime Node25 => new FunctionRuntime("node-25");
        public static FunctionRuntime Php80 => new FunctionRuntime("php-8.0");
        public static FunctionRuntime Php81 => new FunctionRuntime("php-8.1");
        public static FunctionRuntime Php82 => new FunctionRuntime("php-8.2");
        public static FunctionRuntime Php83 => new FunctionRuntime("php-8.3");
        public static FunctionRuntime Php84 => new FunctionRuntime("php-8.4");
        public static FunctionRuntime Ruby30 => new FunctionRuntime("ruby-3.0");
        public static FunctionRuntime Ruby31 => new FunctionRuntime("ruby-3.1");
        public static FunctionRuntime Ruby32 => new FunctionRuntime("ruby-3.2");
        public static FunctionRuntime Ruby33 => new FunctionRuntime("ruby-3.3");
        public static FunctionRuntime Ruby34 => new FunctionRuntime("ruby-3.4");
        public static FunctionRuntime Ruby40 => new FunctionRuntime("ruby-4.0");
        public static FunctionRuntime Python38 => new FunctionRuntime("python-3.8");
        public static FunctionRuntime Python39 => new FunctionRuntime("python-3.9");
        public static FunctionRuntime Python310 => new FunctionRuntime("python-3.10");
        public static FunctionRuntime Python311 => new FunctionRuntime("python-3.11");
        public static FunctionRuntime Python312 => new FunctionRuntime("python-3.12");
        public static FunctionRuntime Python313 => new FunctionRuntime("python-3.13");
        public static FunctionRuntime Python314 => new FunctionRuntime("python-3.14");
        public static FunctionRuntime PythonMl311 => new FunctionRuntime("python-ml-3.11");
        public static FunctionRuntime PythonMl312 => new FunctionRuntime("python-ml-3.12");
        public static FunctionRuntime PythonMl313 => new FunctionRuntime("python-ml-3.13");
        public static FunctionRuntime Deno121 => new FunctionRuntime("deno-1.21");
        public static FunctionRuntime Deno124 => new FunctionRuntime("deno-1.24");
        public static FunctionRuntime Deno135 => new FunctionRuntime("deno-1.35");
        public static FunctionRuntime Deno140 => new FunctionRuntime("deno-1.40");
        public static FunctionRuntime Deno146 => new FunctionRuntime("deno-1.46");
        public static FunctionRuntime Deno20 => new FunctionRuntime("deno-2.0");
        public static FunctionRuntime Deno25 => new FunctionRuntime("deno-2.5");
        public static FunctionRuntime Deno26 => new FunctionRuntime("deno-2.6");
        public static FunctionRuntime Dart215 => new FunctionRuntime("dart-2.15");
        public static FunctionRuntime Dart216 => new FunctionRuntime("dart-2.16");
        public static FunctionRuntime Dart217 => new FunctionRuntime("dart-2.17");
        public static FunctionRuntime Dart218 => new FunctionRuntime("dart-2.18");
        public static FunctionRuntime Dart219 => new FunctionRuntime("dart-2.19");
        public static FunctionRuntime Dart30 => new FunctionRuntime("dart-3.0");
        public static FunctionRuntime Dart31 => new FunctionRuntime("dart-3.1");
        public static FunctionRuntime Dart33 => new FunctionRuntime("dart-3.3");
        public static FunctionRuntime Dart35 => new FunctionRuntime("dart-3.5");
        public static FunctionRuntime Dart38 => new FunctionRuntime("dart-3.8");
        public static FunctionRuntime Dart39 => new FunctionRuntime("dart-3.9");
        public static FunctionRuntime Dart310 => new FunctionRuntime("dart-3.10");
        public static FunctionRuntime Dart311 => new FunctionRuntime("dart-3.11");
        public static FunctionRuntime Dart312 => new FunctionRuntime("dart-3.12");
        public static FunctionRuntime Dotnet60 => new FunctionRuntime("dotnet-6.0");
        public static FunctionRuntime Dotnet70 => new FunctionRuntime("dotnet-7.0");
        public static FunctionRuntime Dotnet80 => new FunctionRuntime("dotnet-8.0");
        public static FunctionRuntime Dotnet10 => new FunctionRuntime("dotnet-10");
        public static FunctionRuntime Java80 => new FunctionRuntime("java-8.0");
        public static FunctionRuntime Java110 => new FunctionRuntime("java-11.0");
        public static FunctionRuntime Java170 => new FunctionRuntime("java-17.0");
        public static FunctionRuntime Java180 => new FunctionRuntime("java-18.0");
        public static FunctionRuntime Java210 => new FunctionRuntime("java-21.0");
        public static FunctionRuntime Java22 => new FunctionRuntime("java-22");
        public static FunctionRuntime Java25 => new FunctionRuntime("java-25");
        public static FunctionRuntime Swift55 => new FunctionRuntime("swift-5.5");
        public static FunctionRuntime Swift58 => new FunctionRuntime("swift-5.8");
        public static FunctionRuntime Swift59 => new FunctionRuntime("swift-5.9");
        public static FunctionRuntime Swift510 => new FunctionRuntime("swift-5.10");
        public static FunctionRuntime Swift62 => new FunctionRuntime("swift-6.2");
        public static FunctionRuntime Kotlin16 => new FunctionRuntime("kotlin-1.6");
        public static FunctionRuntime Kotlin18 => new FunctionRuntime("kotlin-1.8");
        public static FunctionRuntime Kotlin19 => new FunctionRuntime("kotlin-1.9");
        public static FunctionRuntime Kotlin20 => new FunctionRuntime("kotlin-2.0");
        public static FunctionRuntime Kotlin23 => new FunctionRuntime("kotlin-2.3");
        public static FunctionRuntime Cpp17 => new FunctionRuntime("cpp-17");
        public static FunctionRuntime Cpp20 => new FunctionRuntime("cpp-20");
        public static FunctionRuntime Bun10 => new FunctionRuntime("bun-1.0");
        public static FunctionRuntime Bun11 => new FunctionRuntime("bun-1.1");
        public static FunctionRuntime Bun12 => new FunctionRuntime("bun-1.2");
        public static FunctionRuntime Bun13 => new FunctionRuntime("bun-1.3");
        public static FunctionRuntime Go123 => new FunctionRuntime("go-1.23");
        public static FunctionRuntime Go124 => new FunctionRuntime("go-1.24");
        public static FunctionRuntime Go125 => new FunctionRuntime("go-1.25");
        public static FunctionRuntime Go126 => new FunctionRuntime("go-1.26");
        public static FunctionRuntime Rust183 => new FunctionRuntime("rust-1.83");
        public static FunctionRuntime Static1 => new FunctionRuntime("static-1");
        public static FunctionRuntime Flutter324 => new FunctionRuntime("flutter-3.24");
        public static FunctionRuntime Flutter327 => new FunctionRuntime("flutter-3.27");
        public static FunctionRuntime Flutter329 => new FunctionRuntime("flutter-3.29");
        public static FunctionRuntime Flutter332 => new FunctionRuntime("flutter-3.32");
        public static FunctionRuntime Flutter335 => new FunctionRuntime("flutter-3.35");
        public static FunctionRuntime Flutter338 => new FunctionRuntime("flutter-3.38");
        public static FunctionRuntime Flutter341 => new FunctionRuntime("flutter-3.41");
        public static FunctionRuntime Flutter344 => new FunctionRuntime("flutter-3.44");
    }
}
