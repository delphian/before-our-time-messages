﻿using BeforeOurTime.Models.Logs;
using BeforeOurTime.Models.Messages;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.Core.Dbs;
using BeforeOurTime.Models.Modules.Core.Messages.UseItem;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.Core.Models.Properties;
using BeforeOurTime.Models.Modules.Terminal.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Modules
{
    public delegate CoreUseItemEvent HandleItemCommand(ItemCommand itemCommand, Item origin);
    public delegate void ModuleManagerReadyDelegate();
    public delegate void ModuleReadyDelegate();
    public delegate void TickDelegate();
    /// <summary>
    /// Register through reflection and manage all modules
    /// </summary>
    public interface IModuleManager
    {
        /// <summary>
        /// Subscribe to be notified when all modules and managers have been loaded
        /// </summary>
        event ModuleManagerReadyDelegate ModuleManagerReadyEvent;
        /// <summary>
        /// Get API module that implements interface
        /// </summary>
        /// <typeparam name="T">Interface that API module must implement</typeparam>
        /// <returns>API module if found, otherwise null</returns>
        T GetModule<T>() where T : IModule;
        /// <summary>
        /// Get repository that implements interface
        /// </summary>
        /// <typeparam name="T">Interface that repository must implement</typeparam>
        /// <returns></returns>
        T GetRepository<T>() where T : ICrudModelRepository;
        /// <summary>
        /// Get item manager that implements interface
        /// </summary>
        /// <typeparam name="T">Interface that item manager must implement</typeparam>
        /// <returns></returns>
        T GetManager<T>() where T : IModelManager;
        /// <summary>
        /// Get item managers for an item
        /// </summary>
        /// <param name="item">Item to discover manager of</param>
        /// <returns></returns>
        IItemModelManager GetManager(Item item);
        /// <summary>
        /// Get all managers for an item type
        /// </summary>
        /// <param name="dataType">Item type that might be managable</param>
        /// <returns></returns>
        List<IItemModelManager> GetManagers(Type itemType);
        /// <summary>
        /// Get all managers for an item data type
        /// </summary>
        /// <param name="dataType">Item data type that might be managable</param>
        /// <returns></returns>
        List<IItemModelManager> GetManagersOfData(Type dataType);
        /// <summary>
        /// Get all managers for an item property
        /// </summary>
        /// <param name="propertyType">Property type that might be managable</param>
        /// <returns></returns>
        List<IItemModelManager> GetManagersOfProperty(Type propertyType);
        /// <summary>
        /// Get all modules that have registered handle a message
        /// </summary>
        /// <param name="messageId">Unique message identifier</param>
        /// <returns></returns>
        List<IModule> GetModulesForMessage(Guid messageId);
        /// <summary>
        /// Handle a message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="origin">Item that initiated request</param>
        /// <param name="response"></param>
        IResponse HandleMessage(
            IMessage message, 
            Item origin, 
            IResponse response);
        /// <summary>
        /// Get configuration
        /// </summary>
        /// <returns></returns>
        IConfiguration GetConfiguration();
        /// <summary>
        /// Get logger
        /// </summary>
        /// <returns></returns>
        IBotLogger GetLogger();
        /// <summary>
        /// Get item repository
        /// </summary>
        /// <returns></returns>
        IItemRepo GetItemRepo();
        /// <summary>
        /// Register to handle item commands when they are used
        /// </summary>
        /// <param name="itemCommandHandler"></param>
        void RegisterForItemCommands(
            HandleItemCommand itemCommandHandler);
        /// <summary>
        /// Execute a use item request
        /// </summary>
        /// <param name="origin">Item that initiated request</param>
        CoreUseItemResponse UseItem(
            CoreUseItemRequest request, 
            Item origin, 
            IResponse response);
        /// <summary>
        /// Allow handlers to take action every tick
        /// </summary>
        event TickDelegate Ticks;
    }
}
