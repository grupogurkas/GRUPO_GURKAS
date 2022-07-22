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
    public partial class frmAsistenciaPersonaIndividual : Form
    {
        ExportacionExcel.RRHH.ExportarDataExcelRRHH Excel = new ExportacionExcel.RRHH.ExportarDataExcelRRHH();
        Datos.LlenadoDatos.LLenadoDatosRRHH Llenadocbo = new Datos.LlenadoDatos.LLenadoDatosRRHH();
        Datos.DataReportes.RRHH.DataRRHH reporterrhh = new Datos.DataReportes.RRHH.DataRRHH();
        public frmAsistenciaPersonaIndividual()
        {
            InitializeComponent();
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.ExportarDatosExcelConsultarGeneraldeAsistencia(dgvAsistenciaPersonal, progressBar1);
        }
        private void frmAsistenciaPersonaIndividual_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerPersonalRRHH(cboempleadoActivo);
            dgvAsistenciaPersonal.RowHeadersVisible = false;
            dgvAsistenciaPersonal.AllowUserToAddRows = false;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string cod_empleado = cboempleadoActivo.SelectedValue.ToString();
            dgvAsistenciaPersonal.DataSource = reporterrhh.ConsultarAsistenciaporPersona(cod_empleado, dtpFechaInicio.Value, dtpFechaFin.Value);
        }
    }
}
