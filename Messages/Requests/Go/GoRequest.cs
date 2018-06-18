using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Messages.Requests.Go
{
    public class GoRequest : Request, IRequest
    {
        /// <summary>
        /// Unique exit item identifier
        /// </summary>
        public Guid ItemId { set; get; }
        /// <summary>
        /// Constructor
        /// </summary>
        public GoRequest()
        {
            this.MessageId = new Guid("cee49fc3-a342-4720-8887-db7a71f14fa8");
            this.MessageName = "Go Request";
        }
    }
}
