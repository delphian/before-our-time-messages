using BeforeOurTime.Models.Modules.Core.Models.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Terminal.Models.Data
{
    /// <summary>
    /// Indicate that terminal is attached to an item
    /// </summary>
    public class TerminalData : ItemData, IItemData
    {
        /// <summary>
        /// Unique terminal identifier
        /// </summary>
        [JsonProperty(PropertyName = "terminalId", Order = 20)]
        public Guid TerminalId { set; get; }
        /// <summary>
        /// Terminal
        /// </summary>
        [JsonIgnore]
        public ITerminal Terminal { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public TerminalData()
        {
            DataType = this.GetType().ToString();
        }
    }
}
