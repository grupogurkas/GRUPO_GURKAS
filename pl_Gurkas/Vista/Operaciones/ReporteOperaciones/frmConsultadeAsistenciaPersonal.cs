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

namespace pl_Gurkas.Vista.Operaciones.ReporteOperaciones
{
    public partial class frmConsultadeAsistenciaPersonal : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LlenadoDatos.LlenadoDeDatosOperaciones Llenadocbo = new Datos.LlenadoDatos.LlenadoDeDatosOperaciones();
        ExportacionExcel.Operaciones.ExportarDataExcelOperaciones Excel = new ExportacionExcel.Operaciones.ExportarDataExcelOperaciones();
        Datos.AuditoriaModulos modulo = new Datos.AuditoriaModulos();

        public frmConsultadeAsistenciaPersonal()
        {
            InitializeComponent();
        }
        private void ConsultarAsistenciaPersonalResumen(String Cod_Trabajador, DateTime fechaInicio, DateTime FechaFin)
        {
            try
            {
                SqlCommand comando = conexion.conexionBD().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "sp_TAREAJEAsistenciaPersonalResumen  @fechainicio,@fechafin,@Cod_empleado ";
                comando.Parameters.AddWithValue("Cod_empleado", Cod_Trabajador);
                comando.Parameters.AddWithValue("fechainicio", fechaInicio);
                comando.Parameters.AddWithValue("fechafin", FechaFin);
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(comando);
                dta.Fill(dt);
                dt.Columns[0].ColumnName = "Tipo de Asistencia";
                dt.Columns[1].ColumnName = "Cantidad";
                dt.AcceptChanges();
                dgvResumen.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro nungun resultado \n\n " + ex, "ERROR");
            }
        }
        private void ConsultarAsistenciaPersonalTotal(String Cod_Trabajador, DateTime fechaInicio, DateTime FechaFin)
        {
            try
            {
                SqlCommand comando = conexion.conexionBD().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "sp_TAREAJEAsistenciaPersonaltotal  @fechainicio,@fechafin,@Cod_empleado ";
                comando.Parameters.AddWithValue("Cod_empleado", Cod_Trabajador);
                comando.Parameters.AddWithValue("fechainicio", fechaInicio);
                comando.Parameters.AddWithValue("fechafin", FechaFin);
                comando.ExecuteNonQuery();
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    lbltotal.Text = recorre["total"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro nungun resultado \n\n " + ex, "ERROR");
            }
        }
        private void ConsultarAsistenciaPersonal(String Cod_Trabajador, DateTime fechaInicio, DateTime FechaFin)
        {
            try
            {
                SqlCommand comando = conexion.conexionBD().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "sp_TAREAJEAsistenciaPersonal  @fechainicio,@fechafin,@Cod_empleado ";
                comando.Parameters.AddWithValue("Cod_empleado", Cod_Trabajador);
                comando.Parameters.AddWithValue("fechainicio", fechaInicio);
                comando.Parameters.AddWithValue("fechafin", FechaFin);
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(comando);
                dta.Fill(dt);
                dt.Columns[0].ColumnName = "Cod Empleado";
                dt.Columns[1].ColumnName = "Nombre Sede";
                dt.Columns[2].ColumnName = "Fecha Asistencia";
                dt.Columns[3].ColumnName = "Tipo Asistencia";
                dt.AcceptChanges();
                dgvConsultarAsistenciaPersonal.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro nungun resultado \n\n " + ex, "ERROR");
            }
        }
        private void frmConsultadeAsistenciaPersonal_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerPersonalOperaciones(cboempleadoActivo);
            dgvConsultarAsistenciaPersonal.RowHeadersVisible = false;
            dgvConsultarAsistenciaPersonal.AllowUserToAddRows = false;
            dgvResumen.RowHeadersVisible = false;
            dgvResumen.AllowUserToAddRows = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string cod_empleado = cboempleadoActivo.SelectedValue.ToString();
            ConsultarAsistenciaPersonal(cod_empleado, dtpFechaInicio.Value, dtpFechaFin.Value);
            ConsultarAsistenciaPersonalResumen(cod_empleado, dtpFechaInicio.Value, dtpFechaFin.Value);
            ConsultarAsistenciaPersonalTotal(cod_empleado, dtpFechaInicio.Value, dtpFechaFin.Value);
            modulo.auditoriaFunciones("Operaciones", "Buscar asistencia de personal", "Busqueda de asistencia de personal : " + cod_empleado);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string cod_empleado = cboempleadoActivo.SelectedValue.ToString();
            string nombre_empleado = cboempleadoActivo.GetItemText(cboempleadoActivo.SelectedItem);
            string fi = dtpFechaInicio.Value.Date.ToString("dd-MM-yyyy");
            string ff = dtpFechaFin.Value.Date.ToString("dd-MM-yyyy");
            Excel.ExportarDatosExcelAsistencia(dgvConsultarAsistenciaPersonal, progressBar1,nombre_empleado, fi, ff);
            modulo.auditoriaFunciones("Operaciones", "Excel", "Excel de asistencia de personal : " + cod_empleado);
        }
    }
}
