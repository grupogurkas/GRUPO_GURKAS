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
    public partial class frmHistorialSalidaMaterial : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LlenadoDatos.llenadoDatosLogistica Llenadocbo = new Datos.LlenadoDatos.llenadoDatosLogistica();
        Datos.DataReportes.Logistica.DataLogistica datosLogistica = new Datos.DataReportes.Logistica.DataLogistica();
        ExportacionExcel.Logistica.ExportarDataExcelLogistica Excel = new ExportacionExcel.Logistica.ExportarDataExcelLogistica();

        public frmHistorialSalidaMaterial()
        {
            InitializeComponent();
        }

        private void frmHistorialSalidaMaterial_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerPersonalRRHH(cboEmpleado);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Historial de Salida de Producto";
            const string mensaje = "Estas seguro que deseas cerra el Historial de Salida de Producto";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cod_pro = cboEmpleado.SelectedValue.ToString();
            dgvHistorialOrdenServicio.DataSource = datosLogistica.BuscarSalidaProducto(cod_pro);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string num_salida = txtnumsalida.Text;
            dgvHistorialOrdenServicio.DataSource = datosLogistica.BuscarSalidaProductoNum(num_salida);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(txtm.Text);
            int anio = Convert.ToInt32(txta.Text);
            dgvHistorialOrdenServicio.DataSource = datosLogistica.BuscarSalidadMaterial(mes, anio);
        }
    }
}
