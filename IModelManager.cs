using BeforeOurTime.Models;
using BeforeOurTime.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models
{
    public interface IModelManager
    {
        /// <summary>
        /// Determine if an attribute type should be managed by this manager
        /// </summary>
        /// <param name="attributeType"></param>
        /// <returns></returns>
        bool IsManaging(Type attributeType);
        /// <summary>
        /// Get all repositories declared by manager
        /// </summary>
        /// <returns></returns>
        List<ICrudModelRepository> GetRepositories();
        /// <summary>
        /// Get repository as interface
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetRepository<T>() where T : ICrudModelRepository;
    }
}
