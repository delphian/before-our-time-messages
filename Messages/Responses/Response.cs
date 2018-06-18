using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Responses
{
    /// <summary>
    /// A response may be generated as the result of a request
    /// </summary>
    /// <remarks>
    /// All responses must inherit this base class
    /// </remarks>
    public class Response : Message, IResponse
    {
        /// <summary>
        /// The request that initiated this response was a success
        /// </summary>
        /// <returns></returns>
        public bool ResponseSuccess { set; get; }
        /// <summary>
        /// The request that initiated this response was a success
        /// </summary>
        /// <returns></returns>
        public bool IsSuccess()
        {
            return ResponseSuccess;
        }
    }
}
