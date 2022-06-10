using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public DataTable ConsultarAsistenciaporPersona(string Cod_Trabajador, DateTime fechaInicio, DateTime FechaFin)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SP_PersonalAsistencia  @Cod_empleado,@fechainicio, @fechafin";
            comando.Parameters.AddWithValue("Cod_empleado", Cod_Trabajador);
            comando.Parameters.AddWithValue("fechainicio", fechaInicio);
            comando.Parameters.AddWithValue("fechafin", FechaFin);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "Codigo Empleado";
            dt.Columns[1].ColumnName = "Nombre Empleado";
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
        public DataTable ConsultarAsistenciaSede(DateTime fechaInicio, DateTime FechaFin, string unidad)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SP_RRHH_AsistenciaGeneralPersonalUnidad @unidad, @fechaInicio, @FechaFin";
            comando.Parameters.AddWithValue("unidad", unidad);
            comando.Parameters.AddWithValue("fechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("FechaFin", FechaFin);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "Codigo Empleado";
            dt.Columns[1].ColumnName = "Nombre Empleado";
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
        public DataTable ConsultaEstaturas(decimal estaturaInicio, decimal estaturaFin)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SP_ESTATURAPersonal  @estaturainicial, @estaturafinal";
            comando.Parameters.AddWithValue("estaturainicial", estaturaInicio);
            comando.Parameters.AddWithValue("estaturafinal", estaturaFin);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "Cod Empleado";
            dt.Columns[1].ColumnName = "Empleado";
            dt.Columns[2].ColumnName = "Num Identidad";
            dt.Columns[3].ColumnName = "Fecha Nacimineto";
            dt.Columns[4].ColumnName = "Empresa";
            dt.Columns[5].ColumnName = "Fecha Emision";
            dt.Columns[6].ColumnName = "Fecha Vencimiento";
            dt.Columns[7].ColumnName = "Sexo";
            dt.Columns[8].ColumnName = "Nacionalidad ";
            dt.Columns[9].ColumnName = "Departamento ";
            dt.Columns[10].ColumnName = "Provincia ";
            dt.Columns[11].ColumnName = "Distrito ";
            dt.Columns[12].ColumnName = "Direccion ";
            dt.Columns[13].ColumnName = "Telefono";
            dt.Columns[14].ColumnName = "Celular";
            dt.Columns[15].ColumnName = "Talla Prenda";
            dt.Columns[16].ColumnName = "Talla Pantalon";
            dt.Columns[17].ColumnName = "Calzado";
            dt.Columns[18].ColumnName = "Estatura";
            dt.Columns[19].ColumnName = "Correo";
            dt.Columns[20].ColumnName = "Grado Instruccion";
            dt.Columns[21].ColumnName = "Brevete";
            dt.Columns[22].ColumnName = "Numero Brevete";
            dt.Columns[23].ColumnName = "Puesto";
            return dt;
        }
        public DataTable ConsultarEdadEmpleado(int edadInicio, int EdadFin)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SP_RRHHEdadConsulta  @edadInica, @edadFinal";
            comando.Parameters.AddWithValue("edadInica", edadInicio);
            comando.Parameters.AddWithValue("edadFinal", EdadFin);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "Estado Empleado";
            dt.Columns[1].ColumnName = "Cod Empleado";
            dt.Columns[2].ColumnName = "Empleado";
            dt.Columns[3].ColumnName = "Num Identidad";
            dt.Columns[4].ColumnName = "Edad";
            dt.Columns[5].ColumnName = "Empresa";
            dt.Columns[6].ColumnName = "Fecha Nacimineto";
            dt.Columns[7].ColumnName = "Fecha Emision";
            dt.Columns[8].ColumnName = "Fecha Vencimiento";
            dt.Columns[9].ColumnName = "Sexo";
            dt.Columns[10].ColumnName = "Nacionalidad ";
            dt.Columns[11].ColumnName = "Departamento ";
            dt.Columns[12].ColumnName = "Provincia ";
            dt.Columns[13].ColumnName = "Distrito ";
            dt.Columns[14].ColumnName = "Direccion ";
            dt.Columns[15].ColumnName = "Telefono";
            dt.Columns[16].ColumnName = "Celular";
            dt.Columns[17].ColumnName = "Talla Prenda";
            dt.Columns[18].ColumnName = "Talla Pantalon";
            dt.Columns[19].ColumnName = "Calzado";
            dt.Columns[20].ColumnName = "Estatura";
            dt.Columns[21].ColumnName = "Correo";
            dt.Columns[22].ColumnName = "Grado Instruccion";
            dt.Columns[23].ColumnName = "Brevete";
            dt.Columns[24].ColumnName = "Numero Brevete";
            dt.Columns[25].ColumnName = "Puesto";
            return dt;
        }
        public DataTable ConsultarAsistenciaPorEmpresa(int CodEmpresa)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SP_RRHHEmpresaPersonal  @Cod_empresa";
            comando.Parameters.AddWithValue("Cod_empresa", CodEmpresa);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "Cod Empleado";
            dt.Columns[1].ColumnName = "Empleado";
            dt.Columns[2].ColumnName = "Num Identidad";
            dt.Columns[3].ColumnName = "Fecha Nacimineto";
            dt.Columns[4].ColumnName = "Empresa";
            return dt;
        }
        public DataTable ConsultarFechaIngreso(DateTime fechaInicio, DateTime FechaFin, int empresa)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SP_RRHHFechaIngreso  @fechaInicio, @FechaFin,@id_empresa";
            comando.Parameters.AddWithValue("fechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("FechaFin", FechaFin);
            comando.Parameters.AddWithValue("id_empresa", empresa);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "Cod Empleado";
            dt.Columns[1].ColumnName = "Empleado";
            dt.Columns[2].ColumnName = "Num Identidad";
            dt.Columns[3].ColumnName = "Fecha Nacimineto";
            dt.Columns[4].ColumnName = "Empresa";
            dt.Columns[5].ColumnName = "Fecha Inicio Laboral";
            dt.Columns[6].ColumnName = "Puesto ";
            dt.Columns[7].ColumnName = "Sede";
            dt.Columns[8].ColumnName = "Turno";
            dt.Columns[9].ColumnName = "Estado Personal";
            return dt;
        }
        public DataTable ConsultarPersonalSede(string sede)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SP_PERSONALSEDE  @cod_sede";
            comando.Parameters.AddWithValue("cod_sede", sede);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "Cod Empleado";
            dt.Columns[1].ColumnName = "Empleado";
            dt.Columns[2].ColumnName = "Num Identidad";
            dt.Columns[3].ColumnName = "Fecha Nacimineto";
            dt.Columns[4].ColumnName = "Empresa";
            dt.Columns[5].ColumnName = "Fecha Inicio Laboral";
            dt.Columns[6].ColumnName = "Puesto";
            dt.Columns[7].ColumnName = "Sede";
            dt.Columns[8].ColumnName = "Turno";
            dt.Columns[9].ColumnName = "Estado Personal";
            return dt;
        }
        public DataTable ConsultarPersonalUnidad(string unidad)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SP_PERSONALunidad  @cod_unidad";
            comando.Parameters.AddWithValue("cod_unidad", unidad);
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
            return dt;
        }
        public DataTable ConsultarAsistenciaPorTurno(int turno, int id_empresa)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SP_REPORTERRHH_PorTurno  @turno,@id_empresa";
            comando.Parameters.AddWithValue("turno", turno);
            comando.Parameters.AddWithValue("id_empresa", id_empresa);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "Cod Asistencia";
            dt.Columns[1].ColumnName = "Empleado";
            dt.Columns[2].ColumnName = "Num Documento";
            dt.Columns[3].ColumnName = "Fecha Nacimiento";
            dt.Columns[4].ColumnName = "Empresa";
            dt.Columns[5].ColumnName = "Turno";
            return dt;
        }

        public DataTable ConsultarPorDNI(string cod_personal)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SP_RRHHDNI  @dni";
            comando.Parameters.AddWithValue("dni", cod_personal);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "Estado Empleado";
            dt.Columns[1].ColumnName = "Cod Empleado";
            dt.Columns[2].ColumnName = "Empleado";
            dt.Columns[3].ColumnName = "Num Identidad";
            dt.Columns[4].ColumnName = "Edad";
            dt.Columns[5].ColumnName = "Empresa";
            dt.Columns[6].ColumnName = "Fecha Nacimineto";
            dt.Columns[7].ColumnName = "Fecha Emision";
            dt.Columns[8].ColumnName = "Fecha Vencimiento";
            dt.Columns[9].ColumnName = "Sexo";
            dt.Columns[10].ColumnName = "Nacionalidad ";
            dt.Columns[11].ColumnName = "Departamento ";
            dt.Columns[12].ColumnName = "Provincia ";
            dt.Columns[13].ColumnName = "Distrito ";
            dt.Columns[14].ColumnName = "Direccion ";
            dt.Columns[15].ColumnName = "Telefono";
            dt.Columns[16].ColumnName = "Celular";
            dt.Columns[17].ColumnName = "Correo";
            dt.Columns[18].ColumnName = "Puesto";
            return dt;
        }

        public DataTable ConsultarPorCodigo(string cod_personal_activo)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SP_RRHHCODIGO  @cod_empleado";
            comando.Parameters.AddWithValue("cod_empleado", cod_personal_activo);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "Estado Empleado";
            dt.Columns[1].ColumnName = "Cod Empleado";
            dt.Columns[2].ColumnName = "Empleado";
            dt.Columns[3].ColumnName = "Num Identidad";
            dt.Columns[4].ColumnName = "Edad";
            dt.Columns[5].ColumnName = "Empresa";
            dt.Columns[6].ColumnName = "Fecha Nacimineto";
            dt.Columns[7].ColumnName = "Fecha Emision";
            dt.Columns[8].ColumnName = "Fecha Vencimiento";
            dt.Columns[9].ColumnName = "Sexo";
            dt.Columns[10].ColumnName = "Nacionalidad ";
            dt.Columns[11].ColumnName = "Departamento ";
            dt.Columns[12].ColumnName = "Provincia ";
            dt.Columns[13].ColumnName = "Distrito ";
            dt.Columns[14].ColumnName = "Direccion ";
            dt.Columns[15].ColumnName = "Telefono";
            dt.Columns[16].ColumnName = "Celular";
            dt.Columns[17].ColumnName = "Correo";
            dt.Columns[18].ColumnName = "Puesto";
            return dt;
        }
    }




}
