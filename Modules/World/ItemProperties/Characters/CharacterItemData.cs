using BeforeOurTime.Models.Modules.Core.ItemProperties.Visibles;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Modules.World.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Characters
{
    /// <summary>
    /// Item with an animating force
    /// </summary>
    public class CharacterItemData : ItemData, IItemData
    {
        /// <summary>
        /// Character was auto generated for guest and still in temporary state
        /// </summary>
        /// <remarks>
        /// Any temporary character is subject to deletion
        /// </remarks>
        [JsonProperty(PropertyName = "temporary", Order = 20)]
        public bool Temporary { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CharacterItemData()
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
