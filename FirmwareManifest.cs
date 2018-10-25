using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moduware.Platform.Core.Manifests
{
    public class FirmwareManifest : Manifest
    {
        /// <summary>
        /// Version of the firmware.
        /// </summary>
        [JsonProperty("version"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version Version = new Version("0.0.0");

        /// <summary>
        /// The minimum ble version required by the firmware.
        /// </summary>
        [JsonProperty("minimumBootloaderVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version MinimumBootloaderVersion = new Version("0.0.0");

        /// <summary>
        /// Type of the firmware
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FirmwareType Type = FirmwareType.MSP430TXT;
    }
}
