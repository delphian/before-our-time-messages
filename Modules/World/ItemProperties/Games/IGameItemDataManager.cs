using BeforeOurTime.Models.Modules.World.ItemProperties.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Games
{
    public interface IGameItemDataManager : IItemModelManager
    {
        /// <summary>
        /// Update games's default location
        /// </summary>
        /// <param name="id">Unique game attribute identifier</param>
        /// <param name="locationId">Game's new default location</param>
        /// <returns></returns>
        GameItemData UpdateDefaultLocation(Guid id, Guid locationId);
    }
}
