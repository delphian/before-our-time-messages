using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.Json.RestoreAccount
{
    /// <summary>
    /// Read JSON of one or more accounts
    /// </summary>
    public class AccountJsonRestoreAccountRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("6a34bf84-23e2-4304-9e6a-fd70ae869aab");
        /// <summary>
        /// List of account ids to read in JSON form
        /// </summary>
        [JsonProperty("accountsJson")]
        [JsonConverter(typeof(GuidJsonConverter))]
        public List<AccountJson> Accounts { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountJsonRestoreAccountRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Json Restore Account Request";
        }
    }
}
