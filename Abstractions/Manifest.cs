using Newtonsoft.Json;

namespace Moduware.Platform.Core.Manifests.Abstractions
{
    /// <summary>
    /// This is general manifest structure common for every entity
    /// </summary>
    public abstract class Manifest
    {
        /// <summary>
        /// The type identifier of this entity.
        /// </summary>
        [JsonProperty("id")]
        public string TypeId;

        /// <summary>
        /// The name of this entity.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The description of this entity.
        /// </summary>
        [JsonProperty("description")]
        public string Description;
    }
}
