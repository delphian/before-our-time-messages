using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Requests.List
{
    public class ListLocationRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("a50d4898-22f6-46c3-b23b-69b866593b13");
        /// <summary>
        /// Constructor
        /// </summary>
        public ListLocationRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Look Request";
        }
    }
}
