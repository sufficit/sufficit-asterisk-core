using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;

namespace Sufficit.Asterisk.Manager.Events
{
    /// <summary>
    ///     A NewCallerIdEvent is triggered when the caller id of a channel changes.<br />
    ///     It is implemented in channel.c
    /// </summary>
    public class NewCallerIdEvent : AbstractChannelInfoEvent
    {
        private int cidCallingPres;
        private string cidCallingPresTxt;

        /// <summary>
        ///     Get the CallerId presentation/screening.
        /// </summary>
        public int CidCallingPresNumeric
        {
            get { return cidCallingPres; }
        }

        /// <summary>
        ///     Get/Sets the CallerId presentation/screening in the form "%d (%s)".
        /// </summary>
        public string CidCallingPres
        {
            get { return cidCallingPres + " (" + cidCallingPresTxt + ")"; }
            set
            {
                string s = value;
                if (s == null || s.Length == 0)
                    return;

                int spaceIdx = s.IndexOf(' ');
                if (spaceIdx <= 0)
                    spaceIdx = s.Length;
                try
                {
                    cidCallingPres = int.Parse(s.Substring(0, spaceIdx));
                }
                catch (FormatException)
                {
                    return;
                }
                if (s.Length > spaceIdx + 3)
                    cidCallingPresTxt = s.Substring(spaceIdx + 2, (s.Length - 1) - (spaceIdx + 2));
            }
        }
    }
}