using BeforeOurTime.Business.Apis;
using BeforeOurTime.Business.Apis.Terminals;
using BeforeOurTime.Models.Apis;
using BeforeOurTime.Models.Managers;
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
        List<ICrudDataRepository> GetRepositories();
        /// <summary>
        /// Get item managers declared by the module
        /// </summary>
        /// <returns></returns>
        List<IDataManager> GetManagers();
        /// <summary>
        /// Get item manager of specified type
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
        void Initialize(List<ICrudDataRepository> repositories);
    }
}
