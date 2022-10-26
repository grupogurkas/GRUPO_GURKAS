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
    public partial class frmHistorialOrdenServicio : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LlenadoDatos.llenadoDatosLogistica Llenadocbo = new Datos.LlenadoDatos.llenadoDatosLogistica();
        Datos.DataReportes.Logistica.DataLogistica datosLogistica = new Datos.DataReportes.Logistica.DataLogistica();
        ExportacionExcel.Logistica.ExportarDataExcelLogistica Excel = new ExportacionExcel.Logistica.ExportarDataExcelLogistica();
        public frmHistorialOrdenServicio()
        {
            InitializeComponent();
        }

        private void frmHistorialOrdenServicio_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerProveedoresLogistico(cboProveedor);
            Llenadocbo.ObtenerProveedoresLogistico(cboProveedorMesANIO);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Historial de Orden Servicio";
            const string mensaje = "Estas seguro que deseas cerra el Historial de Orden Servicio";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cod_pro = cboProveedor.SelectedValue.ToString();
            dgvHistorialOrdenServicio.DataSource = datosLogistica.BuscarOrdenServicioCodProveedor(cod_pro);
        }

        private void btnBuscarProveedorPorRuc_Click(object sender, EventArgs e)
        {
            string ruc = txtRucProveedor.Text;
            dgvHistorialOrdenServicio.DataSource = datosLogistica.BuscarOrdenServiciorruc(ruc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(txtm.Text);
            int anio = Convert.ToInt32(txta.Text);
            dgvHistorialOrdenServicio.DataSource = datosLogistica.BuscarOrdenServicio_mes_anio(mes, anio);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(textBox1.Text);
            int anio = Convert.ToInt32(textBox2.Text);
            string cod_pro = cboProveedorMesANIO.SelectedValue.ToString();
            dgvHistorialOrdenServicio.DataSource = datosLogistica.BuscarOrdenServicio_mes_anio_cod(mes, anio, cod_pro);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string num_orden_compra = txtordencomprar.Text;
            dgvHistorialOrdenServicio.DataSource = datosLogistica.BuscarOrdenServicio_num_orden_compra(num_orden_compra);
        }

        private void dgvHistorialOrdenServicio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Vista.Logistica.Ordenes.frmImprimirPDF_OC_OS objOrdenes = new Vista.Logistica.Ordenes.frmImprimirPDF_OC_OS();
            objOrdenes._num_orden = dgvHistorialOrdenServicio.CurrentRow.Cells[0].Value.ToString();
            objOrdenes.ShowDialog();
        }
    }
}
