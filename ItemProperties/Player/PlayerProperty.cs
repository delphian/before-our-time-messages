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
        public Guid AccountId
        {
            set { _accountId = value; NotifyPropertyChanged("AccountId"); }
            get { return _accountId; }
        }
        private Guid _accountId { set; get; }
    }
}
