using BeforeOurTime.Models.Apis;
using BeforeOurTime.Models.Messages;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Terminals;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules
{
    public interface IModule
    {
        /// <summary>
        /// Get repositories declared by the module
        /// </summary>
        /// <returns></returns>
        List<ICrudModelRepository> GetRepositories();
        /// <summary>
        /// Get repository of specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetRepository<T>() where T : ICrudModelRepository;
        /// <summary>
        /// Get managers declared by the module
        /// </summary>
        /// <returns></returns>
        List<IModelManager> GetManagers();
        /// <summary>
        /// Get manager of specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetManager<T>();
        /// <summary>
        /// Get message identifiers of messages handled by module
        /// </summary>
        /// <returns></returns>
        List<Guid> RegisterForMessages();
        /// <summary>
        /// Handle a message
        /// </summary>
        /// <param name="api"></param>
        /// <param name="message"></param>
        /// <param name="terminal"></param>
        /// <param name="response"></param>
        IResponse HandleMessage(IMessage message, IApi api, ITerminal terminal, IResponse response);
        /// <summary>
        /// Initialize module
        /// </summary>
        /// <param name="repositories"></param>
        void Initialize(List<ICrudModelRepository> repositories);
    }
}
