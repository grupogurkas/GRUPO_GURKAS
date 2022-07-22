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

namespace pl_Gurkas.Vista.CentroControl.ReporteCentroControl
{
    public partial class frmAsistenciaDetalladoPorEmpleado : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LlenadoDatos.LlenadoDeDatosCentroControl Llenadocbo = new Datos.LlenadoDatos.LlenadoDeDatosCentroControl();
        ExportacionExcel.CentroControl.ExportarDatosExcelCentroControl Excel = new ExportacionExcel.CentroControl.ExportarDatosExcelCentroControl();

        public frmAsistenciaDetalladoPorEmpleado()
        {
            InitializeComponent();
        }
        private void ConsultarAsistenciaPersonal(String Cod_Trabajador, DateTime fechaInicio, DateTime FechaFin)
        {

            try
            {
                SqlCommand comando = conexion.conexionBD().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "sp_PlanillasistenciaPersonal  @fechainicio,@fechafin,@Cod_empleado ";
                comando.Parameters.AddWithValue("Cod_empleado", Cod_Trabajador);
                comando.Parameters.AddWithValue("fechainicio", fechaInicio);
                comando.Parameters.AddWithValue("fechafin", FechaFin);
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(comando);
                dta.Fill(dt);
                dt.Columns[0].ColumnName = "Cod Empleado";
                dt.Columns[1].ColumnName = "Empleado";
                dt.Columns[2].ColumnName = "Nombre Sede";
                dt.Columns[3].ColumnName = "Empresa";
                dt.Columns[4].ColumnName = "Doc Indentidad";
                dt.Columns[5].ColumnName = "Fecha Asistencia";
                dt.Columns[6].ColumnName = "Tipo Asistencia";
                dt.Columns[7].ColumnName = "Turno";
                dt.AcceptChanges();
                dgvAsistenciaDetalladoEmpleado.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro nungun resultado \n\n " + ex, "ERROR");
            }

        }
        private void frmAsistenciaDetalladoPorEmpleado_Load(object sender, EventArgs e)
        {
            dgvAsistenciaDetalladoEmpleado.RowHeadersVisible = false;
            dgvAsistenciaDetalladoEmpleado.AllowUserToAddRows = false;
            Llenadocbo.ObtenerPersonalCentroControl(cboempleadoActivo);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string cod_empleado = cboempleadoActivo.SelectedValue.ToString();
            ConsultarAsistenciaPersonal(cod_empleado, dtpFechaInicio.Value, dtpFechaFin.Value);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvAsistenciaDetalladoEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string nombre_empleado = cboempleadoActivo.GetItemText(cboempleadoActivo.SelectedItem);
            string fi = dtpFechaInicio.Value.Date.ToString("dd-MM-yyyy");
            string ff = dtpFechaInicio.Value.Date.ToString("dd-MM-yyyy");
            Excel.ExportarDatosExcelAsistenciaDetalladoEmpleado(dgvAsistenciaDetalladoEmpleado, progressBar1, nombre_empleado, fi, ff);
        }
    }
}
