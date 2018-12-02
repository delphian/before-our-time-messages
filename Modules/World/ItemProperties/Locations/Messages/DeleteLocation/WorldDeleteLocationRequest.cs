using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Locations.Messages.DeleteLocation
{
    public class WorldDeleteLocationRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("45eb269d-e061-4ebc-b3d6-1d410d6d8a8c");
        /// <summary>
        /// Location to delete
        /// </summary>
        [JsonProperty(PropertyName = "locationItemId", Order = 1000)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid LocationItemId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public WorldDeleteLocationRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "World Delete Location Request";
        }
    }
}
