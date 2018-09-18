using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using BeforeOurTime.Models.Modules.Core.Messages.ItemJson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemJson.UpdateItemJson
{
    /// <summary>
    /// Item JSON has been read
    /// </summary>
    public class CoreUpdateItemJsonEvent : Event, IEvent
    {
        /// <summary>
        /// Unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("ca5f00ad-e092-4313-ac4a-1073c446caab");
        /// <summary>
        /// List of item JSON that has been read
        /// </summary>
        [JsonProperty(PropertyName = "itemsJson", Order = 1100)]
        public List<CoreItemJson> ItemsJson { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreUpdateItemJsonEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Item JSON Has Been Updated";
        }
    }
}
