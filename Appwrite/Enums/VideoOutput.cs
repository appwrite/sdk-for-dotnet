using System;

namespace Appwrite.Enums
{
    public class VideoOutput : IEnum
    {
        public string Value { get; private set; }

        public VideoOutput(string value)
        {
            Value = value;
        }

        public static VideoOutput Hls => new VideoOutput("hls");
        public static VideoOutput Dash => new VideoOutput("dash");
        public static VideoOutput Cmaf => new VideoOutput("cmaf");
    }
}
