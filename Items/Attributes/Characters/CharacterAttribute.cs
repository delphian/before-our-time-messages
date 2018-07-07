using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes.Characters
{
    /// <summary>
    /// Attributes common to a player, or non player, character
    /// </summary>
    public class CharacterAttribute : ItemAttribute, IItemAttribute
    {
        /// <summary>
        /// Health and health related properties
        /// </summary>
        [JsonProperty(PropertyName = "health")]
        public CharacterHealth Health { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CharacterAttribute()
        {
            AttributeType = this.GetType().ToString();
        }
    }
}
