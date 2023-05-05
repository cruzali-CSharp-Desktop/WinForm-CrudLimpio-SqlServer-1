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
    public partial class frmCity : Form
    {
        private bool chBox1
        {
            get
            {
                return checkBox1.Checked;
            }
        }

        public string txBox1 { get { return txbResponse.Text; } } 

        public frmCity(string displayM, string valueM)
        {
            InitializeComponent();
            label2.Text = displayM;
            label3.Text = valueM;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ListaCiudades listaCiudadesForm = new ListaCiudades(checkBox1.Checked, txbResponse.Text.ToString());
            //listaCiudadesForm.  = txbResponse.Text.ToString();
            this.Close();
            //listaCiudadesForm.Show();

        }
    }
}
