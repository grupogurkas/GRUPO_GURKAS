using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.RRHH.ReportesRRHH
{
    public partial class frmPersonalPorDni : Form
    {
        Datos.DataReportes.RRHH.DataRRHH reporterrhh = new Datos.DataReportes.RRHH.DataRRHH();
        ExportacionExcel.RRHH.ExportarDataExcelRRHH Excel = new ExportacionExcel.RRHH.ExportarDataExcelRRHH();

        public frmPersonalPorDni()
        {
            InitializeComponent();
        }

        private void frmPersonalPorDni_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string cod_personal = txtBuscarDNI.Text;
            dgvAsistenciaPersonal.DataSource = reporterrhh.ConsultarPorDNI(cod_personal);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cod_personal_activo = txtBuscarCodigoPer.Text;
            dgvAsistenciaPersonal.DataSource = reporterrhh.ConsultarPorCodigo(cod_personal_activo);

        }
    }
}
