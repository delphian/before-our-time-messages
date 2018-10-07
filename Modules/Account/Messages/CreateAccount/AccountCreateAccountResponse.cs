using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.CreateAccount
{
    /// <summary>
    /// Account creation request has been processed
    /// </summary>
    public class AccountCreateAccountResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("acedc767-cc2e-4da1-b0cc-f1b297e75f01");
        /// <summary>
        /// Event message for player creation
        /// </summary>
        [JsonProperty(PropertyName = "createdAccountEvent", Order = 1000)]
        public AccountCreateAccountEvent CreatedAccountEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountCreateAccountResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Create Account Response";
        }
    }
}
