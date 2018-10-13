using BeforeOurTime.Models;
using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Modules.World.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.Dbs
{
    /// <summary>
    /// Central data repository for all game items
    /// </summary>
    public interface IGameDataRepo : ICrudItemModelRepository<GameData>
    {
        /// <summary>
        /// Read associated game data of item
        /// </summary>
        /// <param name="item">Item that may have associated attributes</param>
        /// <param name="options">Options to customize how data is transacted from datastore</param>
        /// <returns></returns>
        GameData Read(Item item, TransactionOptions options = null);
    }
}
