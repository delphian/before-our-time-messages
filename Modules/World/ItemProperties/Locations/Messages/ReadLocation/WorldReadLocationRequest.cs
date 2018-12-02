using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Locations.Messages.ReadLocation
{
    public class WorldReadLocationRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("272baa24-6725-4e97-9af7-3bc816209e5d");
        /// <summary>
        /// List of location items to read
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonProperty(PropertyName = "itemIds", Order = 1000)]
        public List<Guid> ItemIds { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public WorldReadLocationRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "World Read Location Request";
        }
    }
}
