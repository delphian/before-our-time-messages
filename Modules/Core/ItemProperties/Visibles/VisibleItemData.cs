﻿using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.ItemProperties.Visibles
{
    /// <summary>
    /// An item perceived through the senses, tangible and concrete
    /// </summary>
    public class VisibleItemData : ItemData, IItemData
    {
        /// <summary>
        /// Short description of item
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 30)]
        public string Name { set; get; }
        /// <summary>
        /// Long description of item
        /// </summary>
        [JsonProperty(PropertyName = "description", Order = 40)]
        public string Description { set; get; }
        /// <summary>
        /// Small image representation of item suitable as an icon
        /// </summary>
        [JsonProperty(PropertyName = "icon", Order = 50)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid? Icon { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public VisibleItemData()
        {
            DataType = this.GetType().ToString();
        }
    }
}
