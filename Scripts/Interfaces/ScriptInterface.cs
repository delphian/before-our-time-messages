using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeforeOurTime.Models.Scripts.Interfaces
{
    /// <summary>
    /// A set of data structures and delegates that an item's script must implement
    /// </summary>
    /// <remarks>
    /// A single item script may implement multiple interfaces
    /// </remarks>
    public class ScriptInterface : Model
    {
        /// <summary>
        /// Human friendly name of script interface
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { set; get; }
        /// <summary>
        /// All linking table entries mapping script function to script interface
        /// </summary>
        /// <remarks>
        /// Always return at least an empty list
        /// </remarks>
        [JsonProperty(PropertyName = "delegateLinks")]
        public List<ScriptInterfaceDelegateLink> DelegateLinks { set; get; }
    }
}
