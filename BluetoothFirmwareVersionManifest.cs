using Moduware.Platform.Core.Manifests.Abstractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moduware.Platform.Core.Manifests
{
    public class BluetoothFirmwareVersionManifest : VersionManifest
    {
        /// <summary>
        /// The minimum bootloader version required by the firmware.
        /// </summary>
        [JsonProperty("minimumBootloaderVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version MinimumBootloaderVersion = new Version("0.0.0");
    }
}
