using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Models.Properties
{
    /// <summary>
    /// List of commands an item may respond to
    /// </summary>
    /// <remarks>
    /// Item manager is responsible for executing the use
    /// </remarks>
    public class UseProperty : ItemProperty
    {
        /// <summary>
        /// List of possible commands item will respond to
        /// </summary>
        [JsonProperty(PropertyName = "uses", Order = 20)]
        public List<Use> Uses
        {
            set { _uses = value; NotifyPropertyChanged("Uses"); }
            get { return _uses; }
        }
        private List<Use> _uses { set; get; }

    }
}
