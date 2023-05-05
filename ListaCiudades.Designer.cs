
namespace CRUDFormSqlServer
{
    partial class ListaCiudades
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
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.lblIdSelected = new System.Windows.Forms.Label();
            this.lblCiudadSelected = new System.Windows.Forms.Label();
            this.btnSelectCity = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(56, 54);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 0;
            this.lblCiudad.Text = "Ciudad";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(114, 46);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(451, 21);
            this.cmbCiudad.TabIndex = 1;
            this.cmbCiudad.SelectedIndexChanged += new System.EventHandler(this.cmbCiudad_SelectedIndexChanged);
            // 
            // lblIdSelected
            // 
            this.lblIdSelected.AutoSize = true;
            this.lblIdSelected.Location = new System.Drawing.Point(27, 205);
            this.lblIdSelected.Name = "lblIdSelected";
            this.lblIdSelected.Size = new System.Drawing.Size(16, 13);
            this.lblIdSelected.TabIndex = 2;
            this.lblIdSelected.Text = "Id";
            // 
            // lblCiudadSelected
            // 
            this.lblCiudadSelected.AutoSize = true;
            this.lblCiudadSelected.Location = new System.Drawing.Point(30, 284);
            this.lblCiudadSelected.Name = "lblCiudadSelected";
            this.lblCiudadSelected.Size = new System.Drawing.Size(40, 13);
            this.lblCiudadSelected.TabIndex = 3;
            this.lblCiudadSelected.Text = "Ciudad";
            // 
            // btnSelectCity
            // 
            this.btnSelectCity.Location = new System.Drawing.Point(595, 44);
            this.btnSelectCity.Name = "btnSelectCity";
            this.btnSelectCity.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCity.TabIndex = 4;
            this.btnSelectCity.Text = "Seleccionar";
            this.btnSelectCity.UseVisualStyleBackColor = true;
            this.btnSelectCity.Click += new System.EventHandler(this.btnSelectCity_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblResponse.Location = new System.Drawing.Point(37, 356);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(121, 25);
            this.lblResponse.TabIndex = 5;
            this.lblResponse.Text = "Response: ";
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(595, 274);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnRetrieve.TabIndex = 6;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // ListaCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 432);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.btnSelectCity);
            this.Controls.Add(this.lblCiudadSelected);
            this.Controls.Add(this.lblIdSelected);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.lblCiudad);
            this.Name = "ListaCiudades";
            this.Text = "ListaCiudades";
            this.Load += new System.EventHandler(this.ListaCiudades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label lblIdSelected;
        private System.Windows.Forms.Label lblCiudadSelected;
        private System.Windows.Forms.Button btnSelectCity;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Button btnRetrieve;
    }
}