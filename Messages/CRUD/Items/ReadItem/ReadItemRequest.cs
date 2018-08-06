using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.CRUD.Items.ReadItem
{
    public class ReadItemRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("ad19eb46-0af0-4ad6-866b-feb13b9dc588");
        /// <summary>
        /// List of unique item identifiers to read
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonProperty(PropertyName = "itemIds", Order = 100)]
        public List<Guid> ItemIds { set; get; }
        /// <summary>
        /// List of attribute types. Item must be assigned all attribute types specified
        /// </summary>
        [JsonProperty(PropertyName = "itemAttributeTypes", Order = 110)]
        public List<string> ItemAttributeTypes { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ReadItemRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Read Item Request";
        }
    }
}
