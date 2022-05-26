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

namespace pl_Gurkas.Vista.RRHH.ReportesRRHH
{
    public partial class frmPersonalPorFechaIngreso : Form
    {
        ExportacionExcel.RRHH.ExportarDataExcelRRHH Excel = new ExportacionExcel.RRHH.ExportarDataExcelRRHH();
        int id_empresa = Datos.EmpresaID._empresaid;
        Datos.DataReportes.RRHH.DataRRHH reporterrhh = new Datos.DataReportes.RRHH.DataRRHH();
        public frmPersonalPorFechaIngreso()
        {
            InitializeComponent();
        }
        private void frmPersonalPorFechaIngreso_Load(object sender, EventArgs e)
        {
            dgvFechaIngresoPersonal.RowHeadersVisible = false;
            dgvFechaIngresoPersonal.AllowUserToAddRows = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvFechaIngresoPersonal.DataSource = reporterrhh.ConsultarFechaIngreso(dtpFechaInicio.Value, dtpFechaFin.Value, id_empresa);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.ExportarDatosExcelConsultarFechaIngreso(dgvFechaIngresoPersonal, progressBar1);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Reporte RRHH";
            const string mensaje = "Estas seguro que deseas cerra el reporte de Personal por Fecha de ingreso";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                DateTime fecha = DateTime.Now;
                // obtenerip_nombre();
                // string username = Code.nivelUser._nombre;
                string detalle = "Cerrar Registro de Personal";
                string cod_buscado = "Cerro el registro de Personal";
                // registrar.RegistrarRRHH(fecha, nombrepc, username, ipuser, cod_buscado, detalle);
                this.Close();
            }
        }
    }
}
