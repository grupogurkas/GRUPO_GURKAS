using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.Logistica.CargoEntrega
{
    public partial class frmHistorialProductoEmpleado : Form
    {
        public string cod_personal;
        public string nomb_personal;
        Datos.DataReportes.Logistica.DataLogistica reportelogistica = new Datos.DataReportes.Logistica.DataLogistica();
        private DataTable dt;

        public frmHistorialProductoEmpleado()
        {
            InitializeComponent();
        }

        private void buscar_vale_salida()
        {
            string cod_empleado = txtCodPersonal.Text;
            dgvListarVale.DataSource = reportelogistica.BuscarValesSalidaMateria(cod_empleado);
        }

        private void frmHistorialProductoEmpleado_Load(object sender, EventArgs e)
        {
            txtCodPersonal.Enabled = false;
            txtNombreEmpleado.Enabled = false;
            txtCodPersonal.Text = cod_personal;
            txtNombreEmpleado.Text = nomb_personal;
            buscar_vale_salida();
        }

        private void dgvListarVale_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Vista.Logistica.CargoEntrega.frmDevolucionMaterial objDevolucionMaterial = new Vista.Logistica.CargoEntrega.frmDevolucionMaterial();
            objDevolucionMaterial._numvale = dgvListarVale.CurrentRow.Cells[1].Value.ToString();
            objDevolucionMaterial.ShowDialog();
        }
    }
}
