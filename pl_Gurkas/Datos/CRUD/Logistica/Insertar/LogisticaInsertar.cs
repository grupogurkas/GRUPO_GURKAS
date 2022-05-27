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
            SqlCommand cmd = new SqlCommand("sp_registrar_producto_tecnologico ", conexion.conexionBD());
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
        public void RegistrarPrendaCamisas(string cod_sistema, string cod_camisa, string nombre_camisa, int talla_c, string color_c,
                  int stock_inicial_c, int estado_c, decimal precio_unitario_c, int stock_actual_c, int stock_minimo_c, string desp_c, DateTime f_adquision_c,
                  DateTime f_registro_c, string observacion_c)
        {
            SqlCommand cmd = new SqlCommand("sp_registrar_producto_camisas ", conexion.conexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_SISTEMA", SqlDbType.VarChar).Value = cod_sistema;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_UNI_CAMISAS", SqlDbType.VarChar).Value = cod_camisa;
            cmd.Parameters.AddWithValue("@NOMBRE_CAMISAS", SqlDbType.VarChar).Value = nombre_camisa;
            cmd.Parameters.AddWithValue("@ID_TALLA_PRENDA", SqlDbType.Int).Value = talla_c;
            cmd.Parameters.AddWithValue("@COLOR", SqlDbType.VarChar).Value = color_c;
            cmd.Parameters.AddWithValue("@STOCK_INICIAL", SqlDbType.Int).Value = stock_inicial_c;
            cmd.Parameters.AddWithValue("@ID_ESTADO_MATERIAL", SqlDbType.Int).Value = estado_c;
            cmd.Parameters.AddWithValue("@COSTO_UNITARIO_CAM", SqlDbType.Decimal).Value = precio_unitario_c;
            cmd.Parameters.AddWithValue("@STOCK_ACTUAL", SqlDbType.Int).Value = stock_actual_c;
            cmd.Parameters.AddWithValue("@STOCK_MINIMO", SqlDbType.Int).Value = stock_minimo_c;
            cmd.Parameters.AddWithValue("@DESCRP_CAMISAS", SqlDbType.VarChar).Value = desp_c;
            cmd.Parameters.AddWithValue("@FECHA_ADQUISICION", SqlDbType.VarChar).Value = f_registro_c;
            cmd.Parameters.AddWithValue("@FECHA_REGISTRO", SqlDbType.VarChar).Value = f_adquision_c;
            cmd.Parameters.AddWithValue("@OBSERVACION", SqlDbType.VarChar).Value = observacion_c;
            cmd.Parameters.AddWithValue("@USUARIO", SqlDbType.VarChar).Value = nombre_usuario;
            cmd.ExecuteNonQuery();
        }
    }
}
