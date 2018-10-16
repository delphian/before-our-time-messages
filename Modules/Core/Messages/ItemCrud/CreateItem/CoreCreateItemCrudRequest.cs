using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.ModelsModels.Modules.Core.Messages.ItemCrud.CreateItem
{
    public class CoreCreateItemCrudRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("12044a6f-3b37-4885-8fbc-b1cfbc1c9b00");
        /// <summary>
        /// Item to create
        /// </summary>
        public Item Item { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreCreateItemCrudRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Create Item Crud Request";
        }
    }
}
