﻿using BeforeOurTime.Models.Messages;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Modules.Terminal.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BeforeOurTime.Models.Modules.Terminal.Managers
{
    public interface ITerminalManager : IModelManager
    {
        /// <summary>
        /// Create a new terminal
        /// </summary>
        /// <param name="serverName">Name of server module</param>
        /// <param name="address">IPAddress of connection</param>
        /// <returns></returns>
        ITerminal RequestTerminal(string serverName, IPEndPoint address);
        /// <summary>
        /// Send a message to a specific terminal
        /// </summary>
        /// <param name="terminalId">Unique terminal identifier</param>
        /// <param name="environmentUpdate"></param>
        void SendToTerminalId(Guid terminalId, IMessage environmentUpdate);
        /// <summary>
        /// Destroy a terminal and notify subscribers
        /// </summary>
        /// <param name="terminal">A single remote connection</param>
        ITerminalManager DestroyTerminal(ITerminal terminal);
        /// <summary>
        /// Get list of all active terminals
        /// </summary>
        /// <returns></returns>
        List<ITerminal> GetTerminals();
        /// <summary>
        /// Append attribute to base item when it is loaded
        /// </summary>
        /// <param name="item">Base item just read from datastore</param>
        void OnItemRead(Item item);
    }
}
