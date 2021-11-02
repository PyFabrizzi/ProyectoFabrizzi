﻿
namespace Presentacion
{
    partial class MateriasPrimasListado
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
            this.lbl_TitProvList = new System.Windows.Forms.Label();
            this.btn_CerrarUsuAlta = new System.Windows.Forms.Button();
            this.btn_BuscarProv = new System.Windows.Forms.Button();
            this.lbl_RazonSocial = new System.Windows.Forms.Label();
            this.dgv_ListMateriaPrima = new System.Windows.Forms.DataGridView();
            this.cBox_ProveedorBuscar = new System.Windows.Forms.ComboBox();
            this.btn_BajaProv = new System.Windows.Forms.Button();
            this.btn_ModifProv = new System.Windows.Forms.Button();
            this.btn_ImprimirProv = new System.Windows.Forms.Button();
            this.btn_NuevoProv = new System.Windows.Forms.Button();
            this.cbox_subitpo = new System.Windows.Forms.ComboBox();
            this.lbl_subtipo = new System.Windows.Forms.Label();
            this.cBox_Tipo = new System.Windows.Forms.ComboBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListMateriaPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_TitProvList);
            this.panel1.Controls.Add(this.btn_CerrarUsuAlta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 86);
            this.panel1.TabIndex = 71;
            // 
            // lbl_TitProvList
            // 
            this.lbl_TitProvList.AutoSize = true;
            this.lbl_TitProvList.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitProvList.ForeColor = System.Drawing.Color.White;
            this.lbl_TitProvList.Location = new System.Drawing.Point(313, 26);
            this.lbl_TitProvList.Name = "lbl_TitProvList";
            this.lbl_TitProvList.Size = new System.Drawing.Size(235, 40);
            this.lbl_TitProvList.TabIndex = 66;
            this.lbl_TitProvList.Text = "Materias Primas";
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
            // btn_BuscarProv
            // 
            this.btn_BuscarProv.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_BuscarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarProv.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarProv.Location = new System.Drawing.Point(574, 112);
            this.btn_BuscarProv.Name = "btn_BuscarProv";
            this.btn_BuscarProv.Size = new System.Drawing.Size(140, 39);
            this.btn_BuscarProv.TabIndex = 82;
            this.btn_BuscarProv.Text = "Buscar";
            this.btn_BuscarProv.UseVisualStyleBackColor = false;
            this.btn_BuscarProv.Click += new System.EventHandler(this.btn_BuscarProv_Click);
            // 
            // lbl_RazonSocial
            // 
            this.lbl_RazonSocial.AutoSize = true;
            this.lbl_RazonSocial.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_RazonSocial.ForeColor = System.Drawing.Color.White;
            this.lbl_RazonSocial.Location = new System.Drawing.Point(42, 123);
            this.lbl_RazonSocial.Name = "lbl_RazonSocial";
            this.lbl_RazonSocial.Size = new System.Drawing.Size(82, 17);
            this.lbl_RazonSocial.TabIndex = 79;
            this.lbl_RazonSocial.Text = "Proveedor:";
            // 
            // dgv_ListMateriaPrima
            // 
            this.dgv_ListMateriaPrima.AllowUserToAddRows = false;
            this.dgv_ListMateriaPrima.AllowUserToDeleteRows = false;
            this.dgv_ListMateriaPrima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListMateriaPrima.Location = new System.Drawing.Point(25, 242);
            this.dgv_ListMateriaPrima.Name = "dgv_ListMateriaPrima";
            this.dgv_ListMateriaPrima.ReadOnly = true;
            this.dgv_ListMateriaPrima.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListMateriaPrima.Size = new System.Drawing.Size(777, 154);
            this.dgv_ListMateriaPrima.TabIndex = 77;
      //      this.dgv_ListMateriaPrima.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListProv_CellContentClick);
            // 
            // cBox_ProveedorBuscar
            // 
            this.cBox_ProveedorBuscar.FormattingEnabled = true;
            this.cBox_ProveedorBuscar.Items.AddRange(new object[] {
            "Seleccione",
            "Empleado",
            "Encargado",
            "Supervisor"});
            this.cBox_ProveedorBuscar.Location = new System.Drawing.Point(130, 123);
            this.cBox_ProveedorBuscar.Name = "cBox_ProveedorBuscar";
            this.cBox_ProveedorBuscar.Size = new System.Drawing.Size(328, 21);
            this.cBox_ProveedorBuscar.TabIndex = 83;
            this.cBox_ProveedorBuscar.SelectedIndexChanged += new System.EventHandler(this.cBox_RolBuscar_SelectedIndexChanged);
            // 
            // btn_BajaProv
            // 
            this.btn_BajaProv.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_BajaProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BajaProv.ForeColor = System.Drawing.Color.White;
            this.btn_BajaProv.Location = new System.Drawing.Point(496, 429);
            this.btn_BajaProv.Name = "btn_BajaProv";
            this.btn_BajaProv.Size = new System.Drawing.Size(140, 39);
            this.btn_BajaProv.TabIndex = 89;
            this.btn_BajaProv.Text = "Dar de baja Proveedor";
            this.btn_BajaProv.UseVisualStyleBackColor = false;
            // 
            // btn_ModifProv
            // 
            this.btn_ModifProv.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ModifProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModifProv.ForeColor = System.Drawing.Color.White;
            this.btn_ModifProv.Location = new System.Drawing.Point(165, 429);
            this.btn_ModifProv.Name = "btn_ModifProv";
            this.btn_ModifProv.Size = new System.Drawing.Size(140, 39);
            this.btn_ModifProv.TabIndex = 88;
            this.btn_ModifProv.Text = "Nueva Materia Prima";
            this.btn_ModifProv.UseVisualStyleBackColor = false;
            this.btn_ModifProv.Click += new System.EventHandler(this.btn_ModifProv_Click);
            // 
            // btn_ImprimirProv
            // 
            this.btn_ImprimirProv.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ImprimirProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImprimirProv.ForeColor = System.Drawing.Color.White;
            this.btn_ImprimirProv.Location = new System.Drawing.Point(662, 429);
            this.btn_ImprimirProv.Name = "btn_ImprimirProv";
            this.btn_ImprimirProv.Size = new System.Drawing.Size(140, 39);
            this.btn_ImprimirProv.TabIndex = 87;
            this.btn_ImprimirProv.Text = "Imprimir";
            this.btn_ImprimirProv.UseVisualStyleBackColor = false;
            // 
            // btn_NuevoProv
            // 
            this.btn_NuevoProv.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_NuevoProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoProv.ForeColor = System.Drawing.Color.White;
            this.btn_NuevoProv.Location = new System.Drawing.Point(330, 429);
            this.btn_NuevoProv.Name = "btn_NuevoProv";
            this.btn_NuevoProv.Size = new System.Drawing.Size(140, 39);
            this.btn_NuevoProv.TabIndex = 86;
            this.btn_NuevoProv.Text = "Actualizar Stock";
            this.btn_NuevoProv.UseVisualStyleBackColor = false;
            // 
            // cbox_subitpo
            // 
            this.cbox_subitpo.FormattingEnabled = true;
            this.cbox_subitpo.Location = new System.Drawing.Point(418, 174);
            this.cbox_subitpo.Name = "cbox_subitpo";
            this.cbox_subitpo.Size = new System.Drawing.Size(195, 21);
            this.cbox_subitpo.TabIndex = 95;
            // 
            // lbl_subtipo
            // 
            this.lbl_subtipo.AutoSize = true;
            this.lbl_subtipo.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_subtipo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_subtipo.Location = new System.Drawing.Point(347, 174);
            this.lbl_subtipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_subtipo.Name = "lbl_subtipo";
            this.lbl_subtipo.Size = new System.Drawing.Size(64, 17);
            this.lbl_subtipo.TabIndex = 94;
            this.lbl_subtipo.Text = "Subtipo:";
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
            this.cBox_Tipo.Location = new System.Drawing.Point(101, 174);
            this.cBox_Tipo.Name = "cBox_Tipo";
            this.cBox_Tipo.Size = new System.Drawing.Size(195, 21);
            this.cBox_Tipo.TabIndex = 93;
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Tipo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Tipo.Location = new System.Drawing.Point(42, 174);
            this.lbl_Tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(42, 17);
            this.lbl_Tipo.TabIndex = 92;
            this.lbl_Tipo.Text = "Tipo:";
            // 
            // MateriasPrimasListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(860, 531);
            this.Controls.Add(this.cbox_subitpo);
            this.Controls.Add(this.lbl_subtipo);
            this.Controls.Add(this.cBox_Tipo);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.btn_BajaProv);
            this.Controls.Add(this.btn_ModifProv);
            this.Controls.Add(this.btn_ImprimirProv);
            this.Controls.Add(this.btn_NuevoProv);
            this.Controls.Add(this.cBox_ProveedorBuscar);
            this.Controls.Add(this.btn_BuscarProv);
            this.Controls.Add(this.lbl_RazonSocial);
            this.Controls.Add(this.dgv_ListMateriaPrima);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MateriasPrimasListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MateriasPrimasListado";
            this.Load += new System.EventHandler(this.MateriasPrimasListado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListMateriaPrima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TitProvList;
        private System.Windows.Forms.Button btn_CerrarUsuAlta;
        private System.Windows.Forms.Button btn_BuscarProv;
        public System.Windows.Forms.Label lbl_RazonSocial;
        private System.Windows.Forms.DataGridView dgv_ListMateriaPrima;
        public System.Windows.Forms.ComboBox cBox_ProveedorBuscar;
        public System.Windows.Forms.Button btn_BajaProv;
        public System.Windows.Forms.Button btn_ModifProv;
        private System.Windows.Forms.Button btn_ImprimirProv;
        private System.Windows.Forms.Button btn_NuevoProv;
        private System.Windows.Forms.ComboBox cbox_subitpo;
        public System.Windows.Forms.Label lbl_subtipo;
        private System.Windows.Forms.ComboBox cBox_Tipo;
        public System.Windows.Forms.Label lbl_Tipo;
    }
}