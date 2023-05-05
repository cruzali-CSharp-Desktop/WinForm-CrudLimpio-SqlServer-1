using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDFormSqlServer.Models
{
    public class DAOConnection
    {
        public string stringConn = ConfigurationManager.ConnectionStrings["DBSample"].ConnectionString;

        // Recibo el resulset y lo guardo en el DATATABLE
        public Response SelectDT(string query)
        {
            Response response = new Response();
            response.dt = new DataTable();

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(stringConn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
                    da.Fill(response.dt);
                    return response;
                }
            } catch (Exception ex)
            {
                response.Msg = ex.Message;
                return response;
            }
        }

        // Realizo updates y retorno el numero de filas afectadas.
        public Response AfectTable(string query)
        {
            Response response = new Response();

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(stringConn))
                {
                    SqlCommand comando = new SqlCommand(query, sqlConn);
                    sqlConn.Open();
                    response.RowsAfected = comando.ExecuteNonQuery();
                    return response;
                }
            } catch (SqlException ex)
            {
                response.Msg = ex.Message;
                return response;
            }
        }




        public Response SelectDS(string query)
        {
            Response response = new Response();
            response.ds = new DataSet();

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(stringConn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
                    da.Fill(response.ds);
                    return response;
                }
            } catch(SqlException ex) {
                response.Msg = ex.Message;
                return response;
            }
        }


    }
}
