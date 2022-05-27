using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl_Gurkas.Datos.CRUD.Logistica.Actualizar
{
    class LogisticaActualizar
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.DatosUsuario DatosUsuario = new Datos.DatosUsuario();
        string nombre_usuario = DatosUsuario._usuario;
        public void ActualizarEquipoTecnologico(string cod_sistema, string cod_producto, string nombre_producto, string modelo
          , string marca, string num_serie, string desp_equipo, int estado, decimal precio_unitario, int tipo_unidad,
          int stock_inicial, int stock_actual, int stock_minimo, DateTime f_adquision, DateTime f_registro, string observacion)
        {
            SqlCommand cmd = new SqlCommand("sp_actualizar_producto_tecnologico ", conexion.conexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_SISTEMA", SqlDbType.VarChar).Value = cod_sistema;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_TECNOLOGICO", SqlDbType.VarChar).Value = cod_producto;
            cmd.Parameters.AddWithValue("@NOMBRE_EQUIPO", SqlDbType.VarChar).Value = nombre_producto;
            cmd.Parameters.AddWithValue("@MODELO", SqlDbType.VarChar).Value = modelo;
            cmd.Parameters.AddWithValue("@MARCA", SqlDbType.VarChar).Value = marca;
            cmd.Parameters.AddWithValue("@NUMERO_SERIE", SqlDbType.VarChar).Value = num_serie;
            cmd.Parameters.AddWithValue("@DESCRP_EQUIPO", SqlDbType.VarChar).Value = desp_equipo;
            cmd.Parameters.AddWithValue("@ID_ESTADO_MATERIAL", SqlDbType.Int).Value = estado;
            cmd.Parameters.AddWithValue("@COSTO_UNITARIO_T", SqlDbType.Decimal).Value = precio_unitario;
            cmd.Parameters.AddWithValue("@IDUNIDAD_PRODUCTO", SqlDbType.Int).Value = tipo_unidad;
            cmd.Parameters.AddWithValue("@STOCK_INICIAL", SqlDbType.Int).Value = stock_inicial;
            cmd.Parameters.AddWithValue("@STOCK_ACTUAL", SqlDbType.Int).Value = stock_actual;
            cmd.Parameters.AddWithValue("@STOCK_MINIMO", SqlDbType.Int).Value = stock_minimo;
            cmd.Parameters.AddWithValue("@FECHA_ADQUISICION", SqlDbType.VarChar).Value = f_adquision;
            cmd.Parameters.AddWithValue("@FECHA_REGISTRO", SqlDbType.VarChar).Value = f_registro;
            cmd.Parameters.AddWithValue("@OBSERVACION", SqlDbType.VarChar).Value = observacion;
            cmd.Parameters.AddWithValue("@USUARIO", SqlDbType.VarChar).Value = nombre_usuario;
            cmd.ExecuteNonQuery();
        }
    }
}
