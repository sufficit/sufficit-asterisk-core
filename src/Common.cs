using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Sufficit.Asterisk
{
    public static class Common
    {
        #region Manager API Constants 

        /// <summary> The hostname to use if none is provided.</summary>
        public const string DEFAULT_HOSTNAME = "localhost";

        /// <summary> The port to use if none is provided.</summary>
        public const int DEFAULT_PORT = 5038;

        /// <summary>
        ///     Line separator, should be implemented at asterisk server level in the future <br />
        ///     Because it leads with messages received from asterisk operational system and should use the same NewLine
        /// </summary>
        /// <remarks>* \n for Unix defaults <see cref="Environment.NewLine"></see></remarks>
        public const string LINE_SEPARATOR = "\n";

        public static Regex ASTERISK_VERSION = new Regex("^(?:Output: ){0,1}Asterisk\\s+\\D*([0-9]+\\.[0-9]+\\.[0-9]+|[1-9][0-9]-r[0-9]+|[0-9]+\\.[0-9]+-cert[0-9]).*$",
                          RegexOptions.Compiled | RegexOptions.IgnoreCase );

        public static Regex SHOW_VERSION_FILES_PATTERN = new Regex("^([\\S]+)\\s+Revision: ([0-9\\.]+)");
        public static char[] RESPONSE_KEY_VALUE_SEPARATOR = {':'};
        public static char[] MINUS_SEPARATOR = {'-'};
        public static char INTERNAL_ACTION_ID_DELIMITER = '#';
                
        #endregion

        #region AGI Constants 

        /// <summary> The default AGI bind port. </summary>
        public const int AGI_BIND_PORT = 4573;

        /// <summary> The default AGI thread pool size. </summary>
        public const int AGI_POOL_SIZE = 10;

        /// <summary> The default AGI bind address. </summary>
        public const string AGI_BIND_ADDRESS = "0.0.0.0";

        public const string AGI_DEFAULT_RETURN_VALUE = "AGI_RETVAL";
        public const string AGI_DEFAULT_RETURN_STATUS = "AGISTATUSMESSAGE";

        /// <summary>
        ///     Don't send HANGUP signal for AGI, must be setted before calls AGI by dialplan
        /// </summary>
        public const string AGI_SIGHUP = "AGISIGHUP";

        /// <summary>
        ///     If setted "yes", asterisk server exit agi process imediately after a channel hangup
        /// </summary>
        public const string AGI_EXIT_ON_HANGUP = "AGIEXITONHANGUP";

        public const char AGI_PARAMETER_SEPARATOR = '&';

        public const string AGI_DEFAULT_RESOURCE_BUNDLE_NAME = "fastagi-mapping.resources";
        public const string AGI_END_OF_PROPER_USAGE = "520 End of proper usage.";

        public const int AGI_DEFAULT_MAX_DIGITS = 1024;
        public const int AGI_DEFAULT_TIMEOUT = 0;

        public static Regex AGI_STATUS_PATTERN = new Regex("^(\\d{3})[ -]", RegexOptions.Compiled);
               

        public static Regex AGI_RESULT_PATTERN = new Regex("^200 result= *(\\S+)", RegexOptions.Compiled);
        public static Regex AGI_PARENTHESIS_PATTERN = new Regex("^200 result=\\S* +\\((.*)\\)", RegexOptions.Compiled);

        /// <summary>
        /// Named Groups (code,result,value)
        /// </summary>
        public static Regex AGI_PARENTHESIS_PATTERN_NAMED = new Regex(@"^(?<code>\d*) result=(?<result>\S*) +\((?<value>.*)\)", RegexOptions.Compiled);

        public static Regex AGI_ADDITIONAL_ATTRIBUTES_PATTERN = new Regex("^200 result=\\S* +(\\(.*\\) )?(.+)$", RegexOptions.Compiled);
        public static Regex AGI_ADDITIONAL_ATTRIBUTE_PATTERN = new Regex("(\\S+)=(\\S+)", RegexOptions.Compiled);
        public static Regex AGI_SYNOPSIS_PATTERN = new Regex("^\\s*Usage:\\s*(.*)\\s*$", RegexOptions.Compiled);
        public static Regex AGI_SCRIPT_PATTERN = new Regex("^([^\\?]*)\\?(.*)$");
        public static Regex AGI_PARAMETER_PATTERN = new Regex("^(.*)=(.*)$");

        #endregion
    }
}
