using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.CRUD.Items.DeleteItem
{
    public class DeleteItemRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("0bebb17e-1742-4fe4-a3b9-61ec8c6c6771");
        /// <summary>
        /// Unique item identifier of item to delete
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid ItemId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public DeleteItemRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Delete Item Request";
        }
    }
}
