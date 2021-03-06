﻿using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Models.Items
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
    public class Item : Model, IModel, INotifyPropertyChanged
    {
        /// <summary>
        /// Structure that subscriber must implement to recieve property updates
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Unique item type identifier
        /// </summary>
        [JsonProperty(PropertyName = "typeId", Order = 40)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid? TypeId { set; get; }
        /// <summary>
        /// Parent item
        /// </summary>
        [JsonProperty(PropertyName = "parentId", Order = 50)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid? ParentId { set; get; }
        [JsonIgnore]
        public Item Parent { set; get; }
        /// <summary>
        /// List of children item ids
        /// </summary>
        [JsonProperty(PropertyName = "childrenIds", Order = 60)]
        public List<Guid> ChildrenIds { set; get; }
        [JsonIgnore]
        [JsonProperty(PropertyName = "children", Order = 12000)]
        public List<Item> Children { set; get; }
        /// <summary>
        /// Additional optional properties provided by attribute managers
        /// </summary>
        [JsonProperty(PropertyName = "data", Order = 11500)]
        [JsonConverter(typeof(ItemDataJsonConverter))]
        public List<IItemData> Data
        {
            set { _data = value; NotifyPropertyChanged("Data"); }
            get { return _data; }
        }
        private List<IItemData> _data { set; get; } = new List<IItemData>();
        /// <summary>
        /// View model properties
        /// </summary>
        [JsonProperty(PropertyName = "properties", Order = 11000)]
        [JsonConverter(typeof(ItemViewModelJsonConverter))]
        public Dictionary<Type, IItemProperty> Properties
        {
            get { return _properties; }
            set { _properties = value; NotifyPropertyChanged("Properties"); }
        }
        private Dictionary<Type, IItemProperty> _properties { set; get; } = new Dictionary<Type, IItemProperty>();
        #region View Model Property Getters
        /// <summary>
        /// Determine if item has a specific view model
        /// </summary>
        /// <returns></returns>
        public bool HasProperty(Type viewModelType)
        {
            return Properties.ContainsKey(viewModelType);
        }
        /// <summary>
        /// Determin if item has a specific view model
        /// </summary>
        /// <returns></returns>
        public bool HasProperty<T>()
        {
            return HasProperty(typeof(T));
        }
        /// <summary>
        /// Set item property view model
        /// </summary>
        /// <param name="viewModelType"></param>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public Item AddProperty(Type itemPropertyType, IItemProperty viewModel)
        {
            if (Properties.ContainsKey(itemPropertyType))
            {
                Properties[itemPropertyType] = viewModel;
            }
            else
            {
                Properties.Add(itemPropertyType, viewModel);
            }
            return this;
        }
        public Item AddProperty(IItemProperty property)
        {
            return AddProperty(property.GetType(), property);
        }
        public Item AddProperty(List<IItemProperty> properties)
        {
            properties.ForEach((property) =>
            {
                AddProperty(property);
            });
            return this;
        }
        /// <summary>
        /// Get view model property of specified name or type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public T GetProperty<T>(string propertyName = null) where T : ItemProperty, new()
        {
            object value = null;
            // Allow item subclasses to fill their properties first. If
            // property name is specified then use reflection to locate
            // value. Otherwise send to subclass datas for type comparison.
            if (propertyName != null)
            {
                value = this.GetType().GetProperty(propertyName)?.GetValue(this, null);
            }
            if (value == null)
            {
                value = (HasProperty<T>()) ?
                    Convert.ChangeType(Properties[typeof(T)], typeof(T)) :
                    null;
            }
            return (T)value;
        }
        #endregion
        #region Item Data Getters
        /// <summary>
        /// Determine if item has data
        /// </summary>
        /// <returns></returns>
        public bool HasData(Type dataType)
        {
            return Data.Any(x => x.GetType() == dataType);
        }
        /// <summary>
        /// Determin if item has data
        /// </summary>
        /// <returns></returns>
        public bool HasData<T>()
        {
            return HasData(typeof(T));
        }
        /// <summary>
        /// Get data from the item
        /// </summary>
        /// <param name="dataType"></param>
        /// <returns></returns>
        public object GetData(Type dataType)
        {
            var data = Data.Where(x => x.GetType() == dataType).FirstOrDefault();
            return Convert.ChangeType(data, dataType);
        }
        /// <summary>
        /// Get data from the item
        /// </summary>
        /// <param name="dataType"></param>
        /// <returns></returns>
        public T GetData<T>()
        {
            return (T)GetData(typeof(T));
        }
        #endregion
        /// <summary>
        /// Notify all subscribers that a property has been updated
        /// </summary>
        /// <param name="propertyName">Name of public property that has changed</param>
        public void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    /// <summary>
    /// Extension functions for List<Item>
    /// </summary>
    public static class ListItemExtensions
    {
        /// <summary>
        /// Flatten out an Item tree and remove all children
        /// </summary>
        /// <param name="childItems"></param>
        /// <returns></returns>
        public static List<Item> Flatten(this List<Item> items)
        {
            var flatItems = items
                .Where(x => x.Children != null)
                .SelectMany(x => x.Children.Flatten())
            .Concat(items)
            .GroupBy(x => x.Id)
            .Select(grp => grp.First()).ToList();
            flatItems.ForEach(item =>
            {
                item.Children = new List<Item>();
            });
            return flatItems;
        }
    }
}
