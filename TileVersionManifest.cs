using Moduware.Platform.Core.Manifests.Abstractions;
using Moduware.Platform.Core.Manifests.Enumerations;
using Moduware.Platform.Core.Manifests.Structures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moduware.Platform.Core.Manifests
{
    public class TileVersionManifest : VersionManifest
    {
        /// <summary>
        /// The minimum app version required by this tile.
        /// </summary>
        [JsonProperty("minimumAppVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version MinimumAppVersion = new Version("0.0.0");

        /// <summary>
        /// The list of supported modules.
        /// </summary>
        [JsonProperty("modules")] public List<string> SupportedModules;

        /// <summary>
        /// Type of the tile: webview or native
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TileType Type;

        /// <summary>
        /// Links to install native tile from on every specific platform
        /// </summary>
        [JsonProperty("installationLinks")]
        public NativeTileInstallationLinks InstallationLinks;

        /// <summary>
        /// Indicates that this tile version is included into an app starting with minimum version by default.
        /// Default tiles cannot be removed
        /// </summary>
        [JsonProperty("builtIn")]
        public bool BuiltIn { get; set; } = false;

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
        #endregion

        #region OBSOLETE
        /// <summary>
        /// Backwards compatibility field, to support tiles that are using old non-standard field naming
        /// </summary>
        [Obsolete("Use 'minimumAppVersion' instead")]
        [JsonProperty("app_version"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        private Version LegacyMinimumAppVersion
        {
            set => MinimumAppVersion = value;
        }

        /// <summary>
        /// Backwards compatibility field, to support tiles that are using old non-standard field naming
        /// </summary>
        [Obsolete("Use 'textColor' instead")]
        [JsonProperty("text_color")]
        private string LegacyTextColor
        {
            set => TextColor = value;
        }
        #endregion
    }
}
