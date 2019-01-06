using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.Messages.Emotes
{
    public enum WorldEmoteType : int
    {
        /// <summary>
        /// Unknown or not available. How does this happen?
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Smile
        /// </summary>
        Smile = 100,
        /// <summary>
        /// Frown
        /// </summary>
        Frown = 200,
        /// <summary>
        /// Speak
        /// </summary>
        Speak = 300,
        /// <summary>
        /// An emote that should not be preceeded by the item name
        /// </summary>
        Raw = 400
    }
}
