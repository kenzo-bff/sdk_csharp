using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class OauthCallbackUrl : BunqModel
    {
        /// <summary>
        ///     The id of the callback URL.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        ///     The timestamp of the callback URL's creation.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public string Created { get; set; }

        /// <summary>
        ///     The timestamp of the callback URL's last update.
        /// </summary>
        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }

        /// <summary>
        ///     The Callback URL.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }


        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (Id != null) return false;

            if (Created != null) return false;

            if (Updated != null) return false;

            if (Url != null) return false;

            return true;
        }

        /// <summary>
        /// </summary>
        public static OauthCallbackUrl CreateFromJsonString(string json)
        {
            return CreateFromJsonString<OauthCallbackUrl>(json);
        }
    }
}