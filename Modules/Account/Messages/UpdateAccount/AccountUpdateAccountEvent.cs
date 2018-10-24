using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.UpdateAccount
{
    /// <summary>
    /// An account has been created
    /// </summary>
    public class AccountUpdateAccountEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("3d3cab76-7301-4663-8602-4e6354de11d1");
        /// <summary>
        /// Account that was updated
        /// </summary>
        [JsonProperty(PropertyName = "account", Order = 1000)]
        public BeforeOurTime.Models.Modules.Account.Models.Account Account { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountUpdateAccountEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Has Been Updated";
        }
    }
}
