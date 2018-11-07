using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeforeOurTime.Models
{
    /// <summary>
    /// Manage model operations with user security
    /// </summary>
    public abstract class ModelManager<T> where T : Model
    {
        /// <summary>
        /// Determine if a model type should be managed by this manager
        /// </summary>
        /// <param name="modelType"></param>
        /// <returns></returns>
        public virtual bool IsManaging(Type modelType)
        {
            return modelType == typeof(T);
        }
    }
}
