using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.Models.Properties
{
    /// <summary>
    /// Properties specific to physical items
    /// </summary>
    public class PhysicalItemVM : ItemProperty
    {
        /// <summary>
        /// Item is able to be moved by a character
        /// </summary>
        [JsonProperty(PropertyName = "mobile", Order = 20)]
        public bool Mobile
        {
            set { _mobile = value; NotifyPropertyChanged("Mobile"); }
            get { return _mobile; }
        }
        private bool _mobile { set; get; }
    }
}
