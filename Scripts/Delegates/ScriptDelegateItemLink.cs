using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Scripts.Delegates
{
    /// <summary>
    /// Link a script delegate defintion to an item
    /// </summary>
    public class ScriptDelegateItemLink : Model
    {
        /// <summary>
        /// Item that agrees to implements a script delegate
        /// </summary>
        [JsonProperty(PropertyName = "itemId")]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid ItemId { set; get; }
        [JsonIgnore]
        public virtual Item Item { set; get; }
        /// <summary>
        /// Script delegate definition being implemented
        /// </summary>
        [JsonProperty(PropertyName = "delegateId")]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid DelegateId { set; get; }
    }
}
