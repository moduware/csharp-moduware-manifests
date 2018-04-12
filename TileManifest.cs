using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Moduware.Platform.Core.Manifests
{
    public class TileManifest : Manifest
    {
        /// <summary>
        /// The latest version of this tile.
        /// </summary>
        [JsonProperty("version"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version Version = new Version("0.0.0");

        /// <summary>
        /// The minimum app version required by this tile.
        /// </summary>
        [JsonProperty("minimumAppVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version MinimumAppVersion = new Version("0.0.0");

        // TODO: Should trigger warning when used, will be removed in ~1.1.5
        /// <summary>
        /// Backwards compatibility field, to support tiles that are using old non-standard field naming
        /// </summary>
        [JsonProperty("app_version"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        private Version LegacyMinimumAppVersion
        {
            set => MinimumAppVersion = value;
        }

        /// <summary>
        /// The list of supported modules.
        /// </summary>
        [JsonProperty("modules")] public List<string> SupportedModules;

        /// <summary>
        /// Type of the tile: webview or native
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TileType Type;

        // TODO: for enterprise repositories consider links to zip archives 
        /// <summary>
        /// Links to install native tile from on every specific platform
        /// </summary>
        [JsonProperty("installationLinks")] public NativeTileInstallationLinks InstallationLinks;

        #region Appearance

        /// <summary>
        /// The text that will be shown on tile.
        /// </summary>
        [JsonProperty("title")] public string Title;

        /// <summary>
        /// The background color of tile.
        /// </summary>
        [JsonProperty("color")] public string Background;

        /// <summary>
        /// The color of the text on tile.
        /// </summary>
        [JsonProperty("textColor")] public string TextColor;

        // TODO: Should trigger warning when used, will be removed in ~1.1.5
        /// <summary>
        /// Backwards compatibility field, to support tiles that are using old non-standard field naming
        /// </summary>
        [JsonProperty("text_color")]
        private string LegacyTextColor
        {
            set => TextColor = value;
        }

        #endregion
    }
}