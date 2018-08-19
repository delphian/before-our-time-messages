using BeforeOurTime.Models.Exceptions;
using BeforeOurTime.Models.Json;
using BeforeOurTime.Models.Messages.Systems.Ping;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeforeOurTime.Models.Messages
{
    /// <summary>
    /// All intra-item, environment and terminal commucations are in the form of Message
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Map message Guids to model Types
        /// </summary>
        private static Dictionary<Guid, Type> MessageTypeDictionary { set; get; }
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
        /// Errors encountered when mapping message guids to class types
        /// </summary>
        public static List<string> GuidDictionaryErrors { set; get; } = new List<string>();
        /// <summary>
        /// Get dictionary map of message Guids to model Types
        /// </summary>
        /// <param name="reload"></param>
        /// <returns></returns>
        public static Dictionary<Guid, Type> GetMessageTypeDictionary(bool reload = false)
        {
            if (MessageTypeDictionary == null || MessageTypeDictionary.Count() == 0 || reload == true)
            {
                MessageTypeDictionary = new Dictionary<Guid, Type>();
                var interfaceType = typeof(IMessage);
                try
                {
                    var assemblyTypes = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(x => x.GetTypes())
                        .ToList();
                    assemblyTypes?
// Required because of UWP 'release' build runtime error when traversing GetAssemblies()
                        //.Where(x => interfaceType.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                        //.ToList()
                        .ForEach(x =>
                        {
                            try
                            {
// Required because of UWP 'release' build runtime error when traversing GetAssemblies()
                                if (typeof(Message).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract) {
                                    var instance = (IMessage)Activator.CreateInstance(x);
                                    var messageId = instance.GetMessageId();
                                    if (messageId != Guid.Empty)
                                    {
                                        MessageTypeDictionary.Add(instance.GetMessageId(), x);
                                    }
                                }
                            }
                            catch (Exception)
                            {
// Required because of UWP 'release' build runtime error when traversing GetAssemblies()
                                GuidDictionaryErrors.Add($"{x.FullName}");
                            }
                        });
                }
                catch (Exception e)
                {
                    throw new BotMessageException($"Unable to register message definitions", e);
                }
            }
            return MessageTypeDictionary;
        }
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
            if (!isOfType)
            {
                isOfType = (this is T);
            }
            if (!isOfType)
            {
                try
                {
                    Guid? messageId = (Guid?)typeof(T)?.GetField("_Id")?.GetValue(null);
                    isOfType = (this.GetMessageId() == messageId);
                }
                catch (Exception e)
                {
                    throw new MessageDefinitionInvalidException(typeof(T).ToString() + ": " + e.Message);
                }
            }
            return isOfType;
        }
        /// <summary>
        /// Upcast message as a derived type (that it already is!)
        /// </summary>
        /// <param name="attributeType">Message class type</param>
        /// <returns>Null if wrong message type</returns>
        public object GetMessageAsType(Type messageType)
        {
            object response = null;
            try
            {
                response = Convert.ChangeType(this, messageType);
            } catch(Exception)
            {
                // Swallow it
            }
            return response;
        }
        /// <summary>
        /// Upcast message as a serived type (that it already is!)
        /// </summary>
        /// <param name="messageTypeId">Unique message identifier</param>
        /// <returns></returns>
        public object GetMessageAsType(Guid messageTypeId)
        {
            var messageType = Message.GetMessageTypeDictionary()[GetMessageId()];
            return GetMessageAsType(messageType);
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
