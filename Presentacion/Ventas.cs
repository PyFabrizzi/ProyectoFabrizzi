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
       

        public Ventas()
        {
            InitializeComponent();
            autocompletar();
          

        }
        Usuario usu_idLocal = new Usuario();
        int legajo = 0;
        int local = 0;
        DataTable dt2 = new DataTable();
        VentaNegocio vn = new VentaNegocio();
        private void Ventas_Load(object sender, EventArgs e)
        {
            //legajo = Convert.ToInt32( lblLegajo.Text);
            //dt2 = vn.ConsultaLocalUsuario(usu_legajo);
           // if ()
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

        private void txtCodProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
