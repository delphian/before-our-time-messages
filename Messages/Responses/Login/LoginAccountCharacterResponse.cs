using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Responses.Login
{
    /// <summary>
    /// Grant or deny request for terminal to be attached to character item
    /// </summary>
    public class LoginAccountCharacterResponse : Response, IResponse
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
        public LoginAccountCharacterResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Login Account Character Response";
        }
    }
}
