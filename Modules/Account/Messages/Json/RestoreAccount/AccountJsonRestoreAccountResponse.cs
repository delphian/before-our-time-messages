using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.Json.RestoreAccount
{
    /// <summary>
    /// Read JSON of one or more accounts
    /// </summary>
    public class AccountJsonRestoreAccountResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("ecb5fb97-0fcc-4078-b61d-af7102fb439d");
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountJsonRestoreAccountResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Json Restore Account Response";
        }
    }
}
