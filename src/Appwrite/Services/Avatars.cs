
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Avatars : Service
    {
        public Avatars(Client client) : base(client) { }

        /// <summary>
        /// Get Browser Icon
        /// <para>
        /// You can use this endpoint to show different browser icons to your users.
        /// The code argument receives the browser code as it appears in your user
        /// /account/sessions endpoint. Use width, height and quality arguments to
        /// change the output settings.
        /// </para>
        /// </summary>
        public Task<byte[]> GetBrowser(string code, int? width = null, int? height = null, int? quality = null)
        {
            var path = "/avatars/browsers/{code}"
                .Replace("{code}", code);

            var parameters = new Dictionary<string, object?>()
            {
                { "width", width },
                { "height", height },
                { "quality", quality },
                { "project", _client.Config["project"] },
                { "key", _client.Config["key"] },
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return _client.Call<byte[]>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                responseType: typeof(byte[]));
        }

        /// <summary>
        /// Get Credit Card Icon
        /// <para>
        /// The credit card endpoint will return you the icon of the credit card
        /// provider you need. Use width, height and quality arguments to change the
        /// output settings.
        /// </para>
        /// </summary>
        public Task<byte[]> GetCreditCard(string code, int? width = null, int? height = null, int? quality = null)
        {
            var path = "/avatars/credit-cards/{code}"
                .Replace("{code}", code);

            var parameters = new Dictionary<string, object?>()
            {
                { "width", width },
                { "height", height },
                { "quality", quality },
                { "project", _client.Config["project"] },
                { "key", _client.Config["key"] },
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return _client.Call<byte[]>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                responseType: typeof(byte[]));
        }

        /// <summary>
        /// Get Favicon
        /// <para>
        /// Use this endpoint to fetch the favorite icon (AKA favicon) of any remote
        /// website URL.
        /// 
        /// </para>
        /// </summary>
        public Task<byte[]> GetFavicon(string url)
        {
            var path = "/avatars/favicon";

            var parameters = new Dictionary<string, object?>()
            {
                { "url", url },
                { "project", _client.Config["project"] },
                { "key", _client.Config["key"] },
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return _client.Call<byte[]>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                responseType: typeof(byte[]));
        }

        /// <summary>
        /// Get Country Flag
        /// <para>
        /// You can use this endpoint to show different country flags icons to your
        /// users. The code argument receives the 2 letter country code. Use width,
        /// height and quality arguments to change the output settings.
        /// </para>
        /// </summary>
        public Task<byte[]> GetFlag(string code, int? width = null, int? height = null, int? quality = null)
        {
            var path = "/avatars/flags/{code}"
                .Replace("{code}", code);

            var parameters = new Dictionary<string, object?>()
            {
                { "width", width },
                { "height", height },
                { "quality", quality },
                { "project", _client.Config["project"] },
                { "key", _client.Config["key"] },
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return _client.Call<byte[]>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                responseType: typeof(byte[]));
        }

        /// <summary>
        /// Get Image from URL
        /// <para>
        /// Use this endpoint to fetch a remote image URL and crop it to any image size
        /// you want. This endpoint is very useful if you need to crop and display
        /// remote images in your app or in case you want to make sure a 3rd party
        /// image is properly served using a TLS protocol.
        /// </para>
        /// </summary>
        public Task<byte[]> GetImage(string url, int? width = null, int? height = null)
        {
            var path = "/avatars/image";

            var parameters = new Dictionary<string, object?>()
            {
                { "url", url },
                { "width", width },
                { "height", height },
                { "project", _client.Config["project"] },
                { "key", _client.Config["key"] },
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return _client.Call<byte[]>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                responseType: typeof(byte[]));
        }

        /// <summary>
        /// Get User Initials
        /// <para>
        /// Use this endpoint to show your user initials avatar icon on your website or
        /// app. By default, this route will try to print your logged-in user name or
        /// email initials. You can also overwrite the user name if you pass the 'name'
        /// parameter. If no name is given and no user is logged, an empty avatar will
        /// be returned.
        /// 
        /// You can use the color and background params to change the avatar colors. By
        /// default, a random theme will be selected. The random theme will persist for
        /// the user's initials when reloading the same theme will always return for
        /// the same initials.
        /// </para>
        /// </summary>
        public Task<byte[]> GetInitials(string? name = null, int? width = null, int? height = null, string? color = null, string? background = null)
        {
            var path = "/avatars/initials";

            var parameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "width", width },
                { "height", height },
                { "color", color },
                { "background", background },
                { "project", _client.Config["project"] },
                { "key", _client.Config["key"] },
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return _client.Call<byte[]>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                responseType: typeof(byte[]));
        }

        /// <summary>
        /// Get QR Code
        /// <para>
        /// Converts a given plain text to a QR code image. You can use the query
        /// parameters to change the size and style of the resulting image.
        /// </para>
        /// </summary>
        public Task<byte[]> GetQR(string text, int? size = null, int? margin = null, bool? download = null)
        {
            var path = "/avatars/qr";

            var parameters = new Dictionary<string, object?>()
            {
                { "text", text },
                { "size", size },
                { "margin", margin },
                { "download", download },
                { "project", _client.Config["project"] },
                { "key", _client.Config["key"] },
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return _client.Call<byte[]>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                responseType: typeof(byte[]));
        }
    };
}