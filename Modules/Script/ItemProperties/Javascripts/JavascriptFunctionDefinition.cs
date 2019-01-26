using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Script.ItemProperties.Javascripts
{
    public class JavascriptFunctionDefinition
    {
        [JsonProperty(PropertyName = "prototype", Order = 50)]
        public string Prototype { set; get; }
        [JsonProperty(PropertyName = "global", Order = 60)]
        public bool Global { set; get; }
        [JsonProperty(PropertyName = "description", Order = 70)]
        public string Description { set; get; }
        [JsonProperty(PropertyName = "example", Order = 80)]
        public string Example { set; get; }
    }
}
