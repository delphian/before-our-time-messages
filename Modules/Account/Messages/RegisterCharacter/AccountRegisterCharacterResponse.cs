using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.RegisterCharacter
{
    /// <summary>
    /// A player has been created
    /// </summary>
    public class AccountRegisterCharacterResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("98381351-44c7-4295-bccf-87f0f9546fa1");
        /// <summary>
        /// Updated character item
        /// </summary>
        [JsonProperty(PropertyName = "item", Order = 1000)]
        public Item Item { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountRegisterCharacterResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Register Character Response";
        }
    }
}
