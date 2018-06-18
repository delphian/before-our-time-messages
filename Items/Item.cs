using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items
{
    /// <summary>
    /// Normalized item for consumption as a DTO
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Unique item identifier
        /// </summary>
        [JsonProperty(PropertyName = "id", Order = 100)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid Id { set; get; }
        /// <summary>
        /// Normalized name of item
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 200)]
        public string Name { set; get; }
        /// <summary>
        /// Normalized description of item
        /// </summary>
        [JsonProperty(PropertyName = "description", Order = 300)]
        public string Description { set; get; }
    }
}
