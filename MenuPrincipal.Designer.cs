
namespace CRUDFormSqlServer
{
    partial class menuPrincipalFrm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CiudadesButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnCargaMasivaTRANS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CiudadesButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnCargaMasivaTRANS, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 373);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CiudadesButton
            // 
            this.CiudadesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CiudadesButton.AutoSize = true;
            this.CiudadesButton.BackColor = System.Drawing.Color.DarkOrange;
            this.CiudadesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.CiudadesButton.ForeColor = System.Drawing.Color.White;
            this.CiudadesButton.Location = new System.Drawing.Point(316, 189);
            this.CiudadesButton.Name = "CiudadesButton";
            this.CiudadesButton.Size = new System.Drawing.Size(307, 181);
            this.CiudadesButton.TabIndex = 3;
            this.CiudadesButton.Text = "City";
            this.CiudadesButton.UseVisualStyleBackColor = false;
            this.CiudadesButton.Click += new System.EventHandler(this.ciudadesButton_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 181);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cargas";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnCargaMasivaTRANS
            // 
            this.BtnCargaMasivaTRANS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCargaMasivaTRANS.AutoSize = true;
            this.BtnCargaMasivaTRANS.BackColor = System.Drawing.Color.DarkViolet;
            this.BtnCargaMasivaTRANS.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.BtnCargaMasivaTRANS.ForeColor = System.Drawing.Color.White;
            this.BtnCargaMasivaTRANS.Location = new System.Drawing.Point(316, 3);
            this.BtnCargaMasivaTRANS.Name = "BtnCargaMasivaTRANS";
            this.BtnCargaMasivaTRANS.Size = new System.Drawing.Size(307, 180);
            this.BtnCargaMasivaTRANS.TabIndex = 1;
            this.BtnCargaMasivaTRANS.Text = "Carga Masiva TRANS";
            this.BtnCargaMasivaTRANS.UseVisualStyleBackColor = false;
            this.BtnCargaMasivaTRANS.Click += new System.EventHandler(this.BtnCargaMasivaTRANS_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 180);
            this.button1.TabIndex = 0;
            this.button1.Text = "People";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuPrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "menuPrincipalFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CiudadesButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnCargaMasivaTRANS;
    }
}