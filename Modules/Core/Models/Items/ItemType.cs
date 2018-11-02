using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Models.Items
{
    /// <summary>
    /// Each item must have a primary purpose
    /// </summary>
    public enum ItemType
    {
        Unknown = 0,
        /// <summary>
        /// Fantom item assigned to clients that have connected, but not logged in
        /// </summary>
        Ghost = 1,
        Game = 100,
        Location = 200,
        Exit = 300,
        Character = 400,
        Player = 500
    }
}
