using BeforeOurTime.Models.Exceptions;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeforeOurTime.Models.Json
{
    public class ItemViewModelJsonConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Object)
            {
                var itemViewModels = new Dictionary<Type, IItemProperty>();
                foreach(JProperty attributeObj in token)
                {
                    string viewModelTypeName = attributeObj.Name;
                    var itemViewModelType = Type.GetType(viewModelTypeName);
                    if (itemViewModelType == null)
                    {
                        throw new InvalidAttributeTypeException($"Unable to locate class for item data type: {viewModelTypeName}");
                    }
                    var itemViewModel = (IItemProperty)JsonConvert.DeserializeObject(attributeObj.First().ToString(), itemViewModelType);
                    itemViewModels.Add(itemViewModelType, itemViewModel);
                }
                return itemViewModels;
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
