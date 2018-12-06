using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Models.Properties
{
    /// <summary>
    /// List of commands an item may respond to
    /// </summary>
    /// <remarks>
    /// Item manager is responsible for executing the use
    /// </remarks>
    public class CommandItemProperty : ItemProperty
    {
        /// <summary>
        /// List of possible commands item will respond to
        /// </summary>
        [JsonProperty(PropertyName = "commands", Order = 20)]
        public List<ItemCommand> Commands
        {
            set { _commands = value; NotifyPropertyChanged("Commands"); }
            get { return _commands; }
        }
        private List<ItemCommand> _commands { set; get; }

    }
}
