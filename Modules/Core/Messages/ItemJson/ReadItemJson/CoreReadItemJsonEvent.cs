using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using BeforeOurTime.Models.Modules.Core.Messages.ItemJson;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemJson.ReadItemJson
{
    /// <summary>
    /// Item JSON has been read
    /// </summary>
    public class CoreReadItemJsonEvent : Event, IEvent
    {
        /// <summary>
        /// Unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("bb79f77d-6ed3-43f9-8f44-36cf8d65393b");
        /// <summary>
        /// Origin of update (who did it)
        /// </summary>
        [JsonProperty(PropertyName = "origin", Order = 1000)]
        public Item Origin { set; get; }
        /// <summary>
        /// List of item JSON that has been read
        /// </summary>
        [JsonProperty(PropertyName = "itemsJson", Order = 1100)]
        public List<CoreItemJson> ItemsJson { set; get; }
        /// <summary>
        /// List of items that have been read through json
        /// </summary>
        [JsonProperty(PropertyName = "items", Order = 1200)]
        public List<Item> Items { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreReadItemJsonEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Item JSON Has Been Read";
        }
    }
}
