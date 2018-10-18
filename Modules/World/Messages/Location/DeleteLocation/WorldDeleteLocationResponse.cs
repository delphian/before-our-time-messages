using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.Core.Messages.ItemCrud.DeleteItem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.World.Messages.Location.DeleteLocation
{
    public class WorldDeleteLocationResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("d4e942f5-e347-41fb-9a93-6d780c5ed3f2");
        /// <summary>
        /// Event message for item creation
        /// </summary>
        [JsonProperty(PropertyName = "deleteItemEvents", Order = 1000)]
        public CoreDeleteItemCrudEvent DeleteItemEvent { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public WorldDeleteLocationResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "World Delete Location Response";
        }
    }
}
