using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Requests.Login
{
    public class LoginRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
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
        public LoginRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Login Request";
        }
    }
}
