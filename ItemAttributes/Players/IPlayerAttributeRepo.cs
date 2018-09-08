using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.ItemAttributes.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemAttributes.Players
{
    /// <summary>
    /// Central data repository for all player attributes
    /// </summary>
    public interface IPlayerAttributeRepo : IAttributeRepo<PlayerAttribute>
    {
        /// <summary>
        /// Read all players (avatars) for an account
        /// </summary>
        /// <param name="accountId">Unique account identifier</param>
        /// <returns></returns>
        List<Item> ReadPlayers(Guid accountId);
    }
}
