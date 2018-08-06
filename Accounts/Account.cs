using BeforeOurTime.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeforeOurTime.Models.Accounts
{
    /// <summary>
    /// An account keeps track of a user's access to the system
    /// </summary>
    public class Account : Model
    {
        /// <summary>
        /// Human friendly identifier for account
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 100)]
        public string Name { set; get; }
        /// <summary>
        /// Characters attached to account
        /// </summary>
        [JsonProperty(PropertyName = "characters", Order = 200)]
        public List<Item> Characters { set; get; } = new List<Item>();
    }
}
