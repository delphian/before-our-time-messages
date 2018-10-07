using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.LogoutAccount
{
    /// <summary>
    /// Response to logout request
    /// </summary>
    public class AccountLogoutAccountResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("05c1f08c-353a-4886-9526-9dc1ad69efc7");
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountLogoutAccountResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Logout Account Response";
        }
    }
}
