using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Dbs
{
    /// <summary>
    /// Central data repository for all location items
    /// </summary>
    public interface ILocationDataRepo : ICrudItemModelRepository<LocationData>
    {
        /// <summary>
        /// Read associated location data of item
        /// </summary>
        /// <param name="item">Item that may have associated data</param>
        /// <param name="options">Options to customize how data is transacted from datastore</param>
        /// <returns></returns>
        LocationData Read(Item item, TransactionOptions options = null);
    }
}
