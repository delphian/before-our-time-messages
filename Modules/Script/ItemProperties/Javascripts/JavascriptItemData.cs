using BeforeOurTime.Models.Modules.Core.Models.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Script.ItemProperties.Javascripts
{
    /// <summary>
    /// Define some or all item properties through javascript
    /// </summary>
    public class JavascriptItemData : ItemData, IItemData
    {
        /// <summary>
        /// Javascript script
        /// </summary>
        [JsonProperty(PropertyName = "script", Order = 50)]
        public string Script { set; get; }
        /// <summary>
        /// Semicolon deliminated list of functions declared by script
        /// </summary>
        [JsonProperty(PropertyName = "functions", Order = 55)]
        [JsonIgnore]
        public string ScriptFunctions { set; get; }
        /// <summary>
        /// JSON formatted local data storage
        /// </summary>
        [JsonProperty(PropertyName = "dataBag", Order = 60)]
        public string DataBag { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public JavascriptItemData()
        {
            DataType = this.GetType().ToString();
        }
    }
}
