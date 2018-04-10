using Moduware.Platform.Core.Manifests.Enumerations;
using Newtonsoft.Json;

namespace Moduware.Platform.Core.Manifests
{
    public class ModuleManifest : ProductManifest
    {
        /// <summary>
        /// The size of module in slots 1-3.
        /// </summary>
        [JsonProperty("size")]
        public int Size = 1;

        /// <summary>
        /// The orientation of module from connected slot, it can go up or down.
        /// </summary>
        [JsonProperty("orientation"), JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ModuleOrientation Orientation = ModuleOrientation.Up;

        /// <summary>
        /// The identifier of default tile for this module.
        /// </summary>
        [JsonProperty("defaultTile")]
        public string DefaultTileId;
    }
}
