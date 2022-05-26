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
    public partial class frmAsistenciaGeneralPersonalPorSede : Form
    {
        ExportacionExcel.RRHH.ExportarDataExcelRRHH Excel = new ExportacionExcel.RRHH.ExportarDataExcelRRHH();
        Datos.LLenadoDatosRRHH Llenadocbo = new Datos.LLenadoDatosRRHH();
        Datos.DataReportes.RRHH.DataRRHH reporterrhh = new Datos.DataReportes.RRHH.DataRRHH();
        public frmAsistenciaGeneralPersonalPorSede()
        {
            InitializeComponent();
        }
        private void frmAsistenciaGeneralPersonalPorSede_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerUnidadRRHH(cboUnidad);
            dgvAsistenciaPersonalGeneralSede.RowHeadersVisible = false;
            dgvAsistenciaPersonalGeneralSede.AllowUserToAddRows = false;
        }
        private void cboUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUnidad.SelectedValue.ToString() != null)
            {
                string cod_unidad = cboUnidad.SelectedValue.ToString();
                Llenadocbo.ObtenerSedeRRHH(cboSede, cod_unidad);
            }
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.ExportarDatosExcelAsistenciGeneralSede(dgvAsistenciaPersonalGeneralSede, progressBar1);
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string sede = cboSede.SelectedValue.ToString();
            dgvAsistenciaPersonalGeneralSede.DataSource = reporterrhh.ConsultaDeAsistenciaPorSede(dtpFechaInicio.Value, dtpFechaFin.Value, sede);
        }
    }
}
