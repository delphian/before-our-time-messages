using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using BeforeOurTime.Models.Modules.Core.Messages.ItemJson;
using BeforeOurTime.Models.Modules.Core.Models.Items;
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
        /// Origin of update (who did it)
        /// </summary>
        [JsonProperty(PropertyName = "origin", Order = 1000)]
        public Item Origin { set; get; }
        /// <summary>
        /// List of item JSONs that have been updated
        /// </summary>
        [JsonProperty(PropertyName = "itemsJson", Order = 1100)]
        public List<CoreItemJson> ItemsJson { set; get; }
        /// <summary>
        /// List of items that have been updated through json
        /// </summary>
        [JsonProperty(PropertyName = "items", Order = 1200)]
        public List<Item> Items { set; get; }
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
