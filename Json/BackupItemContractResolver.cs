using BeforeOurTime.Models.Modules.Core.Models.Items;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BeforeOurTime.Models.Json
{
    public class BackupItemContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(
            MemberInfo member,
            MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            if (property.UnderlyingName == "Children") {
                property.Ignored = false;
            }
            if (property.UnderlyingName == nameof(Item.ViewModels))
            {
                property.Ignored = true;
            }
            return property;
        }
    }
}
