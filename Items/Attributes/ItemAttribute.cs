using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes
{
    /// <summary>
    /// Additional information wrapping, but based on an item's type
    /// </summary>
    public class ItemAttribute : Model, IItemAttribute
    {
        [JsonProperty(PropertyName = "attributeType", Order = 14)]
        public string AttributeType { set; get; }
        /// <summary>
        /// Unique item identifier that this item type is associated with
        /// </summary>
        [JsonProperty(PropertyName = "itemId", Order = 15)]
        [JsonConverter(typeof(GuidJsonConverter))]
        /// <summary>
        /// Item that this item type is associated with
        /// </summary>
        public Guid ItemId { set; get; }
        [JsonIgnore]
        public virtual Item Item { set; get; }
        /// <summary>
        /// Get item to which detail information is attached
        /// </summary>
        /// <returns></returns>
        public Item GetItem()
        {
            return this.Item;
        }
    }
}
