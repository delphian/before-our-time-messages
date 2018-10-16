using BeforeOurTime.Models.Modules.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemAttributes
{
    public interface IAttributeRepo<T> : IRepository<T> where T : ItemAttribute
    {
        /// <summary>
        /// Read associated attributes of item
        /// </summary>
        /// <param name="item">Item that may have associated attributes</param>
        /// <param name="options">Options to customize how data is transacted from datastore</param>
        /// <returns>Attribute</returns>
        T Read(Item item, TransactionOptions options = null);
    }
}
