using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
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
        /// Same message request instance identifer copied from request
        /// </summary>
        [JsonProperty(PropertyName = "_requestInstanceId", Order = 100)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid _requestInstanceId { set; get; }
        /// <summary>
        /// The request that initiated this response was a success
        /// </summary>
        /// <returns></returns>
        [JsonProperty(PropertyName = "_responseSuccess", Order = 110)]
        public bool _responseSuccess { set; get; }
        /// <summary>
        /// Get the unique message request identifier
        /// </summary>
        /// <returns></returns>
        public Guid GetRequestInstanceId()
        {
            return _requestInstanceId;
        }
        /// <summary>
        /// The request that initiated this response was a success
        /// </summary>
        /// <returns></returns>
        public bool IsSuccess()
        {
            return _responseSuccess;
        }
    }
}
