using System;
using System.Collections.Generic;
using System.Text;
using BeforeOurTime.Models.Modules.Core.Models.Items;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Exits
{
    public interface IExitItemDataManager : IItemModelManager
    {
        /// <summary>
        /// Read all exits that target the same destination
        /// </summary>
        /// <param name="locationItem"></param>
        /// <returns></returns>
        List<Item> GetLocationExits(Guid destinationId);
    }
}
