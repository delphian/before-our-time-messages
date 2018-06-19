using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Requests.List
{
    public class ListAccountCharactersRequest : Request, IRequest
    {
        /// <summary>
        /// Our unique message identifier
        /// </summary>
        public static Guid _Id = new Guid("afea0f2d-83cf-48ce-ab0f-3555417bfab9");
        /// <summary>
        /// Unique account identifier of player to list characters of
        /// </summary>
        public Guid AccountId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ListAccountCharactersRequest()
        {
            this.MessageId = _Id;
            this.MessageName = "List Player Characters Request";
        }
    }
}
