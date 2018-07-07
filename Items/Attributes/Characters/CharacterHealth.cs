using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes.Characters
{
    /// <summary>
    /// Health and health related properties
    /// </summary>
    public class CharacterHealth : Model
    {
        /// <summary>
        /// Maximum normal health
        /// </summary>
        [JsonProperty(PropertyName = "max", Order = 1000)]
        public int Max { set; get; }
        /// <summary>
        /// Current health value
        /// </summary>
        [JsonProperty(PropertyName = "value", Order = 1100)]
        public int Value { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CharacterHealth()
        {
        }
    }
}
