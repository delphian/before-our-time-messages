using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.World.ItemProperties.Locations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Locations
{
    /// <summary>
    /// Central data repository for all location items
    /// </summary>
    public interface ILocationItemDataRepo : ICrudItemModelRepository<LocationItemData>
    {
        /// <summary>
        /// Read associated location data of item
        /// </summary>
        /// <param name="item">Item that may have associated data</param>
        /// <returns></returns>
        LocationItemData Read(Item item);
    }
}
