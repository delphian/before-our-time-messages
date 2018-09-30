using BeforeOurTime.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeforeOurTime.Models.Modules.Account.Models.Data;
using BeforeOurTime.Models.Modules.Account.Dbs;
using BeforeOurTime.Models.Modules.Account.Models;

namespace BeforeOurTime.Models.Modules.Account.Managers
{
    public class AccountManager : ModelManager<AccountData>, IAccountManager
    {
        private IAccountDataRepo AccountDataRepo { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public AccountManager(
            IItemRepo itemRepo,
            IAccountDataRepo accountDataRepo)
        {
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
    }
}
