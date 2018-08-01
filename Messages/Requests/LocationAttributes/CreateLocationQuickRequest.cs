using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Requests.LocationAttributes
{
    public class CreateLocationQuickRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("100a31d2-24b8-4bf0-80e6-94ba88f0f5b9");
        /// <summary>
        /// Constructor
        /// </summary>
        public CreateLocationQuickRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Create Location Quick Request";
        }
    }
}
