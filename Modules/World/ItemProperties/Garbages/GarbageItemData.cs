using BeforeOurTime.Models.Modules.Core.Models.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Garbages
{
    /// <summary>
    /// Garbage collect an item
    /// </summary>
    public class GarbageItemData : ItemData, IItemData
    {
        /// <summary>
        /// Ticks before item is garbage collected
        /// </summary>
        [JsonProperty(PropertyName = "interval", Order = 50)]
        public int Interval { set; get; }
        /// <summary>
        /// Item has been marked for deletion at this time (unless reset)
        /// </summary>
        [JsonProperty(PropertyName = "intervalTime", Order = 60)]
        public DateTime? IntervalTime { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public GarbageItemData()
        {
            DataType = this.GetType().ToString();
        }
    }
}
