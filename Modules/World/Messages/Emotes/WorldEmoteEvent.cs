using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.Messages.Emotes
{
    /// <summary>
    /// An item has emoted
    /// </summary>
    public class WorldEmoteEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("6cedfd1c-89ec-4389-998b-1e076c9d7b48");
        /// <summary>
        /// Source of the emote
        /// </summary>
        [JsonProperty(PropertyName = "origin", Order = 1200)]
        public Item Origin { set; get; }
        /// <summary>
        /// Type of emote
        /// </summary>
        [JsonProperty(PropertyName = "emoteType", Order = 1100)]
        public WorldEmoteType EmoteType { set; get; }
        /// <summary>
        /// Optional parameter for emote type
        /// </summary>
        [JsonProperty(PropertyName = "parameter", Order = 1150)]
        public string Parameter { set; get; }
        /// <summary>
        /// Item that emote is directed toward (if any)
        /// </summary>
        [JsonProperty(PropertyName = "destination", Order = 1200)]
        public Item Destination { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public WorldEmoteEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Item has emoted";
        }
    }
}
