﻿using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.CreateCharacter
{
    /// <summary>
    /// A player has been created
    /// </summary>
    public class AccountCreateCharacterEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("662e5eb5-8f4a-41e3-a148-52eeacc04121");
        /// <summary>
        /// Unique item identifier of player
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonProperty(PropertyName = "itemId", Order = 1000)]
        public Guid ItemId { set; get; }
        /// <summary>
        /// Name of player
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 1100)]
        public string Name { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountCreateCharacterEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Character Has Been Created";
        }
    }
}
