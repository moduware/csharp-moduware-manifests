using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moduware.Platform.Core.Manifests
{
    public enum FirmwareType
    {
        /// <summary>
        /// This tile runs in a webview
        /// </summary>
        [JsonProperty("msp430txt")] MSP430TXT,

        /// <summary>
        /// This tile runs as a separate application
        /// </summary>
        [JsonProperty("msp430hex")] MSP430HEX

        // WARNING: maxim firmware type was excluded as Moduware don't support it at the moment, we can bring it back
    }
}
