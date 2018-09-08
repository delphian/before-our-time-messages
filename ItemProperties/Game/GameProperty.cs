using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemProperties.Game
{
    /// <summary>
    /// Game wide definition and configurations
    /// </summary>
    public class GameProperty : ItemProperty
    {
        /// <summary>
        /// Default location at which all player characters begin and respawn
        /// </summary>
        public string DefaultLocationId
        {
            set { _defaultLocationId = value; NotifyPropertyChanged("DefaultLocationId"); }
            get { return _defaultLocationId; }
        }
        private string _defaultLocationId { set; get; }
    }
}
