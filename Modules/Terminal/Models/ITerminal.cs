using BeforeOurTime.Models.Messages;
using BeforeOurTime.Models.Messages.Requests;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Modules.World.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BeforeOurTime.Models.Modules.Terminal.Models
{
    /// <summary>
    /// Define delgate that environment can use to update terminal
    /// </summary>
    /// <param name="terminal"></param>
    /// <param name="terminalUpdate"></param>
    public delegate void messageToTerminal(ITerminal terminal, IMessage terminalUpdate);
    /// <summary>
    /// Single generic connection used by the environment to communicate with clients
    /// </summary>
    public interface ITerminal
    {
        /// <summary>
        /// Send a message to the client
        /// </summary>
        /// <param name="message"></param>
        Task SendToClientAsync(IMessage message);
        /// <summary>
        /// Send a message to the environment
        /// </summary>
        /// <param name="request"></param>
        IResponse SendToApi(IRequest request);
        /// <summary>
        /// Get unique terminal identifier
        /// </summary>
        /// <returns></returns>
        Guid GetId();
        /// <summary>
        /// Get current status of terminal
        /// </summary>
        /// <returns></returns>
        TerminalStatus GetStatus();
        /// <summary>
        /// Set terminal status
        /// </summary>
        /// <returns></returns>
        ITerminal SetStatus(TerminalStatus status);
        /// <summary>
        /// Get the terminal data bag
        /// </summary>
        /// <returns></returns>
        Dictionary<string, string> GetDataBag();
        /// <summary>
        /// Get unique player identifier
        /// </summary>
        /// <returns></returns>
        Guid? GetPlayerId();
        /// <summary>
        /// Get unique account identifier of player
        /// </summary>
        /// <returns></returns>
        Guid? GetAccountId();
        /// <summary>
        /// Create a new character and attach
        /// </summary>
        /// <param name="name">Friendly name of character</param>
        /// <returns></returns>
        bool CreatePlayer(string name);
        /// <summary>
        /// Authenticate to use an account
        /// </summary>
        /// <param name="name">User name</param>
        /// <returns></returns>
        void Authenticate(Guid accountId);
        /// <summary>
        /// Attach to environment item as avatar
        /// </summary>
        /// <param name="itemId">Unique item identifier to use as terminal's avatar</param>
        /// <returns></returns>
        void Attach(Guid itemId);
        /// <summary>
        /// Get available characters for terminal attachment
        /// </summary>
        /// <returns>Detached items</returns>
        List<CharacterItem> GetAttachable();
        /// <summary>
        /// Subscribe to messages sent to terminals
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        ITerminal SubscribeMessageToTerminal(messageToTerminal callback);
        /// <summary>
        /// Clone the terminal
        /// </summary>
        /// <returns></returns>
        ITerminal Clone();
    }
}
