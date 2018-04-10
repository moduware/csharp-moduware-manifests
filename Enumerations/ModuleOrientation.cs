using System.Runtime.Serialization;

namespace Moduware.Platform.Core.Manifests.Enumerations
{
    public enum ModuleOrientation
    {
        [EnumMember(Value = "up")]
        Up,
        [EnumMember(Value = "down")]
        Down
    }
}
