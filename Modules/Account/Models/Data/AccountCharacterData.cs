using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Models.Data
{
    public class AccountCharacterData : Model
    {
        /// <summary>
        /// Unique account identifier
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public Guid AccountId { set; get; }
        /// <summary>
        /// Unique character item identifier
        /// </summary>
        [JsonProperty(PropertyName = "characterItemId", Order = 200)]
        public Guid CharacterItemId { set; get; }
    }
}
