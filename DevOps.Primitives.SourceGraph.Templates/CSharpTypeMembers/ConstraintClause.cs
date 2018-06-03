using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.SourceGraph.Templates.CSharpTypeMembers
{
    public class ConstraintClause
    {
        public ConstraintClause() { }
        public ConstraintClause(string name, params string[] constraints)
        {
            Name = name;
            Constraints = constraints?.ToList();
        }

        public string Name { get; set; }
        public List<string> Constraints { get; set; }
    }
}
