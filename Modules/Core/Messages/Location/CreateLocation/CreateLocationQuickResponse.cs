using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.Location.CreateLocation
{
    public class CreateLocationQuickResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("19b55a12-7688-4915-a3de-fab4a4481a9f");
        /// <summary>
        /// Event message for item creation
        /// </summary>
        [JsonProperty(PropertyName = "createLocationEvent", Order = 1000)]
        public CreateLocationEvent CreateLocationEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CreateLocationQuickResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Create Location Quick Response";
        }
    }
}
