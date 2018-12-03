using BeforeOurTime.Models.Modules.Core.ItemProperties.Visibles;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Locations
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
        /// Constructor
        /// </summary>
        public LocationItem()
        {
            Type = ItemType.Location;
        }
    }
}
