using BeforeOurTime.Models.Modules.Core.Models.Properties;
using BeforeOurTime.Models.Primitives.Images;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules.Core.Models.Properties
{
    /// <summary>
    /// Make an item visible
    /// </summary>
    public class VisibleProperty : ItemProperty
    {
        /// <summary>
        /// Short name of item
        /// </summary>
        [JsonProperty(PropertyName = "name", Order = 20)]
        public string Name
        {
            set { _name = value; NotifyPropertyChanged("Name"); }
            get { return _name; }
        }
        private string _name { set; get; }
        /// <summary>
        /// Long description of item
        /// </summary>
        [JsonProperty(PropertyName = "description", Order = 30)]
        public string Description
        {
            set { _description = value; NotifyPropertyChanged("Description"); }
            get { return _description; }
        }
        private string _description { set; get; }
        /// <summary>
        /// Small image representation of item suitable as an icon
        /// </summary>
        [JsonProperty(PropertyName = "icon", Order = 40)]
        public Guid? Icon
        {
            set { _icon = value; NotifyPropertyChanged("Icon"); }
            get { return _icon; }
        }
        private Guid? _icon { set; get; }
        /// <summary>
        /// Compare this object to another object of same type
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Equals(VisibleProperty obj)
        {
            if (obj == null)
                return false;
            return (Name == obj.Name) && 
                   (Description == obj.Description) &&
                   (Icon == obj.Icon);
        }
        /// <summary>
        /// Get hash
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Description.GetHashCode();
        }
    }
}
