﻿using System.Collections.Generic;

namespace DevOps.Primitives.SourceGraph.Templates.CSharpTypeMembers
{
    public class Method
    {
        public Method() { }
        public Method(string name, string type, string comment, string arrowClauseExpression)
        {
            ArrowClauseExpression = arrowClauseExpression;
            Comment = comment;
            Modifiers = "public";
            Name = name;
            Type = type;
        }

        public string ArrowClauseExpression { get; set; }
        public List<Attribute> Attributes { get; set; }
        public List<string> Block { get; set; }
        public string Comment { get; set; }
        public string Modifiers { get; set; }
        public string Name { get; set; }
        public List<Parameter> Parameters { get; set; }
        public string Type { get; set; }
        public List<string> TypeParameters { get; set; }
    }
}
