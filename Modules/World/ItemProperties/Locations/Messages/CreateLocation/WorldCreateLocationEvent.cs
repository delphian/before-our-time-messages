﻿using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Locations.Messages.CreateLocation
{
    /// <summary>
    /// An location item has been created
    /// </summary>
    public class WorldCreateLocationEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("f273ddbc-c605-4d1b-b11b-31aae05c2fe0");
        /// <summary>
        /// Item that has been created
        /// </summary>
        [JsonProperty(PropertyName = "item", Order = 1100)]
        public Item Item { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public WorldCreateLocationEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Location Item Has Been Created";
        }
    }
}
