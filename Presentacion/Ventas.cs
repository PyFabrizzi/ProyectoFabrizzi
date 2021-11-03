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
using System.Drawing.Printing;

namespace Presentacion
{
    public partial class Ventas : Form
    {


        public Ventas()
        {
            InitializeComponent();
            //autocompletar();

            LocalNegocio LocNeg = new LocalNegocio();
            dt = LocNeg.ConsultarLocales();
            cboxLocal.DataSource = dt;

            if (dt.Rows.Count != 0)
            {
                DataRow fila = dt.NewRow();
                fila["loc_IdLoc"] = "Seleccione";
                dt.Rows.InsertAt(fila, 0);
                cboxLocal.DataSource = dt; ;
                cboxLocal.DisplayMember = "loc_IdLoc";
                cboxLocal.ValueMember = "loc_Nombre";



            }

        }
       
        DataTable dt = new DataTable();
        VentaNegocio vn = new VentaNegocio();
        private void Ventas_Load(object sender, EventArgs e)
        {
           


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

        private void imprimir(object sender, PrintPageEventArgs e)
        {

        }

        private void btn_ImprimirVentas_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings sc = new PrinterSettings();
        }
    }
}
