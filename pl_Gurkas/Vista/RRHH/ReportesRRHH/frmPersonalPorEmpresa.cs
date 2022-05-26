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
    public partial class frmPersonalPorEmpresa : Form
    {
        Datos.LlenadoDeDatos Llenadocbo = new Datos.LlenadoDeDatos();
        ExportacionExcel.RRHH.ExportarDataExcelRRHH Excel = new ExportacionExcel.RRHH.ExportarDataExcelRRHH();
        Datos.DataReportes.RRHH.DataRRHH reporterrhh = new Datos.DataReportes.RRHH.DataRRHH();
        public frmPersonalPorEmpresa()
        {
            InitializeComponent();
        }
        private void frmPersonalPorEmpresa_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerEmpresa(cboEmpresa);
            dgvPersonalEmpresa.RowHeadersVisible = false;
            dgvPersonalEmpresa.AllowUserToAddRows = false;
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.ExportarDatosExcelConsultarAsistenciaPorEmpresa(dgvPersonalEmpresa, progressBar1);
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cod_empresa = cboEmpresa.SelectedIndex;
            dgvPersonalEmpresa.DataSource = reporterrhh.ConsultarAsistenciaPorEmpresa(cod_empresa);
        }
    }
}
