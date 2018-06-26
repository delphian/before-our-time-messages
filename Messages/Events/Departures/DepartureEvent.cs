using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Events.Departures
{
    /// <summary>
    /// An item has departed location
    /// </summary>
    public class DepartureEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("1e889a17-2171-488d-b3c9-9920ef664fca");
        /// <summary>
        /// Name of item
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 1000)]
        public string Name { set; get; }
        /// <summary>
        /// Item object
        /// </summary>
        [JsonProperty(PropertyName = "item", Order = 1100)]
        public Item Item { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public DepartureEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Item has departed from location";
        }
    }
}
