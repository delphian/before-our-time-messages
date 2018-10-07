using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.LogoutAccount
{
    public class AccountLogoutAccountRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("96f05cd2-2042-46e6-b4cb-fef35b2ff05a");
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountLogoutAccountRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Logout Account Request";
        }
    }
}
