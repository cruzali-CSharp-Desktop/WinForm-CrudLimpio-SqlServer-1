using CRUDFormSqlServer.Controllers;
using CRUDFormSqlServer.Models;
using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDFormSqlServer
{
    public partial class peopleFrm : Form
    {
        PeopleController peopleC = new PeopleController();
        Response response;
        Person person = new Person();
        DataView dataView;

        int modoOperacion = 0;
        int rowSelected = 0;
        int idPeopleRowSelected = 0;

        enum CRUD : int
        {
            Creacion = 1,
            Edicion = 2
        }


        public peopleFrm()
        {
            InitializeComponent();
        }

        #region Formulario
        // Al iniciar el main form se debe de cargar la lista completa de people
        // El boton en cada fila a la izquierda remite a detalles de la persona selecionada.
        private void mainForm_Load(object sender, EventArgs e)
        {
            PeopleController peopleC = new PeopleController();
            response = peopleC.GetAllPeopleDT();
            peopleListDGV.DataSource = response.dt;

            // Preparo el DGV
            PersonalizarDGV(peopleListDGV);
        }
        #endregion Formulario

        #region CRUD people

        private void PersonalizarDGV(DataGridView peopleDGV)
        {
            // Personalizo el numero, nombre y encabezado de columnas. Comienza en columna 0
            //peopleDGV.AutoGenerateColumns = false;
            //peopleDGV.ColumnCount = 5;

            peopleDGV.Columns[0].HeaderText = "Id";
            peopleDGV.Columns[1].HeaderText = "Nombre";
            peopleDGV.Columns[2].HeaderText = "Apellido";
            peopleDGV.Columns[3].HeaderText = "Email";
            peopleDGV.Columns[4].HeaderText = "Telefono";

            peopleDGV.Columns[0].Name = "Id";
            peopleDGV.Columns[1].Name = "FirstName";
            peopleDGV.Columns[2].Name = "LastName";
            peopleDGV.Columns[3].Name = "EmailAddress";
            peopleDGV.Columns[4].Name = "PhoneNumber";

            //peopleDGV.Columns[0].Visible = false;

            // Ajuste ancho a contenido de celda
            peopleDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Usar todo el ancho del DGV
            peopleDGV.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            peopleDGV.Columns["FirstName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            peopleDGV.Columns["LastName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            peopleDGV.Columns["EmailAddress"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            peopleDGV.Columns["PhoneNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Genero y personalizo boton para el listado de personas
            DataGridViewButtonColumn detallesPersonButton = new DataGridViewButtonColumn();
            detallesPersonButton.FlatStyle = FlatStyle.Standard;
            detallesPersonButton.HeaderText = "Detalles";
            detallesPersonButton.Name = "Button";
            detallesPersonButton.UseColumnTextForButtonValue = true;
            detallesPersonButton.Text = "ver";            
            peopleDGV.Columns.Add(detallesPersonButton);
        }


        // Lleno el DataGridV people
        private void FillPeopleDGV()
        {
            // Limpio el DGV antes (a forma de refrescar dgv)
            peopleListDGV.Rows.Clear();

            // Recorro el DT recibido para pintar cada dato en todas las filas.
            foreach (DataRow dr in response.dt.Rows)
            {
                var index = peopleListDGV.Rows.Add();
                peopleListDGV.Rows[index].Cells["FirstName"].Value = dr["FirstName"].ToString();
                peopleListDGV.Rows[index].Cells["LastName"].Value = dr["LastName"].ToString();
                peopleListDGV.Rows[index].Cells["EmailAddress"].Value = dr["EmailAddress"].ToString();
                peopleListDGV.Rows[index].Cells["PhoneNumber"].Value = dr["PhoneNumber"].ToString();
                peopleListDGV.Rows[index].Cells["Id"].Value = dr["id"].ToString();
            }
        }

        private void stringToSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            // Conforme se escribe en el campo de busqueda se actualiza el dgv para filtrar resultados.
            dataView = response.dt.DefaultView;
            
            dataView.RowFilter = "FirstName LIKE '%" + stringToSearchTextBox.Text +
                    "%' OR LastName LIKE '%" + stringToSearchTextBox.Text + 
                    "%' OR EmailAddress LIKE '%" + stringToSearchTextBox.Text + 
                    "%' OR PhoneNumber LIKE '%" + stringToSearchTextBox.Text + "%'";

            peopleListDGV.DataSource = dataView;
            
            //peopleListDGV.Rows.Clear();

            //PersonalizarDGV(peopleListDGV);
        }


        // Detectar el click en los botones y filas.
        private void peopleListDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = e.RowIndex;
            btnSave.Enabled = false;

            // Si se hace click en cualquier parte del DGV
            if (rowSelected != -1)
            {
                if (dataView != null)
                {
                    idPeopleRowSelected = Convert.ToInt32(peopleListDGV.Rows[rowSelected]
                    .Cells[1].Value.ToString());
                } else
                {
                    idPeopleRowSelected = Convert.ToInt32(peopleListDGV.Rows[rowSelected]
                    .Cells[0].Value.ToString());
                }

                person.id = idPeopleRowSelected;

                // Si hago click en otra parte diferente a la columna de boton
                txbFirstName.Text = peopleListDGV.Rows[rowSelected].Cells["FirstName"].Value.ToString();
                txbLastName.Text = peopleListDGV.Rows[rowSelected].Cells["LastName"].Value.ToString();
                txbEmail.Text = peopleListDGV.Rows[rowSelected].Cells["EmailAddress"].Value.ToString();
                txbPhone.Text = peopleListDGV.Rows[rowSelected].Cells["PhoneNumber"].Value.ToString();
                txbPathPicture.Text = ""; // agregar el path

                person.EmailAddress = txbEmail.Text;
            }

            Console.WriteLine("Row: " + rowSelected + " IdPerson: " + idPeopleRowSelected + " Email: " + person.EmailAddress +
                " Column Index: " + e.ColumnIndex);

            EstaHabilitadoForm(false);
            
            // Si hago click en el boton
            if ((rowSelected != -1 && e.ColumnIndex == 5 && dataView == null) || (dataView != null && e.ColumnIndex == 0))
            {
                //MessageBox.Show(rowSelected);
                DetallesPerson detallesPersonForm = new DetallesPerson(idPeopleRowSelected.ToString());
                //detallesPersonForm.idPersonaTextBox.Text = rowSelected.ToString();
                detallesPersonForm.ShowDialog();
            }

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;                
        }


        // Obtengo Path y nombre de archivo seleccionado para abrir
        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            txbPathPicture.Text = "Seleccione una imagen a subir...";
            openFDSelectPicture.Filter = "Imagenes (*.jpg;*.png)|*.jpeg;*.png";

            try
            {
                // Comprobamos si se selecciono un archivo...
                if (openFDSelectPicture.ShowDialog() == DialogResult.OK)
                {
                    // Ahora que tenemos path y nombre de archivo hacemos los procesos necesarios
                    txbPathPicture.Text = openFDSelectPicture.FileName;

                    // Personalizar imagen a cargar - THUMBNAIL
                    //Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                    //Bitmap imagen1 = new Bitmap(openFDSelectPicture.FileName);
                    //Image thumbnail = imagen1.GetThumbnailImage(90, 90, myCallback, IntPtr.Zero);
                    //pictureBox1.Image = thumbnail;

                    // Redimensionar tamaño imagen para adecuar al picturebox
                    Bitmap originalImage = new Bitmap(openFDSelectPicture.FileName);
                    Bitmap resizedImage = new Bitmap(originalImage, new Size(90, 90));
                    // Adecuar el la imagen recibida al picture box
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = (Image)originalImage;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir la imagen del perfil. " + ex);
            }
        }

        // Obtiene los bytes del path recibido
        private byte[] GetBytesImage(string pathPicture)
        {
            byte[] imageBytes = null;
            FileStream streamPicture = new FileStream(pathPicture, FileMode.Open, FileAccess.Read);
            BinaryReader bReader = new BinaryReader(streamPicture);
            imageBytes = bReader.ReadBytes(Convert.ToInt32(streamPicture.Length));

            return imageBytes;
        }

        public bool ThumbnailCallback()
        {
            return false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            LimpiarCamposForm();
            EstaHabilitadoForm(true);

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            modoOperacion = (int)CRUD.Creacion;
        }

        // Habilito / Deshabilito campos del form people
        private void EstaHabilitadoForm(bool res)
        {
            txbFirstName.Enabled = res;
            txbLastName.Enabled = res;
            txbEmail.Enabled = res;
            txbPhone.Enabled = res;
            txbPathPicture.Enabled = res;
            btnSelectPicture.Enabled = res;
        }

        // Limpio campos del form people
        private void LimpiarCamposForm()
        {
            txbFirstName.Text = "";
            txbLastName.Text = "";
            txbEmail.Text = "";
            txbPhone.Text = "";
            txbPathPicture.Text = "";
            openFDSelectPicture.FileName = null;
            peopleListDGV.Rows[0].Selected = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Habilitar campos form
            btnSave.Enabled = true;
            EstaHabilitadoForm(true);
            modoOperacion = (int)CRUD.Edicion;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Eliminar registro de la base de datos
            person.EmailAddress = txbEmail.Text;

            if (MessageBox.Show("Desea eliminar la fila " + rowSelected + " con personID " +
                    person.id + " con email " + person.EmailAddress, "Seguro que desea eliminar?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (peopleC.DeletePeople(person).RowsAfected > 0)
                {
                    // Eliminar del DATATABLE, Al eliminarlo del DT tambien se elimina del DGV
                    //peopleListDGV.Rows.RemoveAt(rowSelected);
                    response.dt.Rows.RemoveAt(rowSelected);

                    MessageBox.Show("Registro eliminado exitosamente.", "Exito", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Lleno y repinto el DGV
                    //FillPeopleDGV();
                    EstaHabilitadoForm(false);
                    LimpiarCamposForm();
                }
                else
                {
                    MessageBox.Show("Registro no eliminado, intentelo nuevamente.");
                }
            }
        }

        private bool EsEmailValido(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            } catch (FormatException)
            {
                return false;
            }
        }


        // Inserta un nuevo registro capturado a la BD y lo agrega al DATATABLE para pintarlo en el DGV.
        // Se debe distinguir entre un registro nuevo y la edicion de un registro.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Limpiar campos de entrada 'Sanitizar'
            person.FirstName = Regex.Replace(txbFirstName.Text.Trim().ToString(), "/s+", " ");
            person.LastName = Regex.Replace(txbLastName.Text.Trim().ToString(), "/s+", " ");
            person.EmailAddress = Regex.Replace(txbEmail.Text.Trim().ToString(), "/s+", " ");
            person.PhoneNumber = Regex.Replace(txbPhone.Text.Trim().ToString(), "/s+", " ");

            if (EsFormularioCompletado(person))
            {
                try
                {
                    if (modoOperacion == (int)CRUD.Creacion)
                    {
                        var idRowAfected = peopleC.InsertNewPersonBasic(person);
                        if (idRowAfected.dt.Rows.Count > 0)
                        {
                            // Registro insertado en la BD!
                            // Actualizar el datatable con el nuevo registro. Al hacerlo en automatico se
                            // refleja el cambio en el DGV
                            DataRow dr = response.dt.NewRow();

                            dr["id"] = idRowAfected.dt.Rows[0]["id"];
                            dr["FirstName"] = person.FirstName;
                            dr["LastName"] = person.LastName;
                            dr["EmailAddress"] = person.EmailAddress;
                            dr["PhoneNumber"] = person.PhoneNumber;
                            response.dt.Rows.InsertAt(dr, 0);

                            // Lleno y repinto el DGV
                            //FillPeopleDGV();
                            EstaHabilitadoForm(false);
                            LimpiarCamposForm();

                            MessageBox.Show("Agregado con exito.");
                        } else
                        {
                            MessageBox.Show("Registro no insertado, intentelo nuevamente.");
                        }
                    } else if (modoOperacion == (int)CRUD.Edicion)
                    {
                        if (peopleC.UpdatePeople(person).RowsAfected == 1)
                        {
                            // Se realizo el update con exito
                            peopleListDGV.Rows[rowSelected].Cells["FirstName"].Value = person.FirstName;
                            peopleListDGV.Rows[rowSelected].Cells["LastName"].Value = person.LastName;
                            peopleListDGV.Rows[rowSelected].Cells["EmailAddress"].Value = person.EmailAddress;
                            peopleListDGV.Rows[rowSelected].Cells["PhoneNumber"].Value = person.PhoneNumber;
                            // Lleno y repinto el DGV
                            //FillPeopleDGV();
                            EstaHabilitadoForm(false);
                            LimpiarCamposForm();

                            MessageBox.Show("Registro actualizado exitosamente!", "Exito", MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                        } else
                        {
                            MessageBox.Show("Ocurrio un error al intentar actualizar el registro, intentelo nuevamente"
                                , "Error", buttons: MessageBoxButtons.OKCancel);
                        }                        
                    }
                } catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private bool EsFormularioCompletado(Person person)
        {
            if (String.IsNullOrEmpty(person.FirstName))
            {
                MessageBox.Show("Complete el nombre correctamente.");
                return false; 
            } else if (String.IsNullOrEmpty(person.LastName))
            {
                MessageBox.Show("Complete el lastname correctamente.");
                return false;
            } else if (String.IsNullOrEmpty(person.EmailAddress))
            {
                MessageBox.Show("Complete el Email correctamente.");
                return false;
            } else if (String.IsNullOrEmpty(person.PhoneNumber))
            {
                MessageBox.Show("Complete el Telefono correctamente.");
                return false;
            } else if (!EsEmailValido(person.EmailAddress)) {
                MessageBox.Show("Complete el Email correctamente.");
                return false;
            }

            return true;
        }
        #endregion CRUD PEOPLE

        private void BtnExportExcel_Click(object sender, EventArgs e)
        {
            //DataTable dtStrong = new DataTable("Peoples");
            //PersonTable personT = new PersonTable("personT");
            //dtStrong.Columns.Add(new DataColumn("ID", typeof(int)));
            //dtStrong.Columns.Add(new DataColumn("FirstName", typeof(string)));
            //dtStrong.Columns.Add(new DataColumn("LastName", typeof(string)));
            //dtStrong.Columns.Add(new DataColumn("EmailAddress", typeof(string)));
            //dtStrong.Columns.Add(new DataColumn("PhoneNumber", typeof(string)));

            //int row;
            //Reporte reporte;

            //using (SLDocument slDocument = new SLDocument("ReportePeople.xlsx", "Hoja1"))
            //{
            //    SLWorksheetStatistics stats = slDocument.GetWorksheetStatistics();
            //    int iStartColumnIndex = stats.StartColumnIndex;

            //    for (row = stats.StartRowIndex  + 1; row <= stats.EndRowIndex; ++row)
            //    {
            //        dtStrong.Rows.Add(
            //            slDocument.GetCellValueAsInt32(row, iStartColumnIndex),
            //            slDocument.GetCellValueAsString(row, iStartColumnIndex + 1),
            //            slDocument.GetCellValueAsString(row, iStartColumnIndex + 2),
            //            slDocument.GetCellValueAsString(row, iStartColumnIndex + 3),
            //            slDocument.GetCellValueAsString(row, iStartColumnIndex + 4)
            //            );
            //    }

            //    for (row = stats.StartRowIndex + 1; row <= stats.EndRowIndex; ++row)
            //    {
            //        reporte = personT.CreateNewRow();
            //        reporte.ID = slDocument.GetCellValueAsInt32(row, iStartColumnIndex);
            //        reporte.Nombre = slDocument.GetCellValueAsString(row, iStartColumnIndex + 1);
            //        reporte.Apellido = slDocument.GetCellValueAsString(row, iStartColumnIndex + 2);
            //        reporte.Email = slDocument.GetCellValueAsString(row, iStartColumnIndex + 3);
            //        reporte.Telefono = slDocument.GetCellValueAsString(row, iStartColumnIndex + 4);
            //        personT.Rows.Add(reporte);
            //    }
            //}


            //dtStrong.Rows.Add(99, "Nombre1", "Apillido2", "Email3", "Phone");
            //dtStrong.WriteXml("export.xml");
            //personT.WriteXml("ex.xml");

            SLDocument slD = new SLDocument();

            SLStyle slStyle1 = new SLStyle();
            slStyle1.Fill.SetPattern(
                PatternValues.Solid,
                System.Drawing.Color.FromArgb(0, 150, 75, 115),
                System.Drawing.Color.Black);


            slD.SetCellStyle("A1", "E1", slStyle1);

            slD.SetCellValue("A1", "ID");
            slD.SetCellValue("B1", "Nombre");
            slD.SetCellValue("C1", "Apellido");
            slD.SetCellValue("D1", "Email");
            slD.SetCellValue("E1", "Telefono");

            //int fila = 2;


            //foreach (DataRow dr in response.dt.Rows)
            //{
            //    // FILA
            //    int colu = 0;
            //    int i = 0;

            //    // COLUMNA
            //    for (int j = 0; j < 5; j++)
            //    {
            //        slD.SetCellValue(fila, colu, dr[i].ToString());
            //        colu++;
            //        i++;
            //    }

            //    fila++;

            //}

            int fila = 2;

            foreach (DataRow dr in response.dt.Rows)
            {
                slD.SetCellValue(fila, 1, dr["id"].ToString());
                slD.SetCellValue(fila, 2, dr["FirstName"].ToString());
                slD.SetCellValue(fila, 3, dr["LastName"].ToString());
                slD.SetCellValue(fila, 4, dr["EmailAddress"].ToString());
                slD.SetCellValue(fila, 5, dr["PhoneNumber"].ToString());
                fila++;
            }


            slD.SaveAs("ReportePeople.xlsx");

        }
    }
}
