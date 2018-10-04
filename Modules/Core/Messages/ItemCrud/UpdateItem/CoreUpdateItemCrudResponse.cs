using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Events.Created;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemCrud.UpdateItem
{
    public class CoreUpdateItemCrudResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("11899b25-3dae-4159-95ed-e63bf65802ac");
        /// <summary>
        /// Event message for item update
        /// </summary>
        [JsonProperty(PropertyName = "coreUpdateItemCrudEvent", Order = 1000)]
        public CoreUpdateItemCrudEvent CoreUpdateItemCrudEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreUpdateItemCrudResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Update Item Crud Response";
        }
    }
}
