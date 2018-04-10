using System.Runtime.Serialization;

namespace Moduware.Platform.Core.Manifests.Enumerations
{
    public enum ProductFirmwareType
    {
        // This product is based on msp chip and need msp format of firmaware
        [EnumMember(Value = "msp")]
        MSP,

        // This product is based on maxim chip and need maxim format of firmware
        [EnumMember(Value = "max")]
        MAX
    }
}
