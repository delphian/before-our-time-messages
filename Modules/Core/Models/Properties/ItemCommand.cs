using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Models.Properties
{
    /// <summary>
    /// Describe a single command
    /// </summary>
    public class ItemCommand : ItemProperty
    {
        /// <summary>
        /// Unique identifier of command
        /// </summary>
        [JsonProperty(PropertyName = "id", Order = 20)]
        public Guid Id
        {
            set { _id = value; NotifyPropertyChanged("Id"); }
            get { return _id; }
        }
        private Guid _id { set; get; }
        /// <summary>
        /// Item that command is attached to
        /// </summary>
        [JsonProperty(PropertyName = "itemId", Order = 25)]
        public Guid? ItemId
        {
            set { _itemId = value; NotifyPropertyChanged("ItemId"); }
            get { return _itemId; }
        }
        private Guid? _itemId { set; get; }
        /// <summary>
        /// Generic data object defined by id value
        /// </summary>
        [JsonProperty(PropertyName = "data", Order = 28)]
        public object Data
        {
            set { _data = value; NotifyPropertyChanged("Data"); }
            get { return _data; }
        }
        private object _data { set; get; }
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
