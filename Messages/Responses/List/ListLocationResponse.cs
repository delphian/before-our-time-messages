using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Responses.List
{
    /// <summary>
    /// Describe a location and enumerate essential properties
    /// </summary>
    public class ListLocationResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        public static Guid _Id = new Guid("e8de221a-381a-45f3-898f-ca12e1badad1");
        /// <summary>
        /// Unique location item identifier
        /// </summary>
        [JsonProperty(PropertyName = "item", Order = 1000)]
        public Item Item { set; get; }
        /// <summary>
        /// Short name of location
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 1100)]
        public string Name { set; get; }
        /// <summary>
        /// Longer paragraph description of location
        /// </summary>
        [JsonProperty(PropertyName = "description", Order = 1200)]
        public string Description { set; get; }
        /// <summary>
        /// Background image for location
        /// </summary>
        [JsonProperty(PropertyName = "image", Order = 1300)]
        public string Image { set; get; }
        /// <summary>
        /// Potential exits from the location
        /// </summary>
        [JsonProperty(PropertyName = "exits", Order = 1400)]
        public List<ListExitResponse> Exits = new List<ListExitResponse>();
        /// <summary>
        /// Additional descrete textual adendums to the description
        /// </summary>
        [JsonProperty(PropertyName = "adendums", Order = 1500)]
        public List<string> Adendums = new List<string>();
        /// <summary>
        /// Constructor
        /// </summary>
        public ListLocationResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Location Response";
        }
    }
}
