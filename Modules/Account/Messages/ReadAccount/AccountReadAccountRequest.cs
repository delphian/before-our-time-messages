using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.ReadAccount
{
    public class AccountReadAccountRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("bacee9a4-9a8e-4313-a1e5-027f51aa3d6f");
        /// <summary>
        /// Unique account identifier of accounts to read
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonProperty(PropertyName = "accountIds", Order = 1000)]
        public List<Guid> AccountIds { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountReadAccountRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Read Account Request";
        }
    }
}
