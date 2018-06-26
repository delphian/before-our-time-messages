using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes
{
    /// <summary>
    /// A one way path from the exit's current location to a specified and static one
    /// </summary>
    public class AttributeExit : ItemAttribute, IItemAttribute
    {
        /// <summary>
        /// Short description of exit
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { set; get; }
        /// <summary>
        /// Long description of exit
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { set; get; }
        /// <summary>
        /// Destination location
        /// </summary>
        [JsonProperty(PropertyName = "destinationLocationId", Order = 30)]
        public Guid DestinationLocationId { set; get; }
        [JsonIgnore]
        public virtual AttributeLocation DestinationLocation { set; get; }
        /// <summary>
        /// Time in seconds journey will consume
        /// </summary>
        [JsonProperty(PropertyName = "time", Order = 40)]
        public int Time { set; get; }
        /// <summary>
        /// Energy in % (0 - 100) that journey will consume
        /// </summary>
        [JsonProperty(PropertyName = "effort", Order = 50)]
        public int Effort { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AttributeExit()
        {
            AttributeType = this.GetType().ToString();
        }
    }
}
