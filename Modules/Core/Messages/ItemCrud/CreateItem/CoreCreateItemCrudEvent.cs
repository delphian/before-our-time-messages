using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemCrud.CreateItem
{
    /// <summary>
    /// An item has been created with CRUD operations
    /// </summary>
    public class CoreCreateItemCrudEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("8d7b3a16-966e-47f0-8bae-d4f340b3d8a1");
        /// <summary>
        /// Item that has been created
        /// </summary>
        [JsonProperty(PropertyName = "item", Order = 1100)]
        public Item Item { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreCreateItemCrudEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Item has been created via CRUD";
        }
    }
}
