using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events.Created;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.CRUD.Items.ReadItemGraph
{
    public class ReadItemGraphResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("95e73597-640d-420c-9bb8-3b0400dc9ae1");
        /// <summary>
        /// Event message for item graph read
        /// </summary>
        [JsonProperty(PropertyName = "readItemGraphEvent", Order = 1000)]
        public ReadItemGraphEvent ReadItemGraphEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ReadItemGraphResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Read Item Graph Response";
        }
    }
}
