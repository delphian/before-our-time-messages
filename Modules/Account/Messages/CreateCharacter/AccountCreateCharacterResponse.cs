using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.CreateCharacter
{
    /// <summary>
    /// A player has been created
    /// </summary>
    public class AccountCreateCharacterResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("ebb9c305-5902-4c59-97ce-6137eebbe472");
        /// <summary>
        /// Event message for player creation
        /// </summary>
        [JsonProperty(PropertyName = "createdAccountCharacterEvent", Order = 1000)]
        public AccountCreateCharacterEvent CreatedAccountCharacterEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountCreateCharacterResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Create Character Response";
        }
    }
}
