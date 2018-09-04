using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items
{
    /// <summary>
    /// Each item must have a primary purpose
    /// </summary>
    public enum ItemBaseType
    {
        Unknown = 0,
        Game = 100,
        Location = 200,
        Exit = 300
    }
}
