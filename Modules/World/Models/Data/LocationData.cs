﻿using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.Models.Data
{
    /// <summary>
    /// A physical, common area of influence
    /// </summary>
    public class LocationData : ItemData, IItemData
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
        public LocationData()
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
            if (typeof(T) == typeof(VisibleProperty))
            {
                previousValue = previousValue ?? new VisibleProperty();
                ((VisibleProperty)previousValue).Name = Name;
                ((VisibleProperty)previousValue).Description = Description;
            }
            return (T)previousValue;
        }
    }
}