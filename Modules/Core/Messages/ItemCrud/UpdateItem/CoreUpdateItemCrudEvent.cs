﻿using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemCrud.UpdateItem
{
    /// <summary>
    /// An item has been updated via CRUD operations
    /// </summary>
    public class CoreUpdateItemCrudEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("44553e6b-b6ac-4bd8-9c5e-12311acfd5b9");
        /// <summary>
        /// Item that has been updated
        /// </summary>
        [JsonProperty(PropertyName = "items", Order = 1100)]
        public List<Item> Items { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreUpdateItemCrudEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Item Has Been Updated via CRUD";
        }
    }
}
