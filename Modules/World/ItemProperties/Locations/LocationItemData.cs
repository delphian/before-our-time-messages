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
    }
}
