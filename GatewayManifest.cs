using System;
using Moduware.Platform.Core.Manifests.Abstractions;
using Moduware.Platform.Core.Manifests.Structures;
using Newtonsoft.Json;

namespace Moduware.Platform.Core.Manifests
{
    public class GatewayManifest : ProductManifest
    {
        /// <summary>
        /// Versions of a bluetooth firmware
        /// </summary>
        [JsonProperty("bluetoothFirmwareVersions")]
        public VersionLevels BluetoothFirmwareVersions = new VersionLevels
        {
            Stable = new Version("0.0.0"),
            Beta = new Version("0.0.0"),
            Alpha = new Version("0.0.0")
        };

        #region OBSOLETE
        /// <summary>
        /// The latest ble version.
        /// </summary>
        [Obsolete("Not used after update-system-2 (app 1.1.13+)")]
        [JsonProperty("bluetoothFirmwareVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version BluetoothFirmwareVersion = new Version("0.0.0");

        /// <summary>
        /// The changes in this ble version.
        /// </summary>
        [Obsolete("Not used after update-system-2 (app 1.1.13+)")]
        [JsonProperty("bluetoothFirmwareChanges")]
        public string ChangesInThisBluetoothFirmwareVersion;


        /// <summary>
        /// The latest ble version.
        /// </summary>
        [JsonProperty("bootloaderVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        [Obsolete("Wrong name, use BluetoothFirmwareVersion instead")]
        private Version BootloaderVersion
        {
            set => BluetoothFirmwareVersion = value;
        }

        /// <summary>
        /// The changes in this ble version.
        /// </summary>
        [JsonProperty("bootloaderChanges")]
        [Obsolete("Wrong name, use ChangesInThisBluetoothFirmwareVersion instead")]
        private string ChangesInThisBootloaderVersion
        {
            set => ChangesInThisBluetoothFirmwareVersion = value;
        }

        #endregion
    }
}
