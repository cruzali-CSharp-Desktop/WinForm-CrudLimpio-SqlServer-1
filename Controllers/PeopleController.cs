using CRUDFormSqlServer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDFormSqlServer.Controllers
{
    public class PeopleController
    {

        DAOConnection DAOConn = new DAOConnection();

        // Guardo un nuevo registro para People
        // Sin usar el EXECUTE. También podría solo mandar la cadena string con los campos.
        public Response InsertNewPersonBasic(Person person)
        {
            DAOConnection data = new DAOConnection();
            Response response = new Response();

            string query = "execute spInsertPeople " +
                            "@FirstName = '" + person.FirstName + "'" +
                            ",@LastName = '" + person.LastName + "'" +
                            ",@EmailAddress = '" + person.EmailAddress + "'" +
                            ",@PhoneNumber = '" + person.PhoneNumber + "'";
            try
            {
                response = data.SelectDT(query);
                return response;
            }
            catch (SqlException ex)
            {
                response.Msg = ex.Message;
                return response;
            }
        }

        public void InsertNewPersonTRANS1(Person person)
        {
            using (SqlConnection connection = new SqlConnection(DAOConn.stringConn))
            {
                connection.Open();
                // Trans
                SqlTransaction transaction1 = connection.BeginTransaction();                

                try
                {
                    SqlCommand cmd = new SqlCommand("spInsertPeople", connection, transaction1) { CommandType = CommandType.StoredProcedure };
                    

                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = person.FirstName;
                    cmd.Parameters.Add("@LatName", SqlDbType.NVarChar).Value = person.LastName;
                    cmd.Parameters.Add("@EmailAddress", SqlDbType.NVarChar).Value = person.EmailAddress;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = person.PhoneNumber;
                    System.Diagnostics.Debug.WriteLine($"-- EXC [spInsertPeople] @FirstName = {person.FirstName}");

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Exception {ex}");
                }
            }
        }

        public Response UpdatePeople(Person person)
        {
            DAOConnection data = new DAOConnection();
            Response response = new Response();

            string query = "exec uspUpdatePeople @id = " + person.id +
                ", @FirstName = '" + person.FirstName + "'" +
                ", @LastName = '" + person.LastName + "'" +
                ", @EmailAddress = '" + person.EmailAddress + "'" +
                ", @PhoneNumber = '" + person.PhoneNumber + "'";

            response = data.AfectTable(query);
            return response;
        }

        public Response DeletePeople(Person person)
        {
            DAOConnection data = new DAOConnection();
            Response response = new Response();

            string query = "exec uspDeletePeople @id = " + person.id + "";
            response = data.AfectTable(query);
            return response;
        }

        public Response GetAllPeopleDT()
        {
            DAOConnection data = new DAOConnection();
            Response response = new Response();

            string query = "exec spSelectAllPeople";
            response = data.SelectDT(query);
            return response;
        }

        public Response GetAllPeopleDS()
        {
            DAOConnection data = new DAOConnection();
            Response response = new Response();

            string query = "exec spSelectAllPeople";
            response = data.SelectDS(query);
            return response;
        }


        public Response GetAllRolesDT()
        {
            DAOConnection data = new DAOConnection();
            Response response = new Response();

            string query = "exec spSelectAllRoles";
            response = data.SelectDT(query);
            return response;
        }




    }
}
