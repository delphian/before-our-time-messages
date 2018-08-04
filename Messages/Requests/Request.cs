using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Requests
{
    /// <summary>
    /// A query from an item or terminal
    /// </summary>
    public class Request : Message
    {
        /// <summary>
        /// Random unique message identifier. Same identifer will be used in response
        /// </summary>
        public Guid _requestInstanceId { set; get; } = Guid.NewGuid();
        /// <summary>
        /// Get the unique message request identifier
        /// </summary>
        /// <returns></returns>
        public Guid GetRequestInstanceId()
        {
            return _requestInstanceId;
        }
    }
}
