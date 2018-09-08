using BeforeOurTime.Models.ItemProperties.Visible;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Locations
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
                Attributes?.ForEach((attribute) =>
                {
                    value = attribute.GetProperty<VisibleProperty>("Visible", value);
                });
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
