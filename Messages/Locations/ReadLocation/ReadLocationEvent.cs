using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Locations.ReadLocation
{
    /// <summary>
    /// An location item has been created
    /// </summary>
    public class ReadLocationEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("81b55604-4b43-46c7-bef7-40a1ba4c8d93");
        /// <summary>
        /// Location item
        /// </summary>
        [JsonProperty(PropertyName = "location", Order = 1000)]
        public Item Location { set; get; }
        /// <summary>
        /// Exits from location
        /// </summary>
        [JsonProperty(PropertyName = "exits", Order = 1100)]
        public List<Item> Exits { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ReadLocationEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Location Item Has Been Created";
        }
    }
}
