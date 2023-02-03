using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDocumentationGenerator
{
    internal class SqlTable
    {

        public string name { get; set; }
        public List<SqlTableCol> sqlTableColumns;

        public SqlTable()
        {
            sqlTableColumns = new List<SqlTableCol>();
        }

    }
}
