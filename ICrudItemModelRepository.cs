using BeforeOurTime.Models;
using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.Modules.Core.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models
{
    /// <summary>
    /// CRUD Data store operations
    /// </summary>
    public interface ICrudItemModelRepository : ICrudModelRepository
    {
        /// <summary>
        /// Get all unique item identifiers of managed items
        /// </summary>
        /// <returns></returns>
        List<Guid> GetItemIds();
    }
    /// <summary>
    /// CRUD Data store operations for a specified data type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICrudItemModelRepository<T> : ICrudModelRepository<T>, ICrudItemModelRepository where T : ItemData
    {
    }
}
