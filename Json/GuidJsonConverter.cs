using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Json
{
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
