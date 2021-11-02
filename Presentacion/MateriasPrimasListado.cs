using System;
using System.Data;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;

namespace Presentacion
{
    public partial class MateriasPrimasListado : Form
    {
        public MateriasPrimasListado()
        {
            InitializeComponent();
        }
        public String cuitProv = "";
        private void MateriasPrimasListado_Load(object sender, EventArgs e)
        {
            //************para llenar el combobox
            var ProvMet = new ProveedorNegocio();
            var dt2 = new DataTable();
            dt2= ProvMet.ConsultarRZProv();
            
            if (dt2.Rows.Count != 0) 
            {
                DataRow fila = dt2.NewRow();
                fila["RzProv"] = "Seleccione";
                dt2.Rows.InsertAt(fila, 0);
                cBox_ProveedorBuscar.DataSource = dt2;
                cBox_ProveedorBuscar.DisplayMember = "RzProv";
                cBox_ProveedorBuscar.ValueMember = "cuit";
            }
            //************************para llenar el dgv cuando carga
            var ds = new DataSet();
            var dt = new DataTable();
            var MatPriMet = new MateriaPrimaNegocio();
            dt = MatPriMet.ConsultarMateria();


            if (dt.Rows.Count != 0)
            {
                dgv_ListMateriaPrima.DataSource = dt; //ds.Tables[0];

            }
            else
            {
                MessageBox.Show("No hay datos registados.");
            }
        }

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void btn_ModifProv_Click(object sender, EventArgs e)
        {
            MateriasPrimas mPri = new MateriasPrimas();
            mPri.Show();
            this.Close();

        }

        private void cBox_RolBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cuitProv = cBox_ProveedorBuscar.SelectedValue.ToString();
            
        }

        private void btn_BuscarProv_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            var MatPriMet = new MateriaPrimaNegocio();
            dt = MatPriMet.ConsultarMatPrimaporProv(cuitProv);


            if (dt.Rows.Count != 0)
            {
                dgv_ListMateriaPrima.DataSource = dt; //ds.Tables[0];

            }
            else
            {
                MessageBox.Show("No hay datos registados.");
            }

        }
    }
}
