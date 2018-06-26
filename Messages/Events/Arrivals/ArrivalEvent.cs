using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Events.Arrivals
{
    /// <summary>
    /// An item has arrived at same location
    /// </summary>
    public class ArrivalEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("2d6bb89d-08d3-4d3f-acff-2e0dc0481a56");
        /// <summary>
        /// Simple name of item that has arrived
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 1000)]
        public string Name { set; get; }
        /// <summary>
        /// Item that has arrived
        /// </summary>
        [JsonProperty(PropertyName = "item", Order = 1100)]
        public Item Item { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ArrivalEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Item has arrived at location";
        }
    }
}
