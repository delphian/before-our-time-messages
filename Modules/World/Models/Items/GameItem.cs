using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using BeforeOurTime.Models.Modules.World.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.Models.Items
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
        /// Game wide definition and configurations
        /// </summary>
        [JsonProperty(PropertyName = "game", Order = 110)]
        public GameProperty Game
        {
            set { _game = value; NotifyPropertyChanged("Game"); }
            get
            {
                var value = _game;
                if (value == null)
                {
                    Data?.ForEach((data) =>
                    {
                        value = data.GetProperty<GameProperty>("Game", value);
                    });
                    _game = value;
                }
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
