using System;
using Moduware.Platform.Core.Manifests.Enumerations;
using Moduware.Platform.Core.Manifests.Structures;
using Newtonsoft.Json;

namespace Moduware.Platform.Core.Manifests.Abstractions
{
    public class ProductManifest : Manifest
    {
        /// <summary>
        /// Versions of a firmware
        /// </summary>
        [JsonProperty("firmwareVersions")]
        public VersionLevels FirmwareVersions = new VersionLevels
        {
            Stable = new Version("0.0.0"),
            Beta = new Version("0.0.0"),
            Alpha = new Version("0.0.0")
        };

        #region OBSOLETE
        /// <summary>
        /// The latest firmware (App) version.
        /// </summary>
        [Obsolete("Not used after update-system-2 (app 1.1.13+)")]
        [JsonProperty("firmwareVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version FirmwareVersion = new Version("0.0.0");

        /// <summary>
        /// The type of the firmware for this module, default is MSP.
        /// </summary>
        [Obsolete("Not used after update-system-2 (app 1.1.13+)")]
        [JsonProperty("firmwareType"), JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ProductFirmwareType FirmwareType = ProductFirmwareType.MSP;


        /// <summary>
        /// The minimum ble version required by the firmware.
        /// </summary>
        [Obsolete("Moved to firmware manifest after update-system-2 (app 1.1.13+)")]
        [JsonProperty("minimumBootloaderVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version MinimumBootloaderVersion = new Version("0.0.0");
        #endregion
    }
}
