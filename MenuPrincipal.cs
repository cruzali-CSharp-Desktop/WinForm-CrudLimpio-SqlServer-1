using CRUDFormSqlServer.Controllers;
using CRUDFormSqlServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDFormSqlServer
{
    public partial class menuPrincipalFrm : Form
    {

        DAOConnection DAOConn = new DAOConnection();

        public menuPrincipalFrm()
        {
            InitializeComponent();
        }

        private void ciudadesButton_Click(object sender, EventArgs e)
        {
            frmCity frmCiudades = new frmCity(null, null);
            frmCiudades.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            peopleFrm frmPeople = new peopleFrm();
            frmPeople.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListaCiudades frmListaciudades = new ListaCiudades(false, null);
            frmListaciudades.ShowDialog();
        }

        private void BtnCargaMasivaTRANS_Click(object sender, EventArgs e)
        {
            Response responseCiudadesDT = new Response();
            CityController cityC = new CityController();
            responseCiudadesDT = cityC.GetAllCity();

            using (SqlConnection connection = new SqlConnection(DAOConn.stringConn))
            {
                connection.Open();
                // Trans
                SqlTransaction transaction1 = connection.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand("spInsertPeople", connection, transaction1) { CommandType = CommandType.StoredProcedure };

                    foreach (DataRow dr in responseCiudadesDT.dt.Rows)
                    {
                        cmd.Parameters.Clear();
                        cmd.Transaction = transaction1;

                        cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = dr["Name"].ToString();
                        cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = dr["Code"].ToString();
                        cmd.Parameters.Add("@EmailAddress", SqlDbType.NVarChar).Value = dr["Name"].ToString();
                        cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = dr["id"].ToString();
                        System.Diagnostics.Debug.WriteLine($"-- EXC [spInsertPeople] @Name = {dr["Name"]}");
                        cmd.ExecuteNonQuery();
                        //transaction1.Commit();
                        //transaction1 = connection.BeginTransaction();
                    }

                    transaction1.Commit();
                }
                catch (Exception ex)
                {
                    transaction1.Rollback();
                    System.Diagnostics.Debug.WriteLine($"Exception {ex}");
                }
            }            
        }

    }
}
