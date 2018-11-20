using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.Json.ReadAccount
{
    /// <summary>
    /// Response to login request
    /// </summary>
    public class AccountJsonReadAccountResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("3f250feb-9255-4127-b713-a91c79b46b2b");
        /// <summary>
        /// List of accounts in JSON format
        /// </summary>
        [JsonProperty(PropertyName = "accounts", Order = 1000)]
        public List<AccountJson> Accounts { set; get; } = new List<AccountJson>();
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountJsonReadAccountResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Json Read Account Response";
        }
    }
}
