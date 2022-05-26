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
    public partial class frmEstaturaPersonal : Form
    {
        ExportacionExcel.RRHH.ExportarDataExcelRRHH Excel = new ExportacionExcel.RRHH.ExportarDataExcelRRHH();
        Datos.DataReportes.RRHH.DataRRHH reporterrhh = new Datos.DataReportes.RRHH.DataRRHH();
        public frmEstaturaPersonal()
        {
            InitializeComponent();
        }
        private void frmEstaturaPersonal_Load(object sender, EventArgs e)
        {
            dgvPersonalEstatura.RowHeadersVisible = false;
            dgvPersonalEstatura.AllowUserToAddRows = false;
        }
        private void txtEstaturaInicial_TextChanged(object sender, EventArgs e)
        {
            txtEstaturaInicial.MaxLength = 4;
        }
        private void txtEstaturaFin_TextChanged(object sender, EventArgs e)
        {
            txtEstaturaFin.MaxLength = 4;
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.ExportarDatosExcelConsultaEstaturas(dgvPersonalEstatura, progressBar1);
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtEstaturaInicial.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar una Estatura Inicial", "Advertencia");
            }
            else if (txtEstaturaFin.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar una Estatura Final", "Advertencia");
            }
            else
            {
                decimal estaturaInicio = Convert.ToDecimal(txtEstaturaInicial.Text);
                decimal estaturaFin = Convert.ToDecimal(txtEstaturaFin.Text);
                dgvPersonalEstatura.DataSource = reporterrhh.ConsultaEstaturas(estaturaInicio, estaturaFin);
            }
        }
    }
}
