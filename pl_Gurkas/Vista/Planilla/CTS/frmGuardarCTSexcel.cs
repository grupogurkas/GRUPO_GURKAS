﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.Planilla.CTS
{
    public partial class frmGuardarCTSexcel : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        public frmGuardarCTSexcel()
        {
            InitializeComponent();
        }
        DataView importarDatos(string nombrearchivo)
        {
            string conexion = string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Extended Properties = 'Excel 12.0'", nombrearchivo);
            OleDbConnection conector = new OleDbConnection(conexion);
            conector.Open();
            OleDbCommand consulta = new OleDbCommand("select * from [Hoja1$]", conector);
            OleDbDataAdapter adaptador = new OleDbDataAdapter
            {
                SelectCommand = consulta
            };
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            conector.Close();
            return ds.Tables[0].DefaultView;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel | *.xls;*.xlsx;",
                Title = "Seleccionar Archivo"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = importarDatos(openFileDialog.FileName);
            }
        }

        private void frmGuardarCTSexcel_Load(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            const string titulo = "Guardar Datos en el Sistema";
            const string mensaje = "Porfavor verificar antes de guardar en el sistema \n SI  =  GUARDAR IMFORMACION \n NO  =  VERIFICACION DE DATOS";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                SqlCommand comando = new SqlCommand("sp_guardar_cts", conexion.conexionBD());
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["FECHA_INGRESO_PLANILLA"].Value != null &&
                        row.Cells["TIEMPO_COMPUTABLE_POR_MESES"].Value != null &&
                        row.Cells["POR_DIAS"].Value != null && row.Cells["FALTAS_INJUSTI"].Value != null &&
                        row.Cells["COD_TRABAJADR"].Value != null && row.Cells["DNI"].Value != null &&
                        row.Cells["NOMBRES"].Value != null && row.Cells["UNIDAD"].Value != null &&
                        row.Cells["CUENTA"].Value != null && row.Cells["SUELDO_BRUTO"].Value != null &&
                        row.Cells["PROM_REMUNERACION_BASICA"].Value != null && row.Cells["ASIG_FAM"].Value != null &&
                        row.Cells["PROM_H_E"].Value != null && row.Cells["1_6_GRATI"].Value != null &&
                        row.Cells["TOTAL"].Value != null && row.Cells["CTS_ANUAL"].Value != null &&
                        row.Cells["CTS_MENSUAL"].Value != null && row.Cells["CTS_N_DE_MESES"].Value != null &&
                        row.Cells["CTS_N_DE_DIAS"].Value != null && row.Cells["CTS_X_N_FALTOS"].Value != null &&
                        row.Cells["TOTAL_CTS_MESES_CTS_DIAS"].Value != null && row.Cells["INTERESES"].Value != null &&
                        row.Cells["TOTAL_CTS"].Value != null && row.Cells["TOTAL_A_ABONAR"].Value != null &&
                        row.Cells["CUENTA_CTS"].Value != null && row.Cells["BANCO"].Value != null)
                    {
                        comando.Parameters.Clear();
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@FECHA_INGRESO_PLANILLA", SqlDbType.VarChar).Value = row.Cells["FECHA_INGRESO_PLANILLA"].Value;
                        comando.Parameters.AddWithValue("@TIEMPO_COMPUTABLE_POR_MESES", SqlDbType.Int).Value = row.Cells["TIEMPO_COMPUTABLE_POR_MESES"].Value;
                        comando.Parameters.AddWithValue("@POR_DIAS", SqlDbType.Int).Value = row.Cells["POR_DIAS"].Value;
                        comando.Parameters.AddWithValue("@FALTAS_INJUSTI", SqlDbType.Int).Value = row.Cells["FALTAS_INJUSTI"].Value;
                        comando.Parameters.AddWithValue("@COD_TRABAJADR", SqlDbType.VarChar).Value = row.Cells["COD_TRABAJADR"].Value;
                        comando.Parameters.AddWithValue("@DNI", SqlDbType.VarChar).Value = row.Cells["DNI"].Value;
                        comando.Parameters.AddWithValue("@NOMBRES", SqlDbType.VarChar).Value = row.Cells["NOMBRES"].Value;
                        comando.Parameters.AddWithValue("@UNIDAD", SqlDbType.VarChar).Value = row.Cells["UNIDAD"].Value;
                        comando.Parameters.AddWithValue("@CUENTA", SqlDbType.VarChar).Value = row.Cells["CUENTA"].Value;
                        comando.Parameters.AddWithValue("@SUELDO_BRUTO", SqlDbType.Decimal).Value = row.Cells["SUELDO_BRUTO"].Value;
                        comando.Parameters.AddWithValue("@PROM_REMUNERACION_BASICA", SqlDbType.Decimal).Value = row.Cells["PROM_REMUNERACION_BASICA"].Value;
                        comando.Parameters.AddWithValue("@ASIG_FAM", SqlDbType.Decimal).Value = row.Cells["ASIG_FAM"].Value;
                        comando.Parameters.AddWithValue("@PROM_H_E", SqlDbType.Decimal).Value = row.Cells["PROM_H_E"].Value;
                        comando.Parameters.AddWithValue("@1_6_GRATI", SqlDbType.Decimal).Value = row.Cells["1_6_GRATI"].Value;
                        comando.Parameters.AddWithValue("@TOTAL", SqlDbType.Decimal).Value = row.Cells["TOTAL"].Value;
                        comando.Parameters.AddWithValue("@CTS_ANUAL", SqlDbType.Decimal).Value = row.Cells["CTS_ANUAL"].Value;
                        comando.Parameters.AddWithValue("@CTS_MENSUAL", SqlDbType.Decimal).Value = row.Cells["CTS_MENSUAL"].Value;
                        comando.Parameters.AddWithValue("@CTS_N_DE_MESES", SqlDbType.Decimal).Value = row.Cells["CTS_N_DE_MESES"].Value;
                        comando.Parameters.AddWithValue("@CTS_N_DE_DIAS", SqlDbType.Decimal).Value = row.Cells["CTS_N_DE_DIAS"].Value;
                        comando.Parameters.AddWithValue("@CTS_X_N_FALTOS", SqlDbType.Decimal).Value = row.Cells["CTS_X_N_FALTOS"].Value;
                        comando.Parameters.AddWithValue("@TOTAL_CTS_MESES_CTS_DIAS", SqlDbType.Decimal).Value = row.Cells["TOTAL_CTS_MESES_CTS_DIAS"].Value;
                        comando.Parameters.AddWithValue("@INTERESES", SqlDbType.Decimal).Value = row.Cells["INTERESES"].Value;
                        comando.Parameters.AddWithValue("@TOTAL_CTS", SqlDbType.Decimal).Value = row.Cells["TOTAL_CTS"].Value;
                        comando.Parameters.AddWithValue("@TOTAL_A_ABONAR", SqlDbType.Decimal).Value = row.Cells["TOTAL_A_ABONAR"].Value;
                        comando.Parameters.AddWithValue("@CUENTA_CTS", SqlDbType.VarChar).Value = row.Cells["CUENTA_CTS"].Value;
                        comando.Parameters.AddWithValue("@BANCO", SqlDbType.VarChar).Value = row.Cells["BANCO"].Value;
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Datos registrado correptamente \n Registrado Exitosamente "
                   , "Correpto");
                Vista.Planilla.CTS.frmGuardarCTS frmGuardarCTS = new Vista.Planilla.CTS.frmGuardarCTS();
                frmGuardarCTS.ShowDialog();
            }
        }
    }
}
