using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemJson.ReadItemJson
{
    public class CoreReadItemJsonRequest : Request, IRequest
    {
        /// <summary>
        /// Unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("c34e774d-2a90-4225-9eb1-6d972ca69427");
        /// <summary>
        /// List of unique item identifiers to read
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonProperty(PropertyName = "itemIds", Order = 100)]
        public List<Guid> ItemIds { set; get; }
        /// <summary>
        /// Recursively include all children
        /// </summary>
        [JsonProperty(PropertyName = "include_children", Order = 200)]
        public bool IncludeChildren { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreReadItemJsonRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Read Item Json Request";
        }
    }
}
