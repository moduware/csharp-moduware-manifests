using System;
using System.Collections.Generic;
using Moduware.Platform.Core.Manifests.Abstractions;
using Moduware.Platform.Core.Manifests.Enumerations;
using Moduware.Platform.Core.Manifests.Structures;
using Newtonsoft.Json;

namespace Moduware.Platform.Core.Manifests
{
    public class TileManifest : Manifest
    {
        /// <summary>
        /// Versions of a tile
        /// </summary>
        [JsonProperty("versions")]
        public VersionLevels versions = new VersionLevels
        {
            Stable = new Version("0.0.0"),
            Beta = new Version("0.0.0"),
            Alpha = new Version("0.0.0")
        };
    }
}