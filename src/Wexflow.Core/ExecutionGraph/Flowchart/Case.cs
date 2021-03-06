﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wexflow.Core.ExecutionGraph.Flowchart
{
    public class Case
    {
        public string Value { get; private set; }
        public Node[] Nodes { get; private set; }

        public Case(string val, IEnumerable<Node> nodes)
        {
            Value = val;
            if (nodes != null) Nodes = nodes.ToArray();
        }
    }
}
