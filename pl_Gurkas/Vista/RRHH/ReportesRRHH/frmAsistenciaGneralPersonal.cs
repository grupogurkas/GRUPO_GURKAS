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
    public partial class frmAsistenciaGneralPersonal : Form
    {
        Datos.ExportarExcel Excel = new Datos.ExportarExcel();
        Datos.DataReportes.RRHH.DataRRHH reporterrhh = new Datos.DataReportes.RRHH.DataRRHH();
        public frmAsistenciaGneralPersonal()
        {
            InitializeComponent();
        }
        private void frmAsistenciaGneralPersonal_Load(object sender, EventArgs e)
        {
            dgvAsistenciaGeneralPersonal.RowHeadersVisible = false;
            dgvAsistenciaGeneralPersonal.AllowUserToAddRows = false;
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.ExportarDatosBarra(dgvAsistenciaGeneralPersonal, progressBar1);
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvAsistenciaGeneralPersonal.DataSource =  reporterrhh.ConsultarGeneraldeAsistencia(dtpFechaInicio.Value, dtpFechaFin.Value);
        }
    }
}
