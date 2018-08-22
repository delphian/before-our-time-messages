using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Locations.Locations.ReadLocation
{
    public class ReadLocationRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("272baa24-6725-4e97-9af7-3bc816209e5d");
        /// <summary>
        /// List of location items to read
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonProperty(PropertyName = "itemIds", Order = 1000)]
        public List<Guid> ItemIds { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ReadLocationRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Read Location Request";
        }
    }
}
