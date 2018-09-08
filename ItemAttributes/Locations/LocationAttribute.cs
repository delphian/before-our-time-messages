using BeforeOurTime.Models.ItemProperties.Visible;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemAttributes.Locations
{
    /// <summary>
    /// A physical, common area of influence
    /// </summary>
    public class LocationAttribute : ItemAttribute, IItemAttribute
    {
        /// <summary>
        /// Short description of location
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 30)]
        public string Name { set; get; }
        /// <summary>
        /// Long description of location
        /// </summary>
        [JsonProperty(PropertyName = "description", Order = 40)]
        public string Description { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public LocationAttribute()
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
            return previousValue;
        }
        /// <summary>
        /// Copy all source properties into our properties
        /// </summary>
        /// <param name="source"></param>
        public override void Copy(object source)
        {
            var locationAttribute = (LocationAttribute)source;
            Name = locationAttribute.Name;
            Description = locationAttribute.Description;
        }
    }
}
