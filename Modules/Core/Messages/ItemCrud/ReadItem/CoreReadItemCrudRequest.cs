using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemCrud.ReadItem
{
    public class CoreReadItemCrudRequest : Request, IRequest
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
        /// List of item data types.
        /// </summary>
        [JsonProperty(PropertyName = "itemDataTypes", Order = 120)]
        public List<string> ItemDataTypes { set; get; }
        /// <summary>
        /// List of item property types.
        /// </summary>
        [JsonProperty(PropertyName = "itemPropertyTypes", Order = 130)]
        public List<string> ItemPropertyTypes { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreReadItemCrudRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Read Item Crud Request";
        }
    }
}
