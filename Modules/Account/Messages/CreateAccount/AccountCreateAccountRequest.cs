using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.CreateAccount
{
    public class AccountCreateAccountRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("53b95bc4-fce1-492b-997b-ee3ab787a7c9");
        /// <summary>
        /// Unique email to be used as account name
        /// </summary>
        [JsonProperty(PropertyName = "email", Order = 1000)]
        public string Email { set; get; }
        /// <summary>
        /// Password for account
        /// </summary>
        [JsonProperty(PropertyName = "password", Order = 1100)]
        public string Password { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountCreateAccountRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Create Account Request";
        }
    }
}
