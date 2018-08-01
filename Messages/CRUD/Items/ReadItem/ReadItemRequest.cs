using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.CRUD.Items.ReadItem
{
    public class ReadItemRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("ad19eb46-0af0-4ad6-866b-feb13b9dc588");
        /// <summary>
        /// Unique item identifier to read
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid ItemId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ReadItemRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Read Item Request";
        }
    }
}
