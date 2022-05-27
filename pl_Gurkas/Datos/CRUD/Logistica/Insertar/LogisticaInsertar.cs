using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl_Gurkas.Datos.CRUD.Logistica.Insertar
{
    class LogisticaInsertar
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.DatosUsuario DatosUsuario = new Datos.DatosUsuario();
        string nombre_usuario = DatosUsuario._usuario;
        public void RegistrarEquipoTecnologico(string cod_sistema, string cod_producto, string nombre_producto, string modelo
            , string marca, string num_serie, string desp_equipo, int estado, decimal precio_unitario, int tipo_unidad,
            int stock_inicial, int stock_actual, int stock_minimo, DateTime f_adquision, DateTime f_registro, string observacion)
        {
            SqlCommand cmd = new SqlCommand("sp_insertar_sueldo_unidad_puesto ", conexion.conexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_unidad", SqlDbType.VarChar).Value = cod_sistema;
            cmd.Parameters.AddWithValue("@mv", SqlDbType.VarChar).Value = cod_producto;
            cmd.Parameters.AddWithValue("@sueldo", SqlDbType.VarChar).Value = nombre_producto;
            cmd.Parameters.AddWithValue("@idpuesto", SqlDbType.VarChar).Value = modelo;
            cmd.Parameters.AddWithValue("@idpuesto", SqlDbType.VarChar).Value = marca;
            cmd.Parameters.AddWithValue("@idpuesto", SqlDbType.VarChar).Value = num_serie;
            cmd.Parameters.AddWithValue("@idpuesto", SqlDbType.VarChar).Value = desp_equipo;
            cmd.Parameters.AddWithValue("@idpuesto", SqlDbType.Int).Value = estado;
            cmd.Parameters.AddWithValue("@idpuesto", SqlDbType.Decimal).Value = precio_unitario;
            cmd.Parameters.AddWithValue("@idpuesto", SqlDbType.Int).Value = tipo_unidad;
            cmd.Parameters.AddWithValue("@idpuesto", SqlDbType.Int).Value = stock_inicial;
            cmd.Parameters.AddWithValue("@idpuesto", SqlDbType.Int).Value = stock_actual;
            cmd.Parameters.AddWithValue("@idpuesto", SqlDbType.Int).Value = stock_minimo;
            cmd.Parameters.AddWithValue("@idpuesto", SqlDbType.VarChar).Value = f_adquision;
            cmd.Parameters.AddWithValue("@idpuesto", SqlDbType.VarChar).Value = f_registro;
            cmd.Parameters.AddWithValue("@idpuesto", SqlDbType.VarChar).Value = observacion;
            cmd.Parameters.AddWithValue("@idpuesto", SqlDbType.VarChar).Value = nombre_usuario;
            cmd.ExecuteNonQuery();
        }
    }
}
