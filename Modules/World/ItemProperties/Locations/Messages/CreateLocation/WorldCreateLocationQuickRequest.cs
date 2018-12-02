using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Locations.Messages.CreateLocation
{
    public class WorldCreateLocationQuickRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("100a31d2-24b8-4bf0-80e6-94ba88f0f5b9");
        /// <summary>
        /// Location from which to create an exit to the new location
        /// </summary>
        [JsonProperty(PropertyName = "fromLocationItemId", Order = 1000)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid? FromLocationItemId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public WorldCreateLocationQuickRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Create Location Quick Request";
        }
    }
}
