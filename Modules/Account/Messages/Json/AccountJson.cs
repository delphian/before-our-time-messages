﻿using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Account.Messages.Json
{
    /// <summary>
    /// A unique account identifier and it's corrisponding JSON encoding
    /// </summary>
    public class AccountJson
    {
        /// <summary>
        /// Unique account identifier
        /// </summary>
        [JsonProperty(PropertyName = "id", Order = 1000)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid Id { set; get; }
        /// <summary>
        /// Account encoded as JSON
        /// </summary>
        [JsonProperty(PropertyName = "json", Order = 1100)]
        public string JSON { set; get; }
    }
}
