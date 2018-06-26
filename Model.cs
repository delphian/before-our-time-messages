using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models
{
    /// <summary>
    /// All models inherit from this
    /// </summary>
    public class Model
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [JsonProperty(PropertyName = "id", Order = 10)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid Id { set; get; }
    }
}
