using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events.Created;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.CRUD.Items.ReadItem
{
    public class ReadItemResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("14639565-6fc9-4147-91f2-bfceb36215f6");
        /// <summary>
        /// Event message for item read
        /// </summary>
        [JsonProperty(PropertyName = "readItemEvent", Order = 1000)]
        public ReadItemEvent ReadItemEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ReadItemResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Read item response";
        }
    }
}
