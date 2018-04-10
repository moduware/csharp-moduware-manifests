using Newtonsoft.Json;

namespace Moduware.Platform.Core.Manifests
{
    /// <summary>
    /// This is general manifest structure common for every entity
    /// </summary>
    public class Manifest
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

        /// <summary>
        /// The changes in this version.
        /// </summary>
        [JsonProperty("changes")]
        public string ChangesInThisVersion;
    }
}
