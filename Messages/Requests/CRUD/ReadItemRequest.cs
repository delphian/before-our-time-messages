using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Requests.CRUD
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
