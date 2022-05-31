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
        //Datos.DatosUsuario DatosUsuario = new Datos.DatosUsuario();
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
        public void RegistrarPrendaCalzado(string cod_sistema, string cod_calzado, string nombre_calzado, int talla_cal, string color_cal,
                  int tipo_calzado, int stock_inicial_cal, int estado_cal, decimal precio_unitario_cal, int stock_actual_cal,
                  int stock_minimo_cal, string desp_cal,
                  DateTime f_adquision_cal, DateTime f_registro_cal, string observacion_cal)
        {
            SqlCommand cmd = new SqlCommand("sp_registrar_producto_calzado ", conexion.conexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_SISTEMA", SqlDbType.VarChar).Value = cod_sistema;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_UNI_CALZADO", SqlDbType.VarChar).Value = cod_calzado;
            cmd.Parameters.AddWithValue("@NOMBRE_CALZADO", SqlDbType.VarChar).Value = nombre_calzado;
            cmd.Parameters.AddWithValue("@ID_TALLA_PRENDA_CALZADO", SqlDbType.Int).Value = talla_cal;
            cmd.Parameters.AddWithValue("@COLOR_CALZADO", SqlDbType.VarChar).Value = color_cal;
            cmd.Parameters.AddWithValue("@IDTIPOCALZADO", SqlDbType.Int).Value = tipo_calzado;
            cmd.Parameters.AddWithValue("@STOCK_INICIAL_CALZADO", SqlDbType.Int).Value = stock_inicial_cal;
            cmd.Parameters.AddWithValue("@ID_ESTADO_MATERIAL", SqlDbType.Int).Value = estado_cal;
            cmd.Parameters.AddWithValue("@COSTO_UNITARIO_CALZADO", SqlDbType.Decimal).Value = precio_unitario_cal;
            cmd.Parameters.AddWithValue("@STOCK_ACTUAL_CALZADO", SqlDbType.Int).Value = stock_actual_cal;
            cmd.Parameters.AddWithValue("@STOCK_MINIMO_CALZADO", SqlDbType.Int).Value = stock_minimo_cal;
            cmd.Parameters.AddWithValue("@DESCRP_CALZADO", SqlDbType.VarChar).Value = desp_cal;
            cmd.Parameters.AddWithValue("@FECHA_ADQUISICION_CALZADO", SqlDbType.VarChar).Value = f_adquision_cal;
            cmd.Parameters.AddWithValue("@FECHA_REGISTRO_CALZADO", SqlDbType.VarChar).Value = f_registro_cal;
            cmd.Parameters.AddWithValue("@OBSERVACION_CALZADO", SqlDbType.VarChar).Value = observacion_cal;
            cmd.Parameters.AddWithValue("@USUARIO", SqlDbType.VarChar).Value = nombre_usuario;
            cmd.ExecuteNonQuery();
        }
        public void RegistrarPrendaPantalon(string cod_sistema, string cod_pantalon, string nombre_pantalon, int talla_pan,
                     string color_pan,
                     int stock_inicial_pan, int tipo_tela_pan, int estado_pan, decimal precio_unitario_pan, int stock_actual_pan, int stock_minimo_pan,
                     string desp_pan,
                       DateTime f_adquision_pan, DateTime f_registro_pan, string observacion_pan)
        {
            SqlCommand cmd = new SqlCommand("sp_registrar_producto_pantalon ", conexion.conexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_SISTEMA", SqlDbType.VarChar).Value = cod_sistema;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_UNI_PANTALON", SqlDbType.VarChar).Value = cod_pantalon;
            cmd.Parameters.AddWithValue("@NOMBRE_PANTALON", SqlDbType.VarChar).Value = nombre_pantalon;
            cmd.Parameters.AddWithValue("@ID_TALLA_PRENDA_PANTALON", SqlDbType.Int).Value = talla_pan;
            cmd.Parameters.AddWithValue("@COLOR_PANTALON", SqlDbType.VarChar).Value = color_pan;
            cmd.Parameters.AddWithValue("@idTipoPrenda", SqlDbType.Int).Value = tipo_tela_pan;
            cmd.Parameters.AddWithValue("@STOCK_INICIAL_PANTALON", SqlDbType.Int).Value = stock_inicial_pan;
            cmd.Parameters.AddWithValue("@ID_ESTADO_MATERIAL_PANTALON", SqlDbType.Int).Value = estado_pan;
            cmd.Parameters.AddWithValue("@COSTO_UNITARIO_PANTALON", SqlDbType.Decimal).Value = precio_unitario_pan;
            cmd.Parameters.AddWithValue("@STOCK_ACTUAL_PANTALON", SqlDbType.Int).Value = stock_actual_pan;
            cmd.Parameters.AddWithValue("@STOCK_MINIMO_PANTALON", SqlDbType.Int).Value = stock_minimo_pan;
            cmd.Parameters.AddWithValue("@DESCRP_PANTALON", SqlDbType.VarChar).Value = desp_pan;
            cmd.Parameters.AddWithValue("@FECHA_ADQUISICION_PANTALON", SqlDbType.VarChar).Value = f_adquision_pan;
            cmd.Parameters.AddWithValue("@FECHA_REGISTRO_PANTALON", SqlDbType.VarChar).Value = f_registro_pan;
            cmd.Parameters.AddWithValue("@OBSERVACION_PANTALON", SqlDbType.VarChar).Value = observacion_pan;
            cmd.Parameters.AddWithValue("@USUARIO", SqlDbType.VarChar).Value = nombre_usuario;
            cmd.ExecuteNonQuery();
        }
        public void RegistrarPrendaAccesorio(string cod_sistema, string cod_accesorio, string nombre_accesorio, int talla_acc,
                       string color_acc, int stock_inicial_acc, int tipo_tela_acc, int estado_acc, decimal precio_unitario_acc, int stock_actual_acc,
                      int stock_minimo_acc, string desp_acc, DateTime f_adquision_acc, DateTime f_registro_acc, string observacion_acc)
        {
            SqlCommand cmd = new SqlCommand("sp_registrar_producto_accesorio ", conexion.conexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_SISTEMA", SqlDbType.VarChar).Value = cod_sistema;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_UNI_ACCESORIO", SqlDbType.VarChar).Value = cod_accesorio;
            cmd.Parameters.AddWithValue("@NOMBRE_ACCESORIO", SqlDbType.VarChar).Value = nombre_accesorio;
            cmd.Parameters.AddWithValue("@ID_TALLA_PRENDA_ACCESORIO", SqlDbType.Int).Value = talla_acc;
            cmd.Parameters.AddWithValue("@COLOR_ACCESORIO", SqlDbType.VarChar).Value = color_acc;
            cmd.Parameters.AddWithValue("@idTipoPrenda", SqlDbType.Int).Value = tipo_tela_acc;
            cmd.Parameters.AddWithValue("@STOCK_INICIAL_ACCESORIO", SqlDbType.Int).Value = stock_inicial_acc;
            cmd.Parameters.AddWithValue("@ID_ESTADO_MATERIAL_ACCESORIO", SqlDbType.Int).Value = estado_acc;
            cmd.Parameters.AddWithValue("@COSTO_UNITARIO_ACCESORIO", SqlDbType.Decimal).Value = precio_unitario_acc;
            cmd.Parameters.AddWithValue("@STOCK_ACTUAL_ACCESORIO", SqlDbType.Int).Value = stock_actual_acc;
            cmd.Parameters.AddWithValue("@STOCK_MINIMO_ACCESORIO", SqlDbType.Int).Value = stock_minimo_acc;
            cmd.Parameters.AddWithValue("@DESCRP_ACCESORIO", SqlDbType.VarChar).Value = desp_acc;
            cmd.Parameters.AddWithValue("@FECHA_ADQUISICION_ACCESORIO", SqlDbType.VarChar).Value = f_adquision_acc;
            cmd.Parameters.AddWithValue("@FECHA_REGISTRO_ACCESORIO", SqlDbType.VarChar).Value = f_registro_acc;
            cmd.Parameters.AddWithValue("@OBSERVACION_ACCESORIO", SqlDbType.VarChar).Value = observacion_acc;
            cmd.Parameters.AddWithValue("@USUARIO", SqlDbType.VarChar).Value = nombre_usuario;
            cmd.ExecuteNonQuery();
        }
        public void RegistrarUtiles(string cod_sistema, string cod_utiles, string nombre_utiles, string marca_utiles,
                         string modelo_utiles, int tipo_unidad_utiles, int stock_inicial_utiles, int estado_utiles, decimal precio_unitario_utiles,
                          int stock_actual_utiles,
                       int stock_minimo_utiles, string desp_utiles, DateTime f_adquision_utiles, DateTime f_registro_utiles, string observacion_utiles)
        {
            SqlCommand cmd = new SqlCommand("sp_registrar_producto_utiles_escritorio ", conexion.conexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_SISTEMA", SqlDbType.VarChar).Value = cod_sistema;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_UTI_ESCRITORIO", SqlDbType.VarChar).Value = cod_utiles;
            cmd.Parameters.AddWithValue("@NOMBRE_UTI_ESCRITORIO", SqlDbType.VarChar).Value = nombre_utiles;
            cmd.Parameters.AddWithValue("@MARCA_UTI_ESCRITORIO", SqlDbType.VarChar).Value = marca_utiles;
            cmd.Parameters.AddWithValue("@MODELO_UTI_ESCRITORIO", SqlDbType.VarChar).Value = modelo_utiles;
            cmd.Parameters.AddWithValue("@idunidad_producto_UTI_ESCRITORIO", SqlDbType.Int).Value = tipo_unidad_utiles;
            cmd.Parameters.AddWithValue("@STOCK_INICIAL_UTI_ESCRITORIO", SqlDbType.Int).Value = stock_inicial_utiles;
            cmd.Parameters.AddWithValue("@ID_ESTADO_MATERIAL_UTI_ESCRITORIO", SqlDbType.Int).Value = estado_utiles;
            cmd.Parameters.AddWithValue("@COSTO_UNITARIO_UTI_ESCRITORIO", SqlDbType.Decimal).Value = precio_unitario_utiles;
            cmd.Parameters.AddWithValue("@STOCK_ACTUAL_UTI_ESCRITORIO", SqlDbType.Int).Value = stock_actual_utiles;
            cmd.Parameters.AddWithValue("@STOCK_MINIMO_UTI_ESCRITORIO", SqlDbType.Int).Value = stock_minimo_utiles;
            cmd.Parameters.AddWithValue("@DESCRP_UTI_ESCRITORIO", SqlDbType.VarChar).Value = desp_utiles;
            cmd.Parameters.AddWithValue("@FECHA_ADQUISICION_UTI_ESCRITORIO", SqlDbType.VarChar).Value = f_adquision_utiles;
            cmd.Parameters.AddWithValue("@FECHA_REGISTRO_UTI_ESCRITORIO", SqlDbType.VarChar).Value = f_registro_utiles;
            cmd.Parameters.AddWithValue("@OBSERVACION_UTI_ESCRITORIO", SqlDbType.VarChar).Value = observacion_utiles;
            cmd.Parameters.AddWithValue("@USUARIO", SqlDbType.VarChar).Value = nombre_usuario;
            cmd.ExecuteNonQuery();
        }
    }
}
