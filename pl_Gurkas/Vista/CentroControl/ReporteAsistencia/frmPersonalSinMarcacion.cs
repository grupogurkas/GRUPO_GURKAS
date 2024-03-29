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
    public partial class frmPersonalSinMarcacion : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LlenadoDatos.LlenadoDeDatosOperaciones Llenadocboope = new Datos.LlenadoDatos.LlenadoDeDatosOperaciones();
        ExportacionExcel.CentroControl.ExportarDatosExcelCentroControl Excel = new ExportacionExcel.CentroControl.ExportarDatosExcelCentroControl();

        public frmPersonalSinMarcacion()
        {
            InitializeComponent();
        }

        private void frmPersonalSinMarcacion_Load(object sender, EventArgs e)
        {
            Llenadocboope.ObtenerUnidad(cboUnidad);
            Llenadocboope.ObtenerTurno(turno);
            dgvPersonalSinMarcacion.RowHeadersVisible = false;
            dgvPersonalSinMarcacion.AllowUserToAddRows = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime dia = dtpFecha.Value;
            string cod_unidad = cboUnidad.SelectedValue.ToString();
            try
            {
                SqlCommand comando = conexion.conexionBD().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "sp_personalsinmarcacion_unidades  @fecha,@unidad";
                comando.Parameters.AddWithValue("fecha", dia);
                comando.Parameters.AddWithValue("unidad", cod_unidad);
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(comando);
                dta.Fill(dt);
                dt.Columns[0].ColumnName = "Cod Empleado";
                dt.Columns[1].ColumnName = "Empleado";
                dt.Columns[2].ColumnName = "Sede";
                dt.Columns[3].ColumnName = "Turno";
                dt.AcceptChanges();
                dgvPersonalSinMarcacion.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se encontro ningun resultado \n\n " + ex, "ERROR");

            }
        }

        private void cboTurno_Click(object sender, EventArgs e)
        {
            string nombre_unidad = cboUnidad.GetItemText(cboUnidad.SelectedItem);
            string fi = dtpFecha.Value.Date.ToString("dd-MM-yyyy");
            Excel.ExportarDatosExcelPersonalSinMarcacion(dgvPersonalSinMarcacion, progressBar1, nombre_unidad, fi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dia = dateTimePicker1.Value;
            int cod_turno = turno.SelectedIndex;
            try
            {
                SqlCommand comando = conexion.conexionBD().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "sp_personalsinmarcacion_unidades_t  @fecha,@cod_turno";
                comando.Parameters.AddWithValue("fecha", dia);
                comando.Parameters.AddWithValue("cod_turno", cod_turno);
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(comando);
                dta.Fill(dt);
                dt.Columns[0].ColumnName = "Cod Empleado";
                dt.Columns[1].ColumnName = "Empleado";
                dt.Columns[2].ColumnName = "Sede";
                dt.Columns[3].ColumnName = "Turno";
                dt.AcceptChanges();
                dgvPersonalSinMarcacion.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se encontro ningun resultado \n\n " + ex, "ERROR");

            }
        }
    }
}
