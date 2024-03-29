﻿using System;
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
        public void RegistrarOrdenCompraFactura(string ordenCompra, string NumFact)
        {
            SqlCommand cmd = new SqlCommand("sp_registar_ordenes_compra_factura ", conexion.conexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OrdenCompra", SqlDbType.VarChar).Value = ordenCompra;
            cmd.Parameters.AddWithValue("@NUM_FACT", SqlDbType.VarChar).Value = NumFact;
            cmd.ExecuteNonQuery();
        }
        public void RegistrarPrendaCalzado(string cod_sistema, string cod_calzado, string nombre_calzado, int talla_cal, string color_cal,
                  int tipo_calzado, int stock_inicial_cal, int estado_cal, decimal precio_unitario_cal, int stock_actual_cal,
                  int stock_minimo_cal, string desp_cal,
                  DateTime f_adquision_cal, DateTime f_registro_cal, string observacion_cal, int cantidad_cuotas, decimal descuento_cuota)
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
            cmd.Parameters.AddWithValue("@id_cuotas", SqlDbType.VarChar).Value = cantidad_cuotas;
            cmd.Parameters.AddWithValue("@descuento_por_cuota", SqlDbType.VarChar).Value = descuento_cuota;
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

        public void RegistrarEquipaminetoLogistico(string cod_sistema, string cod_logistico, string nombre_logistico, string marca_logistico,
                          string modelo_logistico, int tipo_unidad_logistico, int stock_inicial_logistico, int estado_logistico, decimal precio_unitario_logistico,
                           int stock_actual_logistico,
                        int stock_minimo_logistico, string desp_logistico, DateTime f_adquision_logistico, DateTime f_registro_logistico, string observacion_logistico)
        {
            SqlCommand cmd = new SqlCommand("sp_registrar_producto_equipamiento_logistico ", conexion.conexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_SISTEMA", SqlDbType.VarChar).Value = cod_sistema;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_EQUIP_LOGISTICO", SqlDbType.VarChar).Value = cod_logistico;
            cmd.Parameters.AddWithValue("@NOMBRE_EQUIP_LOGISTICO", SqlDbType.VarChar).Value = nombre_logistico;
            cmd.Parameters.AddWithValue("@MARCA_EQUIP_LOGISTICO", SqlDbType.VarChar).Value = marca_logistico;
            cmd.Parameters.AddWithValue("@MODELO_EQUIP_LOGISTICO", SqlDbType.VarChar).Value = modelo_logistico;
            cmd.Parameters.AddWithValue("@idunidad_producto_EQUIP_LOGISTICO", SqlDbType.Int).Value = tipo_unidad_logistico;
            cmd.Parameters.AddWithValue("@STOCK_INICIAL_EQUIP_LOGISTICO", SqlDbType.Int).Value = stock_inicial_logistico;
            cmd.Parameters.AddWithValue("@ID_ESTADO_MATERIAL_EQUIP_LOGISTICO", SqlDbType.Int).Value = estado_logistico;
            cmd.Parameters.AddWithValue("@COSTO_UNITARIO_EQUIP_LOGISTICO", SqlDbType.Decimal).Value = precio_unitario_logistico;
            cmd.Parameters.AddWithValue("@STOCK_ACTUAL_EQUIP_LOGISTICO", SqlDbType.Int).Value = stock_actual_logistico;
            cmd.Parameters.AddWithValue("@STOCK_MINIMO_EQUIP_LOGISTICO", SqlDbType.Int).Value = stock_minimo_logistico;
            cmd.Parameters.AddWithValue("@DESCRP_EQUIP_LOGISTICO", SqlDbType.VarChar).Value = desp_logistico;
            cmd.Parameters.AddWithValue("@FECHA_ADQUISICION_EQUIP_LOGISTICO", SqlDbType.VarChar).Value = f_adquision_logistico;
            cmd.Parameters.AddWithValue("@FECHA_REGISTRO_EQUIP_LOGISTICO", SqlDbType.VarChar).Value = f_registro_logistico;
            cmd.Parameters.AddWithValue("@OBSERVACION_EQUIP_LOGISTICO", SqlDbType.VarChar).Value = observacion_logistico;
            cmd.Parameters.AddWithValue("@USUARIO", SqlDbType.VarChar).Value = nombre_usuario;
            cmd.ExecuteNonQuery();
        }
        public void RegistrarEpp(string cod_sistema, string cod_epp, string nombre_epp, string marca_epp,
                           string modelo_epp, int tipo_unidad_epp, int stock_inicial_epp, int estado_epp, decimal precio_unitario_epp,
                            int stock_actual_epp,
                         int stock_minimo_epp, string desp_epp, DateTime f_adquision_epp, DateTime f_registro_epp, string observacion_epp)
        {
            SqlCommand cmd = new SqlCommand("sp_registrar_producto_epp ", conexion.conexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_SISTEMA", SqlDbType.VarChar).Value = cod_sistema;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_EPP", SqlDbType.VarChar).Value = cod_epp;
            cmd.Parameters.AddWithValue("@NOMBRE_EQUIP_EPP", SqlDbType.VarChar).Value = nombre_epp;
            cmd.Parameters.AddWithValue("@MARCA_EQUIP_EPPP", SqlDbType.VarChar).Value = marca_epp;
            cmd.Parameters.AddWithValue("@MODELO_EQUIP_EPP", SqlDbType.VarChar).Value = modelo_epp;
            cmd.Parameters.AddWithValue("@idunidad_producto_EQUIP_EPP", SqlDbType.Int).Value = tipo_unidad_epp;
            cmd.Parameters.AddWithValue("@STOCK_INICIAL_EQUIP_EPP", SqlDbType.Int).Value = stock_inicial_epp;
            cmd.Parameters.AddWithValue("@ID_ESTADO_MATERIAL_EQUIP_EPP", SqlDbType.Int).Value = estado_epp;
            cmd.Parameters.AddWithValue("@COSTO_UNITARIO_EQUIP_EPP", SqlDbType.Decimal).Value = precio_unitario_epp;
            cmd.Parameters.AddWithValue("@STOCK_ACTUAL_EQUIP_EPP", SqlDbType.Int).Value = stock_actual_epp;
            cmd.Parameters.AddWithValue("@STOCK_MINIMO_EQUIP_EPP", SqlDbType.Int).Value = stock_minimo_epp;
            cmd.Parameters.AddWithValue("@DESCRP_EQUIP_EQUIP_EPP", SqlDbType.VarChar).Value = desp_epp;
            cmd.Parameters.AddWithValue("@FECHA_ADQUISICION_EQUIP_EPP", SqlDbType.VarChar).Value = f_adquision_epp;
            cmd.Parameters.AddWithValue("@FECHA_REGISTRO_EQUIP_EPP", SqlDbType.VarChar).Value = f_registro_epp;
            cmd.Parameters.AddWithValue("@OBSERVACION_EQUIP_EPP", SqlDbType.VarChar).Value = observacion_epp;
            cmd.Parameters.AddWithValue("@USUARIO", SqlDbType.VarChar).Value = nombre_usuario;
            cmd.ExecuteNonQuery();
        }
        public void RegistrarMobiliario(string cod_sistema, string cod_mobi, string nombre_mobi, string marca_mobi,
                            string modelo_mobi, int tipo_unidad_mobi, string categoria_mobi, int estado_mobi,
                            decimal precio_unitario_mobi,int stock_inicial_mobi,
                          int stock_actual_mobi, int stock_minimo_mobi, string desp_mobi, DateTime f_adquision_mobi, 
                          DateTime f_registro_mobi,string observacion_mobi)
        {
            SqlCommand cmd = new SqlCommand("sp_registrar_producto_mobiliario ", conexion.conexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_SISTEMA", SqlDbType.VarChar).Value = cod_sistema;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_MOBILIARIO", SqlDbType.VarChar).Value = cod_mobi;
            cmd.Parameters.AddWithValue("@NOMBRE_EQUIP_MOBILIARIO", SqlDbType.VarChar).Value = nombre_mobi;
            cmd.Parameters.AddWithValue("@MARCA_EQUIP_MOBILIARIO", SqlDbType.VarChar).Value = marca_mobi;
            cmd.Parameters.AddWithValue("@MODELO_EQUIP_MOBILIARIO", SqlDbType.VarChar).Value = modelo_mobi;
            cmd.Parameters.AddWithValue("@idunidad_producto_EQUIP_MOBILIARIO", SqlDbType.Int).Value = tipo_unidad_mobi;
            cmd.Parameters.AddWithValue("@CATEGORIA_MOBILIARIO", SqlDbType.VarChar).Value = categoria_mobi;
            cmd.Parameters.AddWithValue("@ID_ESTADO_MATERIAL_EQUIP_MOBILIARIO", SqlDbType.Int).Value = estado_mobi;
            cmd.Parameters.AddWithValue("@COSTO_UNITARIO_EQUIP_MOBILIARIO", SqlDbType.Decimal).Value = precio_unitario_mobi;
            cmd.Parameters.AddWithValue("@STOCK_INICIAL_EQUIP_MOBILIARIO", SqlDbType.Int).Value = stock_inicial_mobi;
            cmd.Parameters.AddWithValue("@STOCK_ACTUAL_EQUIP_MOBILIARIO", SqlDbType.Int).Value = stock_actual_mobi;
            cmd.Parameters.AddWithValue("@STOCK_MINIMO_EQUIP_MOBILIARIO", SqlDbType.Int).Value = stock_minimo_mobi;
            cmd.Parameters.AddWithValue("@DESCRP_EQUIP_EQUIP_MOBILIARIO", SqlDbType.VarChar).Value = desp_mobi;
            cmd.Parameters.AddWithValue("@FECHA_ADQUISICION_EQUIP_MOBILIARIO", SqlDbType.VarChar).Value = f_adquision_mobi;
            cmd.Parameters.AddWithValue("@FECHA_REGISTRO_EQUIP_MOBILIARIO", SqlDbType.VarChar).Value = f_registro_mobi;
            cmd.Parameters.AddWithValue("@OBSERVACION_EQUIP_MOBILIARIO", SqlDbType.VarChar).Value = observacion_mobi;
            cmd.Parameters.AddWithValue("@USUARIO", SqlDbType.VarChar).Value = nombre_usuario;
            cmd.ExecuteNonQuery();
        }
        public void RegistrarAseo(string cod_sistema, string cod_aseo, string nombre_aseo, string marca_aseo,
                             int tipo_unidad_aseo, DateTime f_fabricacion_aseo, DateTime f_vencimiento_aseo, int estado_aseo,
                            decimal precio_unitario_aseo, int stock_inicial_aseo,
                          int stock_actual_aseo, int stock_minimo_aseo, string desp_aseo, DateTime f_adquision_aseo,
                          DateTime f_registro_aseo, string observacion_aseo)

        {
            SqlCommand cmd = new SqlCommand("sp_registrar_producto_aseo ", conexion.conexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_SISTEMA", SqlDbType.VarChar).Value = cod_sistema;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_UTI_ASEO", SqlDbType.VarChar).Value = cod_aseo;
            cmd.Parameters.AddWithValue("@NOMBRE_UTI_ASEO", SqlDbType.VarChar).Value = nombre_aseo;
            cmd.Parameters.AddWithValue("@MARCA_UTI_ASEO", SqlDbType.VarChar).Value = marca_aseo;
            cmd.Parameters.AddWithValue("@idunidad_producto_UTI_ASEO", SqlDbType.Int).Value = tipo_unidad_aseo;
            cmd.Parameters.AddWithValue("@FECHA_FABRICACION_UTI_ASEO", SqlDbType.VarChar).Value = f_fabricacion_aseo;
            cmd.Parameters.AddWithValue("@FECHA_VENCIMIENTO_UTI_ASEO", SqlDbType.VarChar).Value = f_vencimiento_aseo;
            cmd.Parameters.AddWithValue("@ID_ESTADO_MATERIAL_UTIL_ASEO", SqlDbType.Int).Value = estado_aseo;
            cmd.Parameters.AddWithValue("@STOCK_INICIAL_UTI_ASEO", SqlDbType.Int).Value = stock_inicial_aseo;
            cmd.Parameters.AddWithValue("@COSTO_UNITARIO_UTI_ASEO", SqlDbType.Decimal).Value = precio_unitario_aseo;
            cmd.Parameters.AddWithValue("@STOCK_ACTUAL_UTI_ASEO", SqlDbType.Int).Value = stock_actual_aseo;
            cmd.Parameters.AddWithValue("@STOCK_MINIMO_UTI_ASEO", SqlDbType.Int).Value = stock_minimo_aseo;
            cmd.Parameters.AddWithValue("@DESCRP_UTI_ASEO", SqlDbType.VarChar).Value = desp_aseo;
            cmd.Parameters.AddWithValue("@FECHA_ADQUISICION_UTI_ASEO", SqlDbType.VarChar).Value = f_adquision_aseo;
            cmd.Parameters.AddWithValue("@FECHA_REGISTRO_UTI_ASEO", SqlDbType.VarChar).Value = f_registro_aseo;
            cmd.Parameters.AddWithValue("@OBSERVACION_UTI_ASEO", SqlDbType.VarChar).Value = observacion_aseo;
            cmd.Parameters.AddWithValue("@USUARIO", SqlDbType.VarChar).Value = nombre_usuario;
            cmd.ExecuteNonQuery();
        }

        public void RegistrarArmamento(string cod_sistema, string cod_armamento, string nombre_armamento, string marca_armamento,
                             string num_serie_armamento, string num_tarjeta_propiedad, DateTime f_inicio_armamento, DateTime f_vencimiento_armamento, int estado_armamento,
                             int stock_inicial_armamento,
                          int stock_actual_armamento, int stock_minimo_armamento, int tipo_unidad_armamento, string desp_armamento, DateTime f_adquision_armamento,
                          DateTime f_registro_armamento, string observacion_armamento)

        {
            SqlCommand cmd = new SqlCommand("sp_registrar_producto_armamento ", conexion.conexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_SISTEMA", SqlDbType.VarChar).Value = cod_sistema;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_ARMAMENTO", SqlDbType.VarChar).Value = cod_armamento;
            cmd.Parameters.AddWithValue("@NOMBRE_ARMAMENTO", SqlDbType.VarChar).Value = nombre_armamento;
            cmd.Parameters.AddWithValue("@MARCA_ARMAMENTO", SqlDbType.VarChar).Value = marca_armamento;
            cmd.Parameters.AddWithValue("@NUMB_SERIAL_ARMAMENTO", SqlDbType.Int).Value = num_serie_armamento;
            cmd.Parameters.AddWithValue("@NUMB_TARJETA_PROPIEDAD", SqlDbType.VarChar).Value = num_tarjeta_propiedad;
            cmd.Parameters.AddWithValue("@FECHA_INICIO_ARMAMENTO", SqlDbType.VarChar).Value = f_inicio_armamento;
            cmd.Parameters.AddWithValue("@FECHA_VENCIMIENTO_ARMAMENTO", SqlDbType.VarChar).Value = f_vencimiento_armamento;
            cmd.Parameters.AddWithValue("@ID_ESTADO_MATERIAL_ARMAMENTO", SqlDbType.Int).Value = estado_armamento;
            cmd.Parameters.AddWithValue("@STOCK_INICIAL_ARMAMENTO", SqlDbType.Int).Value = stock_inicial_armamento;
            cmd.Parameters.AddWithValue("@STOCK_ACTUAL_ARMAMENTO", SqlDbType.Int).Value = stock_actual_armamento;
            cmd.Parameters.AddWithValue("@STOCK_MINIMO_ARMAMENTO", SqlDbType.Int).Value = stock_minimo_armamento;
            cmd.Parameters.AddWithValue("@idunidad_producto_armamento", SqlDbType.Int).Value = tipo_unidad_armamento;
            cmd.Parameters.AddWithValue("@DESCRP_ARMAMENTO", SqlDbType.VarChar).Value = desp_armamento;
            cmd.Parameters.AddWithValue("@FECHA_ADQUISICION_ARMAMENTO", SqlDbType.VarChar).Value = f_adquision_armamento;
            cmd.Parameters.AddWithValue("@FECHA_REGISTRO_ARMAMENTO", SqlDbType.VarChar).Value = f_registro_armamento;
            cmd.Parameters.AddWithValue("@OBSERVACION_ARMAMENTO", SqlDbType.VarChar).Value = observacion_armamento;
            cmd.Parameters.AddWithValue("@USUARIO", SqlDbType.VarChar).Value = nombre_usuario;
            cmd.ExecuteNonQuery();
        }


        public void RegistrarVehiculo(string cod_sistema, string cod_vehi, string nombre_vehi, string marca_vehi,
                             string modelo_vehi, int tipo_unidad_vehi, int categoria_vehi, string color_vehi, int combustible_vehi,
                              string serial_vehi,
                           string anio_vehi, string placa_vehi, string tarejta_vehi, int estado_vehi, string desp_vehi,
                           DateTime f_adquision_vehi, DateTime f_registro_vehi, string observacion_vehi)
        {
            SqlCommand cmd = new SqlCommand("sp_registrar_producto_vehiculo ", conexion.conexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_SISTEMA", SqlDbType.VarChar).Value = cod_sistema;
            cmd.Parameters.AddWithValue("@COD_PRODUCTO_VEHICULO", SqlDbType.VarChar).Value = cod_vehi;
            cmd.Parameters.AddWithValue("@NOMBRE_EQUIP_VEHICULO", SqlDbType.VarChar).Value = nombre_vehi;
            cmd.Parameters.AddWithValue("@MARCA_EQUIP_VEHICULO", SqlDbType.VarChar).Value = marca_vehi;
            cmd.Parameters.AddWithValue("@MODELO_EQUIP_VEHICULO", SqlDbType.VarChar).Value = modelo_vehi;
            cmd.Parameters.AddWithValue("@idunidad_producto_VEHICULO", SqlDbType.Int).Value = tipo_unidad_vehi;
            cmd.Parameters.AddWithValue("@id_vehiculo_categoria", SqlDbType.Int).Value = categoria_vehi;
            cmd.Parameters.AddWithValue("@COLOR_VEHICULO", SqlDbType.VarChar).Value = color_vehi;
            cmd.Parameters.AddWithValue("@id_combustible", SqlDbType.Int).Value = combustible_vehi;
            cmd.Parameters.AddWithValue("@NUM_SERIAL_VEHICULO", SqlDbType.VarChar).Value = serial_vehi;
            cmd.Parameters.AddWithValue("@ANIO_FABRICACION_VEHICULO", SqlDbType.VarChar).Value = anio_vehi;
            cmd.Parameters.AddWithValue("@PLACA_VEHICULO", SqlDbType.VarChar).Value = placa_vehi;
            cmd.Parameters.AddWithValue("@NUM_TAJETA_PROPIEDAD_VEHICULO", SqlDbType.VarChar).Value = tarejta_vehi;
            cmd.Parameters.AddWithValue("@ID_ESTADO_MATERIAL_VEHICULO", SqlDbType.Int).Value = estado_vehi;
            cmd.Parameters.AddWithValue("@DESCRP_EQUIP_VEHICULO", SqlDbType.VarChar).Value = desp_vehi;
            cmd.Parameters.AddWithValue("@FECHA_ADQUISICION_VEHICULO", SqlDbType.VarChar).Value = f_adquision_vehi;
            cmd.Parameters.AddWithValue("@FECHA_REGISTRO_VEHICULO", SqlDbType.VarChar).Value = f_registro_vehi;
            cmd.Parameters.AddWithValue("@OBSERVACION_VEHICULO", SqlDbType.VarChar).Value = observacion_vehi;
            cmd.Parameters.AddWithValue("@USUARIO", SqlDbType.VarChar).Value = nombre_usuario;
            cmd.ExecuteNonQuery();
        }
    }
}
