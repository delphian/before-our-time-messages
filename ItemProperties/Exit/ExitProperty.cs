using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemProperties.Exit
{
    /// <summary>
    /// Movement between locations
    /// </summary>
    public class ExitProperty : ItemProperty
    {
        /// <summary>
        /// Destination item id where character shall go
        /// </summary>
        [JsonProperty(PropertyName = "destinationId", Order = 100)]
        public string DestinationId
        {
            set { _destinationId = value; NotifyPropertyChanged("DestinationId"); }
            get { return _destinationId; }
        }
        private string _destinationId;
        /// <summary>
        /// Effort required to reach destination
        /// </summary>
        [JsonProperty(PropertyName = "effort", Order = 110)]
        public int Effort
        {
            set { _effort = value; NotifyPropertyChanged("Effort"); }
            get { return _effort; }
        }
        private int _effort;
        /// <summary>
        /// Time required to reach destination
        /// </summary>
        [JsonProperty(PropertyName = "time", Order = 120)]
        public int Time
        {
            set { _time = value; NotifyPropertyChanged("Time"); }
            get { return _time; }
        }
        private int _time;
        /// <summary>
        /// Compare this object to another object of same type
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Equals(ExitProperty obj)
        {
            if (obj == null)
                return false;
            return (DestinationId == obj.DestinationId) &&
                   (Effort == obj.Effort) &&
                   (Time == obj.Time);
        }
        /// <summary>
        /// Get hash
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return DestinationId.GetHashCode();
        }
    }
}
