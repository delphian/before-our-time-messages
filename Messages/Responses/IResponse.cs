using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Responses
{
    /// <summary>
    /// A response may be generated as the result of a request
    /// </summary>
    /// <remarks>
    /// All responses must implement this base interface
    /// </remarks>
    public interface IResponse : IMessage
    {
        /// <summary>
        /// Get the unique message request identifier
        /// </summary>
        /// <returns></returns>
        Guid GetRequestInstanceId();
        /// <summary>
        /// The request that initiated this response was a success
        /// </summary>
        /// <returns></returns>
        bool IsSuccess();
    }
}
