using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemJson.UpdateItemJson
{
    public class CoreUpdateItemJsonRequest : Request, IRequest
    {
        /// <summary>
        /// Unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("1bc615f2-a6ff-44ed-b278-428ff73af9b4");
        /// <summary>
        /// List of unique item identifiers to read
        /// </summary>
        [JsonProperty(PropertyName = "itemsJson", Order = 100)]
        public List<CoreItemJson> ItemsJson { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreUpdateItemJsonRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Update Item Json Request";
        }
    }
}
