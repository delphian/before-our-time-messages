using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.LoginCharacter
{
    /// <summary>
    /// Client requests terminal be attached to character item
    /// </summary>
    public class AccountLoginCharacterRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("26f1db1d-1545-4db0-be7e-f127578d6299");
        /// <summary>
        /// Character's unique item identifier
        /// </summary>
        [JsonProperty(PropertyName = "itemId", Order = 1000)]
        public Guid ItemId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountLoginCharacterRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Login Character Request";
        }
    }
}
