using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using BeforeOurTime.Models.Modules.World.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.Models.Items
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
        public VisibleProperty Visible
        {
            set { _visible = value; NotifyPropertyChanged("Visible"); }
            get
            {
                var value = _visible;
                if (value == null)
                {
                    Data?.ForEach((data) =>
                    {
                        value = data.GetProperty<VisibleProperty>("Visible", value);
                    });
                    _visible = value;
                }
                return value;
            }
        }
        private VisibleProperty _visible { set; get; }
        /// <summary>
        /// Movement between locations
        /// </summary>
        [JsonProperty(PropertyName = "exit", Order = 110)]
        public ExitProperty Exit
        {
            set { _exit = value; NotifyPropertyChanged("Exit"); }
            get
            {
                var value = _exit;
                if (value == null)
                {
                    Data?.ForEach((data) =>
                    {
                        value = data.GetProperty<ExitProperty>("Exit", value);
                    });
                    _exit = value;
                }
                return value;
            }
        }
        private ExitProperty _exit { set; get; }
        /// <summary>
        /// List of commands an item may respond to
        /// </summary>
        public UseProperty Uses
        {
            set { _uses = value; NotifyPropertyChanged("Uses"); }
            get
            {
                var value = _uses;
                if (value == null)
                {
                    Data?.ForEach((data) =>
                    {
                        value = data.GetProperty<UseProperty>("Uses", value);
                    });
                    _uses = value;
                }
                return value;
            }
        }
        private UseProperty _uses { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ExitItem()
        {
            Type = ItemType.Exit;
        }
    }
}
