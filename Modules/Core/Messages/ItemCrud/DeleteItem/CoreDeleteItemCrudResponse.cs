using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events.Created;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemCrud.DeleteItem
{
    public class CoreDeleteItemCrudResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("c60abd98-bc9a-4137-854e-95455ba5af34");
        /// <summary>
        /// Event message for item creation
        /// </summary>
        [JsonProperty(PropertyName = "coreDeleteItemCrudEvent", Order = 1000)]
        public CoreDeleteItemCrudEvent CoreDeleteItemCrudEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreDeleteItemCrudResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Delete Item Crud Response";
        }
    }
}
