using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemProperties.Character
{
    /// <summary>
    /// Health effects a character has
    /// </summary>
    public class CharacterHealthProperty : ItemProperty
    {
        /// <summary>
        /// Maximum normal health
        /// </summary>
        [JsonProperty(PropertyName = "max", Order = 1000)]
        public int Max
        {
            set { _max = value; NotifyPropertyChanged("Max"); }
            get { return _max; }
        }
        private int _max { set; get; }
        /// <summary>
        /// Current health value
        /// </summary>
        [JsonProperty(PropertyName = "value", Order = 1100)]
        public int Value
        {
            set { _value = value; NotifyPropertyChanged("Value"); }
            get { return _value; }
        }
        private int _value { set; get; }
    }
}
