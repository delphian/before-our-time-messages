using BeforeOurTime.Models.Modules.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Generators
{
    /// <summary>
    /// Central data repository for all generator item data
    /// </summary>
    public interface IGeneratorItemDataRepo : ICrudItemModelRepository<GeneratorItemData>
    {
        /// <summary>
        /// Read associated generator data of item
        /// </summary>
        /// <param name="item">Item that may have associated data</param>
        /// <returns></returns>
        GeneratorItemData Read(Item item);
    }
}
