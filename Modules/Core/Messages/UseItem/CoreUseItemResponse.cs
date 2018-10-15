using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.UseItem
{
    public class CoreUseItemResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("68dd785e-908e-4057-b841-45430bb32cb2");
        /// <summary>
        /// Event message for item graph read
        /// </summary>
        [JsonProperty(PropertyName = "coreUseItemEvent", Order = 1000)]
        public CoreUseItemEvent CoreUseItemEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreUseItemResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Use Item Response";
        }
    }
}
