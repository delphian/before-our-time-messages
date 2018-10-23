using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.LoginAccount
{
    /// <summary>
    /// Response to login request
    /// </summary>
    public class AccountLoginAccountResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("dbee9538-048c-4ea7-b518-8b6cc17fdeb7");
        /// <summary>
        /// Unique account identifier
        /// </summary>
        [JsonProperty(PropertyName = "account", Order = 1000)]
        public BeforeOurTime.Models.Modules.Account.Models.Account Account { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountLoginAccountResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Login Account Response";
        }
    }
}
