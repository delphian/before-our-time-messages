using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.DeleteAccount
{
    public class AccountDeleteAccountRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("9075b8ee-c609-429d-8a40-d4637359952a");
        /// <summary>
        /// Unique account identifier
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonProperty(PropertyName = "accountId", Order = 1000)]
        public Guid AccountId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountDeleteAccountRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Delete Account Request";
        }
    }
}
