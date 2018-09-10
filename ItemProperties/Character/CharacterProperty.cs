using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemProperties.Character
{
    /// <summary>
    /// Properties describing an animating force
    /// </summary>
    public class CharacterProperty : ItemProperty
    {
        /// <summary>
        /// Health effects a character has
        /// </summary>
        [JsonProperty(PropertyName = "health", Order = 1000)]
        public CharacterHealthProperty Health {
            set { _health = value; NotifyPropertyChanged("Health"); }
            get { return _health; }
        }
        private CharacterHealthProperty _health { set; get; }
        /// <summary>
        /// Compare this object to another object of same type
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Equals(CharacterProperty obj)
        {
            if (obj == null)
                return false;
            return (Health == obj.Health);
        }
        /// <summary>
        /// Get hash
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Health.GetHashCode();
        }
    }
}
