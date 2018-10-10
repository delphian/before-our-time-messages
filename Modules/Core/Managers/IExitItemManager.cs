using System;
using System.Collections.Generic;
using System.Text;
using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Modules.Core.Models.Items;

namespace BeforeOurTime.Models.Modules.Core.Managers
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
