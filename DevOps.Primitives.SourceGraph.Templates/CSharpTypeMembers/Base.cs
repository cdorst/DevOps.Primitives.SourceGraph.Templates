﻿using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.SourceGraph.Templates.CSharpTypeMembers
{
    public class Base
    {
        public Base() { }
        public Base(string name, params string[] typeArguments)
        {
            Name = name;
            TypeArguments = typeArguments?.ToList();
        }

        public string Name { get; set; }
        public List<string> TypeArguments { get; set; }
    }
}
