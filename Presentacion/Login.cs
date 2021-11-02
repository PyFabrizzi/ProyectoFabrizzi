using System;
using System.Data;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;

namespace Presentacion

{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        public String usuID ="";//linea itati

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
           
            var dt = new DataTable();
            var usu = new LoginNegocio();
            var usuario = TextBox_User.Text;
            var pas = TextBox_Password.Text;
            dt = usu.ConsultarLogin(usuario, pas);
                       
            

            if (dt.Rows.Count == 1)
            {
                var frmPrin = new F_Principal();
                dt = usu.consultaNombre(usuario);
                
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    frmPrin.lbl_Usuario.Text = Convert.ToString(row[0]);
                 }

                frmPrin.lbl_Legajo.Text = usuario;
                frmPrin.lbl_Fecha.Text = DateTime.Now.ToShortDateString();
                this.Hide();
                frmPrin.Show();

                var rolMet = new RolNegocio();
                dt = rolMet.ConsultarId(usuario);
                DataRow row2 = dt.Rows[0];
                String nombre = Convert.ToString(row2[0]);

                if ( nombre != "Admin" )
                {
                    frmPrin.lbl_Roles.Visible = false;

                }
               
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
            



        }

        private void btn_CerrarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        

        private void linklbl_RestartPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OlvideMiContraseña olvMiCon = new OlvideMiContraseña();
            var usuario = TextBox_User.Text;

            if (usuario != "")
            {
                olvMiCon.legajo = Convert.ToInt32(usuario);
            }
           
            
            
            olvMiCon.Show();
            

        }
        
    }
}
