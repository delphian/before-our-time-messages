using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using BeforeOurTime.Models;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using BeforeOurTime.Models.Modules.Core.Models.Items;

namespace BeforeOurTime.Models.Modules.Core.Models.Data
{
    /// <summary>
    /// A stored item to item message
    /// </summary>
    public abstract class MessageData : Model
    {
        /// <summary>
        /// Structure that subscriber must implement to recieve property updates
        /// </summary>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
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
