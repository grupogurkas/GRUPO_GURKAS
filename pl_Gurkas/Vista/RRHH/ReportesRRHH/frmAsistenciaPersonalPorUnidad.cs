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
    public partial class frmAsistenciaPersonalPorUnidad : Form
    {
        ExportacionExcel.RRHH.ExportarDataExcelRRHH Excel = new ExportacionExcel.RRHH.ExportarDataExcelRRHH();
        Datos.LlenadoDatos.LLenadoDatosRRHH Llenadocbo = new Datos.LlenadoDatos.LLenadoDatosRRHH();
        Datos.DataReportes.RRHH.DataRRHH reporterrhh = new Datos.DataReportes.RRHH.DataRRHH();
        public frmAsistenciaPersonalPorUnidad()
        {
            InitializeComponent();
        }
        private void frmAsistenciaPersonalPorUnidad_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerUnidadRRHH(cboUnidad);
            dgvAsistenciaPersonalGeneralSede.RowHeadersVisible = false;
            dgvAsistenciaPersonalGeneralSede.AllowUserToAddRows = false;
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.ExportarDatosExcelConsultarAsistenciaSede(dgvAsistenciaPersonalGeneralSede, progressBar1);
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string unidad = cboUnidad.SelectedValue.ToString();
            dgvAsistenciaPersonalGeneralSede.DataSource = reporterrhh.ConsultarAsistenciaSede(dtpFechaInicio.Value, dtpFechaFin.Value, unidad);
        }
    }
}
