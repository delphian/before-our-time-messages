using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.CRUD.Items.DeleteItem;
using BeforeOurTime.Models.Messages.Events.Created;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Locations.DeleteLocation
{
    public class DeleteLocationResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("d4e942f5-e347-41fb-9a93-6d780c5ed3f2");
        /// <summary>
        /// Event message for item creation
        /// </summary>
        [JsonProperty(PropertyName = "deleteItemEvents", Order = 1000)]
        public List<DeleteItemEvent> DeleteItemEvents { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public DeleteLocationResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Delete Location Response";
        }
    }
}
