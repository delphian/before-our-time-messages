using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Items.Attributes
{
    /// <summary>
    /// Any item that possesses at least one of the five senses
    /// </summary>
    public class AttributePhysical : ItemAttribute, IItemAttribute
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
        public AttributePhysical()
        {
            AttributeType = this.GetType().ToString();
        }
    }
}
