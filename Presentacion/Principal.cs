﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class F_Principal : Form
    {
        public String nombre;

        public F_Principal()
        {
            InitializeComponent();

        }

        private void lbl_Roles_Click(object sender, EventArgs e)
        {
            RolesListado rolList = new RolesListado();
            rolList.Show();
            
           
        }

        private void lbl_usuarios_Click(object sender, EventArgs e)
        {
            UsuariosListado usuList = new UsuariosListado();
            usuList.Show();
        }

        private void btn_CerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Proveedores_Click(object sender, EventArgs e)
        {
            ProveedoresListado provList = new ProveedoresListado();
            provList.Show();
        }

        private void lbl_Locales_Click(object sender, EventArgs e)
        {
            LocalesListado Loc = new LocalesListado();
            Loc.Show();
        }

        private void lbl_MatPrimas_Click(object sender, EventArgs e)
        {
            MateriasPrimasListado MatPrim = new MateriasPrimasListado();
            MatPrim.Show();
        }

        private void lbl_productos_Click(object sender, EventArgs e)
        {
            ProductosListado ProdList = new ProductosListado();
            ProdList.Show();
        }



        int m, mx, my;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            m=1;
            mx = e.X;
            my = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RolesListado rolList = new RolesListado();
            rolList.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            UsuariosListado usuList = new UsuariosListado();
            usuList.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LocalesListado Loc = new LocalesListado();
            Loc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MateriasPrimasListado MatPrim = new MateriasPrimasListado();
            MatPrim.Show();
        }

        private void lbl_Pedidos_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductosListado ProdList = new ProductosListado();
            ProdList.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProveedoresListado provList = new ProveedoresListado();
            provList.Show();
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Fabrizzi_logoRoles_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.Black;
                }

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.Black;
                }

            }
        }

        private void lblVentas_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            venta.lblUsuarios_Venta.Text = lbl_Usuario.Text;
            venta.lblLegajo.Text = lbl_Legajo.Text;
            venta.Show();


                
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

    }
}

