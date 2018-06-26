using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Scripts.Delegates
{
    /// <summary>
    /// Base interface for all script delegate definitions
    /// </summary>
    /// <remarks>
    /// To declare a new script delegate definition create a new class that
    /// implements this interface
    /// </remarks>
    public interface IDelegate
    {
        /// <summary>
        /// Get script delegate function name
        /// </summary>
        /// <returns></returns>
        string GetFunctionName();
        /// <summary>
        /// Get script delegate argument type
        /// </summary>
        /// <returns></returns>
        Type GetArgumentType();
        /// <summary>
        /// Get script delegate return value type
        /// </summary>
        /// <returns></returns>
        Type GetReturnType();
        /// <summary>
        /// Get script function definition unique identifier
        /// </summary>
        /// <returns></returns>
        Guid GetId();
    }
}
