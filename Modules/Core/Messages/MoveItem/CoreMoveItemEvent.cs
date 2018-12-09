using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.MoveItem
{
    /// <summary>
    /// An item has been moved
    /// </summary>
    public class CoreMoveItemEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("d7cde3ab-b09b-47ce-9095-33745da3bc22");
        /// <summary>
        /// Item that has had a change in parents
        /// </summary>
        [JsonProperty(PropertyName = "item", Order = 1000)]
        public Item Item { set; get; }
        /// <summary>
        /// Old parent of item
        /// </summary>
        [JsonProperty(PropertyName = "oldParent", Order = 1100)]
        public Item OldParent { set; get; }
        /// <summary>
        /// New parent of item
        /// </summary>
        [JsonProperty(PropertyName = "newParent", Order = 1200)]
        public Item NewParent { set; get; }
        /// <summary>
        /// Source that initiated the movement
        /// </summary>
        [JsonProperty(PropertyName = "source", Order = 1300)]
        public Item Source { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreMoveItemEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Item Has Been Moved";
        }
    }
}
