using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemAttributes.Terminals
{
    /// <summary>
    /// When a client attaches to the game a terminal attribute will be added to the play item
    /// </summary>
    public class TerminalAttribute : ItemAttribute, IItemAttribute
    {
        /// <summary>
        /// Single generic connection used by the environment to communicate with clients
        /// </summary>
        public Guid TerminalId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public TerminalAttribute()
        {
            AttributeType = this.GetType().ToString();
        }
    }
}
