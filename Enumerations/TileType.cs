using Newtonsoft.Json;

namespace Moduware.Platform.Core.Manifests.Enumerations
{
    public enum TileType
    {
        /// <summary>
        /// This tile runs in a webview
        /// </summary>
        [JsonProperty("webview")] WebView,

        /// <summary>
        /// This tile runs as a separate application
        /// </summary>
        [JsonProperty("native")] Native
    }
}