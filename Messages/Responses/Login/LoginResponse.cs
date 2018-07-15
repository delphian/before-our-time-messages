using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Responses.Login
{
    /// <summary>
    /// Response to login request
    /// </summary>
    public class LoginResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("dbee9538-048c-4ea7-b518-8b6cc17fdeb7");
        /// <summary>
        /// Unique account identifier
        /// </summary>
        [JsonProperty(PropertyName = "accountId", Order = 1000)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid? AccountId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public LoginResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Login Response";
        }
    }
}
