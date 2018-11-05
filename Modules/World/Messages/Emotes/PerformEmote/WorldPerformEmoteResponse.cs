using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.Messages.Emotes.PerformEmote
{
    public class WorldPerformEmoteResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("d9e8eed7-e525-4b40-b78a-0cfb42a37dbd");
        /// <summary>
        /// Event message for performed emote
        /// </summary>
        [JsonProperty(PropertyName = "emoteEvent", Order = 1000)]
        public WorldEmoteEvent EmoteEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public WorldPerformEmoteResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "World Perform Emote Response";
        }
    }
}
