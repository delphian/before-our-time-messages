using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Requests
{
    /// <summary>
    /// A query from an item or terminal
    /// </summary>
    public interface IRequest : IMessage
    {
        /// <summary>
        /// Get the unique message request identifier
        /// </summary>
        /// <returns></returns>
        Guid GetRequestInstanceId();
    }
}
