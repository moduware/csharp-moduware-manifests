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
        /// Version of stable tile
        /// </summary>
        [JsonProperty("stableTileVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version StableTileVersion = new Version("0.0.0");

        /// <summary>
        /// Version of beta tile
        /// </summary>
        [JsonProperty("betaTileVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version BetaTileVersion = new Version("0.0.0");

        /// <summary>
        /// Version of alpha tile
        /// </summary>
        [JsonProperty("alphaTileVersion"), JsonConverter(typeof(Newtonsoft.Json.Converters.VersionConverter))]
        public Version AlphaTileVersion = new Version("0.0.0");
    }
}