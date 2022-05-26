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
    public partial class frmPersonalPorEdad : Form
    {
        ExportacionExcel.RRHH.ExportarDataExcelRRHH Excel = new ExportacionExcel.RRHH.ExportarDataExcelRRHH();
        Datos.DataReportes.RRHH.DataRRHH reporterrhh = new Datos.DataReportes.RRHH.DataRRHH();
        public frmPersonalPorEdad()
        {
            InitializeComponent();
        }
        private void frmPersonalPorEdad_Load(object sender, EventArgs e)
        {
            txtEdadInicio.MaxLength = 2;
            txtEdadFin.MaxLength = 2;
            dgvEdadPersonal.RowHeadersVisible = false;
            dgvEdadPersonal.AllowUserToAddRows = false;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtEdadInicio.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar una Edad Inicial", "Advertencia");
            }
            else if (txtEdadFin.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar una Edad Final", "Advertencia");
            }
            else
            {
                int edadInicio = (int)Convert.ToInt64(txtEdadInicio.Text);
                int EdadFin = (int)Convert.ToInt64(txtEdadFin.Text);
                dgvEdadPersonal.DataSource = reporterrhh.ConsultarEdadEmpleado(edadInicio, EdadFin);
            }

        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.ExportarDatosExcelConsultarEdadEmpleado(dgvEdadPersonal, progressBar1);
        }
    }
}
