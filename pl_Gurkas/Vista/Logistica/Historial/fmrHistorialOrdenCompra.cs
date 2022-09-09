using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.Logistica.Historial
{
    public partial class fmrHistorialOrdenCompra : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LlenadoDatos.llenadoDatosLogistica Llenadocbo = new Datos.LlenadoDatos.llenadoDatosLogistica();
        Datos.DataReportes.Logistica.DataLogistica datosLogistica = new Datos.DataReportes.Logistica.DataLogistica();
        public fmrHistorialOrdenCompra()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Historial de Orden Comprar";
            const string mensaje = "Estas seguro que deseas cerra el Historial de Orden Comprar";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fmrHistorialOrdenCompra_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerProveedoresLogistico(cboProveedor);
            Llenadocbo.ObtenerProveedoresLogistico(cboProveedorMesANIO);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cod_pro = cboProveedor.SelectedValue.ToString();
            dgvHistorialOrdenCompra.DataSource = datosLogistica.BuscarOrdenComprarCodProveedor(cod_pro);
        }

        private void btnBuscarProveedorPorRuc_Click(object sender, EventArgs e)
        {
            string ruc = txtRucProveedor.Text;
            dgvHistorialOrdenCompra.DataSource = datosLogistica.BuscarOrdenComprarruc(ruc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string num_orden_compra = txtordencomprar.Text;
            dgvHistorialOrdenCompra.DataSource = datosLogistica.BuscarOrdenCompranum_orden_compra(num_orden_compra);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(txtm.Text);
            int anio = Convert.ToInt32(txta.Text);
            dgvHistorialOrdenCompra.DataSource = datosLogistica.BuscarOrdenCompra_mes_anio(mes,anio);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(textBox1.Text);
            int anio = Convert.ToInt32(textBox2.Text);
            string cod_pro = cboProveedorMesANIO.SelectedValue.ToString();
            dgvHistorialOrdenCompra.DataSource = datosLogistica.BuscarOrdenCompra_mes_anio_cod(mes, anio, cod_pro);
        }
    }
}
