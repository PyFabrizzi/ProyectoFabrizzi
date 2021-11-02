﻿namespace Presentacion
{
    partial class MateriasPrimas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TitProv = new System.Windows.Forms.Label();
            this.btn_CerrarUsuAlta = new System.Windows.Forms.Button();
            this.tBox_Desc = new System.Windows.Forms.TextBox();
            this.tBox_CodArt = new System.Windows.Forms.TextBox();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.lbl_CodArt = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.cBox_Tipo = new System.Windows.Forms.ComboBox();
            this.lbl_Proveedor = new System.Windows.Forms.Label();
            this.btn_GuardarMatPri = new System.Windows.Forms.Button();
            this.cBox_Proveedores = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CargarNuevoArt = new System.Windows.Forms.Button();
            this.cbox_Subtipo = new System.Windows.Forms.ComboBox();
            this.lbl_subtipo = new System.Windows.Forms.Label();
            this.tbox_CantPaq = new System.Windows.Forms.TextBox();
            this.lbl_CantPaq = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_TitProv);
            this.panel1.Controls.Add(this.btn_CerrarUsuAlta);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 86);
            this.panel1.TabIndex = 70;
            // 
            // lbl_TitProv
            // 
            this.lbl_TitProv.AutoSize = true;
            this.lbl_TitProv.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitProv.ForeColor = System.Drawing.Color.White;
            this.lbl_TitProv.Location = new System.Drawing.Point(301, 26);
            this.lbl_TitProv.Name = "lbl_TitProv";
            this.lbl_TitProv.Size = new System.Drawing.Size(342, 40);
            this.lbl_TitProv.TabIndex = 66;
            this.lbl_TitProv.Text = "Alta de materias primas";
            // 
            // btn_CerrarUsuAlta
            // 
            this.btn_CerrarUsuAlta.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_CerrarUsuAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_CerrarUsuAlta.ForeColor = System.Drawing.Color.White;
            this.btn_CerrarUsuAlta.Location = new System.Drawing.Point(774, 26);
            this.btn_CerrarUsuAlta.Name = "btn_CerrarUsuAlta";
            this.btn_CerrarUsuAlta.Size = new System.Drawing.Size(39, 23);
            this.btn_CerrarUsuAlta.TabIndex = 65;
            this.btn_CerrarUsuAlta.Text = "X";
            this.btn_CerrarUsuAlta.UseVisualStyleBackColor = false;
            this.btn_CerrarUsuAlta.Click += new System.EventHandler(this.btn_CerrarUsuAlta_Click);
            // 
            // tBox_Desc
            // 
            this.tBox_Desc.Location = new System.Drawing.Point(214, 237);
            this.tBox_Desc.Name = "tBox_Desc";
            this.tBox_Desc.Size = new System.Drawing.Size(229, 20);
            this.tBox_Desc.TabIndex = 81;
            // 
            // tBox_CodArt
            // 
            this.tBox_CodArt.Location = new System.Drawing.Point(214, 138);
            this.tBox_CodArt.Name = "tBox_CodArt";
            this.tBox_CodArt.Size = new System.Drawing.Size(195, 20);
            this.tBox_CodArt.TabIndex = 80;
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Desc.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Desc.Location = new System.Drawing.Point(106, 240);
            this.lbl_Desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(91, 17);
            this.lbl_Desc.TabIndex = 79;
            this.lbl_Desc.Text = "Descripción:";
            // 
            // lbl_CodArt
            // 
            this.lbl_CodArt.AutoSize = true;
            this.lbl_CodArt.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CodArt.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_CodArt.Location = new System.Drawing.Point(58, 138);
            this.lbl_CodArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CodArt.Name = "lbl_CodArt";
            this.lbl_CodArt.Size = new System.Drawing.Size(139, 17);
            this.lbl_CodArt.TabIndex = 78;
            this.lbl_CodArt.Text = "Código de artículo:";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Tipo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Tipo.Location = new System.Drawing.Point(155, 184);
            this.lbl_Tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(42, 17);
            this.lbl_Tipo.TabIndex = 82;
            this.lbl_Tipo.Text = "Tipo:";
            // 
            // cBox_Tipo
            // 
            this.cBox_Tipo.FormattingEnabled = true;
            this.cBox_Tipo.Items.AddRange(new object[] {
            "Seleccione",
            "De Confección",
            "De Corte",
            "Maquinarias",
            "Otros"});
            this.cBox_Tipo.Location = new System.Drawing.Point(214, 184);
            this.cBox_Tipo.Name = "cBox_Tipo";
            this.cBox_Tipo.Size = new System.Drawing.Size(195, 21);
            this.cBox_Tipo.TabIndex = 83;
            this.cBox_Tipo.SelectedIndexChanged += new System.EventHandler(this.cBox_Tipo_SelectedIndexChanged);
            // 
            // lbl_Proveedor
            // 
            this.lbl_Proveedor.AutoSize = true;
            this.lbl_Proveedor.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Proveedor.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Proveedor.Location = new System.Drawing.Point(116, 284);
            this.lbl_Proveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Proveedor.Name = "lbl_Proveedor";
            this.lbl_Proveedor.Size = new System.Drawing.Size(82, 17);
            this.lbl_Proveedor.TabIndex = 84;
            this.lbl_Proveedor.Text = "Proveedor:";
            // 
            // btn_GuardarMatPri
            // 
            this.btn_GuardarMatPri.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_GuardarMatPri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_GuardarMatPri.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarMatPri.Location = new System.Drawing.Point(673, 390);
            this.btn_GuardarMatPri.Name = "btn_GuardarMatPri";
            this.btn_GuardarMatPri.Size = new System.Drawing.Size(140, 39);
            this.btn_GuardarMatPri.TabIndex = 86;
            this.btn_GuardarMatPri.Text = "Guardar y salir";
            this.btn_GuardarMatPri.UseVisualStyleBackColor = false;
            this.btn_GuardarMatPri.Click += new System.EventHandler(this.btn_GuardarMatPri_Click);
            // 
            // cBox_Proveedores
            // 
            this.cBox_Proveedores.FormattingEnabled = true;
            this.cBox_Proveedores.Location = new System.Drawing.Point(214, 280);
            this.cBox_Proveedores.Name = "cBox_Proveedores";
            this.cBox_Proveedores.Size = new System.Drawing.Size(229, 21);
            this.cBox_Proveedores.TabIndex = 87;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.SeaGreen;
            this.linkLabel1.Location = new System.Drawing.Point(460, 288);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 13);
            this.linkLabel1.TabIndex = 88;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Dar de alta nuevo proveedor.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CargarNuevoArt
            // 
            this.CargarNuevoArt.BackColor = System.Drawing.Color.SeaGreen;
            this.CargarNuevoArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.CargarNuevoArt.ForeColor = System.Drawing.Color.White;
            this.CargarNuevoArt.Location = new System.Drawing.Point(503, 390);
            this.CargarNuevoArt.Name = "CargarNuevoArt";
            this.CargarNuevoArt.Size = new System.Drawing.Size(140, 39);
            this.CargarNuevoArt.TabIndex = 89;
            this.CargarNuevoArt.Text = "Cargar nuevo articulo";
            this.CargarNuevoArt.UseVisualStyleBackColor = false;
            this.CargarNuevoArt.Click += new System.EventHandler(this.CargarNuevoArt_Click);
            // 
            // cbox_Subtipo
            // 
            this.cbox_Subtipo.FormattingEnabled = true;
            this.cbox_Subtipo.Location = new System.Drawing.Point(531, 184);
            this.cbox_Subtipo.Name = "cbox_Subtipo";
            this.cbox_Subtipo.Size = new System.Drawing.Size(195, 21);
            this.cbox_Subtipo.TabIndex = 91;
            // 
            // lbl_subtipo
            // 
            this.lbl_subtipo.AutoSize = true;
            this.lbl_subtipo.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_subtipo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_subtipo.Location = new System.Drawing.Point(460, 184);
            this.lbl_subtipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_subtipo.Name = "lbl_subtipo";
            this.lbl_subtipo.Size = new System.Drawing.Size(64, 17);
            this.lbl_subtipo.TabIndex = 90;
            this.lbl_subtipo.Text = "Subtipo:";
            // 
            // tbox_CantPaq
            // 
            this.tbox_CantPaq.Location = new System.Drawing.Point(274, 347);
            this.tbox_CantPaq.Name = "tbox_CantPaq";
            this.tbox_CantPaq.Size = new System.Drawing.Size(169, 20);
            this.tbox_CantPaq.TabIndex = 93;
            // 
            // lbl_CantPaq
            // 
            this.lbl_CantPaq.AutoSize = true;
            this.lbl_CantPaq.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CantPaq.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_CantPaq.Location = new System.Drawing.Point(106, 350);
            this.lbl_CantPaq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CantPaq.Name = "lbl_CantPaq";
            this.lbl_CantPaq.Size = new System.Drawing.Size(161, 17);
            this.lbl_CantPaq.TabIndex = 92;
            this.lbl_CantPaq.Text = "Cantidad de paquetes:";
            // 
            // MateriasPrimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(860, 531);
            this.Controls.Add(this.tbox_CantPaq);
            this.Controls.Add(this.lbl_CantPaq);
            this.Controls.Add(this.cbox_Subtipo);
            this.Controls.Add(this.lbl_subtipo);
            this.Controls.Add(this.CargarNuevoArt);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cBox_Proveedores);
            this.Controls.Add(this.btn_GuardarMatPri);
            this.Controls.Add(this.lbl_Proveedor);
            this.Controls.Add(this.cBox_Tipo);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.tBox_Desc);
            this.Controls.Add(this.tBox_CodArt);
            this.Controls.Add(this.lbl_Desc);
            this.Controls.Add(this.lbl_CodArt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MateriasPrimas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MateriasPrimas";
            this.Load += new System.EventHandler(this.MateriasPrimas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TitProv;
        private System.Windows.Forms.Button btn_CerrarUsuAlta;
        private System.Windows.Forms.TextBox tBox_Desc;
        private System.Windows.Forms.TextBox tBox_CodArt;
        public System.Windows.Forms.Label lbl_Desc;
        public System.Windows.Forms.Label lbl_CodArt;
        public System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.ComboBox cBox_Tipo;
        public System.Windows.Forms.Label lbl_Proveedor;
        public System.Windows.Forms.Button btn_GuardarMatPri;
        private System.Windows.Forms.ComboBox cBox_Proveedores;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Button CargarNuevoArt;
        private System.Windows.Forms.ComboBox cbox_Subtipo;
        public System.Windows.Forms.Label lbl_subtipo;
        private System.Windows.Forms.TextBox tbox_CantPaq;
        public System.Windows.Forms.Label lbl_CantPaq;
    }
}