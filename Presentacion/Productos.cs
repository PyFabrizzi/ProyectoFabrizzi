using System;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;
using System.Data;


namespace Presentacion
{

    public partial class Productos : Form
    {
        public String piso;
        public int estante;
        public int perchero;
        public int nivel;
        public String temporada;
        public String InicialTemp;
        public int codigoArt;
        public String talle;
        public int StockMin;
        public int StockMax;
        public String colorID;
        public String descripcion;
        public String anio =DateTime.Now.Year.ToString(); 
        public int idUbicacion;

        public Productos()
        {
            InitializeComponent();
        }

        private void cBox_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            int tipoProd = cBox_TipoProd.SelectedIndex;
            if (cBox_Estado.SelectedItem.ToString() == "Outlet")
            {
                switch (tipoProd)
                {
                    case 1://abrigos
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Gaban");
                        cbox_SubtipoProd.Items.Add("Montgomery");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PA - Estante 5 - Nivel 1";
                        codigoArt = 1049;
                        piso = "PA";
                        estante = 5;
                        perchero = 0;
                        nivel = 1;
                        break;
                    case 2://accesosrios
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Cinto");
                        cbox_SubtipoProd.Items.Add("Corbata");
                        cbox_SubtipoProd.Items.Add("Corbatín");
                        cbox_SubtipoProd.Items.Add("Gemelos");
                        cbox_SubtipoProd.Items.Add("Moños");
                        cbox_SubtipoProd.Items.Add("Pañuelo");
                        cbox_SubtipoProd.Items.Add("Tiradores");
                        cbox_SubtipoProd.Items.Add("Traba corbata");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PA - Estante 5 - Nivel 5";
                        piso = "PA";
                        estante = 5;
                        perchero = 0;
                        nivel = 5;
                        break;
                    case 3://calzado
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Urbano");
                        cbox_SubtipoProd.Items.Add("Vestir c/cordones");
                        cbox_SubtipoProd.Items.Add("Vestir s/cordones");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PA - Estante 5 - Nivel 4";
                        piso = "PA";
                        estante = 5;
                        perchero = 0;
                        nivel = 4;
                        break;
                    case 4://camisas manga corta
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Fantasia");
                        cbox_SubtipoProd.Items.Add("Vestir");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PA - Estante 5 - Nivel 3";
                        piso = "PA";
                        estante = 5;
                        perchero = 0;
                        nivel = 3;
                        break;
                    case 5://camisas manga larga
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Fantasia");
                        cbox_SubtipoProd.Items.Add("Vestir");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PA - Estante 5 - Nivel 3";
                        piso = "PA";
                        estante = 5;
                        perchero = 0;
                        nivel = 3;
                        break;
                    case 6://camperas
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Cuero");
                        cbox_SubtipoProd.Items.Add("Inflables");
                        cbox_SubtipoProd.Items.Add("Parkas");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PA - Estante 5 - Nivel 1";
                        piso = "PA";
                        estante = 5;
                        perchero = 0;
                        nivel = 1;
                        break;
                    case 7://pantalon corto
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Chino");
                        cbox_SubtipoProd.Items.Add("Jean");
                        cbox_SubtipoProd.Items.Add("Jogging");
                        cbox_SubtipoProd.Items.Add("Malla");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PA - Estante 5 - Nivel 2";
                        piso = "PA";
                        estante = 5;
                        perchero = 0;
                        nivel = 2;
                        break;
                    case 8://pantalon largo
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Chino");
                        cbox_SubtipoProd.Items.Add("Jean");
                        cbox_SubtipoProd.Items.Add("Jogging");
                        cbox_SubtipoProd.Items.Add("Vestir");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PA - Estante 5 - Nivel 2";
                        piso = "PA";
                        estante = 5;
                        perchero = 0;
                        nivel = 2;
                        break;
                    case 9://remera
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Cuello Base");
                        cbox_SubtipoProd.Items.Add("Cuello pique");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PA - Estante 5 - Nivel 3";
                        piso = "PA";
                        estante = 5;
                        perchero = 0;
                        nivel = 3;
                        break;

                    case 10://sastreria
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Ambo");
                        cbox_SubtipoProd.Items.Add("Saco");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        break;

                    case 11://Sweaters
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Cuello en V Algodon");
                        cbox_SubtipoProd.Items.Add("Cuello en V Bremer");
                        cbox_SubtipoProd.Items.Add("Cuello redondo Algodon");
                        cbox_SubtipoProd.Items.Add("Cuello redondo Bremer");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PA - Estante 5 - Nivel 1";
                        piso = "PA";
                        estante = 5;
                        perchero = 0;
                        nivel = 1;
                        break;
                    default:
                        break;
                }
            }
            else
            {

                switch (tipoProd)
                {
                    case 1://abrigos
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Gaban");
                        cbox_SubtipoProd.Items.Add("Montgomery");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        codigoArt = 1000;
                        tBox_UbiEnDepo.Text = "PB - Perchero 1";
                        piso = "PB";
                        estante = 0;
                        perchero = 1;
                        nivel = 0;
                        break;
                    case 2://accesosrios
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Cinto");
                        cbox_SubtipoProd.Items.Add("Corbata");
                        cbox_SubtipoProd.Items.Add("Corbatín");
                        cbox_SubtipoProd.Items.Add("Gemelos");
                        cbox_SubtipoProd.Items.Add("Moños");
                        cbox_SubtipoProd.Items.Add("Pañuelo");
                        cbox_SubtipoProd.Items.Add("Tiradores");
                        cbox_SubtipoProd.Items.Add("Traba corbata");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PA - Estante 4 - Nivel 1";
                        piso = "PA";
                        estante = 4;
                        perchero = 0;
                        nivel = 1;

                        break;

                    case 3://calzado
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Urbano");
                        cbox_SubtipoProd.Items.Add("Vestir c/cordones");
                        cbox_SubtipoProd.Items.Add("Vestir s/cordones");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PA - Estante 4 - Nivel 1";
                        piso = "PA";
                        estante = 4;
                        perchero = 0;
                        nivel = 2;

                        break;
                    case 4://camisas manga corta
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Fantasia");
                        cbox_SubtipoProd.Items.Add("Vestir");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PA - Estante 4 - Nivel 1";
                        piso = "PA";
                        estante = 3;
                        perchero = 0;
                        nivel = 1;

                        break;
                    case 5://camisas manga larga
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Fantasia");
                        cbox_SubtipoProd.Items.Add("Vestir");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PA - Estante 4 - Nivel 1";
                        piso = "PA";
                        estante = 3;
                        perchero = 0;
                        nivel = 3;

                        break;
                    case 6://camperas
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Cuero");
                        cbox_SubtipoProd.Items.Add("Inflables");
                        cbox_SubtipoProd.Items.Add("Parkas");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PB - Perchero 1";
                        piso = "PB";
                        estante = 0;
                        perchero = 1;
                        nivel = 0;
                        break;
                    case 7://pantalon corto
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Chino");
                        cbox_SubtipoProd.Items.Add("Jean");
                        cbox_SubtipoProd.Items.Add("Jogging");
                        cbox_SubtipoProd.Items.Add("Malla");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PB - Estante 2 - Nivel 1";
                        piso = "PB";
                        estante = 2;
                        perchero = 0;
                        nivel = 1;

                        break;
                    case 8://pantalon largo
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Chino");
                        cbox_SubtipoProd.Items.Add("Jean");
                        cbox_SubtipoProd.Items.Add("Jogging");
                        cbox_SubtipoProd.Items.Add("Malla");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PB - Estante 2 - Nivel 3";
                        piso = "PB";
                        estante = 2;
                        perchero = 0;
                        nivel = 3;
                        break;
                    case 9://remera
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Cuello Base");
                        cbox_SubtipoProd.Items.Add("Cuello pique");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        tBox_UbiEnDepo.Text = "PA - Estante 3 - Nivel 1";
                        piso = "PA";
                        estante = 3;
                        perchero = 0;
                        nivel = 1;
                        break;

                    case 10: //Sastreria
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Ambo");
                        cbox_SubtipoProd.Items.Add("Saco");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        
                        break;

                    case 11://Sweaters
                        cbox_SubtipoProd.Items.Clear();
                        cbox_SubtipoProd.Items.Add("Seleccione");
                        cbox_SubtipoProd.Items.Add("Cuello en V Algodon");
                        cbox_SubtipoProd.Items.Add("Cuello en V Bremer");
                        cbox_SubtipoProd.Items.Add("Cuello redondo Algodon");
                        cbox_SubtipoProd.Items.Add("Cuello redondo Bremer");
                        cbox_SubtipoProd.SelectedIndex = 0;
                        piso = "PB";
                        estante = 1;
                        perchero = 0;
                        nivel = 1;
                        break;
                    default:
                        break;
                }
            }

        }

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Productos_Load(object sender, EventArgs e)
        {
            cBox_Estado.SelectedIndex = 0;
            cBox_TipoProd.SelectedIndex = 0;
            cBox_Talle.SelectedIndex = 0;
            cBox_Temporada.SelectedIndex = 0;

            ProductoNegocio prodNeg = new ProductoNegocio();
            var dt = new DataTable();
            dt = prodNeg.ConsultarColor();

            if (dt.Rows.Count != 0)
            {
                DataRow fila = dt.NewRow();
                fila["Nombre"] = "Seleccione";
                dt.Rows.InsertAt(fila, 0);
                cBox_Color.DataSource = dt; ;
                cBox_Color.DisplayMember = "Nombre";
                cBox_Color.ValueMember = "ID";
            }

        }

       

        private void CargarNuevoArt_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Esta generando una nuevo Producto, desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            ProductoNegocio prodNeg = new ProductoNegocio();
            UbicacionEnDepoNegocio ubiEnDep = new UbicacionEnDepoNegocio();
            Producto prodEnt = new Producto();
            var dt = new DataTable();

            dt = ubiEnDep.ConsultarUbicacionID(piso, estante, perchero, nivel);

            if (dt.Rows.Count == 1)
            {
                //DataRow row = dt.Rows[0];

                idUbicacion =Convert.ToInt32 ( dt.Rows[0]["ID"].ToString());
                prodEnt.prod_UbiEnDepo = idUbicacion;
            }
            prodEnt.prod_Anio = anio;
            String estado = cBox_Estado.SelectedItem.ToString();
            if (estado == "Venta")
            {
                prodEnt.prod_Estado = cBox_Estado.SelectedItem.ToString();
                
                temporada = cBox_Temporada.SelectedItem.ToString();


                if (temporada == "Primavera-Verano")
                {
                    InicialTemp = "V";

                    prodEnt.prod_Temporada = temporada;
                }
                else
                {
                    InicialTemp = "I";
                    prodEnt.prod_Temporada = temporada;
                }


                if (cBox_TipoProd.SelectedIndex == 11)
                {
                    if (cbox_SubtipoProd.SelectedIndex == 1)
                    {
                        codigoArt = 1050;
                        tBox_UbiEnDepo.Text = "PB - Perchero 2";
                        piso = "PB";
                        estante = 0;
                        perchero = 2;
                        nivel = 0;

                    } else
                    {
                        codigoArt = 1100;
                        tBox_UbiEnDepo.Text = "PB - Perchero 3";
                        piso = "PB";
                        estante = 0;
                        perchero = 3;
                        nivel = 0;
                    }
                }

                prodEnt.prod_Tipo = cBox_TipoProd.SelectedItem.ToString();
                prodEnt.prod_subTipo = cbox_SubtipoProd.SelectedItem.ToString();

                if (cBox_Talle.SelectedIndex != 0)
                {
                    talle = cBox_Talle.SelectedItem.ToString();
                    prodEnt.prod_Talle = talle;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un talle.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (tBox_StockMin.Text != "")
                {
                    StockMin = Convert.ToInt32(tBox_StockMin.Text);
                    prodEnt.prod_StockMin = StockMin;
                }
                else
                {
                    MessageBox.Show("Debe ingresar la stock mínimo para el producto.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (tBox_StockMax.Text != "")
                {
                    StockMax = Convert.ToInt32(tBox_StockMax.Text);
                    prodEnt.prod_StockMax = StockMax;
                }
                else
                {
                    MessageBox.Show("Debe ingresar la stock máximo para el producto.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (cBox_Color.SelectedIndex != 0)
                {
                    colorID = cBox_Color.SelectedValue.ToString();
                    prodEnt.prod_Color = colorID;
                    descripcion = tBox_Desc.Text;
                    prodEnt.prod_Descripción = descripcion;

                    prodEnt.prod_CodDeProd = InicialTemp + anio + codigoArt + talle + colorID  ;
                    prodEnt.prod_Fecha = DateTime.Now;

                    Boolean nuevoProd = prodNeg.NuevoProducto(prodEnt);
                    if (nuevoProd == true)
                    {
                        MessageBox.Show("Se registro el producto correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se registro el producto.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un color.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (estado == "Outlet")
            {
                prodEnt.prod_Estado = cBox_Estado.SelectedItem.ToString();

                prodEnt.prod_Temporada = cBox_Temporada.SelectedItem.ToString();

                InicialTemp = "O";
                if (cBox_TipoProd.SelectedIndex == 11)
                {
                    if (cbox_SubtipoProd.SelectedIndex == 1)
                    {
                        codigoArt = 1099;
                        tBox_UbiEnDepo.Text = "PA - Estante 5 - Nivel 1";
                        piso = "PA";
                        estante = 5;
                        perchero = 0;
                        nivel = 1;
                    }
                    else
                    {
                        codigoArt = 1199;
                        tBox_UbiEnDepo.Text = "PA - Estante 5 - Nivel 3";
                        piso = "PA";
                        estante = 5;
                        perchero = 0;
                        nivel = 3;
                    }
                }
                prodEnt.prod_Tipo = cBox_TipoProd.SelectedItem.ToString();
                prodEnt.prod_subTipo = cbox_SubtipoProd.SelectedItem.ToString();

                if (cBox_Talle.SelectedIndex != 0)
                {
                     talle = cBox_Talle.SelectedItem.ToString();
                    prodEnt.prod_Talle = talle; 
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un talle.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (tBox_StockMin.Text != "")
                {
                    StockMin = Convert.ToInt32(tBox_StockMin.Text);
                    prodEnt.prod_StockMin = StockMin;
                }
                else
                {
                    MessageBox.Show("Debe ingresar la stock mínimo para el producto.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (tBox_StockMax.Text != "")
                {
                    StockMax = Convert.ToInt32(tBox_StockMax.Text);
                    prodEnt.prod_StockMax = StockMax;
                }
                else
                {
                    MessageBox.Show("Debe ingresar la stock máximo para el producto.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (cBox_Color.SelectedIndex != 0)
                {
                    colorID = cBox_Color.SelectedValue.ToString();
                    prodEnt.prod_Color = colorID;
                    descripcion = tBox_Desc.Text;
                    prodEnt.prod_Descripción = descripcion;

                   
                    prodEnt.prod_CodDeProd = InicialTemp + anio + codigoArt + talle + colorID;
                    prodEnt.prod_Fecha = DateTime.Now;

                    Boolean nuevoProd = prodNeg.NuevoProducto(prodEnt);
                    if (nuevoProd == true)
                    {
                        MessageBox.Show("Se registro el producto correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se registro el producto.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un color.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            else
            {
                MessageBox.Show("Debe seleccionar un estado.","Guardar",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }
    }
}

