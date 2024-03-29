﻿using Sufficit.Asterisk.Manager.Events.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sufficit.Asterisk.Manager.Events
{
    public class AbstractConfbridgeEvent : ManagerEvent
    {
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+10+Documentation" target="_blank" alt="Asterisk 10 wiki docs">Asterisk 10</see>.
        /// </summary>
        public string Conference { get; set; }
    }
}
