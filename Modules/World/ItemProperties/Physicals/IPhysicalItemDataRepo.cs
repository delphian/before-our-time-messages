using BeforeOurTime.Models.Modules.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Physicals
{
    /// <summary>
    /// Central data repository for all exit items
    /// </summary>
    public interface IPhysicalItemDataRepo : ICrudItemModelRepository<PhysicalItemData>
    {
        /// <summary>
        /// Read associated location data of item
        /// </summary>
        /// <param name="item">Item that may have associated data</param>
        /// <returns></returns>
        PhysicalItemData Read(Item item);
    }
}
