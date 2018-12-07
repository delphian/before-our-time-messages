using BeforeOurTime.Models.Modules.Core.Models.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Games
{
    /// <summary>
    /// A game environmnent containing users, locations, items, and unique rules
    /// </summary>
    public class GameItemData : ItemData, IItemData
    {
        /// <summary>
        /// Default location of a new item when parent is not specified
        /// </summary>
        [JsonProperty(PropertyName = "defaultLocationId")]
        public Guid? DefaultLocationId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public GameItemData()
        {
            DataType = this.GetType().ToString();
        }
    }
}
