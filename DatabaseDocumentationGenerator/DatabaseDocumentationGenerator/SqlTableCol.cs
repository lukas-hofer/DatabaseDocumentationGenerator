using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDocumentationGenerator
{
    internal class SqlTableRow
    {
        public string name { get; set; }
        public string datatype { get; set; }
        public bool nullable { get; set; }
        
    }
}
