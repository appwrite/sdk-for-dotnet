using System;

namespace Appwrite.Enums
{
    public class VideoCaptionStatus : IEnum
    {
        public string Value { get; private set; }

        public VideoCaptionStatus(string value)
        {
            Value = value;
        }

        public static VideoCaptionStatus Pending => new VideoCaptionStatus("pending");
        public static VideoCaptionStatus Started => new VideoCaptionStatus("started");
        public static VideoCaptionStatus Ready => new VideoCaptionStatus("ready");
        public static VideoCaptionStatus Error => new VideoCaptionStatus("error");
        public static VideoCaptionStatus Aborted => new VideoCaptionStatus("aborted");
    }
}
