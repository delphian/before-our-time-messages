using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemCrud.CreateItem
{
    public class CoreCreateItemCrudResponse : Response, IResponse
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
        [JsonProperty(PropertyName = "coreCreateItemCrudEvent", Order = 1000)]
        public CoreCreateItemCrudEvent CoreCreateItemCrudEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="requestInstanceId">Message request instance identifier</param>
        public CoreCreateItemCrudResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Create Item Crud Response";
        }
    }
}
