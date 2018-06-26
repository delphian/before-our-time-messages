using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Scripts.Delegates;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Scripts.Interfaces
{
    /// <summary>
    /// Link a script function to a script interface
    /// </summary>
    public class ScriptInterfaceDelegateLink : Model
    {
        /// <summary>
        /// Script interface function unique identifier
        /// </summary>
        [JsonProperty(PropertyName = "callbackId", Order = 20)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid CallbackId { set; get; }
        /// <summary>
        /// Script interface unique identifier
        /// </summary>
        [JsonProperty(PropertyName = "interfaceId", Order = 25)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid InterfaceId { set; get; }
        [JsonIgnore]
        public virtual ScriptInterface ScriptInterface { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ScriptInterfaceDelegateLink()
        {

        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="scriptInterface">A set of data structures and function callbacks that an item's script must implement</param>
        /// <param name="ScriptCallback">A script callback function name, it's argument type, and return type</param>
        public ScriptInterfaceDelegateLink(ScriptInterface scriptInterface, IDelegate callback)
        {
            ScriptInterface = scriptInterface;
            CallbackId = callback.GetId();
        }
    }
}
