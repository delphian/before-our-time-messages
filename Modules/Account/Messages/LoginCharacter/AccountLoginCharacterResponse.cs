using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.LoginCharacter
{
    /// <summary>
    /// Grant or deny request for terminal to be attached to character item
    /// </summary>
    public class AccountLoginCharacterResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("bf3361e5-1e36-4610-8fda-36b8e540292d");
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="requestInstanceId">Message request instance identifier</param>
        public AccountLoginCharacterResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Login Character Response";
        }
    }
}
