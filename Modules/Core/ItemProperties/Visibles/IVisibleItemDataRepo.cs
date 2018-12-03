using BeforeOurTime.Models.Modules.Core.ItemProperties.Visibles;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Visibles
{
    /// <summary>
    /// Central data repository for all exit items
    /// </summary>
    public interface IVisibleItemDataRepo : ICrudItemModelRepository<VisibleItemData>
    {
        /// <summary>
        /// Read associated location data of item
        /// </summary>
        /// <param name="item">Item that may have associated data</param>
        /// <returns></returns>
        VisibleItemData Read(Item item);
    }
}
