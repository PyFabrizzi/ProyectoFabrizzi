using System;
using System.Data;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;

namespace Presentacion
{
    public partial class MateriasPrimas : Form
    {
        public MateriasPrimas()
        {
            InitializeComponent();
        }

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Proveedores provAlta = new Proveedores();
            provAlta.Show();
        }

        private void btn_GuardarMatPri_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Va a dar de alta un artículo de materia prima, desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var matPriNew = new MateriaPrima();
            var matPriMet = new MateriaPrimaNegocio();
            var dt = new DataTable();

            matPriNew.mpri_tipo = cBox_Tipo.SelectedItem.ToString();
            matPriNew.mpri_CodArt = tBox_CodArt.Text;
            matPriNew.mpri_Descripcion = tBox_Desc.Text;
            matPriNew.mpri_CUITprov = cBox_Proveedores.SelectedValue.ToString();
            matPriNew.mpri_Cantidad = Convert.ToInt32( (tbox_CantPaq.Text));


            if ((resp == DialogResult.Yes))
            {
                if (tBox_CodArt.Text != "")
                {
                    if (cBox_Tipo.SelectedIndex != 0)
                    {
                        Boolean grabo = matPriMet.grabarMatPri(matPriNew);
                        if (grabo == true)
                        {
                            MessageBox.Show("Se registro el artículo para materia prima", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            MateriasPrimasListado MatPriList = new MateriasPrimasListado();
                            MatPriList.Show();

                        }


                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un tipo de artículo.", "Tipo artículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                else
                {
                    MessageBox.Show("Debe ingresar el código de artículo que figura en el remito.", "Código artículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void MateriasPrimas_Load(object sender, EventArgs e)
        {
            cBox_Tipo.SelectedIndex = 0;
            var ProvMet = new ProveedorNegocio();
            var dt2 = new DataTable();
            dt2 = ProvMet.ConsultarRZProv();

            if (dt2.Rows.Count != 0)
            {
                DataRow fila = dt2.NewRow();
                fila["RzProv"] = "Seleccione";
                dt2.Rows.InsertAt(fila, 0);
                cBox_Proveedores.DataSource = dt2; ;
                cBox_Proveedores.DisplayMember = "RzProv";
                cBox_Proveedores.ValueMember = "cuit";
            }


        }

        private void CargarNuevoArt_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Primero guardaremos el articulo actual, desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var matPriNew = new MateriaPrima();
            var matPriMet = new MateriaPrimaNegocio();
            var dt = new DataTable();
            matPriNew.mpri_tipo = cBox_Tipo.SelectedItem.ToString();
            matPriNew.mpri_CodArt = tBox_CodArt.Text;
            matPriNew.mpri_Descripcion = tBox_Desc.Text;
            matPriNew.mpri_CUITprov = cBox_Proveedores.SelectedValue.ToString();
            matPriNew.mpri_subtipo = cbox_Subtipo.SelectedItem.ToString();
            matPriNew.mpri_Cantidad = Convert.ToInt32((tbox_CantPaq.Text));

            if ((resp == DialogResult.Yes))
            {
                if (tBox_CodArt.Text != "")
                {
                    if (cBox_Tipo.SelectedIndex != 0)
                    {
                        Boolean grabo = matPriMet.grabarMatPri(matPriNew);
                        if (grabo == true)
                        {
                            MessageBox.Show("Se registro el artículo para materia prima", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tBox_CodArt.Text = "";
                            cBox_Tipo.SelectedIndex = 0;
                            tBox_Desc.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("No se registro el artículo para materia prima", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un tipo de artículo.", "Tipo artículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el código de artículo que figura en el remito.", "Código artículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }




        }

        private void cBox_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipo = cBox_Tipo.SelectedIndex;
            
            switch (tipo)
            {
                case 1:
                    cbox_Subtipo.Items.Clear();
                    cbox_Subtipo.Items.Add("Seleccione");
                    cbox_Subtipo.Items.Add("Abrojo");
                    cbox_Subtipo.Items.Add("Cierres");
                    cbox_Subtipo.Items.Add("Cierres en cadena");
                    cbox_Subtipo.Items.Add("Cierres finos");
                    cbox_Subtipo.Items.Add("Cinta al bies");
                    cbox_Subtipo.Items.Add("Cinta fruncidoras");
                    cbox_Subtipo.Items.Add("Cinta gross");
                    cbox_Subtipo.Items.Add("Cono de hilo");
                    cbox_Subtipo.Items.Add("Cordon");
                    cbox_Subtipo.Items.Add("Elástico liso");
                    cbox_Subtipo.Items.Add("Elástico redondo");
                    cbox_Subtipo.Items.Add("Hombreras");
                    cbox_Subtipo.Items.Add("Hormillas");
                    cbox_Subtipo.Items.Add("Matriz de broche");
                    cbox_Subtipo.Items.Add("Telas");
                    cbox_Subtipo.Items.Add("Tizas de modista");
                    cbox_Subtipo.SelectedIndex = 0;
                    break;
                case 2:
                    cbox_Subtipo.Items.Clear();
                    cbox_Subtipo.Items.Add("Seleccione");
                    cbox_Subtipo.Items.Add("Alfileres");
                    cbox_Subtipo.Items.Add("Centimetro plástico");
                    cbox_Subtipo.Items.Add("Escuadra");
                    cbox_Subtipo.Items.Add("Pinza prensatela fija");
                    cbox_Subtipo.Items.Add("Tijera");
                    cbox_Subtipo.SelectedIndex = 0;
                    break;
                case 3:
                    cbox_Subtipo.Items.Clear();
                    cbox_Subtipo.Items.Add("Seleccione");
                    cbox_Subtipo.Items.Add("Agujas de máquina");
                    cbox_Subtipo.Items.Add("Base roluet Zic-Zac");
                    cbox_Subtipo.Items.Add("Bobinas");
                    cbox_Subtipo.Items.Add("Carreteles");
                    cbox_Subtipo.Items.Add("Correa dentada");
                    cbox_Subtipo.Items.Add("Correa de cuero");
                    cbox_Subtipo.Items.Add("Dedales");
                    cbox_Subtipo.Items.Add("Enhebrador con lupa");
                    cbox_Subtipo.Items.Add("Guías");
                    cbox_Subtipo.Items.Add("Porta cono");
                    cbox_Subtipo.Items.Add("Porta etiquetas");
                    cbox_Subtipo.SelectedIndex = 0;
                    break; 

            }

        }
    }
}//itati pulgar
