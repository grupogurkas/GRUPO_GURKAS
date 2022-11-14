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

namespace pl_Gurkas.Vista.Operaciones.Analista
{
    public partial class frmResumenTurno : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LlenadoDatos.LlenadoDeDatosCentroControl Llenadocbo = new Datos.LlenadoDatos.LlenadoDeDatosCentroControl();
        ExportacionExcel.CentroControl.ExportarDatosExcelCentroControl Excel = new ExportacionExcel.CentroControl.ExportarDatosExcelCentroControl();
        public frmResumenTurno()
        {
            InitializeComponent();
        }

        private void frmResumenTurno_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerUnidadCentroControlCompleto(cboUnidad);
            Llenadocbo.ObtenerTurnoCentroControl(cboTurno);
            Llenadocbo.ObtenerTurnoCentroControl(cboTurnoUnidad);

            dgvMarcacionFechaTurno.RowHeadersVisible = false;
            dgvMarcacionFechaTurno.AllowUserToAddRows = false;
        }
        private void TurnosEmpleadosTurno( int cod_turno, DateTime fechainicio, DateTime fechafin)
        {
            try
            {
                SqlCommand comando = conexion.conexionBD().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "sp_asistencia_resumida_por_turno  @fehcaInicio,@fechaFin,@codTurno";
                comando.Parameters.AddWithValue("fehcaInicio", fechainicio);
                comando.Parameters.AddWithValue("fechaFin", fechafin);
                comando.Parameters.AddWithValue("codTurno", cod_turno);
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(comando);
                dta.Fill(dt);
                dt.Columns[0].ColumnName = "Orden";
                dt.Columns[0].ColumnName = "Tipo Asistencia";
                dt.AcceptChanges();
                dgvMarcacionFechaTurno.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro nungun resultado \n\n " + ex, "ERROR");
            }

        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cod_turno = cboTurno.SelectedIndex;
            TurnosEmpleadosTurno( cod_turno, dtpFechaInicio.Value, dtpFechaFin.Value);
        }
        private void TurnosEmpleados(string cod_unidad, int cod_turno, DateTime fechainicio, DateTime fechafin)
        {
            try
            {
                SqlCommand comando = conexion.conexionBD().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "sp_asistencia_resumida_por_unidad  @fehcaInicio,@fechaFin,@codTurno,@cod_unidad";
                comando.Parameters.AddWithValue("fehcaInicio", fechainicio);
                comando.Parameters.AddWithValue("fechaFin", fechafin);
                comando.Parameters.AddWithValue("codTurno", cod_turno);
                comando.Parameters.AddWithValue("cod_unidad", cod_unidad);
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(comando);
                dta.Fill(dt);
                dt.Columns[0].ColumnName = "Orden";
                dt.Columns[0].ColumnName = "Tipo Asistencia";
                dt.AcceptChanges();
                dgvMarcacionFechaTurno.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro nungun resultado \n\n " + ex, "ERROR");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cod_unidad = cboUnidad.SelectedValue.ToString();
            int cod_turno = cboTurnoUnidad.SelectedIndex;
            TurnosEmpleados(cod_unidad, cod_turno, dtinicio.Value, dtfin.Value);
        }
    }
}
