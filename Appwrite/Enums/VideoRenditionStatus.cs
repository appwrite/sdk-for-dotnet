using System;

namespace Appwrite.Enums
{
    public class VideoRenditionStatus : IEnum
    {
        public string Value { get; private set; }

        public VideoRenditionStatus(string value)
        {
            Value = value;
        }

        public static VideoRenditionStatus Pending => new VideoRenditionStatus("pending");
        public static VideoRenditionStatus Started => new VideoRenditionStatus("started");
        public static VideoRenditionStatus Ended => new VideoRenditionStatus("ended");
        public static VideoRenditionStatus Ready => new VideoRenditionStatus("ready");
        public static VideoRenditionStatus Error => new VideoRenditionStatus("error");
        public static VideoRenditionStatus Aborted => new VideoRenditionStatus("aborted");
    }
}
