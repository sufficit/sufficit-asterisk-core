using System;
using System.Collections.Generic;
using System.Text;

namespace Sufficit.Asterisk.FastAGI
{
    /// <summary>
    /// Indicates that is an AGI Script with a valid route 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class AGIScriptAttribute : Attribute
    {
        public AGIScriptAttribute(string route)
        {
            if (string.IsNullOrWhiteSpace(route))
                throw new ArgumentNullException(nameof(route));

            Route = route;
        }

        /// <summary>
        /// Route to access this script
        /// </summary>
        public string Route { get; }

        /// <summary>
        /// Load and listen this script at startup
        /// </summary>
        public bool StartUp { get; set; }
    }
}
