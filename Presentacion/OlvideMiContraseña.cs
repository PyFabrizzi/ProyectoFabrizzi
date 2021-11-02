using System;
using System.Data;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;

namespace Presentacion
{
    public partial class OlvideMiContraseña : Form
    {
        public OlvideMiContraseña()
        {
            InitializeComponent();
        }

        public int legajo;
        private void OlvideMiContraseña_Load(object sender, EventArgs e)
        {
            
            if (legajo != 0)
            {
                tBox_Legajo.Text = legajo.ToString();
            }
           
        }

        private void Btn_GuardarNuevaPass_Click(object sender, EventArgs e)
        {
            var logNeg = new LoginNegocio();
            var dt = new DataTable();
            var dt2 = new DataTable();

            legajo = Convert.ToInt32(tBox_Legajo.Text);
            dt = logNeg.consultaExisteLegajo(legajo);
            dt2 = logNeg.consultaPassAnterior(legajo);

            string passNueva = tBox_NuevaPass.Text;
            string repPass = tBox_RepetirPass.Text;

            if (dt.Rows.Count != 0)
            {
                var dr = dt2.Rows[0]["Pass"];
                if (dr.ToString() != repPass)
                {
                    if (passNueva != "")
                    {
                        if (repPass != "")
                        {
                            if (passNueva == repPass)
                            {
                                Boolean cambio = logNeg.CambiarPass(legajo, repPass);
                                if (cambio == true)
                                {
                                    MessageBox.Show("Se registro su nueva contraseña", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Login log = new Login();
                                    this.Close();
                                    log.Show();

                                }
                                else
                                {
                                    MessageBox.Show("No se registro su nueva contraseña", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Las contraseñas no coinciden, por favor verificar", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe repetir su nueva contraseña.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar una nueva contraseña.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("La nueva contraseña no pueden coincidir con la anterior", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El legajo ingresado es incorrecto, por favor verificar", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
