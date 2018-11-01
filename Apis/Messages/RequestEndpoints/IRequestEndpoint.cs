using BeforeOurTime.Models.Apis;
using BeforeOurTime.Models.Messages.Requests;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.Terminal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Business.Apis.Messages.RequestEndpoints
{
    /// <summary>
    /// Handle one or more terminal requests
    /// </summary>
    public interface IRequestEndpoint
    {
        /// <summary>
        /// Register to handle a specific set of IO requests
        /// </summary>
        /// <returns></returns>
        List<Guid> RegisterForRequests();
        /// <summary>
        /// Handle terminal request
        /// </summary>
        /// <param name="api"></param>
        /// <param name="terminal"></param>
        /// <param name="request"></param>
        /// <param name="response"></param>
        IResponse HandleRequest(IApi api, ITerminal terminal, IRequest request, IResponse response);
    }
}
