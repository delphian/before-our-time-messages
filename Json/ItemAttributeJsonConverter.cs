using BeforeOurTime.Models.Items.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Json
{
    public class ItemAttributeJsonConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Array)
            {
                List<ItemAttribute> itemAttributes = new List<ItemAttribute>();
                foreach(JToken attributeObj in token)
                {
                    var itemAttributeType = Type.GetType(attributeObj["attributeType"].ToString());
                    var itemAttribute = (ItemAttribute)JsonConvert.DeserializeObject(attributeObj.ToString(), itemAttributeType);
                    itemAttributes.Add(itemAttribute);
                }
                return itemAttributes;
            }
            return null;
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
