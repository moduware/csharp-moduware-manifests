using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moduware.Platform.Core.Manifests.Structures
{
    public class VersionLevels
    {
        /// <summary>
        /// Stable (production) version
        /// </summary>
        [JsonProperty("stable"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version Stable = new Version("0.0.0");

        /// <summary>
        /// Beta (pre-release) version
        /// </summary>
        [JsonProperty("beta"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version Beta = new Version("0.0.0");

        /// <summary>
        /// Alpha (devs-only) version
        /// </summary>
        [JsonProperty("alpha"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version Alpha = new Version("0.0.0");
    }
}
