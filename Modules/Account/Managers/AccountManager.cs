using BeforeOurTime.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeforeOurTime.Models.Modules.Account.Models.Data;
using BeforeOurTime.Models.Modules.Account.Dbs;
using BeforeOurTime.Models.Modules.Account.Models;
using BeforeOurTime.Models.Messages.Responses;
using BeforeOurTime.Models.Messages;
using BeforeOurTime.Models.Apis;
using BeforeOurTime.Models.Terminals;
using BeforeOurTime.Models.Messages.Requests.Create;
using BeforeOurTime.Models.Messages.Responses.Create;
using BeforeOurTime.Models.Messages.Events.Created;
using BeforeOurTime.Models.Messages.Requests.Login;
using BeforeOurTime.Models.Messages.Responses.Login;
using Microsoft.Extensions.Logging;
using BeforeOurTime.Models.Logs;

namespace BeforeOurTime.Models.Modules.Account.Managers
{
    public class AccountManager : ModelManager<AccountData>, IAccountManager
    {
        /// <summary>
        /// Centralized log messages
        /// </summary>
        private IBotLogger Logger { set; get; }
        private IAccountDataRepo AccountDataRepo { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountManager(
            IBotLogger logger,
            IItemRepo itemRepo,
            IAccountDataRepo accountDataRepo)
        {
            Logger = logger;
            AccountDataRepo = accountDataRepo;
        }
        /// <summary>
        /// Get all repositories declared by manager
        /// </summary>
        /// <returns></returns>
        public List<ICrudModelRepository> GetRepositories()
        {
            return new List<ICrudModelRepository>() { AccountDataRepo };
        }
        /// <summary>
        /// Get repository as interface
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetRepository<T>() where T : ICrudModelRepository
        {
            return GetRepositories().Where(x => x is T).Select(x => (T)x).FirstOrDefault();
        }
        /// <summary>
        /// Create a new account
        /// </summary>
        /// <param name="name">Login name</param>
        /// <param name="password">Login password</param>
        public AccountData Create(string name, string password)
        {
            var account = AccountDataRepo.Create(new List<AccountData>()
            {
                new AccountData()
                {
                    Name = name,
                    Password = BCrypt.Net.BCrypt.HashPassword(password)
                }
            }).FirstOrDefault();
            return account;
        }
        /// <summary>
        /// Authenticate a user name and password
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>User account if authenticated, otherwise null</returns>
        public AccountData Authenticate(string email, string password)
        {
            var authenRequest = new AuthenticationRequest()
            {
                PrincipalName = email,
                PrincipalPassword = password
            };
            var account = AccountDataRepo.Read(authenRequest);
            return account;
        }
        /// <summary>
        /// Handle a message
        /// </summary>
        /// <param name="api"></param>
        /// <param name="message"></param>
        /// <param name="terminal"></param>
        /// <param name="response"></param>
        public IResponse HandleCreateAccountRequest(IMessage message, IApi api, ITerminal terminal, IResponse response)
        {
            var request = message.GetMessageAsType<CreateAccountRequest>();
            response = new CreateAccountResponse()
            {
                _requestInstanceId = request.GetRequestInstanceId(),
            };
            try
            {
                var account = Create(request.Email, request.Password);
                ((CreateAccountResponse)response)._responseSuccess = true;
                ((CreateAccountResponse)response).CreatedAccountEvent = new CreatedAccountEvent()
                {
                    AccountId = account.Id
                };
            }
            catch (Exception e)
            {
                Logger.LogException($"While handling {request.GetMessageName()}", e);
                ((Response)response)._responseMessage = e.Message;
            }
            return response;
        }
        /// <summary>
        /// Handle a message
        /// </summary>
        /// <param name="api"></param>
        /// <param name="message"></param>
        /// <param name="terminal"></param>
        /// <param name="response"></param>
        public IResponse HandleLoginAccountRequest(IMessage message, IApi api, ITerminal terminal, IResponse response)
        {
            var request = message.GetMessageAsType<LoginRequest>();
            response = new LoginResponse()
            {
                _requestInstanceId = request.GetRequestInstanceId(),
            };
            try
            {
                var account = Authenticate(request.Email, request.Password);
                ((LoginResponse)response)._responseSuccess = true;
                ((LoginResponse)response).AccountId = account?.Id;
            }
            catch (Exception e)
            {
                Logger.LogException($"While handling {request.GetMessageName()}", e);
                ((Response)response)._responseMessage = e.Message;
            }
            return response;
        }
        /// <summary>
        /// Handle a message
        /// </summary>
        /// <param name="api"></param>
        /// <param name="message"></param>
        /// <param name="terminal"></param>
        /// <param name="response"></param>
        public IResponse HandleLogoutAccountRequest(IMessage message, IApi api, ITerminal terminal, IResponse response)
        {
            var request = message.GetMessageAsType<LogoutRequest>();
            response = new LogoutResponse()
            {
                _requestInstanceId = request.GetRequestInstanceId(),
            };
            try
            {
                ((LogoutResponse)response)._responseSuccess = true;
            }
            catch (Exception e)
            {
                Logger.LogException($"While handling {request.GetMessageName()}", e);
                ((Response)response)._responseMessage = e.Message;
            }
            return response;
        }
    }
}