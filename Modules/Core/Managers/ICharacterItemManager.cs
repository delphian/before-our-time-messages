using BeforeOurTime.Models.Modules.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Managers
{
    public interface ICharacterItemManager : IItemModelManager
    {
        /// <summary>
        /// Create a new character
        /// </summary>
        /// <param name="name">Name of character</param>
        /// <param name="locationItemId">Initial location of new character</param>
        /// <returns></returns>
        CharacterItem Create(string name, Guid locationItemId);
    }
}
