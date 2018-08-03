using BeforeOurTime.Models.Items.Attributes.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes.Characters
{
    /// <summary>
    /// Central data repository for all character items
    /// </summary>
    public interface ICharacterAttributeRepo : IAttributeRepo<CharacterAttribute>
    {
    }
}
