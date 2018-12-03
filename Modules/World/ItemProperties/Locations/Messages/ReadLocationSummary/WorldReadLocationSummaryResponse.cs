using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Messages.Responses.List;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using BeforeOurTime.Models.Modules.World.ItemProperties.Characters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Locations.Messages.ReadLocationSummary
{
    /// <summary>
    /// Describe a location and enumerate essential properties
    /// </summary>
    public class WorldReadLocationSummaryResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("e8de221a-381a-45f3-898f-ca12e1badad1");
        /// <summary>
        /// Unique location item identifier
        /// </summary>
        [JsonProperty(PropertyName = "item", Order = 1000)]
        public LocationItem Item { set; get; }
        /// <summary>
        /// Background image for location
        /// </summary>
        [JsonProperty(PropertyName = "image", Order = 1300)]
        public string Image { set; get; }
        /// <summary>
        /// Potential exits from the location
        /// </summary>
        [JsonProperty(PropertyName = "exits", Order = 1400)]
        public List<ListExitResponse> Exits = new List<ListExitResponse>();
        /// <summary>
        /// Character items at the location
        /// </summary>
        [JsonProperty(PropertyName = "characters", Order = 1480)]
        public List<CharacterItem> Characters { set; get; } = new List<CharacterItem>();
        /// <summary>
        /// All items present at location
        /// </summary>
        [JsonProperty(PropertyName = "items", Order = 1490)]
        public List<Item> Items { set; get; } = new List<Item>();
        /// <summary>
        /// Commands that items will respond to
        /// </summary>
        [JsonProperty(PropertyName = "commands", Order = 1495)]
        public List<ItemCommand> Commands { set; get; } = new List<ItemCommand>();
        /// <summary>
        /// Additional descrete textual adendums to the description
        /// </summary>
        [JsonProperty(PropertyName = "adendums", Order = 1500)]
        public List<string> Adendums = new List<string>();
        /// <summary>
        /// Constructor
        /// </summary>
        public WorldReadLocationSummaryResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "World Read Location Summary Response";
        }
    }
}
