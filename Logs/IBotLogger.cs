using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Logs
{
    public interface IBotLogger : ILogger
    {
        /// <summary>
        /// Log simple error message with detailed exception history
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        void LogException(string message, Exception exception);
    }
}
