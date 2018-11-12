using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moduware.Platform.Core.Manifests.Abstractions
{
    public abstract class VersionManifest : Manifest
    {
        /// <summary>
        /// Version of the firmware.
        /// </summary>
        [JsonProperty("version"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version Version = new Version("0.0.0");

        /// <summary>
        /// The changes in this version.
        /// </summary>
        [JsonProperty("changes")]
        public string ChangesInThisVersion;
    }
}
