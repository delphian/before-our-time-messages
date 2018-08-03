using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes.Games
{
    /// <summary>
    /// A game environmnent containing users, locations, items, and unique rules
    /// </summary>
    public class GameAttribute : ItemAttribute, IItemAttribute
    {
        /// <summary>
        /// Name of the game
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { set; get; }
        /// <summary>
        /// Default location of a new item when parent is not specified
        /// </summary>
        [JsonProperty(PropertyName = "defaultLocationId")]
        public Guid? DefaultLocationId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public GameAttribute()
        {
            AttributeType = this.GetType().ToString();
        }
    }
}
