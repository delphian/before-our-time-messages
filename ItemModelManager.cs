using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeforeOurTime.Models.Modules.Core.Models.Items;

namespace BeforeOurTime.Models
{
    /// <summary>
    /// Manage details of an item's extended attributes
    /// </summary>
    public abstract class ItemModelManager<T> : ModelManager<T> where T : Item
    {
        /// <summary>
        /// Determine if an item is managed
        /// </summary>
        /// <param name="item">Item that may have managable data</param>
        public bool IsManaging(Item item)
        {
            return item is T;
        }
        /// <summary>
        /// Determine if an item property type is managable
        /// </summary>
        /// <param name="propertyType">Property type that might be managable</param>
        public bool IsManagingProperty(Type propertyType)
        {
            var managing = false;
            typeof(T).GetProperties().ToList().ForEach(property =>
            {
                if (propertyType == property.PropertyType)
                {
                    managing = true;
                }
            });
            return managing;
        }
    }
}
