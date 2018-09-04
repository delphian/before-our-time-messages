using BeforeOurTime.Models.Items.Attributes;
using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Primitives.Images;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BeforeOurTime.Models.Items
{
    /// <summary>
    /// Core functionality and interface properties common to all items
    /// </summary>
    /// <remarks>
    /// Properties on all items should be considered a form of view model.
    /// The attributes property contains the actual models persisted to
    /// the data store and item specific logic which load values into
    /// the item properties.
    /// </remarks>
    public abstract class ItemBase : Model, IModel, INotifyPropertyChanged
    {
        /// <summary>
        /// Structure that subscriber must implement to recieve property updates
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Type of item, conveying it's primary purpose
        /// </summary>
        [JsonProperty(PropertyName = "type", Order = 10)]
        public ItemBaseType Type
        {
            set { _type = value; NotifyPropertyChanged("Type"); }
            get { return _type; }
        }
        private ItemBaseType _type { set; get; }
        /// <summary>
        /// Short name of item
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 20)]
        public string Name
        {
            set { _name = value; NotifyPropertyChanged("Name"); }
            get {
                string name = _name;
                Attributes?.ForEach((attribute) =>
                {
                    name = attribute.GetPropertyValue("Name", name) as string;
                });
                return name;
            }
        }
        private string _name { set; get; }
        /// <summary>
        /// Long description of item
        /// </summary>
        [JsonProperty(PropertyName = "description", Order = 30)]
        public string Description
        {
            set { _description = value; NotifyPropertyChanged("Description"); }
            get
            {
                string description = _description;
                Attributes?.ForEach((attribute) =>
                {
                    description = attribute.GetPropertyValue("Description", description) as string;
                });
                return description;
            }
        }
        private string _description { set; get; }
        /// <summary>
        /// Small image representation of item suitable as an icon
        /// </summary>
        [JsonProperty(PropertyName = "icon", Order = 40)]
        public Image Icon
        {
            set { _icon = value; NotifyPropertyChanged("Icon"); }
            get
            {
                Image icon = _icon;
                Attributes?.ForEach((attribute) =>
                {
                    icon = attribute.GetPropertyValue("Icon", icon) as Image;
                });
                return icon;
            }
        }
        private Image _icon { set; get; }
        /// <summary>
        /// Additional optional properties provided by attribute managers
        /// </summary>
        [JsonProperty(PropertyName = "attributes", Order = 10000)]
        [JsonConverter(typeof(ItemAttributeJsonConverter))]
        public List<ItemAttribute> Attributes
        {
            set { _attributes = value; NotifyPropertyChanged("Attributes"); }
            get { return _attributes; }
        }
        private List<ItemAttribute> _attributes { set; get; } = new List<ItemAttribute>();
        /// <summary>
        /// Determine if item has attribute
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
        /// Notify all subscribers that a property has been updated
        /// </summary>
        /// <param name="propertyName">Name of public property that has changed</param>
        protected void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
