using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.CRUD.Items.ReadItemGraph
{
    /// <summary>
    /// An item graph has been read
    /// </summary>
    public class ReadItemGraphEvent : Event, IEvent
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("f4e131af-3a00-4536-8a71-ff60c558c0b9");
        /// <summary>
        /// Beginning item of graph
        /// </summary>
        [JsonProperty(PropertyName = "itemGraph", Order = 1000)]
        public ItemGraph ItemGraph { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ReadItemGraphEvent()
        {
            this.MessageId = _Id;
            this.MessageName = "Item Graph Has Been Read";
        }
    }
}
