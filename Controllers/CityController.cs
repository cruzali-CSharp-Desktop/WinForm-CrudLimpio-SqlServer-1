using CRUDFormSqlServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDFormSqlServer.Controllers
{
    public class CityController
    {
        public Response GetAllCity()
        {
            DAOConnection data = new DAOConnection();
            Response response = new Response();

            string query = "exec spSelectAllCity";
            response = data.SelectDT(query);
            return response;
        }

    }
}
