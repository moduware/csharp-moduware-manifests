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
        /// The changes in this ble version.
        /// </summary>
        [JsonProperty("bootloaderChanges")]
        public string ChangesInThisBluetoothFirmwareVersion;


        #region OBSOLETE

        /// <summary>
        /// The latest ble version.
        /// </summary>
        //[JsonProperty("bootloaderVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        //[Obsolete("Wrong name, use BluetoothFirmwareVersion instead")]
        //private Version BootloaderVersion
        //{
        //    set => BluetoothFirmwareVersion = value;
        //}

        /// <summary>
        /// The changes in this ble version.
        /// </summary>
        //[JsonProperty("bootloaderChanges")]
        //[Obsolete("Wrong name, use ChangesInThisBluetoothFirmwareVersion instead")]
        //private string ChangesInThisBootloaderVersion
        //{
        //    set => ChangesInThisBluetoothFirmwareVersion = value;
        //}

        #endregion
    }
}
