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
    public partial class frmPersonalPorUnidad : Form
    {
        Datos.LLenadoDatosRRHH Llenadocbo = new Datos.LLenadoDatosRRHH();
        ExportacionExcel.RRHH.ExportarDataExcelRRHH Excel = new ExportacionExcel.RRHH.ExportarDataExcelRRHH();
        Datos.DataReportes.RRHH.DataRRHH reporterrhh = new Datos.DataReportes.RRHH.DataRRHH();
        public frmPersonalPorUnidad()
        {
            InitializeComponent();
        }
        private void frmPersonalPorUnidad_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerUnidadRRHH(cboUnidad);
            dgvPersonalPorSede.RowHeadersVisible = false;
            dgvPersonalPorSede.AllowUserToAddRows = false;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.ExportarDatosExcelConsultarPersonalUnidad(dgvPersonalPorSede, progressBar1);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string undiad = cboUnidad.SelectedValue.ToString();
            dgvPersonalPorSede.DataSource = reporterrhh.ConsultarPersonalUnidad(undiad);
        }
    }
}
