using BeforeOurTime.Models.Modules.Core.ItemProperties.Visibles;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Locations
{
    /// <summary>
    /// A physical, common area of influence
    /// </summary>
    public class LocationItemData : ItemData, IItemData
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LocationItemData()
        {
            DataType = this.GetType().ToString();
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
            return (T)previousValue;
        }
    }
}
