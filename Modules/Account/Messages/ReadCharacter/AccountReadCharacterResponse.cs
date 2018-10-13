using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.World.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.ReadCharacter
{
    public class AccountReadCharacterResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("11753eca-fd29-42ca-8af1-bc24908d29dd");
        /// <summary>
        /// List of character items that an account is able to use as avatars
        /// </summary>
        /// <remarks>
        /// These will be detached items (Db.Set.AsNoTracking()...)
        /// </remarks>
        [JsonProperty(PropertyName = "accountCharacters", Order = 1000)]
        public List<CharacterItem> AccountCharacters { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountReadCharacterResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Account Read Character Response";
        }
    }
}
