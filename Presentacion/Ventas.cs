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
    public partial class Ventas : Form
    {
        VentaNegocio vn = new VentaNegocio();
        DataTable dt2 = new DataTable();

        public Ventas()
        {
            InitializeComponent();
          

        }

        public void Ventas_Load(object sender, EventArgs e)
        {


            autocompletar();
            dt2 = vn.ConsultaLocal();
            cboxLocal.DataSource = dt2;
            cboxLocal.DisplayMember = "loc_IdDir";
            cboxLocal.ValueMember = "loc_IdDir";


        }









        void autocompletar()
        {
            //AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            //usu_idLocal = local.;
            //DataTable dt = new DataTable();
            //VentaNegocio item = new VentaNegocio();
            //dt = item.VentaConsultarStock(usu_idLocal);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    lista.Add(dt.Rows[i][""].ToString());
            //}
            //txtCodProd.AutoCompleteCustomSource = lista;
        }

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (txtCodProd.TextLength.ToString() != "")
            {

            }
        }

        private void btn_CerrarUsuAlta_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_GuardarVentaProductos_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Desea generar esta nueva venta?", "Nueva Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
    }
}
