using BeforeOurTime.Models.Exceptions;
using BeforeOurTime.Models.ItemAttributes;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Json
{
    public class ItemDataJsonConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Array)
            {
                List<IItemData> itemData = new List<IItemData>();
                foreach(JToken attributeObj in token)
                {
                    var itemDataTypeName = attributeObj["dataType"].ToString();
                    var itemDataType = Type.GetType(itemDataTypeName);
                    if (itemDataType == null)
                    {
                        throw new InvalidAttributeTypeException($"Unable to locate class for item data type: {itemDataTypeName}");
                    }
                    var data = (IItemData)JsonConvert.DeserializeObject(attributeObj.ToString(), itemDataType);
                    itemData.Add(data);
                }
                return itemData;
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
