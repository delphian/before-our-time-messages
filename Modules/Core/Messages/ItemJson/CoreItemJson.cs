using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemJson
{
    /// <summary>
    /// A unique item identifier and it's corrisponding JSON encoding
    /// </summary>
    public class CoreItemJson
    {
        /// <summary>
        /// Unique item identifier
        /// </summary>
        [JsonProperty(PropertyName = "id", Order = 1000)]
        public string Id { set; get; }
        /// <summary>
        /// Recursively include all children in json
        /// </summary>
        [JsonProperty(PropertyName = "include_children", Order = 1050)]
        public bool IncludeChildren { set; get; }
        /// <summary>
        /// Item encoded as JSON
        /// </summary>
        [JsonProperty(PropertyName = "json", Order = 1100)]
        public string JSON { set; get; }
    }
}
