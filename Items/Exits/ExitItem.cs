using BeforeOurTime.Models.ItemProperties.Exit;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Exits
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
                if (value != null)
                {
                    Attributes?.ForEach((attribute) =>
                    {
                        value = attribute.GetProperty<VisibleProperty>("Visible", value);
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
                    Attributes?.ForEach((attribute) =>
                    {
                        value = attribute.GetProperty<ExitProperty>("Exit", value);
                    });
                    _exit = value;
                }
                return value;
            }
        }
        private ExitProperty _exit { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ExitItem()
        {
            Type = ItemType.Exit;
        }
    }
}
