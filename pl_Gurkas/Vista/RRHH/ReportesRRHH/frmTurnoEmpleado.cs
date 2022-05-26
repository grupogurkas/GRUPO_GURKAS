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
    public partial class frmTurnoEmpleado : Form
    {
        ExportacionExcel.RRHH.ExportarDataExcelRRHH Excel = new ExportacionExcel.RRHH.ExportarDataExcelRRHH();
        Datos.LLenadoDatosRRHH Llenadocbo = new Datos.LLenadoDatosRRHH();
        Datos.DataReportes.RRHH.DataRRHH reporterrhh = new Datos.DataReportes.RRHH.DataRRHH();
        public frmTurnoEmpleado()
        {
            InitializeComponent();
        }
        private void frmTurnoEmpleado_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerTurnoRRHH(cboTurno);
            dgvPersonalTurno.RowHeadersVisible = false;
            dgvPersonalTurno.AllowUserToAddRows = false;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.ExportarDatosExcelConsultarAsistenciaPorTurno(dgvPersonalTurno, progressBar1);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int turno = cboTurno.SelectedIndex;
            int id_empresa = Datos.EmpresaID._empresaid;
            dgvPersonalTurno.DataSource = reporterrhh.ConsultarAsistenciaPorTurno( turno,  id_empresa);
        }
    }
}
