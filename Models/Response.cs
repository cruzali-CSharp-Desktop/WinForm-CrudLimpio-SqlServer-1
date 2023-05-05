using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDFormSqlServer.Models
{
    public class Response
    {
        public DataTable dt { get; set; }
        public string Msg { get; set; }
        public DataSet ds { get; set; }

        public int RowsAfected { get; set; }
    }
}
