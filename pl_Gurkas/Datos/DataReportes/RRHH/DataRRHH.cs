using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl_Gurkas.Datos.DataReportes.RRHH
{
    class DataRRHH
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();

        public DataTable ConsultaDeAsistenciaPorSede(DateTime fechaInicio, DateTime FechaFin, string Sede)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SP_RRHH_AsistenciaGeneralPersonalSede  @Sede, @fechaInicio, @FechaFin";
            comando.Parameters.AddWithValue("Sede", Sede);
            comando.Parameters.AddWithValue("fechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("FechaFin", FechaFin);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "Cod Empleado";
            dt.Columns[1].ColumnName = "Empleado";
            dt.Columns[2].ColumnName = "Num Identidad";
            dt.Columns[3].ColumnName = "Fecha Nacimineto";
            dt.Columns[4].ColumnName = "Empresa";
            dt.Columns[5].ColumnName = "Fecha Inicio";
            dt.Columns[6].ColumnName = "Sede ";
            dt.Columns[7].ColumnName = "Tipo Asistencia";
            dt.Columns[8].ColumnName = "Fecha Asistencia";
            dt.Columns[9].ColumnName = "Turno";
            dt.Columns[10].ColumnName = "Puesto";
            return dt;
        }
        public DataTable ConsultarGeneraldeAsistencia(DateTime fechaInicio, DateTime FechaFin)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SP_RRHH_AsistenciaGeneralPersonal  @fechaInicio, @FechaFin";
            comando.Parameters.AddWithValue("fechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("FechaFin", FechaFin);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "Cod Empleado";
            dt.Columns[1].ColumnName = "Empleado";
            dt.Columns[2].ColumnName = "Num Identidad";
            dt.Columns[3].ColumnName = "Fecha Nacimineto";
            dt.Columns[4].ColumnName = "Empresa";
            dt.Columns[5].ColumnName = "Fecha Inicio";
            dt.Columns[6].ColumnName = "Sede ";
            dt.Columns[7].ColumnName = "Tipo Asistencia";
            dt.Columns[8].ColumnName = "Fecha Asistencia";
            dt.Columns[9].ColumnName = "Turno";
            dt.Columns[10].ColumnName = "Puesto";
            return dt;
        }
    }
}
