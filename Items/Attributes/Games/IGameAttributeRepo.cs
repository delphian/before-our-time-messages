using BeforeOurTime.Models.Items.Attributes;
using BeforeOurTime.Models.Items.Attributes.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes.Games
{
    /// <summary>
    /// Central data repository for all game items
    /// </summary>
    public interface IGameAttributeRepo : IAttributeRepo<GameAttribute>
    {
    }
}
