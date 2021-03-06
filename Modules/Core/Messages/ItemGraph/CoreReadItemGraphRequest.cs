﻿using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Messages.ItemGraph
{
    public class CoreReadItemGraphRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("34b0dddd-372a-4b09-b6bf-a0ff906a2940");
        /// <summary>
        /// Unique item identifier to begin graph at
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonProperty(PropertyName = "itemId", Order = 100)]
        public Guid? ItemId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public CoreReadItemGraphRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Core Read Item Graph Request";
        }
    }
}
