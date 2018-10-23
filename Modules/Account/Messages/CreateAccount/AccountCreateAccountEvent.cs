using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.CreateAccount
{
    /// <summary>
    /// An account has been created
    /// </summary>
    public class AccountCreateAccountEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("f02c0be3-c491-4c9e-baa5-c59fbf9f0526");
        /// <summary>
        /// Account that was just created
        /// </summary>
        [JsonProperty(PropertyName = "account", Order = 1000)]
        public BeforeOurTime.Models.Modules.Account.Models.Account Account { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountCreateAccountEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Has Been Created";
        }
    }
}
