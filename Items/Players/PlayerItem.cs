using BeforeOurTime.Models.ItemProperties.Character;
using BeforeOurTime.Models.ItemProperties.Visible;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Players
{
    public class PlayerItem : Item
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
        /// Properties describing an animating force
        /// </summary>
        [JsonProperty(PropertyName = "character", Order = 110)]
        public CharacterProperty Character
        {
            set { _character = value; NotifyPropertyChanged("Character"); }
            get
            {
                var value = _character;
                Attributes?.ForEach((attribute) =>
                {
                    value = attribute.GetProperty<CharacterProperty>("Character", value);
                });
                return value;
            }
        }
        private CharacterProperty _character { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public PlayerItem()
        {
            Type = ItemType.Player;
        }
    }
}
