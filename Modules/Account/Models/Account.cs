using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Models
{
    public class Account : Model, IModel, INotifyPropertyChanged
    {
        /// <summary>
        /// Structure that subscriber must implement to recieve property updates
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Login name
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 110)]
        public string Name
        {
            get { return _name; }
            set { _name = value; NotifyPropertyChanged("Name"); }
        }
        private string _name { set; get; }
        /// <summary>
        /// Login password
        /// </summary>
        [JsonProperty(PropertyName = "password", Order = 120)]
        public string Password
        {
            get { return _password; }
            set { _password = value; NotifyPropertyChanged("Password"); }
        }
        private string _password { set; get; }
        /// <summary>
        /// Account was auto generated for guest and still in temporary state
        /// </summary>
        /// <remarks>
        /// Any temporary account is subject to deletion
        /// </remarks>
        [JsonProperty(PropertyName = "temporary", Order = 130)]
        public bool Temporary
        {
            get { return _temporary; }
            set { _temporary = value; NotifyPropertyChanged("Temporary"); }
        }
        private bool _temporary { set; get; }
        /// <summary>
        /// Administrative account
        /// </summary>
        [JsonProperty(PropertyName = "admin", Order = 140)]
        public bool Admin
        {
            get { return _admin; }
            set { _admin = value; NotifyPropertyChanged("Admin"); }
        }
        private bool _admin { set; get; }
        /// <summary>
        /// Notify all subscribers that a property has been updated
        /// </summary>
        /// <param name="propertyName">Name of public property that has changed</param>
        public void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
