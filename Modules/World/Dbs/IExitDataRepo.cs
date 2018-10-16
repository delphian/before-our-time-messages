using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.World.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.Dbs
{
    /// <summary>
    /// Central data repository for all exit items
    /// </summary>
    public interface IExitDataRepo : ICrudItemModelRepository<ExitData>
    {
        /// <summary>
        /// Read all exit data that target the same destination
        /// </summary>
        /// <param name="desitnationId">Location that is the destination</param>
        /// <param name="options">Options to customize how data is transacted from datastore</param>
        /// <returns></returns>
        List<ExitData> ReadDestinationId(
            Guid destinationId,
            TransactionOptions options = null);
        /// <summary>
        /// Read associated location data of item
        /// </summary>
        /// <param name="item">Item that may have associated data</param>
        /// <param name="options">Options to customize how data is transacted from datastore</param>
        /// <returns></returns>
        ExitData Read(Item item, TransactionOptions options = null);
    }
}
