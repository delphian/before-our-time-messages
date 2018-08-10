﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes.Locations
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
        /// Modify the item name before it is returned
        /// </summary>
        /// <param name="name">Previous name of item</param>
        /// <returns></returns>
        public override string GetName(string name)
        {
            return Name;
        }
        /// <summary>
        /// Modify the item description before it is returned
        /// </summary>
        /// <param name="name">Previous description of item</param>
        /// <returns></returns>
        public override string GetDescription(string description)
        {
            return Description;
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
