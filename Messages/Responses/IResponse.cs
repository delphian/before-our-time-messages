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
        /// Set the unique message request identifier
        /// </summary>
        /// <returns></returns>
        IResponse SetRequestInstanceId(Guid value);
        /// <summary>
        /// Get the unique message request identifier
        /// </summary>
        /// <returns></returns>
        Guid GetRequestInstanceId();
        /// <summary>
        /// Set the success property based on success of request
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        IResponse SetSuccess(bool value);
        /// <summary>
        /// Set the meta message
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        IResponse SetMessage(string message);
        /// <summary>
        /// The request that initiated this response was a success
        /// </summary>
        /// <returns></returns>
        bool IsSuccess();
    }
}
