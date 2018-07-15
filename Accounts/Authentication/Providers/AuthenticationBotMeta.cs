using BeforeOurTime.Models;
using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Accounts.Authentication.Providers
{
    /// <summary>
    /// Local meta data associated for an account from an authentication provider
    /// </summary>
    /// <remarks>
    /// In the case of BeforeOurTime this consists of the actual user name and password
    /// </remarks>
    public class AuthenticationBotMeta : Model
    {
        /// <summary>
        /// Unique local credential identifier. Email address. Used as principal identifier
        /// </summary>
        public string Email { set; get; }
        /// <summary>
        /// Encrypted password
        /// </summary>
        public string Password { set; get; }
        /// <summary>
        /// An account keeps track of a user's access to the system
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid AccountId { set; get; }
        [JsonIgnore]
        public virtual Account Account { set; get; }
    }
}
