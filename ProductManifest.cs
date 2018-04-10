using System;
using Moduware.Platform.Core.Manifests.Enumerations;
using Newtonsoft.Json;

namespace Moduware.Platform.Core.Manifests
{
    public class ProductManifest : Manifest
    {
        /// <summary>
        /// The latest firmware (App) version.
        /// </summary>
        [JsonProperty("firmwareVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version FirmwareVersion = new Version("0.0.0");

        /// <summary>
        /// The type of the firmware for this module, default is MSP.
        /// </summary>
        [JsonProperty("firmwareType"), JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ProductFirmwareType FirmwareType = ProductFirmwareType.MSP;


        /// <summary>
        /// The minimum ble version required by the firmware.
        /// </summary>
        [JsonProperty("minimumBootloaderVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version MinimumBootloaderVersion = new Version("0.0.0");
    }
}
