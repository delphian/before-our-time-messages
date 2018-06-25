using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items
{
    /// <summary>
    /// Normalized item for consumption as a DTO
    /// </summary>
    public class Item : System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Unique item identifier
        /// </summary>
        [JsonProperty(PropertyName = "id", Order = 1000)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid Id { set; get; }
        private string _name { set; get; }
        /// <summary>
        /// Normalized name of item
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 1100)]
        public string Name
        {
            get { return _name; }
            set { _name = value; NotifyPropertyChanged("Name"); }
        }
        /// <summary>
        /// Normalized description of item
        /// </summary>
        [JsonProperty(PropertyName = "description", Order = 1200)]
        public string Description { set; get; }
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
