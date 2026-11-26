using System;

namespace Appwrite.Enums
{
    public class VideoCodecId : IEnum
    {
        public string Value { get; private set; }

        public VideoCodecId(string value)
        {
            Value = value;
        }

        public static VideoCodecId H264 => new VideoCodecId("h264");
        public static VideoCodecId Hevc => new VideoCodecId("hevc");
        public static VideoCodecId Vp9 => new VideoCodecId("vp9");
    }
}
