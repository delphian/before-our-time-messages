using BeforeOurTime.Models.Json;
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
        /// Type of item, conveying it's primary purpose
        /// </summary>
        [JsonProperty(PropertyName = "type", Order = 10)]
        public ItemType Type
        {
            set { _type = value; NotifyPropertyChanged("Type"); }
            get { return _type; }
        }
        private ItemType _type { set; get; }
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
        /// If set, the terminal identifier which is in control of the item
        /// </summary>
        [JsonProperty(PropertyName = "terminalId", Order = 70)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid? TerminalId { set; get; }
        /// <summary>
        /// Additional optional properties provided by attribute managers
        /// </summary>
        [JsonProperty(PropertyName = "data", Order = 11000)]
        [JsonConverter(typeof(ItemDataJsonConverter))]
        public List<IItemData> Data
        {
            set { _data = value; NotifyPropertyChanged("Data"); }
            get { return _data; }
        }
        private List<IItemData> _data { set; get; } = new List<IItemData>();
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
        /// <summary>
        /// Convert item to a derrived type
        /// </summary>
        /// <typeparam name="T">Derrived item type</typeparam>
        /// <returns></returns>
        public T GetAsItem<T>() where T : Item, new()
        {
            var derrivedItem = new T
            {
                Data = Data,
                Children = Children,
                ChildrenIds = ChildrenIds,
                Id = Id,
                Parent = Parent,
                ParentId = ParentId
            };
            return derrivedItem;
        }
        /// <summary>
        /// Get a property by name
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public T GetProperty<T>(string propertyName) where T : ItemProperty, new()
        {
            // Allow item subclasses to fill their properties first
            var value = this.GetType().GetProperty(propertyName)?.GetValue(this, null);
            if (value == null)
            {
                // If we are running on the superclass then get values directly from data
                Data?.ForEach((data) =>
                {
                    value = data.GetProperty<T>(propertyName, value);
                });
            }
            return (T)value;
        }
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
