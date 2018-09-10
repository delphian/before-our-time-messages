using BeforeOurTime.Models.ItemAttributes;
using BeforeOurTime.Models.ItemAttributes.Characters;
using BeforeOurTime.Models.ItemProperties.Character;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemAttributes.Characters
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
            var fullClassPath = this.GetType().ToString();
            AttributeType = fullClassPath;
        }
        /// <summary>
        /// Populate an item property value
        /// </summary>
        /// <typeparam name="T">Type of property to populate with value</typeparam>
        /// <param name="propertyName">Name of item property to populate with value</param>
        /// <param name="previousValue">Value assigned to property by previous attribute</param>
        /// <returns></returns>
        public override T GetProperty<T>(string propertyName, object previousValue)
        {
            if (typeof(T) == typeof(CharacterProperty))
            {
                previousValue = previousValue ?? new CharacterProperty();
                ((CharacterProperty)previousValue).Health = ((CharacterProperty)previousValue).Health ?? new CharacterHealthProperty();
                ((CharacterProperty)previousValue).Health.Max = Health?.Max ?? 0;
                ((CharacterProperty)previousValue).Health.Value = Health?.Value ?? 0;
            }
            return (T)previousValue;
        }
    }
}
