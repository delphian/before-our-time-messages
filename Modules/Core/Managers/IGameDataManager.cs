using System;
using System.Collections.Generic;
using System.Text;
using BeforeOurTime.Models.Managers;
using BeforeOurTime.Models.Modules.Core.Models.Data;

namespace BeforeOurTime.Models.Modules.Core.Managers
{
    public interface IGameDataManager : IDataManager, IDataManager<GameData>
    {
        /// <summary>
        /// Update games's default location
        /// </summary>
        /// <param name="id">Unique game attribute identifier</param>
        /// <param name="locationId">Game's new default location</param>
        /// <returns></returns>
        GameData UpdateDefaultLocation(Guid id, Guid locationId);
    }
}
