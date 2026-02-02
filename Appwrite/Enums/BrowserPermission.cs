using System;

namespace Appwrite.Enums
{
    public class BrowserPermission : IEnum
    {
        public string Value { get; private set; }

        public BrowserPermission(string value)
        {
            Value = value;
        }

        public static BrowserPermission Geolocation => new BrowserPermission("geolocation");
        public static BrowserPermission Camera => new BrowserPermission("camera");
        public static BrowserPermission Microphone => new BrowserPermission("microphone");
        public static BrowserPermission Notifications => new BrowserPermission("notifications");
        public static BrowserPermission Midi => new BrowserPermission("midi");
        public static BrowserPermission Push => new BrowserPermission("push");
        public static BrowserPermission ClipboardRead => new BrowserPermission("clipboard-read");
        public static BrowserPermission ClipboardWrite => new BrowserPermission("clipboard-write");
        public static BrowserPermission PaymentHandler => new BrowserPermission("payment-handler");
        public static BrowserPermission Usb => new BrowserPermission("usb");
        public static BrowserPermission Bluetooth => new BrowserPermission("bluetooth");
        public static BrowserPermission Accelerometer => new BrowserPermission("accelerometer");
        public static BrowserPermission Gyroscope => new BrowserPermission("gyroscope");
        public static BrowserPermission Magnetometer => new BrowserPermission("magnetometer");
        public static BrowserPermission AmbientLightSensor => new BrowserPermission("ambient-light-sensor");
        public static BrowserPermission BackgroundSync => new BrowserPermission("background-sync");
        public static BrowserPermission PersistentStorage => new BrowserPermission("persistent-storage");
        public static BrowserPermission ScreenWakeLock => new BrowserPermission("screen-wake-lock");
        public static BrowserPermission WebShare => new BrowserPermission("web-share");
        public static BrowserPermission XrSpatialTracking => new BrowserPermission("xr-spatial-tracking");
    }
}
