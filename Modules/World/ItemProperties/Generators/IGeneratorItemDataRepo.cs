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
        /// <summary>
        /// Read generator data for all generators ready to run
        /// </summary>
        /// <param name="futureTime">Optional future time. Defaults to now</param>
        /// <returns></returns>
        List<GeneratorItemData> ReadReadyToRun(DateTime? futureTime = null);
    }
}
