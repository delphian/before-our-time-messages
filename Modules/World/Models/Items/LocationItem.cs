using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.Models.Items
{
    /// <summary>
    /// A localized area
    /// </summary>
    public class LocationItem : Item
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
        /// Constructor
        /// </summary>
        public LocationItem()
        {
            Type = ItemType.Character;
        }
    }
}
