using BeforeOurTime.Models.ItemProperties.Game;
using BeforeOurTime.Models.ItemProperties.Visible;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Games
{
    /// <summary>
    /// Game wide definition and configurations
    /// </summary>
    public class GameItem : Item
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
        /// Game wide definition and configurations
        /// </summary>
        public GameProperty Game
        {
            set { _game = value; NotifyPropertyChanged("Game"); }
            get
            {
                var value = _game;
                Attributes?.ForEach((attribute) =>
                {
                    value = attribute.GetProperty<GameProperty>("Game", value);
                });
                return value;
            }
        }
        private GameProperty _game { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public GameItem()
        {
            Type = ItemType.Game;
        }
    }
}
