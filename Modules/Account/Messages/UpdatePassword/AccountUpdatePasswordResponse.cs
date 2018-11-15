using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.UpdatePassword
{
    /// <summary>
    /// Account update password processed
    /// </summary>
    public class AccountUpdatePasswordResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("be456a97-4e5f-4ea7-95d8-384819053fb6");
        /// <summary>
        /// Account after password update
        /// </summary>
        [JsonProperty("account", Order = 1000)]
        public BeforeOurTime.Models.Modules.Account.Models.Account Account { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountUpdatePasswordResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Update Password Response";
        }
    }
}
