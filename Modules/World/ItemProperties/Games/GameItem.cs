using BeforeOurTime.Models.Modules.Core.ItemProperties.Visibles;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.World.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Games
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
        /// Game wide definition and configurations
        /// </summary>
        [JsonProperty(PropertyName = "game", Order = 110)]
        public GameItemProperty Game
        {
            set { _game = value; NotifyPropertyChanged("Game"); }
            get
            {
                var value = _game;
                if (value == null)
                {
                    Data?.ForEach((data) =>
                    {
                        value = data.GetProperty<GameItemProperty>("Game", value);
                    });
                    _game = value;
                }
                return value;
            }
        }
        private GameItemProperty _game { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public GameItem()
        {
            Type = ItemType.Game;
        }
    }
}
