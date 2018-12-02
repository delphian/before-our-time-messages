using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.World.ItemProperties.Exits;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Exits
{
    /// <summary>
    /// Central data repository for all exit items
    /// </summary>
    public interface IExitItemDataRepo : ICrudItemModelRepository<ExitItemData>
    {
        /// <summary>
        /// Read associated location data of item
        /// </summary>
        /// <param name="item">Item that may have associated data</param>
        /// <returns></returns>
        ExitItemData Read(Item item);
        /// <summary>
        /// Read all exit data that target the same destination
        /// </summary>
        /// <param name="desitnationId">Location that is the destination</param>
        /// <returns></returns>
        List<ExitItemData> ReadDestinationId(Guid destinationId);
    }
}
