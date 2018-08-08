using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Json
{
    /// <summary>
    /// JSON support for Guid and list of Guids
    /// </summary>
    public class GuidJsonConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            Guid guidOutput;
            if (token.Type == JTokenType.String && (true == Guid.TryParse(token.ToString(), out guidOutput)))
            {
                return guidOutput;
            }
            if (token.Type == JTokenType.Array)
            {
                var Guids = new List<Guid>();
                foreach(var tokenElement in token)
                {
                    if (true == Guid.TryParse(tokenElement.ToString(), out guidOutput))
                    {
                        Guids.Add(guidOutput);
                    }
                }
                return Guids;
            }
            Guid? guidToken = null;
            return guidToken;
        }
        public override bool CanWrite => false;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException("There is no writing implemantation");
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }
    }
}
