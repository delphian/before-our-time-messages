using BeforeOurTime.Models.ItemProperties.Character;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BeforeOurTime.Models.Items.Characters
{
    /// <summary>
    /// An item with an animating force
    /// </summary>
    public class CharacterItem : Item, INotifyPropertyChanged
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
        /// Properties describing an animating force
        /// </summary>
        [JsonProperty(PropertyName = "character", Order = 110)]
        public CharacterProperty Character
        {
            set { _character = value; NotifyPropertyChanged("Character"); }
            get
            {
                var value = _character;
                if (value == null)
                {
                    Attributes?.ForEach((attribute) =>
                    {
                        value = attribute.GetProperty<CharacterProperty>("Character", value);
                    });
                }
                _character = value;
                return value;
            }
        }
        private CharacterProperty _character { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CharacterItem()
        {
            Type = ItemType.Character;
        }
    }
}
