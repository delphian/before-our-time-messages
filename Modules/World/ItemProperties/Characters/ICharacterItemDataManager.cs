using BeforeOurTime.Models.Modules.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Characters
{
    public interface ICharacterItemDataManager : IItemModelManager
    {
        /// <summary>
        /// Create a new character
        /// </summary>
        /// <param name="name">Name of character</param>
        /// <param name="locationItemId">Initial location of new character</param>
        /// <returns></returns>
        Item Create(string name, Guid locationItemId);
    }
}
