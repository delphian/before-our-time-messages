using BeforeOurTime.Models.ItemProperties.Game;
using BeforeOurTime.Models.ItemProperties.Visible;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemAttributes.Games
{
    /// <summary>
    /// A game environmnent containing users, locations, items, and unique rules
    /// </summary>
    public class GameAttribute : ItemAttribute, IItemAttribute
    {
        /// <summary>
        /// Name of the game
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { set; get; }
        /// <summary>
        /// Default location of a new item when parent is not specified
        /// </summary>
        [JsonProperty(PropertyName = "defaultLocationId")]
        public Guid? DefaultLocationId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public GameAttribute()
        {
            AttributeType = this.GetType().ToString();
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
            if (typeof(T) == typeof(VisibleProperty))
            {
                var value = (VisibleProperty)Convert.ChangeType(previousValue, typeof(VisibleProperty));
                value.Name = Name;
                value.Description = null;
                previousValue = (T)Convert.ChangeType(value, typeof(T));
            }
            if (typeof(T) == typeof(GameProperty))
            {
                var value = (GameProperty)Convert.ChangeType(previousValue, typeof(GameProperty));
                value.DefaultLocationId = DefaultLocationId.ToString();
                previousValue = (T)Convert.ChangeType(value, typeof(T));
            }
            return previousValue;
        }
    }
}
