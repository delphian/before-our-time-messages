using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.Json.ReadAccount
{
    /// <summary>
    /// Read JSON of one or more accounts
    /// </summary>
    public class AccountJsonReadAccountRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("e77d8f75-bff8-4ac2-b0d7-6da765bd9627");
        /// <summary>
        /// List of account ids to read in JSON form
        /// </summary>
        [JsonProperty("accountIds")]
        [JsonConverter(typeof(GuidJsonConverter))]
        public List<Guid> AccountIds { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountJsonReadAccountRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Json Read Account Request";
        }
    }
}
