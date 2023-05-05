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
    public partial class DetallesPerson : Form
    {
        public DetallesPerson(string idPerson)
        {
            InitializeComponent();
            idPersonaTextBox.Text = idPerson;
        }

        private void DetallesPerson_Load(object sender, EventArgs e)
        {
            Response response = new Response();
            PeopleController peopleC = new PeopleController();

            rolesComboBox.DataSource = peopleC.GetAllRolesDT().dt;
            rolesComboBox.DisplayMember = "Nombre";
            rolesComboBox.ValueMember = "id";

        }

        private void esAsignarPermisosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                label3.Text = esAsignarPermisosComboBox.SelectedIndex.ToString();
            
        }
    }
}
