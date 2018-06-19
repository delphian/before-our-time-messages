using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages
{
    /// <summary>
    /// All intra-item, environment and terminal commucations are in the form of IMessage
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Get unique message identifier
        /// </summary>
        /// <returns></returns>
        Guid GetMessageId();
        /// <summary>
        /// Get human friendly name describing message
        /// </summary>
        /// <returns></returns>
        string GetMessageName();
        /// <summary>
        /// Determine if inherited message class if of the specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        bool IsMessageType<T>();
        /// <summary>
        /// Upcast message as a derived type (that it already is!)
        /// </summary>
        /// <param name="attributeType"></param>
        /// <returns></returns>
        object GetMessageAsType(Type messageType);
        /// <summary>
        /// Upcast message as a derived type (that it already is!)
        /// </summary>
        /// <param name="attributeType">Message class type</param>
        /// <returns></returns>
        T GetMessageAsType<T>();
        /// <summary>
        /// Upcast message as a serived type (that it already is!)
        /// </summary>
        /// <param name="messageTypeId">Unique message identifier</param>
        /// <returns></returns>
        object GetMessageAsType(Guid messageTypeId);
    }
}
