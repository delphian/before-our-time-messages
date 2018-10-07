using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemJson.UpdateItemJson
{
    public class CoreUpdateItemJsonResponse : Response, IResponse
    {
        /// <summary>
        /// Unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("7c9adca1-6f23-4eae-9ef3-a53fff3d058d");
        /// <summary>
        /// Event message for item read
        /// </summary>
        [JsonProperty(PropertyName = "coreUpdateItemJsonEvent", Order = 1000)]
        public CoreUpdateItemJsonEvent CoreUpdateItemJsonEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreUpdateItemJsonResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Update Item JSON Response";
        }
    }
}
