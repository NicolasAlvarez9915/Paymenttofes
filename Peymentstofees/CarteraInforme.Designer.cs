namespace Peymentstofees
{
    partial class CarteraInforme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarteraInforme));
            this.label1 = new System.Windows.Forms.Label();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.DgvPagos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblDineroDisponible = new System.Windows.Forms.Label();
            this.LblDineroPrestado = new System.Windows.Forms.Label();
            this.DgvCreditos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.LblCantidadDeudores = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LblCapital = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de deudores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DgvClientes
            // 
            this.DgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(72, 268);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.Size = new System.Drawing.Size(638, 150);
            this.DgvClientes.TabIndex = 1;
            this.DgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentClick);
            // 
            // DgvPagos
            // 
            this.DgvPagos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPagos.Location = new System.Drawing.Point(9, 73);
            this.DgvPagos.Name = "DgvPagos";
            this.DgvPagos.Size = new System.Drawing.Size(372, 150);
            this.DgvPagos.TabIndex = 2;
            this.DgvPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPagos_CellContentClick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(72, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(638, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clientes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dinero disponible";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dinero Prestado";
            // 
            // LblDineroDisponible
            // 
            this.LblDineroDisponible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDineroDisponible.Location = new System.Drawing.Point(100, 7);
            this.LblDineroDisponible.Name = "LblDineroDisponible";
            this.LblDineroDisponible.Size = new System.Drawing.Size(100, 23);
            this.LblDineroDisponible.TabIndex = 6;
            this.LblDineroDisponible.Click += new System.EventHandler(this.label5_Click);
            // 
            // LblDineroPrestado
            // 
            this.LblDineroPrestado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDineroPrestado.Location = new System.Drawing.Point(445, 8);
            this.LblDineroPrestado.Name = "LblDineroPrestado";
            this.LblDineroPrestado.Size = new System.Drawing.Size(100, 23);
            this.LblDineroPrestado.TabIndex = 7;
            // 
            // DgvCreditos
            // 
            this.DgvCreditos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCreditos.Location = new System.Drawing.Point(399, 73);
            this.DgvCreditos.Name = "DgvCreditos";
            this.DgvCreditos.Size = new System.Drawing.Size(372, 150);
            this.DgvCreditos.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(399, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(372, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Creditos";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LblCantidadDeudores
            // 
            this.LblCantidadDeudores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCantidadDeudores.Location = new System.Drawing.Point(671, 9);
            this.LblCantidadDeudores.Name = "LblCantidadDeudores";
            this.LblCantidadDeudores.Size = new System.Drawing.Size(100, 23);
            this.LblCantidadDeudores.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ingresos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(776, 424);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 30);
            this.panel5.TabIndex = 13;
            // 
            // LblCapital
            // 
            this.LblCapital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCapital.Location = new System.Drawing.Point(250, 8);
            this.LblCapital.Name = "LblCapital";
            this.LblCapital.Size = new System.Drawing.Size(100, 23);
            this.LblCapital.TabIndex = 15;
            this.LblCapital.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Capital";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(2, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 30);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Peymentstofees.Properties.Resources.excel_office_4658;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(2, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Image = global::Peymentstofees.Properties.Resources.ic_back_97586;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(588, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 30);
            this.button3.TabIndex = 12;
            this.button3.Text = "CERRAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CarteraInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblCapital);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblCantidadDeudores);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DgvCreditos);
            this.Controls.Add(this.LblDineroPrestado);
            this.Controls.Add(this.LblDineroDisponible);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvPagos);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarteraInforme";
            this.Text = "Cartera";
            this.Load += new System.EventHandler(this.Cartera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCreditos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.DataGridView DgvPagos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDineroDisponible;
        private System.Windows.Forms.Label LblDineroPrestado;
        private System.Windows.Forms.DataGridView DgvCreditos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblCantidadDeudores;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LblCapital;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}