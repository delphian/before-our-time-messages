using BeforeOurTime.Models.Modules.Core.ItemProperties.Visibles;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Exits
{
    /// <summary>
    /// A one way path from one item to another
    /// </summary>
    public class ExitItem : Item
    {
        /// <summary>
        /// Make an item visible
        /// </summary>
        [JsonProperty(PropertyName = "visible", Order = 100)]
        public VisibleItemProperty Visible
        {
            set { _visible = value; NotifyPropertyChanged("Visible"); }
            get
            {
                var value = _visible;
                if (value == null)
                {
                    Data?.ForEach((data) =>
                    {
                        value = data.GetProperty<VisibleItemProperty>("Visible", value);
                    });
                    _visible = value;
                }
                return value;
            }
        }
        private VisibleItemProperty _visible { set; get; }
        /// <summary>
        /// Movement between locations
        /// </summary>
        [JsonProperty(PropertyName = "exit", Order = 110)]
        public ExitItemProperty Exit
        {
            set { _exit = value; NotifyPropertyChanged("Exit"); }
            get
            {
                var value = _exit;
                if (value == null)
                {
                    Data?.ForEach((data) =>
                    {
                        value = data.GetProperty<ExitItemProperty>("Exit", value);
                    });
                    _exit = value;
                }
                return value;
            }
        }
        private ExitItemProperty _exit { set; get; }
        /// <summary>
        /// List of commands an item may respond to
        /// </summary>
        public CommandProperty CommandList
        {
            set { _commandList = value; NotifyPropertyChanged("CommandList"); }
            get
            {
                var value = _commandList;
                if (value == null)
                {
                    Data?.ForEach((data) =>
                    {
                        value = data.GetProperty<CommandProperty>("CommandsList", value);
                    });
                    _commandList = value;
                }
                return value;
            }
        }
        private CommandProperty _commandList { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ExitItem()
        {
            Type = ItemType.Exit;
        }
    }
}
