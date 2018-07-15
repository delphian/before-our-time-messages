using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Accounts.Authentication
{
    /// <summary>
    /// User credentials that may be used for an authentication request
    /// </summary>
    public class AuthenticationRequest
    {
        /// <summary>
        /// Account name
        /// </summary>
        public string PrincipalName { set; get; }
        /// <summary>
        /// Account password
        /// </summary>
        public string PrincipalPassword { set; get; }
    }
}
