using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Requests.CRUD
{
    public class UpdateItemRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("26127ca1-5604-40a0-b93e-4b424aa6ca63");
        /// <summary>
        /// Item to update
        /// </summary>
        public Item Item { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public UpdateItemRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Update Item Request";
        }
    }
}
