using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemGraph
{
    public class CoreReadItemGraphResponse : Response, IResponse
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
        [JsonProperty(PropertyName = "coreReadItemGraphEvent", Order = 1000)]
        public CoreReadItemGraphEvent CoreReadItemGraphEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreReadItemGraphResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Read Item Graph Response";
        }
    }
}
