using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Events.Emotes
{
    /// <summary>
    /// An item has emoted
    /// </summary>
    public class EmoteEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("6cedfd1c-89ec-4389-998b-1e076c9d7b48");
        /// <summary>
        /// Name of item that has emoted
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 1000)]
        public string Name { set; get; }
        /// <summary>
        /// Type of emote
        /// </summary>
        [JsonProperty(PropertyName = "type", Order = 1100)]
        public EmoteType Type { set; get; }
        /// <summary>
        /// Item object
        /// </summary>
        [JsonProperty(PropertyName = "item", Order = 1200)]
        public Item Item { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public EmoteEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Item has emoted";
        }
    }
}
