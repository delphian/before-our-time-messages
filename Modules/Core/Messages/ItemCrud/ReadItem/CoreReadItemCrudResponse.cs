using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemCrud.ReadItem
{
    public class CoreReadItemCrudResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("14639565-6fc9-4147-91f2-bfceb36215f6");
        /// <summary>
        /// Event message for item read
        /// </summary>
        [JsonProperty(PropertyName = "coreReadItemCrudEvent", Order = 1000)]
        public CoreReadItemCrudEvent CoreReadItemCrudEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreReadItemCrudResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Read Item Crud Response";
        }
    }
}
