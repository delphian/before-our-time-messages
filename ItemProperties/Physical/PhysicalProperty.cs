using BeforeOurTime.Models.Modules.Core.Models.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemProperties.Physical
{
    /// <summary>
    /// Weight, height, size, and other physical descriptions
    /// </summary>
    public class PhysicalProperty : ItemProperty
    {
        /// <summary>
        /// Height
        /// </summary>
        [JsonProperty(PropertyName = "height", Order = 1000)]
        public int Height
        {
            set { _height = value; NotifyPropertyChanged("Height"); }
            get { return _height; }
        }
        private int _height { set; get; }
        /// <summary>
        /// Width
        /// </summary>
        [JsonProperty(PropertyName = "width", Order = 1100)]
        public int Width
        {
            set { _width = value; NotifyPropertyChanged("Width"); }
            get { return _width; }
        }
        private int _width { set; get; }
        /// <summary>
        /// Depth
        /// </summary>
        [JsonProperty(PropertyName = "depth", Order = 1200)]
        public int Depth
        {
            set { _depth = value; NotifyPropertyChanged("Depth"); }
            get { return _depth; }
        }
        private int _depth { set; get; }
        /// <summary>
        /// Weight
        /// </summary>
        [JsonProperty(PropertyName = "weight", Order = 1300)]
        public int Weight
        {
            set { _weight = value; NotifyPropertyChanged("Weight"); }
            get { return _weight; }
        }
        public int _weight { set; get; }
        /// <summary>
        /// Compare this object to another object of same type
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Equals(PhysicalProperty obj)
        {
            if (obj == null)
                return false;
            return (Height == obj.Height) &&
                   (Width == obj.Width) &&
                   (Depth == obj.Depth) &&
                   (Weight == obj.Weight);
        }
        /// <summary>
        /// Get hash
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Height.GetHashCode() ^ Width.GetHashCode();
        }
    }
}
