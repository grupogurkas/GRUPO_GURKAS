﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.CentroControl.ReporteAsistencia
{
    public partial class frmAsistenciaDePersonalDetallado : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LlenadoDatos.LlenadoDeDatosCentroControl Llenadocbo = new Datos.LlenadoDatos.LlenadoDeDatosCentroControl();
        ExportacionExcel.CentroControl.ExportarDatosExcelCentroControl Excel = new ExportacionExcel.CentroControl.ExportarDatosExcelCentroControl();
        public frmAsistenciaDePersonalDetallado()
        {
            InitializeComponent();
        }
        private void ConsultarPersonalDetallado(DateTime fechaInicio, DateTime FechaFin, string cod_unidad)
        {
            try
            {
                SqlCommand comando = conexion.conexionBD().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "sp_asistenciadetalladoPersonal  @fechainicio,@fechafin,@cod_unidad";
                comando.Parameters.AddWithValue("fechainicio", fechaInicio);
                comando.Parameters.AddWithValue("fechafin", FechaFin);
                comando.Parameters.AddWithValue("cod_unidad", cod_unidad);
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(comando);
                dta.Fill(dt);
                dt.Columns[0].ColumnName = "Cod Empleado";
                dt.Columns[1].ColumnName = "Empleado";
                dt.Columns[2].ColumnName = "Sede";
                dt.Columns[3].ColumnName = "Empresa";
                dt.Columns[4].ColumnName = "Num Documento";
                dt.Columns[5].ColumnName = "Fecha";
                dt.Columns[6].ColumnName = "Tipo Asistencia";
                dt.AcceptChanges();
                dgvAsistenciaPersonalDetallado.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se encontro nungun resultado \n\n " + ex, "ERROR");

            }

        }
        private void ConsultarPersonalDetalladoCompleto(DateTime fechaInicio, DateTime FechaFin)
        {
            try
            {
                SqlCommand comando = conexion.conexionBD().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "sp_asistenciadetalladoPersonal_completo  @fechainicio,@fechafin";
                comando.Parameters.AddWithValue("fechainicio", fechaInicio);
                comando.Parameters.AddWithValue("fechafin", FechaFin);
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(comando);
                dta.Fill(dt);
                dt.Columns[0].ColumnName = "Cod Empleado";
                dt.Columns[1].ColumnName = "Empleado";
                dt.Columns[2].ColumnName = "Sede";
                dt.Columns[3].ColumnName = "Empresa";
                dt.Columns[4].ColumnName = "Num Documento";
                dt.Columns[5].ColumnName = "Fecha";
                dt.Columns[6].ColumnName = "Tipo Asistencia";
                dt.AcceptChanges();
                dgvAsistenciaPersonalDetallado.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se encontro nungun resultado \n\n " + ex, "ERROR");

            }

        }
        private void frmAsistenciaDePersonalDetallado_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerUnidadCentroControlCompleto(cboUnidad);
            dgvAsistenciaPersonalDetallado.RowHeadersVisible = false;
            dgvAsistenciaPersonalDetallado.AllowUserToAddRows = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string cod_unidad = cboUnidad.SelectedValue.ToString();
            ConsultarPersonalDetallado(dtpFechaInicio.Value, dtpFechaFin.Value, cod_unidad);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string nombre_unidad = cboUnidad.GetItemText(cboUnidad.SelectedItem);
            string fi = dtpFechaInicio.Value.Date.ToString("dd-MM-yyyy");
            string ff = dtpFechaInicio.Value.Date.ToString("dd-MM-yyyy");
            Excel.ExportarDatosExcelAsistenciaPersonalDetallado(dgvAsistenciaPersonalDetallado, progressBar1, nombre_unidad, fi, ff);
        }

        private void btnconsultarcompleto_Click(object sender, EventArgs e)
        {
            ConsultarPersonalDetalladoCompleto(dtiniciocompleto.Value, dtfincompleto.Value);
        }
    }
}
