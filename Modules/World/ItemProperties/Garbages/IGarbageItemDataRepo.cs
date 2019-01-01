using BeforeOurTime.Models.Modules.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Garbages
{
    /// <summary>
    /// Central data repository for all garbage item data
    /// </summary>
    public interface IGarbageItemDataRepo : ICrudItemModelRepository<GarbageItemData>
    {
        /// <summary>
        /// Read associated garbage data of item
        /// </summary>
        /// <param name="item">Item that may have associated data</param>
        /// <returns></returns>
        GarbageItemData Read(Item item);
        /// <summary>
        /// Read garbage data for all items ready to be collected
        /// </summary>
        /// <returns></returns>
        List<GarbageItemData> ReadExpired();
    }
}
