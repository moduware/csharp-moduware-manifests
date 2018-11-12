using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moduware.Platform.Core.Manifests.Structures
{
    public struct VersionLevels
    {
        /// <summary>
        /// Stable (production) version
        /// </summary>
        [JsonProperty("stable")] public Version Stable;

        /// <summary>
        /// Beta (pre-release) version
        /// </summary>
        [JsonProperty("beta")] public Version Beta;

        /// <summary>
        /// Alpha (devs-only) version
        /// </summary>
        [JsonProperty("alpha")] public Version Alpha;
    }
}
