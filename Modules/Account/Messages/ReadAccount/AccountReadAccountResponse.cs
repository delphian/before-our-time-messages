using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.Account.Models.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.ReadAccount
{
    public class AccountReadAccountResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("a57b33df-e052-4e90-9932-b388ba3294ae");
        /// <summary>
        /// List of accounts
        /// </summary>
        [JsonProperty(PropertyName = "accounts", Order = 1000)]
        public List<AccountData> Accounts { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountReadAccountResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Read Account Response";
        }
    }
}
