using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.Logistica.producto
{
    public partial class frmListarProductos : Form
    {
        Datos.DataReportes.Logistica.DataLogistica datosLogistica = new Datos.DataReportes.Logistica.DataLogistica();
        ExportacionExcel.Logistica.ExportarDataExcelLogistica Excel = new ExportacionExcel.Logistica.ExportarDataExcelLogistica();
        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();
        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();


        private Timer ti;
        

        public frmListarProductos()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
        }

        private void eventoTimer(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            //lblRelog.Text = hoy.ToString("hh:mm:ss tt");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmListarProductos_Load(object sender, EventArgs e)
        {
            llenadoDatosProducto();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void llenadoDatosProducto()
        {
            Llenadocbo.ObtenerProductosGeneral(cboProducto);
            Llenadocbo.ObtenerCodigoProducto(cboCodigoSistema);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Registro de Personal";
            const string mensaje = "Estas seguro que deseas cerra el Registro de Personal";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBuscarCodigoProveedor_Click(object sender, EventArgs e)
        {
            if(cboProducto.SelectedItem != "")
            {
                string cod_producto = cboProducto.SelectedValue.ToString();
                dgvBuscarProducto.DataSource = datosLogistica.BuscarProducto(cod_producto);
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Producto");
            }
            
        }

        private void btnBuscarProductoCodigo_Click(object sender, EventArgs e)
        {
            string cod_producto = txtCodProducto.Text;
            dgvBuscarProducto.DataSource = datosLogistica.BuscarProductoPorCodigo(cod_producto);
        }

        private void btnBuscarProductoSistema_Click(object sender, EventArgs e)
        {
            string cod_producto = cboCodigoSistema.SelectedValue.ToString();
            dgvBuscarProducto.DataSource = datosLogistica.BuscarProductoPorCodigoSistema(cod_producto);

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.ExportarDatosExcelProveedores(dgvBuscarProducto, progressBar1);
        }
    }
}
