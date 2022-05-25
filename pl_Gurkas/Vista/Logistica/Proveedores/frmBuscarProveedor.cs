﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.Logistica.Proveedores
{
    public partial class frmBuscarProveedor : Form
    {
        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();
        public frmBuscarProveedor()
        {
            InitializeComponent();
        }

        Datos.Proveedor Proveedor = new Datos.Proveedor();

        private void Form1_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerProveedoresLogistico(cboProveedor);
            Llenadocbo.ObtenerTipoEmpresalogistica(cboEmpresa);
            dgvBuscarProveedor.DataSource = Proveedor.MostrarProveedor();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Registro de Personal";
            const string mensaje = "Estas seguro que deseas cerra el Buscar Proveedor";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                //  DateTime fecha = DateTime.Now;
                //  obtenerip_nombre();
                // string username = Code.nivelUser._nombre;
                // string detalle = "Cerrar Registro de Personal";
                // string cod_buscado = "Cerro el registro de Personal";
                // registrar.RegistrarRRHH(fecha, nombrepc, username, ipuser, cod_buscado, detalle);
                this.Close();
            }
    }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cod_proveerdor = cboProveedor.SelectedValue.ToString();

        }
    }
}
