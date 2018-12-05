using BeforeOurTime.Models.Modules.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Games
{
    /// <summary>
    /// Central data repository for all game items
    /// </summary>
    public interface IGameItemDataRepo : ICrudItemModelRepository<GameItemData>
    {
        /// <summary>
        /// Read associated game data of item
        /// </summary>
        /// <param name="item">Item that may have associated attributes</param>
        /// <returns></returns>
        GameItemData Read(Item item);
    }
}
