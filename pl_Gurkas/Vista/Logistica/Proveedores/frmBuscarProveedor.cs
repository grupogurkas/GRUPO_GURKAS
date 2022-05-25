using System;
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
        Datos.DataReportes.Logistica.DataLogistica datosLogistica = new Datos.DataReportes.Logistica.DataLogistica();
        Datos.Proveedor Proveedor = new Datos.Proveedor();
        public frmBuscarProveedor()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerProveedoresLogistico(cboProveedor);
            Llenadocbo.ObtenerTipoEmpresalogistica(cboEmpresa);
            dgvBuscarProveedor.RowHeadersVisible = false;
            dgvBuscarProveedor.AllowUserToAddRows = false;
            //  dgvBuscarProveedor.DataSource = Proveedor.MostrarProveedor();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Registro de Personal";
            const string mensaje = "Estas seguro que deseas cerra el Buscar Proveedor";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                this.Close();
            }
    }

        private void btnBuscarProveedorPorRuc_Click(object sender, EventArgs e)
        {
            string ruc_proveedor = txtRucProveedor.Text;
            dgvBuscarProveedor.DataSource = datosLogistica.BuscarProveeedorPorRuc(ruc_proveedor);
        }

        private void btnBuscarCodigoProveedor_Click(object sender, EventArgs e)
        {
            string cod_proveerdor = cboProveedor.SelectedValue.ToString();
            dgvBuscarProveedor.DataSource = datosLogistica.BuscarProveeedor(cod_proveerdor);
        }
    }
}
