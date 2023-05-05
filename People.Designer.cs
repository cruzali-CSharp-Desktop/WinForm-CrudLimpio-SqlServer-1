
namespace CRUDFormSqlServer
{
    partial class peopleFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(peopleFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.panelBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.stringToSearchTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnExportExcel = new System.Windows.Forms.Button();
            this.peopleListDGV = new System.Windows.Forms.DataGridView();
            this.panelDataGridVPeople = new System.Windows.Forms.TableLayoutPanel();
            this.panelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelPie = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panelEditPeople = new System.Windows.Forms.TableLayoutPanel();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.txbPathPicture = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.openFDSelectPicture = new System.Windows.Forms.OpenFileDialog();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleListDGV)).BeginInit();
            this.panelDataGridVPeople.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelPie.SuspendLayout();
            this.panelEditPeople.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD People";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBusqueda.ColumnCount = 3;
            this.panelBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.panelBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelBusqueda.Controls.Add(this.label4, 0, 0);
            this.panelBusqueda.Controls.Add(this.stringToSearchTextBox, 1, 0);
            this.panelBusqueda.Controls.Add(this.pictureBox1, 2, 0);
            this.panelBusqueda.Controls.Add(this.BtnExportExcel, 1, 1);
            this.panelBusqueda.Location = new System.Drawing.Point(3, 3);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.RowCount = 2;
            this.panelBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelBusqueda.Size = new System.Drawing.Size(754, 112);
            this.panelBusqueda.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Buscar:";
            // 
            // stringToSearchTextBox
            // 
            this.stringToSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stringToSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringToSearchTextBox.Location = new System.Drawing.Point(116, 20);
            this.stringToSearchTextBox.Name = "stringToSearchTextBox";
            this.stringToSearchTextBox.Size = new System.Drawing.Size(446, 31);
            this.stringToSearchTextBox.TabIndex = 3;
            this.stringToSearchTextBox.TextChanged += new System.EventHandler(this.stringToSearchTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(609, 3);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(100, 100);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(100, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BtnExportExcel
            // 
            this.BtnExportExcel.Location = new System.Drawing.Point(116, 75);
            this.BtnExportExcel.Name = "BtnExportExcel";
            this.BtnExportExcel.Size = new System.Drawing.Size(75, 23);
            this.BtnExportExcel.TabIndex = 5;
            this.BtnExportExcel.Text = "Exportar";
            this.BtnExportExcel.UseVisualStyleBackColor = true;
            this.BtnExportExcel.Click += new System.EventHandler(this.BtnExportExcel_Click);
            // 
            // peopleListDGV
            // 
            this.peopleListDGV.AllowUserToAddRows = false;
            this.peopleListDGV.AllowUserToDeleteRows = false;
            this.peopleListDGV.AllowUserToResizeColumns = false;
            this.peopleListDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleListDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.peopleListDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.peopleListDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.peopleListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.peopleListDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.peopleListDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.peopleListDGV.Location = new System.Drawing.Point(3, 3);
            this.peopleListDGV.MultiSelect = false;
            this.peopleListDGV.Name = "peopleListDGV";
            this.peopleListDGV.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.peopleListDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.peopleListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.peopleListDGV.Size = new System.Drawing.Size(748, 422);
            this.peopleListDGV.TabIndex = 2;
            this.peopleListDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.peopleListDGV_CellClick);
            // 
            // panelDataGridVPeople
            // 
            this.panelDataGridVPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDataGridVPeople.ColumnCount = 1;
            this.panelDataGridVPeople.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDataGridVPeople.Controls.Add(this.peopleListDGV, 0, 0);
            this.panelDataGridVPeople.Location = new System.Drawing.Point(3, 121);
            this.panelDataGridVPeople.Name = "panelDataGridVPeople";
            this.panelDataGridVPeople.RowCount = 1;
            this.panelDataGridVPeople.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDataGridVPeople.Size = new System.Drawing.Size(754, 428);
            this.panelDataGridVPeople.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.ColumnCount = 1;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.Controls.Add(this.panelDataGridVPeople, 0, 1);
            this.panelMain.Controls.Add(this.panelBusqueda, 0, 0);
            this.panelMain.Controls.Add(this.panelPie, 0, 2);
            this.panelMain.Location = new System.Drawing.Point(12, 49);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 3;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.panelMain.Size = new System.Drawing.Size(760, 750);
            this.panelMain.TabIndex = 6;
            // 
            // panelPie
            // 
            this.panelPie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPie.ColumnCount = 2;
            this.panelPie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panelPie.Controls.Add(this.btnSave, 0, 3);
            this.panelPie.Controls.Add(this.btnDelete, 1, 2);
            this.panelPie.Controls.Add(this.btnEdit, 1, 1);
            this.panelPie.Controls.Add(this.panelEditPeople, 0, 0);
            this.panelPie.Controls.Add(this.btnCreate, 1, 0);
            this.panelPie.Location = new System.Drawing.Point(3, 555);
            this.panelPie.Name = "panelPie";
            this.panelPie.RowCount = 4;
            this.panelPie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelPie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelPie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelPie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelPie.Size = new System.Drawing.Size(754, 192);
            this.panelPie.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(657, 155);
            this.btnSave.MaximumSize = new System.Drawing.Size(95, 26);
            this.btnSave.MinimumSize = new System.Drawing.Size(95, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 26);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(657, 107);
            this.btnDelete.MaximumSize = new System.Drawing.Size(95, 26);
            this.btnDelete.MinimumSize = new System.Drawing.Size(95, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 26);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(657, 59);
            this.btnEdit.MaximumSize = new System.Drawing.Size(95, 26);
            this.btnEdit.MinimumSize = new System.Drawing.Size(95, 26);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 26);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelEditPeople
            // 
            this.panelEditPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditPeople.ColumnCount = 3;
            this.panelEditPeople.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.55665F));
            this.panelEditPeople.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.44335F));
            this.panelEditPeople.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.panelEditPeople.Controls.Add(this.txbEmail, 1, 2);
            this.panelEditPeople.Controls.Add(this.txbLastName, 1, 1);
            this.panelEditPeople.Controls.Add(this.label3, 0, 1);
            this.panelEditPeople.Controls.Add(this.label2, 0, 0);
            this.panelEditPeople.Controls.Add(this.txbFirstName, 1, 0);
            this.panelEditPeople.Controls.Add(this.label6, 0, 3);
            this.panelEditPeople.Controls.Add(this.label5, 0, 2);
            this.panelEditPeople.Controls.Add(this.label7, 0, 4);
            this.panelEditPeople.Controls.Add(this.txbPhone, 1, 3);
            this.panelEditPeople.Controls.Add(this.btnSelectPicture, 2, 4);
            this.panelEditPeople.Controls.Add(this.txbPathPicture, 1, 4);
            this.panelEditPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEditPeople.Location = new System.Drawing.Point(3, 3);
            this.panelEditPeople.Name = "panelEditPeople";
            this.panelEditPeople.RowCount = 5;
            this.panelPie.SetRowSpan(this.panelEditPeople, 4);
            this.panelEditPeople.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelEditPeople.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelEditPeople.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelEditPeople.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelEditPeople.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelEditPeople.Size = new System.Drawing.Size(648, 186);
            this.panelEditPeople.TabIndex = 4;
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditPeople.SetColumnSpan(this.txbEmail, 2);
            this.txbEmail.Enabled = false;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbEmail.Location = new System.Drawing.Point(162, 77);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(483, 26);
            this.txbEmail.TabIndex = 7;
            // 
            // txbLastName
            // 
            this.txbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditPeople.SetColumnSpan(this.txbLastName, 2);
            this.txbLastName.Enabled = false;
            this.txbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbLastName.Location = new System.Drawing.Point(162, 40);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(483, 26);
            this.txbLastName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditPeople.SetColumnSpan(this.txbFirstName, 2);
            this.txbFirstName.Enabled = false;
            this.txbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbFirstName.Location = new System.Drawing.Point(162, 3);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(483, 26);
            this.txbFirstName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Select Photo";
            // 
            // txbPhone
            // 
            this.txbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditPeople.SetColumnSpan(this.txbPhone, 2);
            this.txbPhone.Enabled = false;
            this.txbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbPhone.Location = new System.Drawing.Point(162, 114);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(483, 26);
            this.txbPhone.TabIndex = 8;
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectPicture.Enabled = false;
            this.btnSelectPicture.Location = new System.Drawing.Point(540, 151);
            this.btnSelectPicture.MaximumSize = new System.Drawing.Size(95, 26);
            this.btnSelectPicture.MinimumSize = new System.Drawing.Size(95, 26);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(95, 26);
            this.btnSelectPicture.TabIndex = 9;
            this.btnSelectPicture.Text = "...";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // txbPathPicture
            // 
            this.txbPathPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPathPicture.Enabled = false;
            this.txbPathPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbPathPicture.Location = new System.Drawing.Point(162, 151);
            this.txbPathPicture.Name = "txbPathPicture";
            this.txbPathPicture.Size = new System.Drawing.Size(372, 26);
            this.txbPathPicture.TabIndex = 10;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(657, 11);
            this.btnCreate.MaximumSize = new System.Drawing.Size(95, 26);
            this.btnCreate.MinimumSize = new System.Drawing.Size(95, 26);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 26);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // openFDSelectPicture
            // 
            this.openFDSelectPicture.FileName = "openFileDialog1";
            // 
            // peopleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 811);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 850);
            this.Name = "peopleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleListDGV)).EndInit();
            this.panelDataGridVPeople.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelPie.ResumeLayout(false);
            this.panelEditPeople.ResumeLayout(false);
            this.panelEditPeople.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel panelBusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stringToSearchTextBox;
        private System.Windows.Forms.DataGridView peopleListDGV;
        private System.Windows.Forms.TableLayoutPanel panelDataGridVPeople;
        private System.Windows.Forms.TableLayoutPanel panelMain;
        private System.Windows.Forms.OpenFileDialog openFDSelectPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel panelPie;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TableLayoutPanel panelEditPeople;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.TextBox txbPathPicture;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnExportExcel;
    }
}

