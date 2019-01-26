using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Script.ItemProperties.Javascripts
{
    public class ScriptReadJSDefinitionsResponse : Response, IResponse
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("c2ebf86c-7a6b-40bf-ac79-6cf4fe351090");
        /// <summary>
        /// Event message for performed emote
        /// </summary>
        [JsonProperty(PropertyName = "definitions", Order = 1000)]
        public List<JavascriptFunctionDefinition> Definitions { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ScriptReadJSDefinitionsResponse()
        {
            this.MessageId = _Id;
            this.MessageName = "Script Read JS Definitions Response";
        }
    }
}
