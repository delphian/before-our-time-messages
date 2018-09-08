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
        public override T GetProperty<T>(string propertyName, T previousValue)
        {
            previousValue = previousValue ?? new T();
            if (typeof(T) == typeof(CharacterProperty))
            {
                var value = (CharacterProperty)Convert.ChangeType(previousValue, typeof(CharacterProperty));
                value.Health = new CharacterHealthProperty() {
                    Max = Health?.Max ?? 0,
                    Value = Health?.Value ?? 0
                };
                previousValue = (T)Convert.ChangeType(value, typeof(T));
            }
            return previousValue;
        }
    }
}
