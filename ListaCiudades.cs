using CRUDFormSqlServer.Controllers;
using CRUDFormSqlServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDFormSqlServer
{
    public partial class ListaCiudades : Form
    {


        public ListaCiudades(bool responseCheck, string responseS)
        {
            InitializeComponent();
            //lblResponse.Text = responseS.ToString();
        }

        DAOConnection data = new DAOConnection();
        Response response = new Response();

        private void btnSelectCity_Click(object sender, EventArgs e)
        {           
    
        }

        private void ListaCiudades_Load(object sender, EventArgs e)
        {
            CityController cityC = new CityController();
            Response response = new Response();

            response = cityC.GetAllCity();

            cmbCiudad.DataSource = response.dt;
            cmbCiudad.DisplayMember = "Name";
            cmbCiudad.ValueMember = "Code";
        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdSelected.Text = cmbCiudad.SelectedValue.ToString();
            lblCiudadSelected.Text = cmbCiudad.Text;
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            using (frmCity frmcity = new frmCity(cmbCiudad.SelectedValue.ToString(), cmbCiudad.Text))
            {
                if (frmcity.ShowDialog() == DialogResult.OK)
                {
                    lblResponse.Text = frmcity.txBox1;
                }
            }

        }
    }
}
