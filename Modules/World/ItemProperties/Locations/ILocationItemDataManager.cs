using BeforeOurTime.Models.Messages;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.Terminal.Models;
using BeforeOurTime.Models.Modules.World.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Locations
{
    public interface ILocationItemDataManager : IItemModelManager
    {
        /// <summary>
        /// Create an empty new location and connecting exits from a provided location
        /// </summary>
        /// <param name="currentLocationItemId">Existing location item to link to new location with exits</param>
        /// <returns></returns>
        LocationItem CreateFromHere(Guid currentLocationItemId);
        /// <summary>
        /// Read location summary
        /// </summary>
        /// <param name="message"></param>
        /// <param name="origin">Item that initiated request</param>
        /// <param name="mm">Module manager</param>
        /// <param name="response"></param>
        IResponse HandleReadLocationSummaryRequest(
            IMessage message,
            Item origin,
            IModuleManager mm,
            IResponse response);
        /// <summary>
        /// Create location
        /// </summary>
        /// <param name="message"></param>
        /// <param name="origin">Item that initiated request</param>
        /// <param name="mm">Module manager</param>
        /// <param name="response"></param>
        IResponse HandleCreateLocationQuickRequest(
            IMessage message,
            Item origin,
            IModuleManager mm,
            IResponse response);
    }
}
