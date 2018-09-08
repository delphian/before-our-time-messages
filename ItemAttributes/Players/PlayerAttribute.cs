using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemAttributes.Players
{
    /// <summary>
    /// Item is being played by an account
    /// </summary>
    public class PlayerAttribute : ItemAttribute, IItemAttribute
    {
        /// <summary>
        /// Account of player
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid AccountId { set; get; }
        /// <summary>
        /// Public name of player
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public PlayerAttribute()
        {
            AttributeType = this.GetType().ToString();
        }
    }
}
