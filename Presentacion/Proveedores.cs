﻿using System;
using System.Data;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;

namespace Presentacion
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }
        

        private void linklbl_Direccion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Direcciones dirAlta = new Direcciones();
            dirAlta.letra = "P-";
            dirAlta.operacion = "A";
            var dirMet = new DireccionNegocio();
            dirAlta.dt = dirMet.ConsultarIdDirProv();
            dirAlta.Show();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_GuardarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Va a dar de alta a un nuevo proveedor, desea continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var provMet = new ProveedorNegocio();
            var dirMet = new DireccionNegocio();
            var provNew = new Proveedor();
            var dt = new DataTable();


            provNew.pro_CUIT = tBox_CUIT.Text;
            provNew.pro_RazonSocial = tBox_RazonSocial.Text;

            dt = dirMet.ConsultarDirProv();
            DataRow row2 = dt.Rows[0];
            provNew.pro_IdDireccion = row2[0].ToString();
                 
            

            provNew.pro_Telefono = tBox_Telefono.Text;
            provNew.pro_Email = tBox_Email.Text;
            

            dt = provMet.ConsultarProv(provNew.pro_CUIT);

            if (provNew.pro_CUIT != "")
            {
                if (dt.Rows.Count == 0)
                {
                    if (provNew.pro_RazonSocial != "")
                    {
                        Boolean grabo = provMet.grabarProveedor(provNew);
                        if (grabo == false)
                        {
                            MessageBox.Show("No se puedo registrar el proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Boolean borro = dirMet.BorrarDireccion(provNew.pro_IdDireccion);
                            if (borro == true)
                            {
                                MessageBox.Show("Se borro la dirección ingresada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El proveedor fue registrado con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ProveedoresListado provList = new ProveedoresListado();
                            this.Hide();
                            provList.Show();
                        }
                    }
                    else MessageBox.Show("Es necesario que ingrese la razón social", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("El proveedor ya está registrado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Es necesario que ingrese un número de CUIT", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btn_CerrarUsuAlta_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DireccionNegocio dirMet = new DireccionNegocio();
            var dt2 = new DataTable();           
            dt2 = dirMet.ConsultarProv();
            //DataRow row2 = dt2.Rows[0];

            dgv_direccionIngresada.DataSource = dt2; //row2[0].ToString();
        }
    }
}
