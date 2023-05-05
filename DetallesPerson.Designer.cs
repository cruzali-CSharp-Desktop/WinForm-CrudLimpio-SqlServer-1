
namespace CRUDFormSqlServer
{
    partial class DetallesPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.idPersonaTextBox = new System.Windows.Forms.TextBox();
            this.esAsignarPermisosComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rolesComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Persona:";
            // 
            // idPersonaTextBox
            // 
            this.idPersonaTextBox.Location = new System.Drawing.Point(115, 41);
            this.idPersonaTextBox.Name = "idPersonaTextBox";
            this.idPersonaTextBox.Size = new System.Drawing.Size(160, 20);
            this.idPersonaTextBox.TabIndex = 1;
            // 
            // esAsignarPermisosComboBox
            // 
            this.esAsignarPermisosComboBox.FormattingEnabled = true;
            this.esAsignarPermisosComboBox.Items.AddRange(new object[] {
            "Seleccionar",
            "Si",
            "No"});
            this.esAsignarPermisosComboBox.Location = new System.Drawing.Point(115, 178);
            this.esAsignarPermisosComboBox.Name = "esAsignarPermisosComboBox";
            this.esAsignarPermisosComboBox.Size = new System.Drawing.Size(160, 21);
            this.esAsignarPermisosComboBox.TabIndex = 2;
            this.esAsignarPermisosComboBox.SelectedIndexChanged += new System.EventHandler(this.esAsignarPermisosComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Asignar Permisos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.Location = new System.Drawing.Point(115, 295);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(160, 21);
            this.rolesComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Roles:";
            // 
            // DetallesPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rolesComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.esAsignarPermisosComboBox);
            this.Controls.Add(this.idPersonaTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DetallesPerson";
            this.Text = "DetallesPerson";
            this.Load += new System.EventHandler(this.DetallesPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox esAsignarPermisosComboBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox idPersonaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rolesComboBox;
        private System.Windows.Forms.Label label4;
    }
}