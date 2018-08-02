using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.CRUD.Items.DeleteItem
{
    /// <summary>
    /// An item has been deleted with CRUD operations
    /// </summary>
    public class DeleteItemEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("048a5d77-ad53-48e0-92ba-dfb99644c586");
        /// <summary>
        /// Item that has been deleted
        /// </summary>
        [JsonProperty(PropertyName = "item", Order = 1100)]
        public Item Item { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public DeleteItemEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Item has been deleted via CRUD";
        }
    }
}
