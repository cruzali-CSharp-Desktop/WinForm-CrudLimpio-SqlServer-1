
namespace CRUDFormSqlServer
{
    partial class frmCity
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFolios = new System.Windows.Forms.TabPage();
            this.tabCarga = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbResponse = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabFolios);
            this.tabControl1.Controls.Add(this.tabCarga);
            this.tabControl1.Location = new System.Drawing.Point(12, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 375);
            this.tabControl1.TabIndex = 1;
            // 
            // tabFolios
            // 
            this.tabFolios.Location = new System.Drawing.Point(4, 22);
            this.tabFolios.Name = "tabFolios";
            this.tabFolios.Padding = new System.Windows.Forms.Padding(3);
            this.tabFolios.Size = new System.Drawing.Size(677, 349);
            this.tabFolios.TabIndex = 0;
            this.tabFolios.Text = "Folios";
            this.tabFolios.UseVisualStyleBackColor = true;
            // 
            // tabCarga
            // 
            this.tabCarga.Controls.Add(this.txbResponse);
            this.tabCarga.Controls.Add(this.checkBox1);
            this.tabCarga.Controls.Add(this.label3);
            this.tabCarga.Controls.Add(this.label2);
            this.tabCarga.Controls.Add(this.label1);
            this.tabCarga.Location = new System.Drawing.Point(4, 22);
            this.tabCarga.Name = "tabCarga";
            this.tabCarga.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarga.Size = new System.Drawing.Size(677, 349);
            this.tabCarga.TabIndex = 1;
            this.tabCarga.Text = "Carga";
            this.tabCarga.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargas";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(562, 243);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Visto?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbResponse
            // 
            this.txbResponse.Location = new System.Drawing.Point(355, 243);
            this.txbResponse.Name = "txbResponse";
            this.txbResponse.Size = new System.Drawing.Size(100, 20);
            this.txbResponse.TabIndex = 4;
            // 
            // frmCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 462);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Compartida";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCarga.ResumeLayout(false);
            this.tabCarga.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFolios;
        private System.Windows.Forms.TabPage tabCarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbResponse;
    }
}