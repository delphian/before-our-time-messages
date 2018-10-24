using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.UpdateAccount
{
    public class AccountUpdateAccountRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("3c9b1bf7-4d2e-458f-b2e0-9114eb24a72f");
        /// <summary>
        /// Account to update
        /// </summary>
        [JsonProperty(PropertyName = "account", Order = 1000)]
        public BeforeOurTime.Models.Modules.Account.Models.Account Account { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountUpdateAccountRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Update Account Request";
        }
    }
}
