using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Items.Attributes;
using BeforeOurTime.Models.Scripts.Delegates;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeforeOurTime.Models.Items
{
    /// <summary>
    /// Generic item
    /// </summary>
    public class Item : Model
    {
        /// <summary>
        /// Structure that subscriber must implement to recieve property updates
        /// </summary>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        private string _name { set; get; }
        /// <summary>
        /// Short (less than 3) word description of item
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 22)]
        public string Name
        {
            get
            {
                string name = _name;
                Attributes?.ForEach((attribute) =>
                {
                    name = attribute.GetName(name);
                });
                return name;
            }
            set { _name = value; NotifyPropertyChanged("Name"); }
        }
        private string _description { set; get; }
        /// <summary>
        /// Long detailed description of item while in a generic state
        /// </summary>
        [JsonProperty(PropertyName = "description", Order = 23)]
        public string Description
        {
            get
            {
                string description = _description;
                Attributes?.ForEach((attribute) =>
                {
                    description = attribute.GetDescription(description);
                });
                return description;
            }
            set { _description = value; NotifyPropertyChanged("Description"); }
        }
        /// <summary>
        /// NON unique pre-defined identifier that may be referenced by a third party
        /// </summary>
        /// <remarks>
        /// Used to identity a type of item. There may be many spoons each with
        /// their own unique Uuid. If any spoon will do, and they all share the
        /// 'spoon' UuidType, then check against the item's UuidType instead of 
        /// Uuid
        /// </remarks>
        [JsonProperty(PropertyName = "uuidType", Order = 30)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid UuidType { set; get; }
        /// <summary>
        /// Javascript that provides custom properties and their management
        /// </summary>
        [JsonProperty(PropertyName = "script", Order = 35)]
        public string Script { set; get; }
        /// <summary>
        /// Delegates that an item script implements
        /// </summary>
        [JsonProperty(PropertyName = "delegateLinks", Order = 40)]
        public List<ScriptDelegateItemLink> DelegateLinks { set; get; }
        /// <summary>
        /// Data bag for script to persist variables
        /// </summary>
        /// <remarks>
        /// Probably, but not always, a monolothic JSON object
        /// </remarks>
        [JsonProperty(PropertyName = "data", Order = 45)]
        public string Data { set; get; }
        /// <summary>
        /// Unique parent item identifier and navigation property
        /// </summary>
        [JsonProperty(PropertyName = "parentId", Order = 50)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid? ParentId { set; get; }
        [JsonIgnore]
        public virtual Item Parent { set; get; }
        /// <summary>
        /// Items contained by this item
        /// </summary>
        [JsonIgnore]
        public List<Item> Children = new List<Item>();
        /// <summary>
        /// Additional optional properties provided by attribute managers
        /// </summary>
        [JsonProperty(PropertyName = "attributes", Order = 60)]
        [JsonConverter(typeof(ItemAttributeJsonConverter))]
        public List<ItemAttribute> Attributes = new List<ItemAttribute>();
        /// <summary>
        /// Determin if item has attribute
        /// </summary>
        /// <returns></returns>
        public bool HasAttribute(Type attributeType)
        {
            return Attributes.Any(x => x.GetType() == attributeType);
        }
        /// <summary>
        /// Determin if item has attribute
        /// </summary>
        /// <returns></returns>
        public bool HasAttribute<T>()
        {
            return HasAttribute(typeof(T));
        }
        /// <summary>
        /// Get an attribute from the item
        /// </summary>
        /// <example>
        /// var location = (AttributeLocation)item.GetAttribute(typeof(AttributeLocation));
        /// </example>
        /// <param name="attributeType"></param>
        /// <returns></returns>
        public object GetAttribute(Type attributeType)
        {
            var attribute = Attributes.Where(x => x.GetType() == attributeType).FirstOrDefault();
            return Convert.ChangeType(attribute, attributeType);
        }
        /// <summary>
        /// Get an attribute from the item
        /// </summary>
        /// <example>
        /// var location = item.GetAttribute<AttributeLocation>();
        /// </example>
        /// <param name="attributeType"></param>
        /// <returns></returns>
        public T GetAttribute<T>()
        {
            return (T)GetAttribute(typeof(T));
        }
        /// <summary>
        /// Clone the item
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        /// <summary>
        /// Notify all subscribers that a property has been updated
        /// </summary>
        /// <param name="propertyName">Name of public property that has changed</param>
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
