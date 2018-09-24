using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Models.Properties
{
    /// <summary>
    /// Game wide definition and configurations
    /// </summary>
    public class GameProperty : ItemProperty
    {
        /// <summary>
        /// Default location at which all player characters begin and respawn
        /// </summary>
        [JsonProperty(PropertyName = "defaultLocationId", Order = 1000)]
        public string DefaultLocationId
        {
            set { _defaultLocationId = value; NotifyPropertyChanged("DefaultLocationId"); }
            get { return _defaultLocationId; }
        }
        private string _defaultLocationId { set; get; }
        /// <summary>
        /// Compare this object to another object of same type
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Equals(GameProperty obj)
        {
            if (obj == null)
                return false;
            return (DefaultLocationId == obj.DefaultLocationId);
        }
        /// <summary>
        /// Get hash
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return DefaultLocationId.GetHashCode();
        }
    }
}
