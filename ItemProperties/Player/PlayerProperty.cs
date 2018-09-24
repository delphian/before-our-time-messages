using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemProperties.Player
{
    /// <summary>
    /// A player is in charge of the underlying item
    /// </summary>
    public class PlayerProperty : ItemProperty
    {
        /// <summary>
        /// Account identifier of owner
        /// </summary>
        [JsonProperty(PropertyName = "accountId", Order = 1000)]
        public string AccountId
        {
            set { _accountId = value; NotifyPropertyChanged("AccountId"); }
            get { return _accountId; }
        }
        private string _accountId { set; get; }
        /// <summary>
        /// Compare this object to another object of same type
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Equals(PlayerProperty obj)
        {
            if (obj == null)
                return false;
            return (AccountId == obj.AccountId);
        }
        /// <summary>
        /// Get hash
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return AccountId.GetHashCode();
        }
    }
}
