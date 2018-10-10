using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.UseItem
{
    /// <summary>
    /// An item graph has been read
    /// </summary>
    public class CoreUseItemEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("28907aa4-3305-4ddd-accf-720068b1e48c");
        /// <summary>
        /// Item that initiated use
        /// </summary>
        [JsonProperty(PropertyName = "using", Order = 1000)]
        public Item Using { set; get; }
        /// <summary>
        /// Item that is being used
        /// </summary>
        [JsonProperty(PropertyName = "used", Order = 1100)]
        public Item Used { set; get; }
        /// <summary>
        /// How item is to be used
        /// </summary>
        [JsonProperty(PropertyName = "use", Order = 1200)]
        public Use Use { set; get; }
        /// <summary>
        /// Item use attempt was a success or failure
        /// </summary>
        [JsonProperty(PropertyName = "success", Order = 1300)]
        public bool Success { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreUseItemEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Item Has Been Used";
        }
    }
}
