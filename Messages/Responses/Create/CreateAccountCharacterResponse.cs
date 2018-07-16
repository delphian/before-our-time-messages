using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events.Created;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Responses.Create
{
    /// <summary>
    /// A player has been created
    /// </summary>
    public class CreateAccountCharacterResponse : Response, IResponse
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
        public CreatedAccountCharacterEvent CreatedAccountCharacterEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CreateAccountCharacterResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Create account character response";
        }
    }
}
