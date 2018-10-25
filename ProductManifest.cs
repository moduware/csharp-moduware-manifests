using System;
using Moduware.Platform.Core.Manifests.Enumerations;
using Newtonsoft.Json;

namespace Moduware.Platform.Core.Manifests
{
    public class ProductManifest : Manifest
    {
        /// <summary>
        /// Version of stable firmware
        /// </summary>
        [JsonProperty("stableFirmwareVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version StableFirmwareVersion = new Version("0.0.0");

        /// <summary>
        /// Version of beta firmware
        /// </summary>
        [JsonProperty("betaFirmwareVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version BetaFirmwareVersion = new Version("0.0.0");

        /// <summary>
        /// Version of alpha firmware
        /// </summary>
        [JsonProperty("alphaFirmwareVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version AlphaFirmwareVersion = new Version("0.0.0");

        #region OBSOLETE
        /// <summary>
        /// The latest firmware (App) version.
        /// </summary>
        [Obsolete("Not used after update-system-2 (app 1.1.12+)")]
        [JsonProperty("firmwareVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version FirmwareVersion = new Version("0.0.0");

        /// <summary>
        /// The type of the firmware for this module, default is MSP.
        /// </summary>
        [Obsolete("Not used after update-system-2 (app 1.1.12+)")]
        [JsonProperty("firmwareType"), JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ProductFirmwareType FirmwareType = ProductFirmwareType.MSP;


        /// <summary>
        /// The minimum ble version required by the firmware.
        /// </summary>
        [Obsolete("Moved to firmware manifest after update-system-2 (app 1.1.12+)")]
        [JsonProperty("minimumBootloaderVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version MinimumBootloaderVersion = new Version("0.0.0");
        #endregion
    }
}
