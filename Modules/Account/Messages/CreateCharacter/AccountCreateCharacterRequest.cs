﻿using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.CreateCharacter
{
    public class AccountCreateCharacterRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("233f84d1-8734-4429-a155-27bdd473ab66");
        /// <summary>
        /// Name of player
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 1000)]
        public string Name { set; get; }
        /// <summary>
        /// Character is temporary
        /// </summary>
        [JsonProperty(PropertyName = "temporary", Order = 1100)]
        public bool Temporary { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountCreateCharacterRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Create Character Request";
        }
    }
}
