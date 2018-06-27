using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Responses.List
{
    /// <summary>
    /// Enumerate an exit
    /// </summary>
    public class ListExitResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        public static Guid _Id = new Guid("88f8dbfe-cd70-4da4-97cf-6eeeadc7b861");
        /// <summary>
        /// Unique exit item identifier
        /// </summary>
        [JsonProperty(PropertyName = "item", Order = 1000)]
        public Item Item { set; get; }
        /// <summary>
        /// Name of the exit
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 1100)]
        public string Name { set; get; }
        /// <summary>
        /// Description of exit
        /// </summary>
        [JsonProperty(PropertyName = "description", Order = 1200)]
        public string Description { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ListExitResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "List Exit Response";
        }
    }
}
