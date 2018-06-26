using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.Scripts.Delegates
{
    /// <summary>
    /// Base class for all script delegate definitions
    /// </summary>
    /// <remarks>
    /// To declare a new script delegate definition create a new class that
    /// inherits this class
    /// </remarks>
    public class ScriptDelegate
    {
        /// <summary>
        /// Unique delegate identifier
        /// </summary>
        public Guid DelegateId { set; get; }
        /// <summary>
        /// Name of function in script to invoke
        /// </summary>
        public string DelegateFunctionName { set; get; }
        /// <summary>
        /// Script function's argument data type
        /// </summary>
        public Type DelegateArgumentType { set; get; }
        /// <summary>
        /// Script function's return data type
        /// </summary>
        public Type DelegateReturnType { set; get; }
        /// <summary>
        /// Get the unique delegate identifier
        /// </summary>
        /// <returns></returns>
        public Guid GetId()
        {
            return DelegateId;
        }
        /// <summary>
        /// Get the function name
        /// </summary>
        /// <returns></returns>
        public string GetFunctionName()
        {
            return DelegateFunctionName;
        }
        /// <summary>
        /// Get the script function argument type
        /// </summary>
        /// <returns></returns>
        public Type GetArgumentType()
        {
            return DelegateArgumentType;
        }
        /// <summary>
        /// Get the script function return type
        /// </summary>
        /// <returns></returns>
        public Type GetReturnType()
        {
            return DelegateReturnType;
        }
    }
}
