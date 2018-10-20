using BeforeOurTime.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models
{
    /// <summary>
    /// CRUD Data store operations
    /// </summary>
    public interface ICrudModelRepository : IModelRepository
    {
    }
    /// <summary>
    /// CRUD Data store operations for a specified data type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICrudModelRepository<T> : ICrudModelRepository where T : Model
    {
        /// <summary>
        /// Create multiple models
        /// </summary>
        /// <remarks>
        /// All other forms of create should call this one
        /// </remarks>
        /// <param name="models">List of models to create</param>
        /// <returns>List of models created</returns>
        List<T> Create(List<T> models);
        /// <summary>
        /// Create single model
        /// </summary>
        /// <param name="model">Model to create</param>
        /// <returns>Model created</returns>
        T Create(T model);
        /// <summary>
        /// Read multiple models
        /// </summary>
        /// <remarks>
        /// All other forms of read should call this one
        /// </remarks>
        /// <param name="ids">List of unique model identifiers</param>
        /// <returns>List of models</returns>
        List<T> Read(List<Guid> ids);
        /// <summary>
        /// Read single model
        /// </summary>
        /// <param name="id">Unique model identifier</param>
        /// <returns>Single model</returns>
        T Read(Guid id);
        /// <summary>
        /// Read all models, or specify an offset and limit
        /// </summary>
        /// <param name="offset">Number of model records to skip</param>
        /// <param name="limit">Maximum number of model records to return</param>
        /// <returns>List of models</returns>
        List<T> Read(int? offset = null, int? limit = null);
        /// <summary>
        /// Update multiple models
        /// </summary>
        /// <remarks>
        /// All other forms of update should call this one
        /// </remarks>
        /// <param name="models">List of models to update</param>
        /// <returns>List of models updated</returns>
        List<T> Update(List<T> models);
        /// <summary>
        /// Update single model
        /// </summary>
        /// <param name="model">Model to update</param>
        /// <returns>Updated model</returns>
        T Update(T model);
        /// <summary>
        /// Delete multiple models
        /// </summary>
        /// <remarks>
        /// All other forms of delete should call this one
        /// </remarks>
        /// <param name="models">List of models to delete</param>
        void Delete(List<T> models);
        /// <summary>
        /// Delete single model
        /// </summary>
        /// <param name="model">Model to delete</param>
        void Delete(T model);
        /// <summary>
        /// Delete all models
        /// </summary>
        void Delete();
    }
}
