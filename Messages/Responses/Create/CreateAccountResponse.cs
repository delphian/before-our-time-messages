using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events.Created;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Responses.Create
{
    /// <summary>
    /// Account creation request has been processed
    /// </summary>
    public class CreateAccountResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("acedc767-cc2e-4da1-b0cc-f1b297e75f01");
        /// <summary>
        /// Event message for player creation
        /// </summary>
        [JsonProperty(PropertyName = "createdAccountEvent", Order = 1000)]
        public CreatedAccountEvent CreatedAccountEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CreateAccountResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Create Account Response";
        }
    }
}
