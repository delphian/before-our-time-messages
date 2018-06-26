using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes
{
    /// <summary>
    /// A physical, common area of influence
    /// </summary>
    public class AttributeLocation : ItemAttribute, IItemAttribute
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
        public AttributeLocation()
        {
            AttributeType = this.GetType().ToString();
        }
    }
}
