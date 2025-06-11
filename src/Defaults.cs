using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Sufficit.Asterisk
{
    public static class Defaults
    {
        /// <summary>
        ///     Used even for Manager as for Gateway interfaces.
        /// </summary>
        public static readonly CultureInfo CultureInfo = new CultureInfo("en-US", false);
    }
}
