using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.Messages.Emotes.PerformEmote
{
    public class WorldPerformEmoteRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("cc310f88-cc74-4070-b47e-34912d080013");
        /// <summary>
        /// Emote requested to be performed
        /// </summary>
        [JsonProperty(PropertyName = "emoteType", Order = 1000)]
        public WorldEmoteType EmoteType { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public WorldPerformEmoteRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "World Perform Emote Request";
        }
    }
}
