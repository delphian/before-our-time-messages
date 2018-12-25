using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.DeleteAccount
{
    /// <summary>
    /// Account creation request has been processed
    /// </summary>
    public class AccountDeleteAccountResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("e656c271-f678-4c2a-ba8b-3f36af1e899d");
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountDeleteAccountResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Delete Account Response";
        }
    }
}
