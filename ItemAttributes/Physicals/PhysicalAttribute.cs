using BeforeOurTime.Models.Primitives.Images;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemAttributes.Physicals
{
    /// <summary>
    /// Any item that possesses at least one of the five senses
    /// </summary>
    public class PhysicalAttribute : ItemAttribute, IItemAttribute
    {
        /// <summary>
        /// One, two, or three word short description of item
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// A long description of the item. Include many sensory experiences
        /// </summary>
        public string Description { set; get; }
        /// <summary>
        /// Item image suitable for display as an icon
        /// </summary>
        public Image ImageIcon { set; get; }
        /// <summary>
        /// Height
        /// </summary>
        public int Height { set; get; }
        /// <summary>
        /// Width
        /// </summary>
        public int Width { set; get; }
        /// <summary>
        /// Depth
        /// </summary>
        public int Depth { set; get; }
        /// <summary>
        /// Weight
        /// </summary>
        public int Weight { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public PhysicalAttribute()
        {
            AttributeType = this.GetType().ToString();
        }
    }
}
