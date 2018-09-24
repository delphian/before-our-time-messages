using BeforeOurTime.Models.Modules.Core.Models.Properties;
using BeforeOurTime.Models.Primitives.Images;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemAttributes.Visibles
{
    /// <summary>
    /// Any item that can be observed
    /// </summary>
    public class VisibleAttribute : ItemAttribute, IItemAttribute
    {
        /// <summary>
        /// One, two, or three word short description of item
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 30)]
        public string Name { set; get; }
        /// <summary>
        /// A long description of the item. Include many sensory experiences
        /// </summary>
        [JsonProperty(PropertyName = "description", Order = 30)]
        public string Description { set; get; }
        /// <summary>
        /// Item image suitable for display as an icon
        /// </summary>
        [JsonProperty(PropertyName = "icon", Order = 30)]
        public Image Icon { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public VisibleAttribute()
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
        public override T GetProperty<T>(string propertyName, object previousValue)
        {
            if (typeof(T) == typeof(VisibleProperty))
            {
                previousValue = previousValue ?? new VisibleProperty();
                ((VisibleProperty)previousValue).Name = Name;
                ((VisibleProperty)previousValue).Description = Description;
                ((VisibleProperty)previousValue).Icon = Icon;
            }
            return (T)previousValue;
        }
    }
}
