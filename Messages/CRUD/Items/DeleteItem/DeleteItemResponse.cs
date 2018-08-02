using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events.Created;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.CRUD.Items.DeleteItem
{
    public class DeleteItemResponse : Response, IResponse
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
        [JsonProperty(PropertyName = "deleteItemEvent", Order = 1000)]
        public DeleteItemEvent DeleteItemEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public DeleteItemResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Delete item response";
        }
    }
}
