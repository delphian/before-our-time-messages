using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemJson.CreateItemJson
{
    public class CoreCreateItemJsonRequest : Request, IRequest
    {
        /// <summary>
        /// Unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("e5956fc6-c653-4cb9-a803-c74ed37c833a");
        /// <summary>
        /// List of unique item identifiers to read
        /// </summary>
        [JsonProperty(PropertyName = "itemsJson", Order = 100)]
        public List<CoreItemJson> ItemsJson { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreCreateItemJsonRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Create Item Json Request";
        }
    }
}
