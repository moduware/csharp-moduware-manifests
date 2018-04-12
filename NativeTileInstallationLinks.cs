using System;
using Newtonsoft.Json;

namespace Moduware.Platform.Core.Manifests
{
    public struct NativeTileInstallationLinks
    {
        /// <summary>
        /// Link to install native tile on Android platform
        /// </summary>
        [JsonProperty("android")] public Uri Android;

        /// <summary>
        /// Link to install native tile on iOS platform
        /// </summary>
        [JsonProperty("ios")] public Uri iOS;
    }
}