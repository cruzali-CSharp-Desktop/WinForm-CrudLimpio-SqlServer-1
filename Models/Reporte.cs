using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDFormSqlServer.Models
{
    public class Reporte : DataRow
    {
        public int ID
        {
            get { return (int)base["ID"]; }
            set { base["ID"] = value; }
        }

        public string Nombre
        {
            get { return (string)base["Nombre"]; }
            set { base["Nombre"] = value; }
        }

        public string Apellido
        {
            get { return (string)base["Apellido"]; }
            set { base["Apellido"] = value; }
        }

        public string Email
        {
            get { return (string)base["Email"]; }
            set { base["Email"] = value; }
        }

        public string Telefono
        {
            get { return (string)base["Telefono"]; }
            set { base["Telefono"] = value; }
        }

        internal Reporte(DataRowBuilder builder):base(builder)
        {
            this.ID = 0;
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.Email = string.Empty;
            this.Telefono = string.Empty;
        }
    }

    public class PersonTable : DataTable
    {
        public PersonTable(string TableName)
        {
            this.TableName = TableName;
            this.Columns.Add(new DataColumn("id", typeof(int)));
            this.Columns.Add(new DataColumn("FirstName", typeof(string)));
            this.Columns.Add(new DataColumn("LastName", typeof(string)));
            this.Columns.Add(new DataColumn("EmailAddress", typeof(string)));
            this.Columns.Add(new DataColumn("PhoneNumber", typeof(string)));
        }

        public Reporte CreateNewRow()
        {
            return (Reporte)NewRow();
        }

        protected override Type GetRowType()
        {
            return typeof(Reporte);
        }

        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new Reporte(builder);
        }
    }
}
