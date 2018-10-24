using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.UpdateAccount
{
    /// <summary>
    /// Account creation request has been processed
    /// </summary>
    public class AccountUpdateAccountResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("191c829d-f06b-48da-951f-21facb65351b");
        /// <summary>
        /// Event message for player creation
        /// </summary>
        [JsonProperty(PropertyName = "updateAccountEvent", Order = 1000)]
        public AccountUpdateAccountEvent UpdateAccountEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountUpdateAccountResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Update Account Response";
        }
    }
}
