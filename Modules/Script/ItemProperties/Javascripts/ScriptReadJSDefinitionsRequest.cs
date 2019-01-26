using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Script.ItemProperties.Javascripts
{
    public class ScriptReadJSDefinitionsRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        [JsonIgnore]
        [JsonConverter(typeof(GuidJsonConverter))]
        public static Guid _Id = new Guid("a34aa41b-2a87-4ab2-a67f-d86ba0e56633");
        /// <summary>
        /// Constructor
        /// </summary>
        public ScriptReadJSDefinitionsRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "Script Read JS Definitions Request";
        }
    }
}
