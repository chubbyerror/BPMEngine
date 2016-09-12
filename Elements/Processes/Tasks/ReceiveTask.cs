﻿using Org.Reddragonit.BpmEngine.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Org.Reddragonit.BpmEngine.Elements.Processes.Tasks
{
    [XMLTag("bpmn", "receiveTask")]
    internal class ReceiveTask : ATask
    {
        public ReceiveTask(XmlElement elem, XmlPrefixMap map)
            : base(elem, map) { }
    }
}