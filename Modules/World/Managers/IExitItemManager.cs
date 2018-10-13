using System;
using System.Collections.Generic;
using System.Text;
using BeforeOurTime.Models.Items;

namespace BeforeOurTime.Models.Modules.World.Managers
{
    public interface IExitItemManager : IItemModelManager
    {
        /// <summary>
        /// Read all exits that target the same destination
        /// </summary>
        /// <param name="locationItem"></param>
        /// <returns></returns>
        List<Item> GetLocationExits(Guid destinationId);
    }
}
