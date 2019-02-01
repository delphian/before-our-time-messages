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
        /// Prevent the script from executing
        /// </summary>
        [JsonProperty(PropertyName = "disabled", Order = 65)]
        public bool Disabled { set; get; }
        /// <summary>
        /// Number of thrown errors encountered while script was running
        /// </summary>
        [JsonProperty(PropertyName = "errCount", Order = 70)]
        public int ErrCount { set; get; }
        /// <summary>
        /// Thrown errors while script is executing
        /// </summary>
        [JsonProperty(PropertyName = "errDescriptions", Order = 75)]
        public string ErrDescriptions { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public JavascriptItemData()
        {
            DataType = this.GetType().ToString();
        }
    }
}
