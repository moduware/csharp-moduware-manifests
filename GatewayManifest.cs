using System;
using Newtonsoft.Json;

namespace Moduware.Platform.Core.Manifests
{
    public class GatewayManifest : ProductManifest
    {
        /// <summary>
        /// The latest ble version.
        /// </summary>
        [JsonProperty("bootloaderVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version BluetoothFirmwareVersion = new Version("0.0.0");

        /// <summary>
        /// The minimum ble version required by the firmware.
        /// </summary>
        [JsonProperty("minimumBootloaderVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version MinimumBluetoothFirmwareVersion = new Version("0.0.0");

        /// <summary>
        /// The changes in this ble version.
        /// </summary>
        [JsonProperty("bootloaderChanges")]
        public string ChangesInThisBluetoothFirmwareVersion;
    }
}
