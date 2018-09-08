using BeforeOurTime.Models.ItemAttributes;
using BeforeOurTime.Models.ItemAttributes.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemAttributes.Games
{
    /// <summary>
    /// Central data repository for all game items
    /// </summary>
    public interface IGameAttributeRepo : IAttributeRepo<GameAttribute>
    {
    }
}
