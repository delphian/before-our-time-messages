using BeforeOurTime.Business.Apis.Items.Attributes;
using BeforeOurTime.Models;
using BeforeOurTime.Models.Items;
using BeforeOurTime.Models.ItemAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeforeOurTime.Models.Modules.Core.Models.Data;

namespace BeforeOurTime.Models
{
    /// <summary>
    /// Manage model operations with user security
    /// </summary>
    public abstract class ModelManager<T> where T : Model
    {
        /// <summary>
        /// Determine if a model should be managed by this manager
        /// </summary>
        /// <param name="modelType"></param>
        /// <returns></returns>
        public bool IsManaging(Type modelType)
        {
            return modelType == typeof(T);
        }
    }
}
