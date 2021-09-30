namespace Peymentstofees
{
    partial class Abono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abono));
            this.label2 = new System.Windows.Forms.Label();
            this.LblInfoCredito = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbQueAbonara = new System.Windows.Forms.ComboBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PnlDecorativoBtnBuscar = new System.Windows.Forms.Panel();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // LblInfoCredito
            // 
            resources.ApplyResources(this.LblInfoCredito, "LblInfoCredito");
            this.LblInfoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblInfoCredito.Name = "LblInfoCredito";
            this.LblInfoCredito.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtIdentificacion
            // 
            resources.ApplyResources(this.TxtIdentificacion, "TxtIdentificacion");
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // CmbQueAbonara
            // 
            this.CmbQueAbonara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbQueAbonara.FormattingEnabled = true;
            this.CmbQueAbonara.Items.AddRange(new object[] {
            resources.GetString("CmbQueAbonara.Items"),
            resources.GetString("CmbQueAbonara.Items1"),
            resources.GetString("CmbQueAbonara.Items2")});
            resources.ApplyResources(this.CmbQueAbonara, "CmbQueAbonara");
            this.CmbQueAbonara.Name = "CmbQueAbonara";
            this.CmbQueAbonara.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LblCantidad
            // 
            resources.ApplyResources(this.LblCantidad, "LblCantidad");
            this.LblCantidad.Name = "LblCantidad";
            // 
            // TxtCantidad
            // 
            resources.ApplyResources(this.TxtCantidad, "TxtCantidad");
            this.TxtCantidad.Name = "TxtCantidad";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // PnlDecorativoBtnBuscar
            // 
            this.PnlDecorativoBtnBuscar.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.PnlDecorativoBtnBuscar, "PnlDecorativoBtnBuscar");
            this.PnlDecorativoBtnBuscar.Name = "PnlDecorativoBtnBuscar";
            // 
            // lblIdentificacion
            // 
            resources.ApplyResources(this.lblIdentificacion, "lblIdentificacion");
            this.lblIdentificacion.Name = "lblIdentificacion";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Name = "panel5";
            // 
            // BtnCerrar
            // 
            resources.ApplyResources(this.BtnCerrar, "BtnCerrar");
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCerrar.Image = global::Peymentstofees.Properties.Resources.ic_back_97586;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.BtnBuscar, "BtnBuscar");
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnBuscar.Image = global::Peymentstofees.Properties.Resources.ic_search_97602;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = global::Peymentstofees.Properties.Resources.credit_card_with_check_symbol_icon_icons_com_56181;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Abono
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.PnlDecorativoBtnBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.CmbQueAbonara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.LblInfoCredito);
            this.Controls.Add(this.label2);
            this.Name = "Abono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblInfoCredito;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbQueAbonara;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel PnlDecorativoBtnBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnCerrar;
    }
}