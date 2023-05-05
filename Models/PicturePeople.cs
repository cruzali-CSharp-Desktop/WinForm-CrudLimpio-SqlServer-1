using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDFormSqlServer.Models
{
    public class PicturePeople
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string ImagenBytes { get; set; }
        public int idPeople { get; set; }


    }
}
