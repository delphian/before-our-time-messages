using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using BeforeOurTime.Models;
using BeforeOurTime.Models.Modules.Core.Models.Properties;

namespace BeforeOurTime.Models.Modules.Core.Models.Data
{
    /// <summary>
    /// Additional information wrapping, but based on an item's type
    /// </summary>
    public abstract class ItemData : Model
    {
        /// <summary>
        /// Structure that subscriber must implement to recieve property updates
        /// </summary>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [JsonProperty(PropertyName = "dataType", Order = 14)]
        public string DataType { set; get; }
        /// <summary>
        /// Unique item identifier that this item type is associated with
        /// </summary>
        /// <summary>
        /// Item that this item type is associated with
        /// </summary>
        [JsonProperty(PropertyName = "dataItemId", Order = 15)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid DataItemId { set; get; }
        /// <summary>
        /// Populate an item property value
        /// </summary>
        /// <typeparam name="T">Type of property to populate with value</typeparam>
        /// <param name="propertyName">Name of item property to populate with value</param>
        /// <param name="previousValue">Value assigned to property by previous attribute</param>
        /// <returns></returns>
        public virtual T GetProperty<T>(string propertyName, object previousValue) where T : ItemProperty, new()
        {
            return (T)previousValue;
        }
        /// <summary>
        /// Get priority order of attribute in comparison to other attributes
        /// </summary>
        /// <remarks>
        /// Defaults to 1000. Higher number has higher priority and will be executed _last_
        /// </remarks>
        /// <returns></returns>
        public virtual int GetOrder()
        {
            return 1000;
        }
        /// <summary>
        /// Notify all subscribers that a property has been updated
        /// </summary>
        /// <param name="propertyName">Name of public property that has changed</param>
        protected void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
