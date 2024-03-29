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

namespace pl_Gurkas.Vista.RRHH.ReportesRRHH
{
    public partial class frmBajaPersonal : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();
        Datos.LlenadoDatos.LLenadoDatosRRHH Llenadocbo = new Datos.LlenadoDatos.LLenadoDatosRRHH();
        Datos.registrar registrar = new Datos.registrar();
        Datos.Actualizar actualizar = new Datos.Actualizar();
        ExportacionExcel.RRHH.ExportarDataExcelRRHH ExcelRRHH = new ExportacionExcel.RRHH.ExportarDataExcelRRHH();
        public frmBajaPersonal()
        {
            InitializeComponent();
        }

        private void buscafaltasUnidad(DateTime fechainicio, DateTime fechafin, string cod_unidad)
        {

            try
            {
                SqlCommand comando = conexion.conexionBD().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "sp_buscar_bajas_unidad  @FechaInicio,@FechaFin,@cod_unidad";
                comando.Parameters.AddWithValue("FechaInicio", fechainicio);
                comando.Parameters.AddWithValue("FechaFin", fechafin);
                comando.Parameters.AddWithValue("cod_unidad", cod_unidad);
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(comando);
                dta.Fill(dt);
                dt.Columns[0].ColumnName = "Asistecia Actual";
                dt.Columns[1].ColumnName = "Fecha de asistencia";
                dt.Columns[2].ColumnName = "Cod Empleado";
                dt.Columns[3].ColumnName = "Empleado";
                dt.Columns[4].ColumnName = "Sede";
                dt.Columns[5].ColumnName = "Fecha";
                dt.AcceptChanges();
                dgvFaltasJustificadas.DataSource = dt;
                dgvFaltasJustificadas.Columns[5].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro nungun resultado \n\n ", "ERROR");
            }
        }

        private void buscafaltas(int empresa, DateTime fechainicio, DateTime fechafin)
        {

            try
            {
                SqlCommand comando = conexion.conexionBD().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "sp_buscar_bajas  @empresa,@FechaInicio,@FechaFin";
                comando.Parameters.AddWithValue("empresa", empresa);
                comando.Parameters.AddWithValue("FechaInicio", fechainicio);
                comando.Parameters.AddWithValue("FechaFin", fechafin);
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(comando);
                dta.Fill(dt);
                dt.Columns[0].ColumnName = "Asistecia Actual";
                dt.Columns[1].ColumnName = "Fecha de asistencia";
                dt.Columns[2].ColumnName = "Cod Empleado";
                dt.Columns[3].ColumnName = "Empleado";
                dt.Columns[4].ColumnName = "Sede";
                dt.Columns[5].ColumnName = "Fecha";
                dt.AcceptChanges();
                dgvFaltasJustificadas.DataSource = dt;
                dgvFaltasJustificadas.Columns[5].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro nungun resultado \n\n ", "ERROR");
            }
        }

        private void frmBajaPersonal_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerUnidadRRHH(cbounidadRRHH);
            Llenadocbo.ObtenerEmpresaBaja(cboEmpresa);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int emp = cboEmpresa.SelectedIndex;
            buscafaltas(emp, dtpFechaInicio.Value, dtpFehcaFin.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cod_unidad = cbounidadRRHH.SelectedValue.ToString();
            buscafaltasUnidad(fechainicio.Value, fechafin.Value, cod_unidad);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelRRHH.ExportarDatosBarra(dgvFaltasJustificadas, progressBar1);
        }
    }
}
