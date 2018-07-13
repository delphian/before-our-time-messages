using BeforeOurTime.Models.Primitives.Images;
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
        public AttributePhysical()
        {
            AttributeType = this.GetType().ToString();
        }
        /// <summary>
        /// Modify the item name before it is returned
        /// </summary>
        /// <param name="name">Previous name of item</param>
        /// <returns></returns>
        public override string GetName(string name)
        {
            return Name;
        }
        /// <summary>
        /// Modify the item description before it is returned
        /// </summary>
        /// <param name="name">Previous description of item</param>
        /// <returns></returns>
        public override string GetDescription(string description)
        {
            return Description;
        }
        /// <summary>
        /// Modify the item image icon before it is returned
        /// </summary>
        /// <param name="imageIcon">Previous value of item image icon</param>
        /// <returns></returns>
        public override Image GetImageIcon(Image imageIcon)
        {
            return ImageIcon;
        }
    }
}
