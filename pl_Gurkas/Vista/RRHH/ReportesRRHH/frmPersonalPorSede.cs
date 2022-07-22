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
    public partial class frmPersonalPorSede : Form
    {
        Datos.LlenadoDatos.LLenadoDatosRRHH Llenadocbo = new Datos.LlenadoDatos.LLenadoDatosRRHH();
        ExportacionExcel.RRHH.ExportarDataExcelRRHH Excel = new ExportacionExcel.RRHH.ExportarDataExcelRRHH();
        Datos.DataReportes.RRHH.DataRRHH reporterrhh = new Datos.DataReportes.RRHH.DataRRHH();
        public frmPersonalPorSede()
        {
            InitializeComponent();
        }
        private void llenado_combo()
        {
            Llenadocbo.ObtenerUnidadRRHH(cboUnidad);
        }
        private void frmPersonalPorSede_Load(object sender, EventArgs e)
        {
            llenado_combo();
            dgvPersonalPorSede.RowHeadersVisible = false;
            dgvPersonalPorSede.AllowUserToAddRows = false;
        }

        private void cboUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUnidad.SelectedValue.ToString() != null)
            {
                string cod_unidad = cboUnidad.SelectedValue.ToString();
                Llenadocbo.ObtenerSedeRRHH(cboSede, cod_unidad);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string Sede = cboSede.SelectedValue.ToString();
            dgvPersonalPorSede.DataSource = reporterrhh.ConsultarPersonalSede(Sede);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.ExportarDatosExcelConsultarPersonalSede(dgvPersonalPorSede, progressBar1);
        }
    }
}
