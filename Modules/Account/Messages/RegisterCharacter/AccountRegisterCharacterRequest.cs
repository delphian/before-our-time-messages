using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.RegisterCharacter
{
    public class AccountRegisterCharacterRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("5ea223d3-75b4-4c00-bb4b-49ac9a74a30f");
        /// <summary>
        /// Unique identifier of character
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonProperty(PropertyName = "characterId", Order = 1000)]
        public Guid CharacterId { set; get; }
        /// <summary>
        /// Name of character
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 1100)]
        public string Name { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountRegisterCharacterRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Register Character Request";
        }
    }
}
