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
        public int Height
        {
            set { _height = value; NotifyPropertyChanged("Height"); }
            get { return _height; }
        }
        private int _height { set; get; }
        /// <summary>
        /// Width
        /// </summary>
        public int Width
        {
            set { _width = value; NotifyPropertyChanged("Width"); }
            get { return _width; }
        }
        private int _width { set; get; }
        /// <summary>
        /// Depth
        /// </summary>
        public int Depth
        {
            set { _depth = value; NotifyPropertyChanged("Depth"); }
            get { return _depth; }
        }
        private int _depth { set; get; }
        /// <summary>
        /// Weight
        /// </summary>
        public int Weight
        {
            set { _weight = value; NotifyPropertyChanged("Weight"); }
            get { return _weight; }
        }
        public int _weight { set; get; }
    }
}
