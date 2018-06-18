using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Repository.Models.Messages.Requests.Look
{
    public class LookRequest : Request, IRequest
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LookRequest()
        {
            this.MessageId = new Guid("a50d4898-22f6-46c3-b23b-69b866593b13");
            this.MessageName = "Look Request";
        }
    }
}
