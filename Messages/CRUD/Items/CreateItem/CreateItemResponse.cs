using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events.Created;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.CRUD.Items.CreateItem
{
    public class CreateItemResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("b5a57574-ad8a-46cd-a58c-c67f0ae3aea2");
        /// <summary>
        /// Event message for item creation
        /// </summary>
        [JsonProperty(PropertyName = "createItemEvent", Order = 1000)]
        public CreateItemEvent CreateItemEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="requestInstanceId">Message request instance identifier</param>
        public CreateItemResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Create item response";
        }
    }
}
