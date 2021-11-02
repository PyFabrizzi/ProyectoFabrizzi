using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;

namespace Presentacion
{
    public partial class ProductosListado : Form
    {
        public ProductosListado()
        {
            InitializeComponent();
        }

        private void lbl_RazonSocial_Click(object sender, EventArgs e)
        {

        }

        private void btn_ModifProv_Click(object sender, EventArgs e)
        {
            Productos prod = new Productos();
            prod.Show();
        }

        private void btn_BuscarProducto_Click(object sender, EventArgs e)
        {

          ProductoNegocio prodNegocio = new ProductoNegocio();


            if (cBox_TipoProd.Text != "")
            {
             //   producto.prod_Tipo = cBox_TipoProd.SelectedItem.ToString() ;

                //// producto.prod_Tipo = cBox_TipoProd.Text;
                //DataTable dt = new DataTable();
                //dt = prodNegocio.ConsultarProdXTipo(producto);
                //dgv_ListProductos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No hay disponibilidad del producto seleccionado, seleccione otro tipo");


            }


        }

        private void cBox_TipoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void ProductosListado_Load(object sender, EventArgs e)
        {
             cBox_TipoProd.SelectedIndex = 0;
        }
    }
}





