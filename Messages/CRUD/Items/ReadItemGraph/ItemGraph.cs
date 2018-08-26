using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.CRUD.Items.ReadItemGraph
{
    /// <summary>
    /// Item with reduced properties tailored toward presenting an item graph
    /// </summary>
    public class ItemGraph
    {
        /// <summary>
        /// Unique item identifier
        /// </summary>
        public Guid Id { set; get; }
        /// <summary>
        /// Name of item
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// Child items
        /// </summary>
        public List<ItemGraph> Children { set; get; } = new List<ItemGraph>();
    }
}
