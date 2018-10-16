using System;
using System.Collections.Generic;
using System.Text;
using BeforeOurTime.Models.Apis;
using BeforeOurTime.Models.Messages;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.Core.Models.Items;
using BeforeOurTime.Models.Terminals;

namespace BeforeOurTime.Models.Modules.World.Managers
{
    public interface IExitItemManager : IItemModelManager
    {
        /// <summary>
        /// Read all exits that target the same destination
        /// </summary>
        /// <param name="locationItem"></param>
        /// <returns></returns>
        List<Item> GetLocationExits(Guid destinationId);
        /// <summary>
        /// Use an exit
        /// </summary>
        /// <param name="api"></param>
        /// <param name="message"></param>
        /// <param name="terminal"></param>
        /// <param name="response"></param>
        IResponse HandleUseItemRequest(IMessage message, IApi api, ITerminal terminal, IResponse response);
    }
}
