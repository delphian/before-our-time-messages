using BeforeOurTime.Business.Apis.Messages;
using BeforeOurTime.Business.Apis.Terminals;
using BeforeOurTime.Models.Logs;
using BeforeOurTime.Models.Modules;
using BeforeOurTime.Models.Modules.Core.Managers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BeforeOurTime.Models.Apis
{
    /// <summary>
    /// Interface to the core environment
    /// </summary>
    public interface IApi
    {
        IBotLogger GetLogger();
        IConfiguration GetConfiguration();
        IMessageManager GetMessageManager();
        IItemManager GetItemManager();
        ITerminalManager GetTerminalManager();
        IModuleManager GetModuleManager();
        /// <summary>
        /// (awaitable) Execute all item scripts that desire a regular periodic event
        /// </summary>
        /// <param name="delayMs">Interval between ticks</param>
        /// <param name="ct">Cancelation token for ticks</param>
            //        Task TickAsync(int delayMs, CancellationToken ct);
            /// <summary>
            /// Deliver messages to their recipient items and execute each item script
            /// </summary>
            /// <param name="delayMs">Interval between ticks</param>
            /// <param name="ct">Cancelation token for ticks</param>
            //Task DeliverMessagesAsync(
            //    int delayMs,
            //    CancellationToken ct,
            //    IConfiguration config,
            //    IServiceProvider serviceProvider);
    }
}
