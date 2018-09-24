using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using BeforeOurTime.Models.Modules.Core.Messages.ItemJson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemJson.CreateItemJson
{
    /// <summary>
    /// Item JSON has been read
    /// </summary>
    public class CoreCreateItemJsonEvent : Event, IEvent
    {
        /// <summary>
        /// Unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("e38908e4-f6f3-4982-98fc-14a1cdf8846d");
        /// <summary>
        /// List of item JSON that has been read
        /// </summary>
        [JsonProperty(PropertyName = "itemsJson", Order = 1100)]
        public List<CoreItemJson> ItemsJson { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreCreateItemJsonEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Item Has Been Created via JSON";
        }
    }
}
