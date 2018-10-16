using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.UseItem
{
    public class CoreUseItemRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("a169af8f-cbc7-4d69-9fdb-ad11adf83ab4");
        /// <summary>
        /// Unique item identifier to use
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonProperty(PropertyName = "itemId", Order = 100)]
        public Guid? ItemId { set; get; }
        /// <summary>
        /// How item is to be used
        /// </summary>
        [JsonProperty(PropertyName = "use", Order = 110)]
        public Use Use { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreUseItemRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Use Item Request";
        }
    }
}
