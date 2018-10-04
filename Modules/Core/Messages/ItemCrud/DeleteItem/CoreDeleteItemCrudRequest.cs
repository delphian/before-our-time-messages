using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemCrud.DeleteItem
{
    public class CoreDeleteItemCrudRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("0bebb17e-1742-4fe4-a3b9-61ec8c6c6771");
        /// <summary>
        /// List of unique item identifiers of items to delete
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        public List<Guid> ItemIds { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreDeleteItemCrudRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Delete Item Crud Request";
        }
    }
}
