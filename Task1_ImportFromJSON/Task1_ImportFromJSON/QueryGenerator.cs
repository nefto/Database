using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ImportFromJSON
{
    public class QueryGenerator
    {
        public List<string> OrderBy { get; set; }
        public List<string> WhereClauses { get; set; }
        public IQueryable GenerateCollection(IQueryable collection)
        {
            return null;
        }
    }
}
