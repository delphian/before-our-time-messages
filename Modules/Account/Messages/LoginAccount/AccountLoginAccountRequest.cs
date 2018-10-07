using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.LoginAccount
{
    public class AccountLoginAccountRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("29908ab8-6403-4094-aa32-1ea0b3af70bf");
        /// <summary>
        /// Credential's email
        /// </summary>
        [JsonProperty(PropertyName = "email", Order = 100)]
        public string Email { set; get; }
        /// <summary>
        /// Credential's password
        /// </summary>
        [JsonProperty(PropertyName = "password", Order = 200)]
        public string Password { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountLoginAccountRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Login Account Request";
        }
    }
}
