using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.ItemProperties.Exits
{
    /// <summary>
    /// Movement between locations
    /// </summary>
    public class ExitItemProperty : ItemProperty
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
        /// Compass direction of exit
        /// </summary>
        [JsonProperty(PropertyName = "direction", Order = 130)]
        public ExitDirection Direction
        {
            set { _direction = value; NotifyPropertyChanged("Direction"); }
            get { return _direction; }
        }
        private ExitDirection _direction { set; get; }
        /// <summary>
        /// Compare this object to another object of same type
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Equals(ExitItemProperty obj)
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
