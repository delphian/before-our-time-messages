﻿using BeforeOurTime.Models.Modules.Core.Models.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Models.Data
{
    public class AccountData : ItemData, IItemData
    {
        /// <summary>
        /// Login name for account
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { set; get; }
        /// <summary>
        /// Encrypted password
        /// </summary>
        [JsonProperty(PropertyName = "password", Order = 120)]
        public string Password { set; get; }
        /// <summary>
        /// Account was auto generated for guest and still in temporary state
        /// </summary>
        /// <remarks>
        /// Any temporary account is subject to deletion
        /// </remarks>
        [JsonProperty(PropertyName = "temporary", Order = 130)]
        public bool Temporary { set; get; }
        /// <summary>
        /// Administrative account
        /// </summary>
        [JsonProperty(PropertyName = "admin", Order = 140)]
        public bool Admin { set; get; }
        /// <summary>
        /// Characters attached to account
        /// </summary>
        [JsonProperty(PropertyName = "characters", Order = 200)]
        public List<AccountCharacterData> Characters { set; get; } = new List<AccountCharacterData>();
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountData()
        {
            DataType = this.GetType().ToString();
        }
    }
}
