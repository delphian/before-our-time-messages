using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.Messages.Location.ReadLocationSummary
{
    public class WorldReadLocationSummaryRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("a50d4898-22f6-46c3-b23b-69b866593b13");
        /// <summary>
        /// Constructor
        /// </summary>
        public WorldReadLocationSummaryRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Read Location Summary Request";
        }
    }
}
