using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events.Created;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.CRUD.Items.UpdateItem
{
    public class UpdateItemResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("11899b25-3dae-4159-95ed-e63bf65802ac");
        /// <summary>
        /// Event message for item update
        /// </summary>
        [JsonProperty(PropertyName = "updateItemEvent", Order = 1000)]
        public UpdateItemEvent UpdateItemEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public UpdateItemResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Update item response";
        }
    }
}
