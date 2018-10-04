using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemGraph
{
    /// <summary>
    /// Item with reduced properties tailored toward presenting an item graph
    /// </summary>
    public class ItemGraph
    {
        /// <summary>
        /// Unique item identifier
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonProperty(PropertyName = "id", Order = 1000)]
        public Guid Id { set; get; }
        /// <summary>
        /// Name of item
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 1100)]
        public string Name { set; get; }
        /// <summary>
        /// Child items
        /// </summary>
        [JsonProperty(PropertyName = "children", Order = 1200)]
        public List<ItemGraph> Children { set; get; } = new List<ItemGraph>();
    }
}
