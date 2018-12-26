using BeforeOurTime.Models.Modules.Core.Models.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Generators
{
    /// <summary>
    /// Generate an item
    /// </summary>
    public class GeneratorItemData : ItemData, IItemData
    {
        /// <summary>
        /// Seconds between item generation
        /// </summary>
        [JsonProperty(PropertyName = "interval", Order = 50)]
        public int Interval { set; get; }
        /// <summary>
        /// Maximum number of items that can exist at parent.
        /// Determined by comparing type ids
        /// </summary>
        [JsonProperty(PropertyName = "maximum", Order = 70)]
        public int Maximum { set; get; }
        /// <summary>
        /// Json of item to create
        /// </summary>
        [JsonProperty(PropertyName = "json", Order = 80)]
        public string Json { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public GeneratorItemData()
        {
            DataType = this.GetType().ToString();
        }
    }
}
