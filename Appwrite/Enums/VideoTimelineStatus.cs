using System;

namespace Appwrite.Enums
{
    public class VideoTimelineStatus : IEnum
    {
        public string Value { get; private set; }

        public VideoTimelineStatus(string value)
        {
            Value = value;
        }

        public static VideoTimelineStatus Pending => new VideoTimelineStatus("pending");
        public static VideoTimelineStatus Started => new VideoTimelineStatus("started");
        public static VideoTimelineStatus Ready => new VideoTimelineStatus("ready");
        public static VideoTimelineStatus Skipped => new VideoTimelineStatus("skipped");
        public static VideoTimelineStatus Error => new VideoTimelineStatus("error");
    }
}
