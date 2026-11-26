using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Videos : Service
    {
        public Videos(Client client) : base(client)
        {
        }

        /// <para>
        /// Get a list of videos in the current project. Sessions receive only videos
        /// they can read according to each video's `$permissions`. API keys and admins
        /// receive the full project catalog. Playback uses the same document read ACL
        /// plus the `videos.play` (or `videos.read`) scope: a guest can stream a video
        /// that grants `read("any")` or `read("guests")` even though guests lack
        /// `videos.read` and will not see it in this list.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.VideoList> List(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/videos";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.VideoList Convert(Dictionary<string, object> it)
            {
                return Models.VideoList.From(map: it);
            }

            return _client.Call<Models.VideoList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a video resource from an existing file in a storage bucket. The
        /// source file must be a video or audio file, and the caller must be able to
        /// read that file. Creating a video stores the document and queues timeline
        /// generation. The worker downloads the source, probes metadata, extracts
        /// embedded captions once, and deletes its working copy when finished. Sources
        /// with a video track also get a thumbnail timeline. Call create-rendition to
        /// package a streaming output.
        /// 
        /// An optional `name` defaults to the source file name. An optional
        /// `permissions` array sets the video document ACL (list, get, update, delete,
        /// manage child resources, and playback). By default, only the current user is
        /// granted all permissions; API keys and admins create with empty permissions
        /// when omitted. Guests with `videos.play` can stream when the video grants
        /// them read (`read("any")` or `read("guests")`).
        /// 
        /// Uploaded caption files stay listed alongside auto-extracted tracks for the
        /// same language; when the current default is an auto-extracted track with
        /// that code, the upload takes the default flag.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Video> Create(string videoId, string bucketId, string fileId, string? name = null, List<string>? permissions = null)
        {
            var apiPath = "/videos";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "videoId", videoId },
                { "bucketId", bucketId },
                { "fileId", fileId },
                { "name", name },
                { "permissions", permissions }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Video Convert(Dictionary<string, object> it)
            {
                return Models.Video.From(map: it);
            }

            return _client.Call<Models.Video>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a list of video encode codecs enabled on this instance. Each codec
        /// includes the output formats it may be packaged into.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.VideoCodecList> ListCodecs()
        {
            var apiPath = "/videos/codecs";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.VideoCodecList Convert(Dictionary<string, object> it)
            {
                return Models.VideoCodecList.From(map: it);
            }

            return _client.Call<Models.VideoCodecList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a video by its unique ID. This endpoint response returns a JSON object
        /// with the video metadata.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Video> Get(string videoId)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            var apiPath = "/videos/{videoId}"
                .Replace("{videoId}", Client.EncodePath(videoId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.Video Convert(Dictionary<string, object> it)
            {
                return Models.Video.From(map: it);
            }

            return _client.Call<Models.Video>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a video's name, permissions, or both. Only the fields you pass are
        /// changed: omit `name` to keep the current name and `permissions` to keep the
        /// current ACL. The caller must hold update permission on the video document.
        /// The source file cannot be replaced; delete the video and create a new one
        /// to point at a different file.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Video> Update(string videoId, string? name = null, List<string>? permissions = null)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            var apiPath = "/videos/{videoId}"
                .Replace("{videoId}", Client.EncodePath(videoId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "permissions", permissions }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Video Convert(Dictionary<string, object> it)
            {
                return Models.Video.From(map: it);
            }

            return _client.Call<Models.Video>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a video by its unique ID. This also removes every rendition,
        /// caption, preview and transcoded artifact derived from it. Fails with
        /// `video_rendition_in_progress` while a rendition is started or ended, unless
        /// that rendition has not been updated within the rendition retention window.
        /// Fails with `video_timeline_in_progress` while the video's timeline is being
        /// generated, unless the video has not been updated within the same window.
        /// 
        /// </para>
        /// </summary>
        public Task<object> Delete(string videoId)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            var apiPath = "/videos/{videoId}"
                .Replace("{videoId}", Client.EncodePath(videoId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Get a list of all the caption tracks attached to a video. You can use the
        /// query params to filter your results.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.VideoCaptionList> ListCaptions(string videoId, List<string>? queries = null, bool? total = null)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            var apiPath = "/videos/{videoId}/captions"
                .Replace("{videoId}", Client.EncodePath(videoId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.VideoCaptionList Convert(Dictionary<string, object> it)
            {
                return Models.VideoCaptionList.From(map: it);
            }

            return _client.Call<Models.VideoCaptionList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Add a caption track to a video from a WebVTT or SubRip file in a storage
        /// bucket. The file is normalised to WebVTT and segmented in the background.
        /// Subscribe to `videos.[videoId].captions.[captionId].update` for `started`,
        /// `ready`, and `error` status changes instead of only polling the caption
        /// document.
        /// 
        /// Uploaded tracks are listed alongside auto-extracted embedded tracks
        /// (`embedded: true`). When the current default is an auto-extracted track for
        /// the same language code, the upload takes the default flag so players pick
        /// the authored file first. Auto-extracted tracks are never removed
        /// automatically — delete a track explicitly to remove it. Extraction runs
        /// once per video, so a deleted extracted track is not re-created.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.VideoCaption> CreateCaption(string videoId, string bucketId, string fileId, string name, string language, bool? @default = null)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            var apiPath = "/videos/{videoId}/captions"
                .Replace("{videoId}", Client.EncodePath(videoId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "bucketId", bucketId },
                { "fileId", fileId },
                { "name", name },
                { "language", language },
                { "default", @default }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.VideoCaption Convert(Dictionary<string, object> it)
            {
                return Models.VideoCaption.From(map: it);
            }

            return _client.Call<Models.VideoCaption>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a caption track by its unique ID. Pass only `name`, `language`,
        /// and/or `default` to retag an extracted track (for example `und` → `heb`
        /// for Hebrew) without replacing the file. Changing `bucketId`/`fileId`
        /// re-packages the track in the background.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.VideoCaption> UpdateCaption(string videoId, string captionId, string? bucketId = null, string? fileId = null, string? name = null, string? language = null, bool? @default = null)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            if (captionId == "")
            {
                throw new AppwriteException("Missing required parameter: \"captionId\"");
            }

            var apiPath = "/videos/{videoId}/captions/{captionId}"
                .Replace("{videoId}", Client.EncodePath(videoId))
                .Replace("{captionId}", Client.EncodePath(captionId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "bucketId", bucketId },
                { "fileId", fileId },
                { "name", name },
                { "language", language },
                { "default", @default }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.VideoCaption Convert(Dictionary<string, object> it)
            {
                return Models.VideoCaption.From(map: it);
            }

            return _client.Call<Models.VideoCaption>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a caption track by its unique ID, along with its packaged segments.
        /// 
        /// </para>
        /// </summary>
        public Task<object> DeleteCaption(string videoId, string captionId)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            if (captionId == "")
            {
                throw new AppwriteException("Missing required parameter: \"captionId\"");
            }

            var apiPath = "/videos/{videoId}/captions/{captionId}"
                .Replace("{videoId}", Client.EncodePath(videoId))
                .Replace("{captionId}", Client.EncodePath(captionId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Get the top-level streaming manifest for a video output: an HLS master
        /// playlist (`master.m3u8`) or a DASH MPD (`master.mpd`). Hand this URL to a
        /// player to begin adaptive playback.
        /// 
        /// Guests can request this URL when they hold `videos.play` (or `videos.read`)
        /// **and** the video document grants them read. A video with `read("any")` or
        /// `read("guests")` is playable without a session.
        /// 
        /// For CMAF renditions, use `getCmafHlsManifest` or `getCmafDashManifest`.
        /// Both masters point at the same fMP4 segment set.
        /// 
        /// </para>
        /// </summary>
        public Task<byte[]> GetCmafHlsManifest(string videoId)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            var apiPath = "/videos/{videoId}/outputs/cmaf/master.m3u8"
                .Replace("{videoId}", Client.EncodePath(videoId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "*/*" }
            };



            return _client.Call<byte[]>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Get the top-level streaming manifest for a video output: an HLS master
        /// playlist (`master.m3u8`) or a DASH MPD (`master.mpd`). Hand this URL to a
        /// player to begin adaptive playback.
        /// 
        /// Guests can request this URL when they hold `videos.play` (or `videos.read`)
        /// **and** the video document grants them read. A video with `read("any")` or
        /// `read("guests")` is playable without a session.
        /// 
        /// For CMAF renditions, use `getCmafHlsManifest` or `getCmafDashManifest`.
        /// Both masters point at the same fMP4 segment set.
        /// 
        /// </para>
        /// </summary>
        public Task<byte[]> GetCmafDashManifest(string videoId)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            var apiPath = "/videos/{videoId}/outputs/cmaf/master.mpd"
                .Replace("{videoId}", Client.EncodePath(videoId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "*/*" }
            };



            return _client.Call<byte[]>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Get the top-level streaming manifest for a video output: an HLS master
        /// playlist (`master.m3u8`) or a DASH MPD (`master.mpd`). Hand this URL to a
        /// player to begin adaptive playback.
        /// 
        /// Guests can request this URL when they hold `videos.play` (or `videos.read`)
        /// **and** the video document grants them read. A video with `read("any")` or
        /// `read("guests")` is playable without a session.
        /// 
        /// For CMAF renditions, use `getCmafHlsManifest` or `getCmafDashManifest`.
        /// Both masters point at the same fMP4 segment set.
        /// 
        /// </para>
        /// </summary>
        public Task<byte[]> GetDashManifest(string videoId)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            var apiPath = "/videos/{videoId}/outputs/dash/master.mpd"
                .Replace("{videoId}", Client.EncodePath(videoId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "*/*" }
            };



            return _client.Call<byte[]>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Get the top-level streaming manifest for a video output: an HLS master
        /// playlist (`master.m3u8`) or a DASH MPD (`master.mpd`). Hand this URL to a
        /// player to begin adaptive playback.
        /// 
        /// Guests can request this URL when they hold `videos.play` (or `videos.read`)
        /// **and** the video document grants them read. A video with `read("any")` or
        /// `read("guests")` is playable without a session.
        /// 
        /// For CMAF renditions, use `getCmafHlsManifest` or `getCmafDashManifest`.
        /// Both masters point at the same fMP4 segment set.
        /// 
        /// </para>
        /// </summary>
        public Task<byte[]> GetHlsManifest(string videoId)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            var apiPath = "/videos/{videoId}/outputs/hls/master.m3u8"
                .Replace("{videoId}", Client.EncodePath(videoId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "*/*" }
            };



            return _client.Call<byte[]>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Get the playable caption resource for a video output: an HLS captions
        /// playlist, or the WebVTT file itself for DASH.
        /// 
        /// Guests can request this URL when they hold `videos.play` (or `videos.read`)
        /// **and** the video document grants them read.
        /// 
        /// </para>
        /// </summary>
        public Task<byte[]> GetCaptionManifest(string videoId, Appwrite.Enums.VideoOutput output, string captionId)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            if (captionId == "")
            {
                throw new AppwriteException("Missing required parameter: \"captionId\"");
            }

            var apiPath = "/videos/{videoId}/outputs/{output}/captions/{captionId}/manifest"
                .Replace("{videoId}", Client.EncodePath(videoId))
                .Replace("{output}", Client.EncodePath(output.Value))
                .Replace("{captionId}", Client.EncodePath(captionId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "*/*" }
            };



            return _client.Call<byte[]>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Get a list of all the renditions of a video. You can use the query params
        /// to filter your results.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.VideoRenditionList> ListRenditions(string videoId, List<string>? queries = null, bool? total = null)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            var apiPath = "/videos/{videoId}/renditions"
                .Replace("{videoId}", Client.EncodePath(videoId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.VideoRenditionList Convert(Dictionary<string, object> it)
            {
                return Models.VideoRenditionList.From(map: it);
            }

            return _client.Call<Models.VideoRenditionList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Request a new rendition of a video, encoded against a video profile and
        /// packaged for HLS, DASH, or CMAF. The rendition is created immediately with
        /// a `pending` status and transcoded in the background; poll it or subscribe
        /// to realtime events to follow its progress. The worker downloads the source
        /// file for this job, probes metadata and extracts embedded captions when
        /// needed, then deletes the working copy when the job ends.
        /// 
        /// The profile codec must be enabled on this instance. A disabled codec fails
        /// with `video_codec_disabled`.
        /// 
        /// Each video may have only one rendition per profile and output combination.
        /// Creating a duplicate fails with `video_rendition_already_exists`. After an
        /// encode fails or is aborted, delete the rendition and create it again. The
        /// same profile may still be encoded for different outputs (for example HLS
        /// and DASH).
        /// 
        /// A video accepts 10 rendition creates per hour. The next create returns
        /// `general_rate_limit_exceeded`.
        /// 
        /// CMAF packs shared fMP4 segments once and exposes both HLS
        /// (`/outputs/cmaf/master.m3u8`) and DASH (`/outputs/cmaf/master.mpd`) masters
        /// for the same encode.
        /// 
        /// Renditions can only be created from the Console or a server SDK with an API
        /// key that has the `videos.write` scope. Each encode spends the project's
        /// compute, so client sessions receive `user_unauthorized`.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.VideoRendition> CreateRendition(string videoId, string profileId, Appwrite.Enums.VideoOutput output)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            var apiPath = "/videos/{videoId}/renditions"
                .Replace("{videoId}", Client.EncodePath(videoId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "profileId", profileId },
                { "output", output?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.VideoRendition Convert(Dictionary<string, object> it)
            {
                return Models.VideoRendition.From(map: it);
            }

            return _client.Call<Models.VideoRendition>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a rendition by its unique ID, including its current transcoding status
        /// and progress.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.VideoRendition> GetRendition(string videoId, string renditionId)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            if (renditionId == "")
            {
                throw new AppwriteException("Missing required parameter: \"renditionId\"");
            }

            var apiPath = "/videos/{videoId}/renditions/{renditionId}"
                .Replace("{videoId}", Client.EncodePath(videoId))
                .Replace("{renditionId}", Client.EncodePath(renditionId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.VideoRendition Convert(Dictionary<string, object> it)
            {
                return Models.VideoRendition.From(map: it);
            }

            return _client.Call<Models.VideoRendition>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a rendition by its unique ID, along with its packaged segments and
        /// transcoded output. Fails with `video_rendition_in_progress` while the
        /// rendition is started or ended, unless it has not been updated within the
        /// rendition retention window.
        /// 
        /// </para>
        /// </summary>
        public Task<object> DeleteRendition(string videoId, string renditionId)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            if (renditionId == "")
            {
                throw new AppwriteException("Missing required parameter: \"renditionId\"");
            }

            var apiPath = "/videos/{videoId}/renditions/{renditionId}"
                .Replace("{videoId}", Client.EncodePath(videoId))
                .Replace("{renditionId}", Client.EncodePath(renditionId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Get a single thumbnail sheet from a video's timeline as an image. You can
        /// resize the returned image and choose its output format.
        /// 
        /// Guests can request this URL when they hold `videos.play` (or `videos.read`)
        /// **and** the video document grants them read.
        /// 
        /// </para>
        /// </summary>
        public Task<byte[]> GetThumbnail(string videoId, string thumbnailId, long? width = null, long? height = null, Appwrite.Enums.ImageFormat? output = null)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            if (thumbnailId == "")
            {
                throw new AppwriteException("Missing required parameter: \"thumbnailId\"");
            }

            var apiPath = "/videos/{videoId}/thumbnails/{thumbnailId}"
                .Replace("{videoId}", Client.EncodePath(videoId))
                .Replace("{thumbnailId}", Client.EncodePath(thumbnailId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "width", width },
                { "height", height },
                { "output", output?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "image/*" }
            };



            return _client.Call<byte[]>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Get the WebVTT thumbnail timeline for a video, used to render scrubbing
        /// thumbnails in a player. Timeline generation is queued when the video is
        /// created. Subscribe to `videos.[videoId].timelines.update` for probe and
        /// terminal updates, or poll this endpoint until it returns a WebVTT document.
        /// Audio-only sources produce no timeline and this endpoint returns
        /// `video_timelines_not_found`.
        /// 
        /// Guests can request this URL when they hold `videos.play` (or `videos.read`)
        /// **and** the video document grants them read. A video with `read("any")` or
        /// `read("guests")` is playable without a session.
        /// 
        /// </para>
        /// </summary>
        public Task<byte[]> GetTimeline(string videoId)
        {
            if (videoId == "")
            {
                throw new AppwriteException("Missing required parameter: \"videoId\"");
            }

            var apiPath = "/videos/{videoId}/timeline"
                .Replace("{videoId}", Client.EncodePath(videoId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "*/*" }
            };



            return _client.Call<byte[]>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

    }
}
