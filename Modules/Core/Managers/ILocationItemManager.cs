using BeforeOurTime.Models;
using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Managers;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Managers
{
    public interface ILocationItemManager : IDataManager, IDataManager<LocationData>
    {
        /// <summary>
        /// Read item's detailed location
        /// </summary>
        /// <remarks>
        /// If item itself has no location detail then item's parents will be 
        /// traversed until one is found
        /// </remarks>
        /// <param name="item">Item that has attached detail location data</param>
        /// <param name="options">Options to customize how data is transacted from datastore</param>
        /// <returns>The Item's detailed location data. Null if none found</returns>
        new LocationData Read(Item item, TransactionOptions options = null);
        /// <summary>
        /// Create an empty new location and connecting exits from a provided location
        /// </summary>
        /// <param name="currentLocationItemId">Existing location item to link to new location with exits</param>
        /// <returns></returns>
        LocationItem CreateFromHere(Guid currentLocationItemId);
    }
}
