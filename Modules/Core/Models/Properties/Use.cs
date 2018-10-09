using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Models.Properties
{
    /// <summary>
    /// Describe a single use
    /// </summary>
    public class Use : ItemProperty
    {
        /// <summary>
        /// Unique identifier of use
        /// </summary>
        [JsonProperty(PropertyName = "id", Order = 20)]
        public Guid Id
        {
            set { _id = value; NotifyPropertyChanged("Id"); }
            get { return _id; }
        }
        private Guid _id { set; get; }
        /// <summary>
        /// Displayed command name
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 30)]
        public string Name
        {
            set { _name = value; NotifyPropertyChanged("Name"); }
            get { return _name; }
        }
        private string _name { set; get; }
    }
}
