using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes
{
    /// <summary>
    /// User played character
    /// </summary>
    public class AttributePlayer : ItemAttribute, IItemAttribute
    {
        /// <summary>
        /// Account to which this player belongs
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid AccountId { set; get; }
        /// <summary>
        /// Public name of the player
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AttributePlayer()
        {
            AttributeType = this.GetType().ToString();
        }
    }
}
