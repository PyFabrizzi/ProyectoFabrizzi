
namespace Presentacion
{
    partial class ProductosListado
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
            this.cBox_TipoProd = new System.Windows.Forms.ComboBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.btn_BajaProd = new System.Windows.Forms.Button();
            this.btn_ModifProv = new System.Windows.Forms.Button();
            this.btn_ImprimirProv = new System.Windows.Forms.Button();
            this.btn_NuevoProv = new System.Windows.Forms.Button();
            this.btn_BuscarProducto = new System.Windows.Forms.Button();
            this.dgv_ListProductos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TitProvList = new System.Windows.Forms.Label();
            this.btn_CerrarUsuAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBox_TipoProd
            // 
            this.cBox_TipoProd.FormattingEnabled = true;
            this.cBox_TipoProd.Items.AddRange(new object[] {
            "Seleccione",
            "Abrigos",
            "Accesorios",
            "Ambos",
            "Calzados",
            "Camisas mangas cortas",
            "Camisas mangas largas",
            "Camperas",
            "Pantalones cortos",
            "Pantalones largos",
            "Remeras",
            "Sastreria",
            "Sweaters"});
            this.cBox_TipoProd.Location = new System.Drawing.Point(165, 121);
            this.cBox_TipoProd.Name = "cBox_TipoProd";
            this.cBox_TipoProd.Size = new System.Drawing.Size(195, 21);
            this.cBox_TipoProd.TabIndex = 106;
            this.cBox_TipoProd.SelectedIndexChanged += new System.EventHandler(this.cBox_TipoProd_SelectedIndexChanged);
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Tipo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Tipo.Location = new System.Drawing.Point(95, 125);
            this.lbl_Tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(42, 17);
            this.lbl_Tipo.TabIndex = 105;
            this.lbl_Tipo.Text = "Tipo:";
            // 
            // btn_BajaProd
            // 
            this.btn_BajaProd.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_BajaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BajaProd.ForeColor = System.Drawing.Color.White;
            this.btn_BajaProd.Location = new System.Drawing.Point(496, 420);
            this.btn_BajaProd.Name = "btn_BajaProd";
            this.btn_BajaProd.Size = new System.Drawing.Size(140, 39);
            this.btn_BajaProd.TabIndex = 104;
            this.btn_BajaProd.Text = "Dar de baja Proveedor";
            this.btn_BajaProd.UseVisualStyleBackColor = false;
            // 
            // btn_ModifProv
            // 
            this.btn_ModifProv.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ModifProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModifProv.ForeColor = System.Drawing.Color.White;
            this.btn_ModifProv.Location = new System.Drawing.Point(165, 420);
            this.btn_ModifProv.Name = "btn_ModifProv";
            this.btn_ModifProv.Size = new System.Drawing.Size(140, 39);
            this.btn_ModifProv.TabIndex = 103;
            this.btn_ModifProv.Text = "Nuevo Producto";
            this.btn_ModifProv.UseVisualStyleBackColor = false;
            this.btn_ModifProv.Click += new System.EventHandler(this.btn_ModifProv_Click);
            // 
            // btn_ImprimirProv
            // 
            this.btn_ImprimirProv.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ImprimirProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImprimirProv.ForeColor = System.Drawing.Color.White;
            this.btn_ImprimirProv.Location = new System.Drawing.Point(662, 420);
            this.btn_ImprimirProv.Name = "btn_ImprimirProv";
            this.btn_ImprimirProv.Size = new System.Drawing.Size(140, 39);
            this.btn_ImprimirProv.TabIndex = 102;
            this.btn_ImprimirProv.Text = "Imprimir";
            this.btn_ImprimirProv.UseVisualStyleBackColor = false;
            // 
            // btn_NuevoProv
            // 
            this.btn_NuevoProv.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_NuevoProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoProv.ForeColor = System.Drawing.Color.White;
            this.btn_NuevoProv.Location = new System.Drawing.Point(330, 420);
            this.btn_NuevoProv.Name = "btn_NuevoProv";
            this.btn_NuevoProv.Size = new System.Drawing.Size(140, 39);
            this.btn_NuevoProv.TabIndex = 101;
            this.btn_NuevoProv.Text = "Actualizar Stock";
            this.btn_NuevoProv.UseVisualStyleBackColor = false;
            // 
            // btn_BuscarProducto
            // 
            this.btn_BuscarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_BuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarProducto.Location = new System.Drawing.Point(496, 103);
            this.btn_BuscarProducto.Name = "btn_BuscarProducto";
            this.btn_BuscarProducto.Size = new System.Drawing.Size(140, 39);
            this.btn_BuscarProducto.TabIndex = 99;
            this.btn_BuscarProducto.Text = "Buscar";
            this.btn_BuscarProducto.UseVisualStyleBackColor = false;
            this.btn_BuscarProducto.Click += new System.EventHandler(this.btn_BuscarProducto_Click);
            // 
            // dgv_ListProductos
            // 
            this.dgv_ListProductos.AllowUserToAddRows = false;
            this.dgv_ListProductos.AllowUserToDeleteRows = false;
            this.dgv_ListProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListProductos.Location = new System.Drawing.Point(25, 170);
            this.dgv_ListProductos.Name = "dgv_ListProductos";
            this.dgv_ListProductos.ReadOnly = true;
            this.dgv_ListProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListProductos.Size = new System.Drawing.Size(777, 217);
            this.dgv_ListProductos.TabIndex = 97;
       //     this.dgv_ListProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListProductos_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_TitProvList);
            this.panel1.Controls.Add(this.btn_CerrarUsuAlta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 86);
            this.panel1.TabIndex = 96;
            // 
            // lbl_TitProvList
            // 
            this.lbl_TitProvList.AutoSize = true;
            this.lbl_TitProvList.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitProvList.ForeColor = System.Drawing.Color.White;
            this.lbl_TitProvList.Location = new System.Drawing.Point(313, 26);
            this.lbl_TitProvList.Name = "lbl_TitProvList";
            this.lbl_TitProvList.Size = new System.Drawing.Size(163, 40);
            this.lbl_TitProvList.TabIndex = 66;
            this.lbl_TitProvList.Text = "Productos ";
            // 
            // btn_CerrarUsuAlta
            // 
            this.btn_CerrarUsuAlta.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_CerrarUsuAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_CerrarUsuAlta.ForeColor = System.Drawing.Color.White;
        //    this.btn_CerrarUsuAlta.Location = new System.Drawing.Point(774, 26);
            this.btn_CerrarUsuAlta.Name = "btn_CerrarUsuAlta";
            this.btn_CerrarUsuAlta.Size = new System.Drawing.Size(39, 23);
            this.btn_CerrarUsuAlta.TabIndex = 65;
            this.btn_CerrarUsuAlta.Text = "X";
            this.btn_CerrarUsuAlta.UseVisualStyleBackColor = false;
      //      this.btn_CerrarUsuAlta.Click += new System.EventHandler(this.btn_CerrarUsuAlta_Click);
            // 
            // ProductosListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(844, 492);
            this.Controls.Add(this.cBox_TipoProd);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.btn_BajaProd);
            this.Controls.Add(this.btn_ModifProv);
            this.Controls.Add(this.btn_ImprimirProv);
            this.Controls.Add(this.btn_NuevoProv);
            this.Controls.Add(this.btn_BuscarProducto);
            this.Controls.Add(this.dgv_ListProductos);
            this.Controls.Add(this.panel1);
            this.Name = "ProductosListado";
            this.Text = "ProductosListado";
            this.Load += new System.EventHandler(this.ProductosListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cBox_TipoProd;
        public System.Windows.Forms.Label lbl_Tipo;
        public System.Windows.Forms.Button btn_BajaProd;
        public System.Windows.Forms.Button btn_ModifProv;
        private System.Windows.Forms.Button btn_ImprimirProv;
        private System.Windows.Forms.Button btn_NuevoProv;
        private System.Windows.Forms.Button btn_BuscarProducto;
        private System.Windows.Forms.DataGridView dgv_ListProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TitProvList;
        private System.Windows.Forms.Button btn_CerrarUsuAlta;
    }
}