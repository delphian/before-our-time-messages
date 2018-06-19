using BeforeOurTime.Models.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages
{
    /// <summary>
    /// All intra-item, environment and terminal commucations are in the form of Message
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Unique message identifier
        /// </summary>
        [JsonProperty(PropertyName = "messageId", Order = 10)]
        [JsonConverter(typeof(GuidJsonConverter))]
        public Guid MessageId { set; get; }
        /// <summary>
        /// Human friendly name describing message
        /// </summary>
        [JsonProperty(PropertyName = "messageName", Order = 20)]
        public string MessageName { set; get; }
        /// <summary>
        /// Get unique message identifier
        /// </summary>
        /// <returns></returns>
        public Guid GetMessageId()
        {
            return MessageId;
        }
        /// <summary>
        /// Get human friendly name describing message
        /// </summary>
        /// <returns></returns>
        public string GetMessageName()
        {
            return MessageName;
        }
        /// <summary>
        /// Determine if inherited message class if of the specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public bool IsMessageType<T>()
        {
            bool isOfType = (this.GetType() == typeof(T));
            if (isOfType == false)
            {
                Guid? messageId = (Guid?)typeof(T).GetProperty("_Id").GetValue(null);
                isOfType = (this.GetMessageId() == messageId);
            }
            return isOfType;
        }
        /// <summary>
        /// Upcast message as a derived type (that it already is!)
        /// </summary>
        /// <param name="attributeType"></param>
        /// <returns></returns>
        public object GetMessageAsType(Type messageType)
        {
            return Convert.ChangeType(this, messageType);
        }
        /// <summary>
        /// Upcast message as a derived type (that it already is!)
        /// </summary>
        /// <param name="attributeType"></param>
        /// <returns></returns>
        public T GetMessageAsType<T>()
        {
            return (T)GetMessageAsType(typeof(T));
        }
    }
}
