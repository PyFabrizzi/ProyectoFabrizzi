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
        public String TipoMp = "";
        private void MateriasPrimasListado_Load(object sender, EventArgs e)
        {

            cBox_Tipo.SelectedIndex = 0;
            //************para llenar el combobox
            var ProvMet = new ProveedorNegocio();
            var dt2 = new DataTable();
            dt2 = ProvMet.ConsultarRZProv();

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

            dgv_ListMateriaPrima.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_ListMateriaPrima.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
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
            

            if (cBox_ProveedorBuscar.SelectedIndex != 0 )
            {
                if (cBox_Tipo.SelectedIndex != 0)
                {
                    dt = MatPriMet.ConsultarMatPrimaporProvyTipo(cuitProv, TipoMp);
                    if (dt.Rows.Count != 0)
                    {
                        dgv_ListMateriaPrima.DataSource = dt; //ds.Tables[0];
                        dgv_ListMateriaPrima.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        dgv_ListMateriaPrima.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    }
                    else
                    {
                        MessageBox.Show("No hay datos registados.");
                    }
                }
                else
                {
                    dt = MatPriMet.ConsultarMatPrimaporProv (cuitProv);
                    if (dt.Rows.Count != 0)
                    {
                        dgv_ListMateriaPrima.DataSource = dt; //ds.Tables[0];
                        dgv_ListMateriaPrima.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        dgv_ListMateriaPrima.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    }
                    else
                    {
                        MessageBox.Show("No hay datos registados.");
                    }
                }
            }
            else if (cBox_Tipo.SelectedIndex != 0)
            {
                dt = MatPriMet.ConsultarMatPrimaporTipo (TipoMp);
                if (dt.Rows.Count != 0)
                {
                    dgv_ListMateriaPrima.DataSource = dt; //ds.Tables[0];
                    dgv_ListMateriaPrima.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dgv_ListMateriaPrima.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                else
                {
                    MessageBox.Show("No hay datos registados.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar algún filtro", "Buscar",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cBox_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoMp = cBox_Tipo.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_ListMateriaPrima.Rows)
            {
                try
                {
                    if (Convert.ToBoolean(row.Cells[1].Value))
                    {
                        foreach (DataGridViewRow row2 in dgv_Envio.Rows)
                        {
                            dgv_Envio[0, row2.Index].Value = dgv_ListMateriaPrima[0, row.Index].Value;
                            dgv_Envio[1, row2.Index].Value = dgv_ListMateriaPrima[2, row.Index].Value;
                            dgv_Envio[2, row2.Index].Value = dgv_ListMateriaPrima[3, row.Index].Value;
                            dgv_Envio[3, row2.Index].Value = dgv_ListMateriaPrima[4, row.Index].Value;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Materias primas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
