using System;

namespace Appwrite.Enums
{
    public class BuildRuntime : IEnum
    {
        public string Value { get; private set; }

        public BuildRuntime(string value)
        {
            Value = value;
        }

        public static BuildRuntime Node145 => new BuildRuntime("node-14.5");
        public static BuildRuntime Node160 => new BuildRuntime("node-16.0");
        public static BuildRuntime Node180 => new BuildRuntime("node-18.0");
        public static BuildRuntime Node190 => new BuildRuntime("node-19.0");
        public static BuildRuntime Node200 => new BuildRuntime("node-20.0");
        public static BuildRuntime Node210 => new BuildRuntime("node-21.0");
        public static BuildRuntime Node22 => new BuildRuntime("node-22");
        public static BuildRuntime Php80 => new BuildRuntime("php-8.0");
        public static BuildRuntime Php81 => new BuildRuntime("php-8.1");
        public static BuildRuntime Php82 => new BuildRuntime("php-8.2");
        public static BuildRuntime Php83 => new BuildRuntime("php-8.3");
        public static BuildRuntime Ruby30 => new BuildRuntime("ruby-3.0");
        public static BuildRuntime Ruby31 => new BuildRuntime("ruby-3.1");
        public static BuildRuntime Ruby32 => new BuildRuntime("ruby-3.2");
        public static BuildRuntime Ruby33 => new BuildRuntime("ruby-3.3");
        public static BuildRuntime Python38 => new BuildRuntime("python-3.8");
        public static BuildRuntime Python39 => new BuildRuntime("python-3.9");
        public static BuildRuntime Python310 => new BuildRuntime("python-3.10");
        public static BuildRuntime Python311 => new BuildRuntime("python-3.11");
        public static BuildRuntime Python312 => new BuildRuntime("python-3.12");
        public static BuildRuntime PythonMl311 => new BuildRuntime("python-ml-3.11");
        public static BuildRuntime PythonMl312 => new BuildRuntime("python-ml-3.12");
        public static BuildRuntime Deno121 => new BuildRuntime("deno-1.21");
        public static BuildRuntime Deno124 => new BuildRuntime("deno-1.24");
        public static BuildRuntime Deno135 => new BuildRuntime("deno-1.35");
        public static BuildRuntime Deno140 => new BuildRuntime("deno-1.40");
        public static BuildRuntime Deno146 => new BuildRuntime("deno-1.46");
        public static BuildRuntime Deno20 => new BuildRuntime("deno-2.0");
        public static BuildRuntime Dart215 => new BuildRuntime("dart-2.15");
        public static BuildRuntime Dart216 => new BuildRuntime("dart-2.16");
        public static BuildRuntime Dart217 => new BuildRuntime("dart-2.17");
        public static BuildRuntime Dart218 => new BuildRuntime("dart-2.18");
        public static BuildRuntime Dart219 => new BuildRuntime("dart-2.19");
        public static BuildRuntime Dart30 => new BuildRuntime("dart-3.0");
        public static BuildRuntime Dart31 => new BuildRuntime("dart-3.1");
        public static BuildRuntime Dart33 => new BuildRuntime("dart-3.3");
        public static BuildRuntime Dart35 => new BuildRuntime("dart-3.5");
        public static BuildRuntime Dart38 => new BuildRuntime("dart-3.8");
        public static BuildRuntime Dotnet60 => new BuildRuntime("dotnet-6.0");
        public static BuildRuntime Dotnet70 => new BuildRuntime("dotnet-7.0");
        public static BuildRuntime Dotnet80 => new BuildRuntime("dotnet-8.0");
        public static BuildRuntime Java80 => new BuildRuntime("java-8.0");
        public static BuildRuntime Java110 => new BuildRuntime("java-11.0");
        public static BuildRuntime Java170 => new BuildRuntime("java-17.0");
        public static BuildRuntime Java180 => new BuildRuntime("java-18.0");
        public static BuildRuntime Java210 => new BuildRuntime("java-21.0");
        public static BuildRuntime Java22 => new BuildRuntime("java-22");
        public static BuildRuntime Swift55 => new BuildRuntime("swift-5.5");
        public static BuildRuntime Swift58 => new BuildRuntime("swift-5.8");
        public static BuildRuntime Swift59 => new BuildRuntime("swift-5.9");
        public static BuildRuntime Swift510 => new BuildRuntime("swift-5.10");
        public static BuildRuntime Kotlin16 => new BuildRuntime("kotlin-1.6");
        public static BuildRuntime Kotlin18 => new BuildRuntime("kotlin-1.8");
        public static BuildRuntime Kotlin19 => new BuildRuntime("kotlin-1.9");
        public static BuildRuntime Kotlin20 => new BuildRuntime("kotlin-2.0");
        public static BuildRuntime Cpp17 => new BuildRuntime("cpp-17");
        public static BuildRuntime Cpp20 => new BuildRuntime("cpp-20");
        public static BuildRuntime Bun10 => new BuildRuntime("bun-1.0");
        public static BuildRuntime Bun11 => new BuildRuntime("bun-1.1");
        public static BuildRuntime Go123 => new BuildRuntime("go-1.23");
        public static BuildRuntime Static1 => new BuildRuntime("static-1");
        public static BuildRuntime Flutter324 => new BuildRuntime("flutter-3.24");
        public static BuildRuntime Flutter327 => new BuildRuntime("flutter-3.27");
        public static BuildRuntime Flutter329 => new BuildRuntime("flutter-3.29");
        public static BuildRuntime Flutter332 => new BuildRuntime("flutter-3.32");
    }
}
