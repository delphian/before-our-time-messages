using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Events.Created
{
    /// <summary>
    /// An account has been created
    /// </summary>
    public class CreatedAccountEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("f02c0be3-c491-4c9e-baa5-c59fbf9f0526");
        /// <summary>
        /// Unique account identifier
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonProperty(PropertyName = "accountId", Order = 1000)]
        public Guid AccountId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CreatedAccountEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Account has been created";
        }
    }
}
