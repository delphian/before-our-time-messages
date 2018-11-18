using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.Models.Properties
{
    /// <summary>
    /// Properties specific to characters
    /// </summary>
    public class CharacterProperty : ItemProperty
    {
        /// <summary>
        /// Character is temporary, created for account to test game
        /// </summary>
        [JsonProperty(PropertyName = "temporary", Order = 20)]
        public bool Temporary
        {
            set { _temporary = value; NotifyPropertyChanged("Temporary"); }
            get { return _temporary; }
        }
        private bool _temporary { set; get; }
    }
}
