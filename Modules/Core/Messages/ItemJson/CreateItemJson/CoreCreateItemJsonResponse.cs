using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events.Created;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemJson.CreateItemJson
{
    public class CoreCreateItemJsonResponse : Response, IResponse
    {
        /// <summary>
        /// Unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("da12307d-9e76-4baa-a55b-fad2a991318c");
        /// <summary>
        /// Event message for item read
        /// </summary>
        [JsonProperty(PropertyName = "coreCreateItemJsonEvent", Order = 1000)]
        public CoreCreateItemJsonEvent CoreCreateItemJsonEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreCreateItemJsonResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Create Item JSON Response";
        }
    }
}
