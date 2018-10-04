using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemCrud.UpdateItem
{
    /// <summary>
    /// Update one or more items
    /// </summary>
    public class CoreUpdateItemCrudRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("26127ca1-5604-40a0-b93e-4b424aa6ca63");
        /// <summary>
        /// Item to update
        /// </summary>
        [JsonProperty(PropertyName = "items", Order = 1100)]
        public List<Item> Items { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreUpdateItemCrudRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Update Item Crud Request";
        }
    }
}
