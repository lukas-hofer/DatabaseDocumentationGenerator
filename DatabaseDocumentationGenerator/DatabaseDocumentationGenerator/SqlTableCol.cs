using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDocumentationGenerator
{
    internal class SqlTableCol
    {
        public string name { get; set; }
        public string datatype { get; set; }
        public bool nullable { get; set; }
        
    }
}
