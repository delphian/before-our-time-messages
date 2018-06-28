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
        /// <summary>
        /// Item that this item type is associated with
        /// </summary>
        [JsonProperty(PropertyName = "itemId", Order = 15)]
        [JsonConverter(typeof(GuidJsonConverter))]
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
        /// <summary>
        /// Modify the item name before it is returned
        /// </summary>
        /// <param name="name">Previous name of item</param>
        /// <returns></returns>
        public virtual string GetName(string name)
        {
            return name;
        }
        /// <summary>
        /// Modify the item description before it is returned
        /// </summary>
        /// <param name="name">Previous description of item</param>
        /// <returns></returns>
        public virtual string GetDescription(string description)
        {
            return description;
        }
    }
}
