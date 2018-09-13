using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.ItemProperties;
using BeforeOurTime.Models.Primitives.Images;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Business.Models
{
    /// <summary>
    /// Additional information wrapping, but based on an item's type
    /// </summary>
    public interface IData
    {
        /// <summary>
        /// Populate an item property value
        /// </summary>
        /// <typeparam name="T">Type of property to populate with value</typeparam>
        /// <param name="propertyName">Name of item property to populate with value</param>
        /// <param name="previousValue">Value assigned to property by previous attribute</param>
        /// <returns></returns>
        T GetProperty<T>(string propertyName, object previousValue) where T : ItemProperty, new();
        /// <summary>
        /// Get priority order of attribute in comparison to other attributes
        /// </summary>
        /// <remarks>
        /// Defaults to 1000. Higher number has higher priority and will be executed _last_
        /// </remarks>
        /// <returns></returns>
        int GetOrder();
    }
}
