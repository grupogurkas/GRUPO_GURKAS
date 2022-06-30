using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.IO;
using pl_Gurkas.Datos;

namespace pl_Gurkas.Vista.Logistica.producto
{
    public partial class frmNuevoProducto : Form
    {
        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();
        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.CRUD.Logistica.Insertar.LogisticaInsertar logisticaInsertar = new Datos.CRUD.Logistica.Insertar.LogisticaInsertar();
        Datos.CRUD.Logistica.Actualizar.LogisticaActualizar logisticaActualizar = new Datos.CRUD.Logistica.Actualizar.LogisticaActualizar();
        public frmNuevoProducto()
        {
            InitializeComponent();
        }
        public void BuscarProductoCamisas(string cod_uniforme_camisa)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM v_producto_camisa WHERE COD_PRODUCTO_UNI_CAMISAS = '" + cod_uniforme_camisa + "'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtCodSistema.Text = recorre["COD_PRODUCTO_SISTEMA"].ToString();
                    txtcodcamisas.Text = recorre["COD_PRODUCTO_UNI_CAMISAS"].ToString();
                    txtNombreCamisas.Text = recorre["NOMBRE_CAMISAS"].ToString();
                    cboTallaPrendaCamisas.SelectedIndex = Convert.ToInt32(recorre["ID_TALLA_PRENDA"].ToString());
                    txtColorCamisas.Text = recorre["COLOR"].ToString();
                    txtStockInicialCamisas.Text = recorre["STOCK_INICIAL"].ToString();
                    cboEstadoProduCamisas.SelectedIndex = Convert.ToInt32(recorre["ID_ESTADO_MATERIAL"].ToString());
                    txtCostoUniCamisas.Text = recorre["COSTO_UNITARIO_CAM"].ToString();
                    txtStockActualCamisas.Text = recorre["STOCK_ACTUAL"].ToString();
                    txtStockMinimoCamisas.Text = (recorre["STOCK_MINIMO"].ToString());
                    txtDescripcionCamisas.Text = (recorre["DESCRP_CAMISAS"].ToString());
                    dtpAdquisicionCamisas.Text = (recorre["FECHA_ADQUISICION"].ToString());
                    dtpRegistroCamisas.Text = (recorre["FECHA_REGISTRO"].ToString());
                    txtObservacionCamisas.Text = (recorre["OBSERVACION"].ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }
        public void BuscarProductoCalzado(string cod_uniforme_calzado)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM v_producto_calzado WHERE COD_PRODUCTO_UNI_CALZADO = '" + cod_uniforme_calzado + "'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtCodSistema.Text = recorre["COD_PRODUCTO_SISTEMA"].ToString();
                    txtCodCalzado.Text = recorre["COD_PRODUCTO_UNI_CALZADO"].ToString();
                    txtNombreCalzado.Text = recorre["NOMBRE_CALZADO"].ToString();
                    cboTallaCalzado.SelectedIndex = Convert.ToInt32(recorre["ID_TALLA_PRENDA_CALZADO"].ToString());
                    txtColorCalzado.Text = recorre["COLOR_CALZADO"].ToString();
                    cboTipoCalzado.SelectedIndex = Convert.ToInt32(recorre["IDTIPOCALZADO"].ToString());
                    txtStockInicialCalzado.Text = recorre["STOCK_INICIAL_CALZADO"].ToString();
                    cboEstadoCalzado.SelectedIndex = Convert.ToInt32(recorre["ID_ESTADO_MATERIAL"].ToString());
                    txtCostoUniCalzado.Text = recorre["COSTO_UNITARIO_CALZADO"].ToString();
                    txtStockActualCalzado.Text = (recorre["STOCK_ACTUAL_CALZADO"].ToString());
                    txtStockMinimoCalzado.Text = (recorre["STOCK_MINIMO_CALZADO"].ToString());
                    txtDespCalzado.Text = (recorre["DESCRP_CALZADO"].ToString());
                    dtpAdquiCalzado.Text = (recorre["FECHA_ADQUISICION_CALZADO"].ToString());
                    dtpRegistroCalzado.Text = (recorre["FECHA_REGISTRO_CALZADO"].ToString());
                    txtObservacionCalzado.Text = (recorre["OBSERVACION_CALZADO"].ToString());
                    cboNcuota.SelectedIndex = Convert.ToInt32(recorre["id_cuotas"].ToString());
                    txtDescuento.Text = (recorre["descuento_por_cuota"].ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }
        public void BuscarProductoPantalon(string cod_uniforme_pantalon)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM v_producto_pantalon WHERE COD_PRODUCTO_UNI_PANTALON = '" + cod_uniforme_pantalon + "'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtCodSistema.Text = recorre["COD_PRODUCTO_SISTEMA"].ToString();
                    txtCodPantalon.Text = recorre["COD_PRODUCTO_UNI_PANTALON"].ToString();
                    txtNombrePantalon.Text = recorre["NOMBRE_PANTALON"].ToString();
                    cboTallaPantalon.SelectedIndex = Convert.ToInt32(recorre["ID_TALLA_PRENDA_PANTALON"].ToString());
                    txtColorPantalon.Text = recorre["COLOR_PANTALON"].ToString();
                    txtStockIniPantalon.Text = recorre["STOCK_INICIAL_PANTALON"].ToString();
                    cboTipoTelaPantalon.SelectedIndex = Convert.ToInt32(recorre["idTipoPrenda"].ToString());
                    cboEstadoPantalon.SelectedIndex = Convert.ToInt32(recorre["ID_ESTADO_MATERIAL_PANTALON"].ToString());
                    txtCostoUniPantalon.Text = recorre["COSTO_UNITARIO_PANTALON"].ToString();
                    txtStockActuPantalon.Text = (recorre["STOCK_ACTUAL_PANTALON"].ToString());
                    txtStockMinPantalon.Text = (recorre["STOCK_MINIMO_PANTALON"].ToString());
                    txtDespPantalon.Text = (recorre["DESCRP_PANTALON"].ToString());
                    dtpAdPantalon.Text = (recorre["FECHA_ADQUISICION_PANTALON"].ToString());
                    dtpRegistroPantalon.Text = (recorre["FECHA_REGISTRO_PANTALON"].ToString());
                    txtObservacionPantalon.Text = (recorre["OBSERVACION_PANTALON"].ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }
        public void BuscarProductoAccesorio(string cod_uniforme_Accesorio)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM v_producto_accesorio WHERE COD_PRODUCTO_UNI_ACCESORIO = '" + cod_uniforme_Accesorio + "'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtCodSistema.Text = recorre["COD_PRODUCTO_SISTEMA"].ToString();
                    txtCodAccesorio.Text = recorre["COD_PRODUCTO_UNI_ACCESORIO"].ToString();
                    txtNombreAccesorio.Text = recorre["NOMBRE_ACCESORIO"].ToString();
                    cboTallaAccesorio.SelectedIndex = Convert.ToInt32(recorre["ID_TALLA_PRENDA_ACCESORIO"].ToString());
                    txtColorAccesorio.Text = recorre["COLOR_ACCESORIO"].ToString();
                    txtStockInicalAcessorio.Text = recorre["STOCK_INICIAL_ACCESORIO"].ToString();
                    cboTipoTelaAccesorio.SelectedIndex = Convert.ToInt32(recorre["idTipoPrenda"].ToString());
                    cboEstadoAccesorio.SelectedIndex = Convert.ToInt32(recorre["ID_ESTADO_MATERIAL_ACCESORIO"].ToString());
                    txtCostoUnitarioAccesorio.Text = recorre["COSTO_UNITARIO_ACCESORIO"].ToString();
                    txtStockActutalAccesorio.Text = (recorre["STOCK_ACTUAL_ACCESORIO"].ToString());
                    txtStockMinimoAccesorio.Text = (recorre["STOCK_MINIMO_ACCESORIO"].ToString());
                    txtDespAccesorio.Text = (recorre["DESCRP_ACCESORIO"].ToString());
                    dtpAdquAccesorio.Text = (recorre["FECHA_ADQUISICION_ACCESORIO"].ToString());
                    dtpRegistroAccesorio.Text = (recorre["FECHA_REGISTRO_ACCESORIO"].ToString());
                    txtObservacionAccesorio.Text = (recorre["OBSERVACION_ACCESORIO"].ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }
        public void BuscarProductoEscritorio(string cod_utiles_escritorio)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM v_producto_utiles WHERE COD_PRODUCTO_UTI_ESCRITORIO = '" + cod_utiles_escritorio + "'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtCodSistema.Text = recorre["COD_PRODUCTO_SISTEMA"].ToString();
                    txtCodigoUtiles.Text = recorre["COD_PRODUCTO_UTI_ESCRITORIO"].ToString();
                    txtNombreUtiles.Text = recorre["NOMBRE_UTI_ESCRITORIO"].ToString();
                    txtMarcaUtiles.Text = recorre["MARCA_UTI_ESCRITORIO"].ToString();
                    txtModeloUtiles.Text = recorre["MODELO_UTI_ESCRITORIO"].ToString();
                    cboTipoUnidadUtiles.SelectedIndex = Convert.ToInt32(recorre["idunidad_producto_UTI_ESCRITORIO"].ToString());
                    txtCantidadUtiles.Text = recorre["STOCK_INICIAL_UTI_ESCRITORIO"].ToString();
                    cboEstadoUtilez.SelectedIndex = Convert.ToInt32(recorre["ID_ESTADO_MATERIAL_UTI_ESCRITORIO"].ToString());
                    txtPrecioUnitarioUtiles.Text = (recorre["COSTO_UNITARIO_UTI_ESCRITORIO"].ToString());
                    txtStockIniUtiles.Text = (recorre["STOCK_ACTUAL_UTI_ESCRITORIO"].ToString());
                    txtStockMinUtiles.Text = (recorre["STOCK_MINIMO_UTI_ESCRITORIO"].ToString());
                    txtDescripcionUti.Text = (recorre["DESCRP_UTI_ESCRITORIO"].ToString());
                    dtpFechaAdUtiles.Text = (recorre["FECHA_ADQUISICION_UTI_ESCRITORIO"].ToString());
                    dtpFechaRegisUtiles.Text = (recorre["FECHA_REGISTRO_UTI_ESCRITORIO"].ToString());
                    txtObservacionUti.Text = (recorre["OBSERVACION_UTI_ESCRITORIO"].ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }
        public void BuscarProductoEquipoLogistico(string cod_equi_logistico)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM v_producto_equipo_logistico WHERE COD_PRODUCTO_EQUIP_LOGISTICO = '" + cod_equi_logistico + "'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtCodSistema.Text = recorre["COD_PRODUCTO_SISTEMA"].ToString();
                    txtCodEquipoEquip.Text = recorre["COD_PRODUCTO_EQUIP_LOGISTICO"].ToString();
                    txtNombreEquip.Text = recorre["NOMBRE_EQUIP_LOGISTICO"].ToString();
                    txtMarcaEquip.Text = recorre["MARCA_EQUIP_LOGISTICO"].ToString();
                    txtModeloEquip.Text = recorre["MODELO_EQUIP_LOGISTICO"].ToString();
                    cboTipoUnidadEquipo.SelectedIndex = Convert.ToInt32(recorre["idunidad_producto_EQUIP_LOGISTICO"].ToString());
                    txtCantidadEquip.Text = recorre["STOCK_INICIAL_EQUIP_LOGISTICO"].ToString();
                    cboEstadoEquipo.SelectedIndex = Convert.ToInt32(recorre["ID_ESTADO_MATERIAL_EQUIP_LOGISTICO"].ToString());
                    txtPrecioUniEquip.Text = (recorre["COSTO_UNITARIO_EQUIP_LOGISTICO"].ToString());
                    txtStockIniEquip.Text = (recorre["STOCK_ACTUAL_EQUIP_LOGISTICO"].ToString());
                    txtStockMinEquip.Text = (recorre["STOCK_MINIMO_EQUIP_LOGISTICO"].ToString());
                    txtDescripcionEquip.Text = (recorre["DESCRP_EQUIP_LOGISTICO"].ToString());
                    dtpFechaAdEquip.Text = (recorre["FECHA_ADQUISICION_EQUIP_LOGISTICO"].ToString());
                    dtpFechaRegisEquip.Text = (recorre["FECHA_REGISTRO_EQUIP_LOGISTICO"].ToString());
                    txtObservacionEquip.Text = (recorre["OBSERVACION_EQUIP_LOGISTICO"].ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }
        public void BuscarProductoEpp(string cod_equi_epp)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM v_producto_epp WHERE COD_PRODUCTO_EPP = '" + cod_equi_epp + "'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtCodSistema.Text = recorre["COD_PRODUCTO_SISTEMA"].ToString();
                    txtCodEquipProtec.Text = recorre["COD_PRODUCTO_EPP"].ToString();
                    txtNombreProtec.Text = recorre["NOMBRE_EQUIP_EPP"].ToString();
                    txtMarcaProtec.Text = recorre["MARCA_EQUIP_EPPP"].ToString();
                    txtModeloProtec.Text = recorre["MODELO_EQUIP_EPP"].ToString();
                    cboTipoEquipoPro.SelectedIndex = Convert.ToInt32(recorre["idunidad_producto_EQUIP_EPP"].ToString());
                    txtCantidadProtec.Text = recorre["STOCK_INICIAL_EQUIP_EPP"].ToString();
                    cboEstadoEquipoPro.SelectedIndex = Convert.ToInt32(recorre["ID_ESTADO_MATERIAL_EQUIP_EPP"].ToString());
                    txtPrecioUniProtec.Text = (recorre["COSTO_UNITARIO_EQUIP_EPP"].ToString());
                    txtStockIniProtec.Text = (recorre["STOCK_ACTUAL_EQUIP_EPP"].ToString());
                    txtStockMinProtec.Text = (recorre["STOCK_MINIMO_EQUIP_EPP"].ToString());
                    txtDescripcionProtec.Text = (recorre["DESCRP_EQUIP_EQUIP_EPP"].ToString());
                    dtpFechaAdProtec.Text = (recorre["FECHA_ADQUISICION_EQUIP_EPP"].ToString());
                    dtpFechaRegisProtec.Text = (recorre["FECHA_REGISTRO_EQUIP_EPP"].ToString());
                    txtObservacionProtec.Text = (recorre["OBSERVACION_EQUIP_EPP"].ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n  " + err, "ERROR");
            }
        }
        public void BuscarProductoMobiliario(string cod_mobiliario)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM v_producto_mobiliario WHERE COD_PRODUCTO_MOBILIARIO = '" + cod_mobiliario + "'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtCodSistema.Text = recorre["COD_PRODUCTO_SISTEMA"].ToString();
                    txtCodEquipMobi.Text = recorre["COD_PRODUCTO_MOBILIARIO"].ToString();
                    txtNombreMobi.Text = recorre["NOMBRE_EQUIP_MOBILIARIO"].ToString();
                    txtMarcaMobi.Text = recorre["MARCA_EQUIP_MOBILIARIO"].ToString();
                    txtModeloMobi.Text = recorre["MODELO_EQUIP_MOBILIARIO"].ToString();
                    cboTipoUnidadMobi.SelectedIndex = Convert.ToInt32(recorre["idunidad_producto_EQUIP_MOBILIARIO"].ToString());
                    txtCantidadMobi.Text = recorre["CATEGORIA_MOBILIARIO"].ToString();
                    cboEstadoMobi.SelectedIndex = Convert.ToInt32(recorre["ID_ESTADO_MATERIAL_EQUIP_MOBILIARIO"].ToString());
                    txtPrecioUniMobi.Text = (recorre["COSTO_UNITARIO_EQUIP_MOBILIARIO"].ToString());
                    txtStockIniMobil.Text = (recorre["STOCK_INICIAL_EQUIP_MOBILIARIO"].ToString());
                    txtStockactualMobi.Text = (recorre["STOCK_ACTUAL_EQUIP_MOBILIARIO"].ToString());
                    txtStockMinMobi.Text = (recorre["STOCK_MINIMO_EQUIP_MOBILIARIO"].ToString());
                    txtDescripcionMobi.Text = (recorre["DESCRP_EQUIP_EQUIP_MOBILIARIO"].ToString());
                    dtpFechaAdMobi.Text = (recorre["FECHA_ADQUISICION_EQUIP_MOBILIARIO"].ToString());
                    dtpFechaRegisMobi.Text = (recorre["FECHA_REGISTRO_EQUIP_MOBILIARIO"].ToString());
                    txtObservacionMobi.Text = (recorre["OBSERVACION_EQUIP_MOBILIARIO"].ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }
        public void BuscarProductoVehiculo(string cod_vehiculo)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM v_producto_vehiculo WHERE COD_PRODUCTO_VEHICULO = '" + cod_vehiculo + "'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtCodSistema.Text = recorre["COD_PRODUCTO_SISTEMA"].ToString();
                    txtCodVehiculo.Text = recorre["COD_PRODUCTO_VEHICULO"].ToString();
                    txtNombreVehiculo.Text = recorre["NOMBRE_EQUIP_VEHICULO"].ToString();
                    txtMarcaVehiculo.Text = recorre["MARCA_EQUIP_VEHICULO"].ToString();
                    txtModeloVehiculo.Text = recorre["MODELO_EQUIP_VEHICULO"].ToString();
                    cboTipoUnidadVehiculo.SelectedIndex = Convert.ToInt32(recorre["idunidad_producto_VEHICULO"].ToString());
                    cboCategoriaVehiculo.SelectedIndex = Convert.ToInt32(recorre["id_vehiculo_categoria"].ToString());
                    txtcolorVehiculo.Text = recorre["COLOR_VEHICULO"].ToString();
                    cboCombustibleVehiculo.SelectedIndex = Convert.ToInt32(recorre["id_combustible"].ToString());
                    txtserialVehiculo.Text = (recorre["NUM_SERIAL_VEHICULO"].ToString());
                    txtaniovehiculo.Text = (recorre["ANIO_FABRICACION_VEHICULO"].ToString());
                    txtPlacaVehiculo.Text = (recorre["PLACA_VEHICULO"].ToString());
                    txtNTarjetaVehiculo.Text = (recorre["NUM_TAJETA_PROPIEDAD_VEHICULO"].ToString());
                    cboEstadoVehiculo.SelectedIndex = Convert.ToInt32(recorre["ID_ESTADO_MATERIAL_VEHICULO"].ToString());
                    txtDescripcionVehiculo.Text = (recorre["DESCRP_EQUIP_VEHICULO"].ToString());
                    dtpFechaAdVehiculo.Text = (recorre["FECHA_ADQUISICION_VEHICULO"].ToString());
                    dtpFechaRegisVehi.Text = (recorre["FECHA_REGISTRO_VEHICULO"].ToString());
                    txtObservacionVehi.Text = (recorre["OBSERVACION_VEHICULO"].ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }

        public void BuscarProductoAseo(string cod_aseo)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM v_producto_aseo WHERE COD_PRODUCTO_UTI_ASEO = '" + cod_aseo + "'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtCodSistema.Text = recorre["COD_PRODUCTO_SISTEMA"].ToString();
                    txtCodEquipAseo.Text = recorre["COD_PRODUCTO_UTI_ASEO"].ToString();
                    txtNombreUtilesAseo.Text = recorre["NOMBRE_UTI_ASEO"].ToString();
                    txtMarcaUtilesAseo.Text = recorre["MARCA_UTI_ASEO"].ToString();
                    cboTipoUnidadAseo.SelectedIndex = Convert.ToInt32(recorre["idunidad_producto_UTI_ASEO"].ToString());
                    dtpFechaFabAseo.Text = (recorre["FECHA_FABRICACION_UTI_ASEO"].ToString());
                    dtpFechaVecAseo.Text = (recorre["FECHA_VENCIMIENTO_UTI_ASEO"].ToString());
                    cboEstadoAseo.SelectedIndex = Convert.ToInt32(recorre["ID_ESTADO_MATERIAL_UTIL_ASEO"].ToString());
                    txtStockIniAseo.Text = (recorre["STOCK_INICIAL_UTI_ASEO"].ToString());
                    txtCostoUtilesAseo.Text = (recorre["COSTO_UNITARIO_UTI_ASEO"].ToString());
                    txtStockActualAseo.Text = (recorre["STOCK_ACTUAL_UTI_ASEO"].ToString());
                    txtStockMinAseo.Text = (recorre["STOCK_MINIMO_UTI_ASEO"].ToString());
                    txtDescripcionAseo.Text = (recorre["DESCRP_UTI_ASEO"].ToString());
                    dtpFechaAdAseo.Text = (recorre["FECHA_ADQUISICION_UTI_ASEO"].ToString());
                    dtpFechaRegisAseo.Text = (recorre["FECHA_REGISTRO_UTI_ASEO"].ToString());
                    txtObservacionAseo.Text = (recorre["OBSERVACION_UTI_ASEO"].ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }

        public void BuscarProductoArmamento(string cod_armamento)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM v_producto_armamento WHERE COD_PRODUCTO_ARMAMENTO = '" + cod_armamento + "'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtCodSistema.Text = recorre["COD_PRODUCTO_SISTEMA"].ToString();
                    txtCodEquipArmamento.Text = recorre["COD_PRODUCTO_ARMAMENTO"].ToString();
                    txtNombreArmamento.Text = recorre["NOMBRE_ARMAMENTO"].ToString();
                    txtMarcaArmamento.Text = recorre["MARCA_ARMAMENTO"].ToString();
                    txtNumbSerialArmamento.Text = recorre["NUMB_SERIAL_ARMAMENTO"].ToString();
                    txtNumbTarjetaArmamento.Text = recorre["NUMB_TARJETA_PROPIEDAD"].ToString();
                    dtpFechaIniArmamento.Text = (recorre["FECHA_INICIO_ARMAMENTO"].ToString());
                    dtpFechaVecArmamento.Text = (recorre["FECHA_VENCIMIENTO_ARMAMENTO"].ToString());
                    cboEstadoArmamento.SelectedIndex = Convert.ToInt32(recorre["ID_ESTADO_MATERIAL_ARMAMENTO"].ToString());
                    txtStockIniArmamento.Text = (recorre["STOCK_INICIAL_ARMAMENTO"].ToString());
                    txtStockActualArmamento.Text = (recorre["STOCK_ACTUAL_ARMAMENTO"].ToString());
                    txtStockMinArmamento.Text = (recorre["STOCK_MINIMO_ARMAMENTO"].ToString());
                    cboTipoUnidadArmamento.SelectedIndex = Convert.ToInt32(recorre["idunidad_producto_armamento"].ToString());
                    txtDespArmamento.Text = (recorre["DESCRP_ARMAMENTO"].ToString());
                    dtpFechaAdArmamento.Text = (recorre["FECHA_ADQUISICION_ARMAMENTO"].ToString());
                    dtpFechaRegisArmamento.Text = (recorre["FECHA_REGISTRO_ARMAMENTO"].ToString());
                    txtObsArmamento.Text = (recorre["OBSERVACION_ARMAMENTO"].ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }


        public void actualizarDatosCamisas()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_camisa = txtcodcamisas.Text.ToUpper();
                string nombre_camisa = txtNombreCamisas.Text.ToUpper();
                int talla_c = cboTallaPrendaCamisas.SelectedIndex;
                string color_c = txtColorCamisas.Text.ToUpper();
                int stock_inicial_c = Convert.ToInt32(txtStockInicialCamisas.Text);
                int estado_c = cboEstadoProduCamisas.SelectedIndex;
                decimal precio_unitario_c = Convert.ToDecimal(txtCostoUniCamisas.Text);
                int stock_actual_c = Convert.ToInt32(txtStockActualCamisas.Text);
                int stock_minimo_c = Convert.ToInt32(txtStockMinimoCamisas.Text);
                string desp_c = txtDescripcionCamisas.Text.ToUpper();
                DateTime f_adquision_c = dtpAdquisicionCamisas.Value;
                DateTime f_registro_c = dtpRegistroCamisas.Value;
                string observacion_c = txtObservacionCamisas.Text.ToUpper();

                logisticaActualizar.ActualizarPrendaCamisas(cod_sistema, cod_camisa, nombre_camisa, talla_c, color_c,
                   stock_inicial_c, estado_c, precio_unitario_c, stock_actual_c, stock_minimo_c, desp_c, f_adquision_c,
                   f_registro_c, observacion_c);
                MessageBox.Show("Datos Actualizado correptamente", "Correpto");
                LimpiarDatosCamisas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Actualizado el producto", "Error");
            }
        }
        public void AgregarProductoCamisas()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_camisa = txtcodcamisas.Text.ToUpper();
                string Condicion = cboEstadoProduCamisas.GetItemText(cboEstadoProduCamisas.SelectedItem).ToUpper();
                string ta = cboTallaPrendaCamisas.GetItemText(cboTallaPrendaCamisas.SelectedItem).ToUpper();
                string nombre = txtNombreCamisas.Text.ToUpper();
                int talla_c = cboTallaPrendaCamisas.SelectedIndex;
                string color_c = txtColorCamisas.Text.ToUpper();
                int stock_inicial_c = Convert.ToInt32(txtStockInicialCamisas.Text);
                int estado_c = cboEstadoProduCamisas.SelectedIndex;
                decimal precio_unitario_c = Convert.ToDecimal(txtCostoUniCamisas.Text);
                int stock_actual_c = Convert.ToInt32(txtStockActualCamisas.Text);
                int stock_minimo_c = Convert.ToInt32(txtStockMinimoCamisas.Text);
                string desp_c = txtDescripcionCamisas.Text.ToUpper();
                DateTime f_adquision_c = dtpAdquisicionCamisas.Value;
                DateTime f_registro_c = dtpRegistroCamisas.Value;
                string observacion_c = txtObservacionCamisas.Text.ToUpper();
                string nombre_camisa = (nombre + "-"+ color_c+"-"+ ta + "-"+ Condicion ).ToUpper();

                logisticaInsertar.RegistrarPrendaCamisas(cod_sistema, cod_camisa, nombre_camisa, talla_c, color_c,
                   stock_inicial_c, estado_c, precio_unitario_c, stock_actual_c, stock_minimo_c, desp_c, f_adquision_c,
                   f_registro_c, observacion_c);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
                LimpiarDatosCamisas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto", "Error");
            }
        }
        public void ActulizarPantalon()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_pantalon = txtCodPantalon.Text.ToUpper();
                string nombre_pantalon = txtNombrePantalon.Text.ToUpper();
                int talla_pan = cboTallaPantalon.SelectedIndex;
                string color_pan = txtColorPantalon.Text.ToUpper();
                int stock_inicial_pan = Convert.ToInt32(txtStockIniPantalon.Text);
                int tipo_tela_pan = cboTipoTelaPantalon.SelectedIndex;
                int estado_pan = cboEstadoPantalon.SelectedIndex;
                decimal precio_unitario_pan = Convert.ToDecimal(txtCostoUniPantalon.Text);
                int stock_actual_pan = Convert.ToInt32(txtStockActuPantalon.Text);
                int stock_minimo_pan = Convert.ToInt32(txtStockMinPantalon.Text);
                string desp_pan = txtDespPantalon.Text.ToUpper();
                DateTime f_adquision_pan = dtpAdPantalon.Value;
                DateTime f_registro_pan = dtpRegistroPantalon.Value;
                string observacion_pan = txtObservacionPantalon.Text.ToUpper();

                logisticaActualizar.ActualizarPrendaPantalon(cod_sistema, cod_pantalon, nombre_pantalon, talla_pan,
                      color_pan, stock_inicial_pan, tipo_tela_pan, estado_pan, precio_unitario_pan, stock_actual_pan,
                      stock_minimo_pan, desp_pan, f_adquision_pan, f_registro_pan, observacion_pan);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
                LimpiarDatosPantalon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }
        public void AgregarActualizarCalzado()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_calzado = txtCodCalzado.Text.ToUpper();
                string nombre_calzado = txtNombreCalzado.Text.ToUpper();
                int talla_cal = cboTallaCalzado.SelectedIndex;
                string color_cal = txtColorCalzado.Text.ToUpper();
                int tipo_calzado = cboTipoCalzado.SelectedIndex;
                int stock_inicial_cal = Convert.ToInt32(txtStockInicialCalzado.Text);
                int estado_cal = cboEstadoCalzado.SelectedIndex;
                decimal precio_unitario_cal = Convert.ToDecimal(txtCostoUniCalzado.Text);
                int stock_actual_cal = Convert.ToInt32(txtStockActualCalzado.Text);
                int stock_minimo_cal = Convert.ToInt32(txtStockMinimoCalzado.Text);
                string desp_cal = txtDespCalzado.Text.ToUpper();
                DateTime f_adquision_cal = dtpAdquiCalzado.Value;
                DateTime f_registro_cal = dtpRegistroCalzado.Value;
                string observacion_cal = txtObservacionCalzado.Text.ToUpper();
                int cantidad_cuotas = cboNcuota.SelectedIndex;
                decimal descuento_cuota = Convert.ToDecimal(txtDescuento.Text);

                logisticaActualizar.ActualizarPrendaCalzado(cod_sistema, cod_calzado, nombre_calzado, talla_cal, color_cal,
                     tipo_calzado, stock_inicial_cal, estado_cal, precio_unitario_cal, stock_actual_cal, stock_minimo_cal, desp_cal,
                     f_adquision_cal, f_registro_cal, observacion_cal, cantidad_cuotas, descuento_cuota);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
                LimpiarDatosCalzado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto", "Error");
            }
        }
        public void AgregarActualizarAccesorio()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_accesorio = txtCodAccesorio.Text.ToUpper();
                string nombre_accesorio = txtNombreAccesorio.Text.ToUpper();
                int talla_acc = cboTallaAccesorio.SelectedIndex;
                string color_acc = txtColorAccesorio.Text.ToUpper();
                int stock_inicial_acc = Convert.ToInt32(txtStockInicalAcessorio.Text);
                int tipo_tela_acc = cboTipoTelaAccesorio.SelectedIndex;
                int estado_acc = cboEstadoAccesorio.SelectedIndex;
                decimal precio_unitario_acc = Convert.ToDecimal(txtCostoUnitarioAccesorio.Text);
                int stock_actual_acc = Convert.ToInt32(txtStockActutalAccesorio.Text);
                int stock_minimo_acc = Convert.ToInt32(txtStockMinimoAccesorio.Text);
                string desp_acc = txtDespAccesorio.Text.ToUpper();
                DateTime f_adquision_acc = dtpAdquAccesorio.Value;
                DateTime f_registro_acc = dtpRegistroAccesorio.Value;
                string observacion_acc = txtObservacionAccesorio.Text.ToUpper();

                logisticaActualizar.ActualizarPrendaAccesorio(cod_sistema, cod_accesorio, nombre_accesorio, talla_acc,
                        color_acc, stock_inicial_acc, tipo_tela_acc, estado_acc, precio_unitario_acc, stock_actual_acc,
                       stock_minimo_acc, desp_acc, f_adquision_acc, f_registro_acc, observacion_acc);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
                LimpiarDatosAccesorios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }
        public void AgregarActualizarUtiles()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_utiles = txtCodigoUtiles.Text.ToUpper();
                string nombre_utiles = txtNombreUtiles.Text.ToUpper();
                string marca_utiles = txtMarcaUtiles.Text.ToUpper();
                string modelo_utiles = txtModeloUtiles.Text.ToUpper();
                int tipo_unidad_utiles = cboTipoUnidadUtiles.SelectedIndex;
                int stock_inicial_utiles = Convert.ToInt32(txtCantidadUtiles.Text);
                int estado_utiles = cboEstadoUtilez.SelectedIndex;
                decimal precio_unitario_utiles = Convert.ToDecimal(txtPrecioUnitarioUtiles.Text);
                int stock_actual_utiles = Convert.ToInt32(txtStockIniUtiles.Text);
                int stock_minimo_utiles = Convert.ToInt32(txtStockMinUtiles.Text);
                string desp_utiles = txtDescripcionUti.Text.ToUpper();
                DateTime f_adquision_utiles = dtpFechaAdUtiles.Value;
                DateTime f_registro_utiles = dtpFechaRegisUtiles.Value;
                string observacion_utiles = txtObservacionUti.Text.ToUpper();

                logisticaActualizar.ActualizarUtiles(cod_sistema, cod_utiles, nombre_utiles, marca_utiles,
                          modelo_utiles, tipo_unidad_utiles, stock_inicial_utiles, estado_utiles, precio_unitario_utiles,
                           stock_actual_utiles,
                        stock_minimo_utiles, desp_utiles, f_adquision_utiles, f_registro_utiles, observacion_utiles);
                MessageBox.Show("Datos Actualizado correptamente", "Correpto");
                LimpiarDatosUtilezEscritorio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede actualizar el producto" + ex, "Error");
            }
        }
        public void ActualizarEquipamientoLogistico()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_logistico = txtCodEquipoEquip.Text.ToUpper();
                string nombre_logistico = txtNombreEquip.Text.ToUpper();
                string marca_logistico = txtMarcaEquip.Text.ToUpper();
                string modelo_logistico = txtModeloEquip.Text.ToUpper();
                int tipo_unidad_logistico = cboTipoUnidadEquipo.SelectedIndex;
                int stock_inicial_logistico = Convert.ToInt32(txtCantidadEquip.Text);
                int estado_logistico = cboEstadoEquipo.SelectedIndex;
                decimal precio_unitario_logistico = Convert.ToDecimal(txtPrecioUniEquip.Text);
                int stock_actual_logistico = Convert.ToInt32(txtStockIniEquip.Text);
                int stock_minimo_logistico = Convert.ToInt32(txtStockMinEquip.Text);
                string desp_logistico = txtDescripcionEquip.Text.ToUpper();
                DateTime f_adquision_logistico = dtpFechaAdEquip.Value;
                DateTime f_registro_logistico = dtpFechaRegisEquip.Value;
                string observacion_logistico = txtObservacionEquip.Text.ToUpper();

                logisticaActualizar.ActualizarEquipoLogistico(cod_sistema, cod_logistico, nombre_logistico, marca_logistico,
                           modelo_logistico, tipo_unidad_logistico, stock_inicial_logistico, estado_logistico, precio_unitario_logistico,
                            stock_actual_logistico,
                         stock_minimo_logistico, desp_logistico, f_adquision_logistico, f_registro_logistico, observacion_logistico);
                MessageBox.Show("Datos actualizado correptamente", "Correpto");
                LimpiarDatosEquipamientoLogistico();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }
        public void ActualizarEPP()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_epp = txtCodEquipProtec.Text.ToUpper();
                string nombre_epp = txtNombreProtec.Text.ToUpper();
                string marca_epp = txtMarcaProtec.Text.ToUpper();
                string modelo_epp = txtModeloProtec.Text.ToUpper();
                int tipo_unidad_epp = cboTipoEquipoPro.SelectedIndex;
                int stock_inicial_epp = Convert.ToInt32(txtCantidadProtec.Text);
                int estado_epp = cboEstadoEquipoPro.SelectedIndex;
                decimal precio_unitario_epp = Convert.ToDecimal(txtPrecioUniProtec.Text);
                int stock_actual_epp = Convert.ToInt32(txtStockIniProtec.Text);
                int stock_minimo_epp = Convert.ToInt32(txtStockMinProtec.Text);
                string desp_epp = txtDescripcionProtec.Text.ToUpper();
                DateTime f_adquision_epp = dtpFechaAdProtec.Value;
                DateTime f_registro_epp = dtpFechaRegisProtec.Value;
                string observacion_epp = txtObservacionProtec.Text.ToUpper();

                logisticaActualizar.ActualizarEpp(cod_sistema, cod_epp, nombre_epp, marca_epp,
                            modelo_epp, tipo_unidad_epp, stock_inicial_epp, estado_epp, precio_unitario_epp,
                             stock_actual_epp,
                          stock_minimo_epp, desp_epp, f_adquision_epp, f_registro_epp, observacion_epp);
                MessageBox.Show("Datos Actualizado correptamente", "Correpto");
                LimpiarDatosEpp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }
        public void ActualizarMobiliario()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_mobi = txtCodEquipMobi.Text.ToUpper();
                string nombre_mobi = txtNombreMobi.Text.ToUpper();
                string marca_mobi = txtMarcaMobi.Text.ToUpper();
                string modelo_mobi = txtModeloMobi.Text.ToUpper();
                int tipo_unidad_mobi = cboTipoUnidadMobi.SelectedIndex;
                string categoria_mobi = txtCantidadMobi.Text.ToUpper();
                int estado_mobi = cboEstadoMobi.SelectedIndex;
                decimal precio_unitario_mobi = Convert.ToDecimal(txtPrecioUniMobi.Text);
                int stock_inicial_mobi = Convert.ToInt32(txtStockIniMobil.Text);
                int stock_actual_mobi = Convert.ToInt32(txtStockactualMobi.Text);
                int stock_minimo_mobi = Convert.ToInt32(txtStockMinMobi.Text);
                string desp_mobi = txtDescripcionMobi.Text.ToUpper();
                DateTime f_adquision_mobi = dtpFechaAdMobi.Value;
                DateTime f_registro_mobi = dtpFechaRegisMobi.Value;
                string observacion_mobi = txtObservacionMobi.Text.ToUpper();

                logisticaActualizar.ActualizarMobiliario(cod_sistema, cod_mobi, nombre_mobi, marca_mobi,
                             modelo_mobi, tipo_unidad_mobi, categoria_mobi, estado_mobi, precio_unitario_mobi,
                              stock_inicial_mobi,
                           stock_actual_mobi, stock_minimo_mobi, desp_mobi, f_adquision_mobi, f_registro_mobi,
                           observacion_mobi);
                MessageBox.Show("Datos Actualizado correptamente", "Correpto");
                LimpiarDatosMobiliario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }
        public void ActualizarVehiculo()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_vehi = txtCodVehiculo.Text.ToUpper();
                string nombre_vehi = txtNombreVehiculo.Text.ToUpper();
                string marca_vehi = txtMarcaVehiculo.Text.ToUpper();
                string modelo_vehi = txtModeloVehiculo.Text.ToUpper();
                int tipo_unidad_vehi = cboTipoUnidadVehiculo.SelectedIndex;
                int categoria_vehi = cboCategoriaVehiculo.SelectedIndex;
                string color_vehi = txtcolorVehiculo.Text.ToUpper();
                int combustible_vehi = cboCombustibleVehiculo.SelectedIndex;
                string serial_vehi = txtserialVehiculo.Text.ToUpper();
                string anio_vehi = txtaniovehiculo.Text.ToUpper();
                string placa_vehi = txtPlacaVehiculo.Text.ToUpper();
                string tarejta_vehi = txtNTarjetaVehiculo.Text.ToUpper();
                int estado_vehi = cboEstadoVehiculo.SelectedIndex;
                string desp_vehi = txtDescripcionVehiculo.Text.ToUpper();
                DateTime f_adquision_vehi = dtpFechaAdVehiculo.Value;
                DateTime f_registro_vehi = dtpFechaRegisVehi.Value;
                string observacion_vehi = txtObservacionVehi.Text.ToUpper();

                logisticaActualizar.ActualizarVehiculo(cod_sistema, cod_vehi, nombre_vehi, marca_vehi,
                              modelo_vehi, tipo_unidad_vehi, categoria_vehi, color_vehi, combustible_vehi,
                               serial_vehi,
                            anio_vehi, placa_vehi, tarejta_vehi, estado_vehi, desp_vehi,
                            f_adquision_vehi, f_registro_vehi, observacion_vehi);
                MessageBox.Show("Datos Actualizado correptamente", "Correpto");
                LimpiarDatosVehiculo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }

        public void ActualizarUtilesAseo()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_aseo = txtCodEquipAseo.Text.ToUpper();
                string nombre_aseo = txtNombreUtilesAseo.Text.ToUpper();
                string marca_aseo = txtMarcaUtilesAseo.Text.ToUpper();
                int tipo_unidad_aseo = Convert.ToInt32(cboTipoUnidadAseo.SelectedIndex);
                DateTime f_fabricacion_aseo = dtpFechaFabAseo.Value;
                DateTime f_vencimiento_aseo = dtpFechaVecAseo.Value;
                int estado_aseo = cboEstadoAseo.SelectedIndex;
                decimal precio_unitario_aseo = Convert.ToDecimal(txtCostoUtilesAseo.Text);
                int stock_inicial_aseo = Convert.ToInt32(txtStockIniAseo.Text);
                int stock_actual_aseo = Convert.ToInt32(txtStockActualAseo.Text);
                int stock_minimo_aseo = Convert.ToInt32(txtStockMinAseo.Text);
                string desp_aseo = txtDescripcionAseo.Text.ToUpper();
                DateTime f_adquision_aseo = dtpFechaAdAseo.Value;
                DateTime f_registro_aseo = dtpFechaRegisAseo.Value;
                string observacion_aseo = txtObservacionAseo.Text.ToUpper();

                logisticaActualizar.ActualizarUtilesAseo(cod_sistema, cod_aseo, nombre_aseo, marca_aseo,
                             tipo_unidad_aseo, f_fabricacion_aseo, f_vencimiento_aseo, estado_aseo, precio_unitario_aseo,
                              stock_inicial_aseo,
                           stock_actual_aseo, stock_minimo_aseo, desp_aseo, f_adquision_aseo, f_registro_aseo,
                           observacion_aseo);
                MessageBox.Show("Datos registrado correctamente", "Correcto");
                LimpiarDatosAseo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }
      

        public void ActualizarArmamento()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_armamento = txtCodEquipArmamento.Text.ToUpper();
                string nombre_armamento = txtNombreArmamento.Text.ToUpper();
                string marca_armamento = txtMarcaArmamento.Text.ToUpper();
                string num_serie_armamento = txtNumbSerialArmamento.Text.ToUpper();
                string num_tarjeta_propiedad = txtNumbTarjetaArmamento.Text.ToUpper();
                DateTime f_inicio_armamento = dtpFechaIniArmamento.Value;
                DateTime f_vencimiento_armamento = dtpFechaVecArmamento.Value;
                int estado_armamento = cboEstadoArmamento.SelectedIndex;
                int stock_inicial_armamento = Convert.ToInt32(txtStockIniArmamento.Text);
                int stock_actual_armamento = Convert.ToInt32(txtStockActualArmamento.Text);
                int stock_minimo_armamento = Convert.ToInt32(txtStockMinArmamento.Text);
                int tipo_unidad_armamento = Convert.ToInt32(cboTipoUnidadArmamento.SelectedIndex);
                string desp_armamento = txtDespArmamento.Text.ToUpper();
                DateTime f_adquision_armamento = dtpFechaAdArmamento.Value;
                DateTime f_registro_armamento = dtpFechaRegisArmamento.Value;
                string observacion_armamento = txtObsArmamento.Text.ToUpper();

                logisticaActualizar.ActualizarArmamento(cod_sistema, cod_armamento, nombre_armamento, marca_armamento,
                             num_serie_armamento, num_tarjeta_propiedad, f_inicio_armamento, f_vencimiento_armamento, estado_armamento, stock_inicial_armamento,
                           stock_actual_armamento, stock_minimo_armamento, tipo_unidad_armamento, desp_armamento, f_adquision_armamento,
                           f_registro_armamento, observacion_armamento);
                MessageBox.Show("Datos registrado correctamente", "Correcto");
                LimpiarDatosArmamento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }

        public void AgregarProductoAccesorio()
        {
            try
            {
                string Condicion = cboEstadoAccesorio.GetItemText(cboEstadoAccesorio.SelectedItem).ToUpper();
                string t = cboTallaAccesorio.GetItemText(cboTallaAccesorio.SelectedItem).ToUpper();
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_accesorio = txtCodAccesorio.Text.ToUpper();
                string nombre = txtNombreAccesorio.Text.ToUpper();
                int talla_acc = cboTallaAccesorio.SelectedIndex;
                string color_acc = txtColorAccesorio.Text.ToUpper();
                int stock_inicial_acc = Convert.ToInt32(txtStockInicalAcessorio.Text);
                int tipo_tela_acc = cboTipoTelaAccesorio.SelectedIndex;
                int estado_acc = cboEstadoAccesorio.SelectedIndex;
                decimal precio_unitario_acc = Convert.ToDecimal(txtCostoUnitarioAccesorio.Text);
                int stock_actual_acc = Convert.ToInt32(txtStockActutalAccesorio.Text);
                int stock_minimo_acc = Convert.ToInt32(txtStockMinimoAccesorio.Text);
                string desp_acc = txtDespAccesorio.Text.ToUpper();
                DateTime f_adquision_acc = dtpAdquAccesorio.Value;
                DateTime f_registro_acc = dtpRegistroAccesorio.Value;
                string observacion_acc = txtObservacionAccesorio.Text.ToUpper();

                string nombre_accesorio = (nombre + "-" + t + "-" + color_acc + "-" + Condicion).ToUpper();

                logisticaInsertar.RegistrarPrendaAccesorio(cod_sistema, cod_accesorio, nombre_accesorio, talla_acc,
                        color_acc, stock_inicial_acc, tipo_tela_acc, estado_acc, precio_unitario_acc, stock_actual_acc,
                       stock_minimo_acc, desp_acc, f_adquision_acc, f_registro_acc, observacion_acc);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
                LimpiarDatosAccesorios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }
        public void AgregarProductoUtiles()
        {
            try
            {
                string Condicion = cboEstadoUtilez.GetItemText(cboEstadoUtilez.SelectedItem).ToUpper();
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_utiles = txtCodigoUtiles.Text.ToUpper();
                string nombre = txtNombreUtiles.Text.ToUpper();
                string marca_utiles = txtMarcaUtiles.Text.ToUpper();
                string modelo_utiles = txtModeloUtiles.Text.ToUpper();
                int tipo_unidad_utiles = cboTipoUnidadUtiles.SelectedIndex;
                int stock_inicial_utiles = Convert.ToInt32(txtCantidadUtiles.Text);
                int estado_utiles = cboEstadoUtilez.SelectedIndex;
                decimal precio_unitario_utiles = Convert.ToDecimal(txtPrecioUnitarioUtiles.Text);
                int stock_actual_utiles = Convert.ToInt32(txtStockIniUtiles.Text);
                int stock_minimo_utiles = Convert.ToInt32(txtStockMinUtiles.Text);
                string desp_utiles = txtDescripcionUti.Text.ToUpper();
                DateTime f_adquision_utiles = dtpFechaAdUtiles.Value;
                DateTime f_registro_utiles = dtpFechaRegisUtiles.Value;
                string observacion_utiles = txtObservacionUti.Text.ToUpper();
                string nombre_utiles = (nombre + "-" + marca_utiles + "-" + modelo_utiles + "-"+ Condicion).ToUpper();
                logisticaInsertar.RegistrarUtiles(cod_sistema, cod_utiles, nombre_utiles, marca_utiles,
                          modelo_utiles, tipo_unidad_utiles, stock_inicial_utiles, estado_utiles, precio_unitario_utiles,
                           stock_actual_utiles,
                        stock_minimo_utiles, desp_utiles, f_adquision_utiles, f_registro_utiles, observacion_utiles);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
                LimpiarDatosUtilezEscritorio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }
        public void AgregarEquipamientoLogistico()
        {
            try
            {
                string Condicion = cboEstadoEquipo.GetItemText(cboEstadoEquipo.SelectedItem).ToUpper();
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_logistico = txtCodEquipoEquip.Text.ToUpper();
                string nombre = txtNombreEquip.Text.ToUpper();
                string marca_logistico = txtMarcaEquip.Text.ToUpper();
                string modelo_logistico = txtModeloEquip.Text.ToUpper();
                int tipo_unidad_logistico = cboTipoUnidadEquipo.SelectedIndex;
                int stock_inicial_logistico = Convert.ToInt32(txtCantidadEquip.Text);
                int estado_logistico = cboEstadoEquipo.SelectedIndex;
                decimal precio_unitario_logistico = Convert.ToDecimal(txtPrecioUniEquip.Text);
                int stock_actual_logistico = Convert.ToInt32(txtStockIniEquip.Text);
                int stock_minimo_logistico = Convert.ToInt32(txtStockMinEquip.Text);
                string desp_logistico = txtDescripcionEquip.Text.ToUpper();
                DateTime f_adquision_logistico = dtpFechaAdEquip.Value;
                DateTime f_registro_logistico = dtpFechaRegisEquip.Value;
                string observacion_logistico = txtObservacionEquip.Text.ToUpper();
                string nombre_logistico = (nombre + "-"+marca_logistico+"-"+modelo_logistico+"-"+estado_logistico).ToUpper();
                logisticaInsertar.RegistrarEquipaminetoLogistico(cod_sistema, cod_logistico, nombre_logistico, marca_logistico,
                           modelo_logistico, tipo_unidad_logistico, stock_inicial_logistico, estado_logistico, precio_unitario_logistico,
                            stock_actual_logistico,
                         stock_minimo_logistico, desp_logistico, f_adquision_logistico, f_registro_logistico, observacion_logistico);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
                LimpiarDatosEquipamientoLogistico();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }
        public void AgregarEPP()
        {
            try
            {
                string Condicion = cboEstadoEquipoPro.GetItemText(cboEstadoEquipoPro.SelectedItem).ToUpper();
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_epp = txtCodEquipProtec.Text.ToUpper();
                string nombre = txtNombreProtec.Text.ToUpper();
                string marca_epp = txtMarcaProtec.Text.ToUpper();
                string modelo_epp = txtModeloProtec.Text.ToUpper();
                int tipo_unidad_epp = cboTipoEquipoPro.SelectedIndex;
                int stock_inicial_epp = Convert.ToInt32(txtCantidadProtec.Text);
                int estado_epp = cboEstadoEquipoPro.SelectedIndex;
                decimal precio_unitario_epp = Convert.ToDecimal(txtPrecioUniProtec.Text);
                int stock_actual_epp = Convert.ToInt32(txtStockIniProtec.Text);
                int stock_minimo_epp = Convert.ToInt32(txtStockMinProtec.Text);
                string desp_epp = txtDescripcionProtec.Text.ToUpper();
                DateTime f_adquision_epp = dtpFechaAdProtec.Value;
                DateTime f_registro_epp = dtpFechaRegisProtec.Value;
                string observacion_epp = txtObservacionProtec.Text.ToUpper();
                string nombre_epp = (nombre +"-"+marca_epp+"-"+modelo_epp+"-"+ Condicion).ToUpper();
                logisticaInsertar.RegistrarEpp(cod_sistema, cod_epp, nombre_epp, marca_epp,
                            modelo_epp, tipo_unidad_epp, stock_inicial_epp, estado_epp, precio_unitario_epp,
                             stock_actual_epp,
                          stock_minimo_epp, desp_epp, f_adquision_epp, f_registro_epp, observacion_epp);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
                LimpiarDatosEpp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }
        public void AgregarMobiliario()
        {
            try
            {
                string Condicion = cboEstadoMobi.GetItemText(cboEstadoMobi.SelectedItem).ToUpper();
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_mobi = txtCodEquipMobi.Text.ToUpper();
                string nombre = txtNombreMobi.Text.ToUpper();
                string marca_mobi = txtMarcaMobi.Text.ToUpper();
                string modelo_mobi = txtModeloMobi.Text.ToUpper();
                int tipo_unidad_mobi = cboTipoUnidadMobi.SelectedIndex;
                string categoria_mobi = txtCantidadMobi.Text.ToUpper();
                int estado_mobi = cboEstadoMobi.SelectedIndex;
                decimal precio_unitario_mobi = Convert.ToDecimal(txtPrecioUniMobi.Text);
                int stock_inicial_mobi = Convert.ToInt32(txtStockIniMobil.Text);
                int stock_actual_mobi = Convert.ToInt32(txtStockactualMobi.Text);
                int stock_minimo_mobi = Convert.ToInt32(txtStockMinMobi.Text);
                string desp_mobi = txtDescripcionMobi.Text.ToUpper();
                DateTime f_adquision_mobi = dtpFechaAdMobi.Value;
                DateTime f_registro_mobi = dtpFechaRegisMobi.Value;
                string observacion_mobi = txtObservacionMobi.Text.ToUpper();
                string nombre_mobi = (nombre + "-"+marca_mobi+"-"+modelo_mobi+"-"+Condicion).ToUpper();
                logisticaInsertar.RegistrarMobiliario(cod_sistema, cod_mobi, nombre_mobi, marca_mobi,
                             modelo_mobi, tipo_unidad_mobi, categoria_mobi, estado_mobi, precio_unitario_mobi,
                              stock_inicial_mobi,
                           stock_actual_mobi, stock_minimo_mobi, desp_mobi, f_adquision_mobi, f_registro_mobi,
                           observacion_mobi);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
                LimpiarDatosMobiliario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }
        public void AgregarVehiculo()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_vehi = txtCodVehiculo.Text.ToUpper();
                string nombre_vehi = txtNombreVehiculo.Text.ToUpper();
                string marca_vehi = txtMarcaVehiculo.Text.ToUpper();
                string modelo_vehi = txtModeloVehiculo.Text.ToUpper();
                int tipo_unidad_vehi = cboTipoUnidadVehiculo.SelectedIndex;
                int categoria_vehi = cboCategoriaVehiculo.SelectedIndex;
                string color_vehi = txtcolorVehiculo.Text.ToUpper();
                int combustible_vehi = cboCombustibleVehiculo.SelectedIndex;
                string serial_vehi = txtserialVehiculo.Text.ToUpper();
                string anio_vehi = txtaniovehiculo.Text.ToUpper();
                string placa_vehi = txtPlacaVehiculo.Text.ToUpper();
                string tarejta_vehi = txtNTarjetaVehiculo.Text.ToUpper();
                int estado_vehi = cboEstadoVehiculo.SelectedIndex;
                string desp_vehi = txtDescripcionVehiculo.Text.ToUpper();
                DateTime f_adquision_vehi = dtpFechaAdVehiculo.Value;
                DateTime f_registro_vehi = dtpFechaRegisVehi.Value;
                string observacion_vehi = txtObservacionVehi.Text.ToUpper();

                logisticaInsertar.RegistrarVehiculo( cod_sistema,  cod_vehi,  nombre_vehi,  marca_vehi,
                              modelo_vehi,  tipo_unidad_vehi,  categoria_vehi,  color_vehi,  combustible_vehi,
                               serial_vehi,
                            anio_vehi,  placa_vehi,  tarejta_vehi,  estado_vehi,  desp_vehi,
                            f_adquision_vehi,  f_registro_vehi,  observacion_vehi);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
                LimpiarDatosVehiculo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }


        public void AgregarUtilesAseo()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_aseo = txtCodEquipAseo.Text.ToUpper();
                string nombre = txtNombreUtilesAseo.Text.ToUpper();
                string marca_aseo = txtMarcaUtilesAseo.Text.ToUpper();
                int tipo_unidad_aseo = Convert.ToInt32(cboTipoUnidadAseo.SelectedIndex);
                DateTime f_fabricacion_aseo = dtpFechaFabAseo.Value;
                DateTime f_vencimiento_aseo = dtpFechaVecAseo.Value;
                int estado_aseo = cboEstadoAseo.SelectedIndex;
                decimal precio_unitario_aseo = Convert.ToDecimal(txtCostoUtilesAseo.Text);
                int stock_inicial_aseo = Convert.ToInt32(txtStockIniAseo.Text);
                int stock_actual_aseo = Convert.ToInt32(txtStockActualAseo.Text);
                int stock_minimo_aseo = Convert.ToInt32(txtStockMinAseo.Text);
                string desp_aseo = txtDescripcionAseo.Text.ToUpper();
                DateTime f_adquision_aseo = dtpFechaAdAseo.Value;
                DateTime f_registro_aseo = dtpFechaRegisAseo.Value;
                string observacion_aseo = txtObservacionAseo.Text.ToUpper();

                string nombre_aseo = (nombre+"-"+marca_aseo).ToUpper();

                logisticaInsertar.RegistrarAseo(cod_sistema, cod_aseo, nombre_aseo, marca_aseo,
                             tipo_unidad_aseo, f_fabricacion_aseo, f_vencimiento_aseo, estado_aseo, precio_unitario_aseo,
                              stock_inicial_aseo,
                           stock_actual_aseo, stock_minimo_aseo, desp_aseo, f_adquision_aseo, f_registro_aseo,
                           observacion_aseo);
                MessageBox.Show("Datos registrado correctamente", "Correcto");
                LimpiarDatosAseo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }
      

        public void AgregarArmamentos()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_armamento = txtCodEquipArmamento.Text.ToUpper();
                string nombre_armamento = txtNombreArmamento.Text.ToUpper();
                string marca_armamento = txtMarcaArmamento.Text.ToUpper();
                string num_serie_armamento = txtNumbSerialArmamento.Text.ToUpper();
                string num_tarjeta_propiedad = txtNumbTarjetaArmamento.Text.ToUpper();
                DateTime f_inicio_armamento = dtpFechaIniArmamento.Value;
                DateTime f_vencimiento_armamento = dtpFechaVecArmamento.Value;
                int estado_armamento = cboEstadoArmamento.SelectedIndex;
                int stock_inicial_armamento = Convert.ToInt32(txtStockIniArmamento.Text);
                int stock_actual_armamento = Convert.ToInt32(txtStockActualArmamento.Text);
                int stock_minimo_armamento = Convert.ToInt32(txtStockMinArmamento.Text);
                int tipo_unidad_armamento = Convert.ToInt32(cboTipoUnidadArmamento.SelectedIndex);
                string desp_armamento = txtDespArmamento.Text.ToUpper();
                DateTime f_adquision_armamento = dtpFechaAdArmamento.Value;
                DateTime f_registro_armamento = dtpFechaRegisArmamento.Value;
                string observacion_armamento = txtObsArmamento.Text.ToUpper();

                logisticaInsertar.RegistrarArmamento(cod_sistema, cod_armamento, nombre_armamento, marca_armamento,
                             num_serie_armamento, num_tarjeta_propiedad, f_inicio_armamento, f_vencimiento_armamento, estado_armamento, stock_inicial_armamento,
                           stock_actual_armamento, stock_minimo_armamento, tipo_unidad_armamento, desp_armamento, f_adquision_armamento,
                           f_registro_armamento, observacion_armamento);
                MessageBox.Show("Datos registrado correctamente", "Correcto");
                LimpiarDatosArmamento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }

        public void AgregarProductoPantalon()
        {
            try
            {
                string Condicion = cboEstadoPantalon.GetItemText(cboEstadoPantalon.SelectedItem).ToUpper();
                string t_tela = cboTipoTelaPantalon.GetItemText(cboTipoTelaPantalon.SelectedItem).ToUpper();
                string t_ta = cboTallaPantalon.GetItemText(cboTallaPantalon.SelectedItem).ToUpper();
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_pantalon = txtCodPantalon.Text.ToUpper();
                string nombre = txtNombrePantalon.Text;
                int talla_pan = cboTallaPantalon.SelectedIndex;
                string color_pan = txtColorPantalon.Text.ToUpper();
                int stock_inicial_pan = Convert.ToInt32(txtStockIniPantalon.Text);
                int tipo_tela_pan = cboTipoTelaPantalon.SelectedIndex;
                int estado_pan = cboEstadoPantalon.SelectedIndex;
                decimal precio_unitario_pan = Convert.ToDecimal(txtCostoUniPantalon.Text);
                int stock_actual_pan = Convert.ToInt32(txtStockActuPantalon.Text);
                int stock_minimo_pan = Convert.ToInt32(txtStockMinPantalon.Text);
                string desp_pan = txtDespPantalon.Text.ToUpper();
                DateTime f_adquision_pan = dtpAdPantalon.Value;
                DateTime f_registro_pan = dtpRegistroPantalon.Value;
                string observacion_pan = txtObservacionPantalon.Text.ToUpper();
                string nombre_pantalon = (nombre + "-" + color_pan + "-" + t_tela + "-"+ t_ta + "-" + Condicion).ToUpper();

                logisticaInsertar.RegistrarPrendaPantalon(cod_sistema, cod_pantalon, nombre_pantalon, talla_pan,
                      color_pan, stock_inicial_pan, tipo_tela_pan, estado_pan, precio_unitario_pan, stock_actual_pan,
                      stock_minimo_pan, desp_pan, f_adquision_pan, f_registro_pan, observacion_pan);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
                LimpiarDatosPantalon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto" + ex, "Error");
            }
        }
        public void AgregarProductoCalzado()
        {
            try
            {
                string Condicion = cboEstadoCalzado.GetItemText(cboEstadoCalzado.SelectedItem).ToUpper();
                string ta = cboTallaCalzado.GetItemText(cboTallaCalzado.SelectedItem).ToUpper();
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_calzado = txtCodCalzado.Text.ToUpper();
                string nombre = txtNombreCalzado.Text.ToUpper();
                int talla_cal = cboTallaCalzado.SelectedIndex;
                string color_cal = txtColorCalzado.Text.ToUpper();
                int tipo_calzado = cboTipoCalzado.SelectedIndex;
                int stock_inicial_cal = Convert.ToInt32(txtStockInicialCalzado.Text);
                int estado_cal = cboEstadoCalzado.SelectedIndex;
                decimal precio_unitario_cal = Convert.ToDecimal(txtCostoUniCalzado.Text);
                int stock_actual_cal = Convert.ToInt32(txtStockActualCalzado.Text);
                int stock_minimo_cal = Convert.ToInt32(txtStockMinimoCalzado.Text);
                string desp_cal = txtDespCalzado.Text.ToUpper();
                DateTime f_adquision_cal = dtpAdquiCalzado.Value;
                DateTime f_registro_cal = dtpRegistroCalzado.Value;
                string observacion_cal = txtObservacionCalzado.Text.ToUpper();
                string nombre_calzado = (nombre + "-" + color_cal + "-"+ ta + "-" + Condicion).ToUpper();

                int cantidad_cuotas = cboNcuota.SelectedIndex;
                decimal descuento_cuota = Convert.ToDecimal(txtDescuento.Text);

                logisticaInsertar.RegistrarPrendaCalzado(cod_sistema, cod_calzado, nombre_calzado, talla_cal, color_cal,
                     tipo_calzado, stock_inicial_cal, estado_cal, precio_unitario_cal, stock_actual_cal, stock_minimo_cal, desp_cal,
                     f_adquision_cal, f_registro_cal, observacion_cal, cantidad_cuotas, descuento_cuota);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
                LimpiarDatosCalzado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto", "Error");
            }
        }
        public void registrarProductoTecnologico()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_producto = txtCodEquipoTecnologia.Text.ToUpper();
                string nombre_producto = txtNombreEquipoTecnologia.Text.ToUpper();
                string modelo = txtModeloEquipoTecnologia.Text.ToUpper();
                string marca = txtMarcaEquipoTecnologia.Text.ToUpper();
                string num_serie = txtNumSerialEquipoTecnologia.Text.ToUpper();
                string desp_equipo = txtDescripcionEquipoTecnologia.Text.ToUpper();
                int estado = cboEstadoProducEquipoTecnologia.SelectedIndex;
                decimal precio_unitario = Convert.ToDecimal(txtPrecioUnitarioEquipoTecnologia.Text);
                int tipo_unidad = cboTipoUnidadEquipoTecnologia.SelectedIndex;
                int stock_inicial = Convert.ToInt32(txtStockInicialEquipoTecnologia.Text);
                int stock_actual = Convert.ToInt32(txtStockActualEquipoTecnologia.Text);
                int stock_minimo = Convert.ToInt32(txtStockMinEquipoTecnologia.Text);
                DateTime f_adquision = dtpFechaAdquisicionEquipoTecnologia.Value;
                DateTime f_registro = dtpFechaRegistroEquipoTecnologia.Value;
                string observacion = txtObservacionEquipoTecnologia.Text.ToUpper();

                logisticaInsertar.RegistrarEquipoTecnologico(cod_sistema, cod_producto, nombre_producto, modelo,
                    marca, num_serie, desp_equipo, estado, precio_unitario, tipo_unidad, stock_inicial,
                    stock_actual, stock_minimo, f_adquision, f_registro, observacion);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
                LimpiarDatosTecnologico();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto", "Error");
            }
        }
        public void actualizarProductoTecnologico()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text.ToUpper();
                string cod_producto = txtCodEquipoTecnologia.Text.ToUpper();
                string nombre_producto = txtNombreEquipoTecnologia.Text.ToUpper();
                string modelo = txtModeloEquipoTecnologia.Text.ToUpper();
                string marca = txtMarcaEquipoTecnologia.Text.ToUpper();
                string num_serie = txtNumSerialEquipoTecnologia.Text.ToUpper();
                string desp_equipo = txtDescripcionEquipoTecnologia.Text.ToUpper();
                int estado = cboEstadoProducEquipoTecnologia.SelectedIndex;
                decimal precio_unitario = Convert.ToDecimal(txtPrecioUnitarioEquipoTecnologia.Text);
                int tipo_unidad = cboTipoUnidadEquipoTecnologia.SelectedIndex;
                int stock_inicial = Convert.ToInt32(txtStockInicialEquipoTecnologia.Text);
                int stock_actual = Convert.ToInt32(txtStockActualEquipoTecnologia.Text);
                int stock_minimo = Convert.ToInt32(txtStockMinEquipoTecnologia.Text);
                DateTime f_adquision = dtpFechaAdquisicionEquipoTecnologia.Value;
                DateTime f_registro = dtpFechaRegistroEquipoTecnologia.Value;
                string observacion = txtObservacionEquipoTecnologia.Text.ToUpper();

                logisticaActualizar.ActualizarEquipoTecnologico(cod_sistema, cod_producto, nombre_producto, modelo,
                    marca, num_serie, desp_equipo, estado, precio_unitario, tipo_unidad, stock_inicial,
                    stock_actual, stock_minimo, f_adquision, f_registro, observacion);
                MessageBox.Show("Datos Actualizado correptamente", "Correpto");
                LimpiarDatosTecnologico();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Actualizar el producto", "Error");
            }
        }
        public void BuscarProductoTecnologico(string cod_producto_tecnologia)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM v_producto_tecnologico WHERE COD_PRODUCTO_TECNOLOGICO = '" + cod_producto_tecnologia + "'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtCodSistema.Text = recorre["COD_PRODUCTO_SISTEMA"].ToString();
                    txtCodEquipoTecnologia.Text = recorre["COD_PRODUCTO_TECNOLOGICO"].ToString();
                    txtNombreEquipoTecnologia.Text = recorre["NOMBRE_EQUIPO"].ToString();
                    txtModeloEquipoTecnologia.Text = recorre["MODELO"].ToString();
                    txtMarcaEquipoTecnologia.Text = recorre["MARCA"].ToString();
                    txtNumSerialEquipoTecnologia.Text = recorre["NUMERO_SERIE"].ToString();
                    txtDescripcionEquipoTecnologia.Text = recorre["DESCRP_EQUIPO"].ToString();
                    cboEstadoProducEquipoTecnologia.SelectedIndex = Convert.ToInt32(recorre["ID_ESTADO_MATERIAL"].ToString());
                    txtPrecioUnitarioEquipoTecnologia.Text = (recorre["COSTO_UNITARIO_T"].ToString());
                    cboTipoUnidadEquipoTecnologia.SelectedIndex = Convert.ToInt32(recorre["IDUNIDAD_PRODUCTO"].ToString());
                    txtStockInicialEquipoTecnologia.Text = (recorre["STOCK_INICIAL"].ToString());
                    txtStockActualEquipoTecnologia.Text = (recorre["STOCK_ACTUAL"].ToString());
                    txtStockMinEquipoTecnologia.Text = (recorre["STOCK_MINIMO"].ToString());
                    dtpFechaAdquisicionEquipoTecnologia.Text = (recorre["FECHA_ADQUISICION"].ToString());
                    dtpFechaRegistroEquipoTecnologia.Text = (recorre["FECHA_REGISTRO"].ToString());
                    txtObservacionEquipoTecnologia.Text = (recorre["OBSERVACION"].ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }
        public void GenerarCodigoPrincipal()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("select count(id_producto) as 't' from T_MAE_PRODUCTO ", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtCodSistema.Text = "SUM000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtCodSistema.Text = "SUM00" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtCodSistema.Text = "SUM0" + (numero + 1);
            }
        }
        public void generarCodigos()
        {
            GenerarCodigoTecnologico();
            GenerarCodigoCamisas();
            GenerarCodigoPrincipal();
            GenerarCodigoCalzado();
            GenerarCodigoPantalon();
            GenerarCodigoAccesorio();
            GenerarCodigoUtilesEscritorio();
            GenerarCodigoEquipamientoLogistico();
            GenerarCodigoEquipoPersonal();
            GenerarCodigoMobiliario();
            GenerarCodigoVehiculo();
            GenerarCodigoUtilesAseo();
            GenerarCodigoArmamento();
        }
        public void LimpiarDatosCamisas()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox1);
            txtNombreCamisas.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox5);
            generarCodigos();
            Llenadocbo.ObtenerProductoCamisas(cboProductoCamisas);
            btnAgregarProductoCamisas.Enabled = true;
        }
        public void LimpiarDatosTecnologico()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox2);
            txtNombreEquipoTecnologia.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox13);
            generarCodigos();
            Llenadocbo.ObtenerProductoTecnologico(cboNombreProductoTecnologico);
            btnAgregarProductoTecnologico.Enabled = true;
        }
        public void LimpiarDatosCalzado()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox7);
            txtNombreCalzado.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox8);
            generarCodigos();
            Llenadocbo.ObtenerProductoCalzado(cboCalzado);
            btnAgregarCalzado.Enabled = true;
        }
        public void LimpiarDatosAccesorios()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox11);
            txtNombreAccesorio.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox12);
            generarCodigos();
            Llenadocbo.ObtenerProductoAccesorio(cboAccesorios);
            btnAgregarAccesorio.Enabled = true;
        }
        public void LimpiarDatosUtilezEscritorio()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox3);
            txtNombreUtiles.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox14);
            generarCodigos();
            Llenadocbo.ObtenerProductoUtilezEscritorio(cboUtilesEscritorio);
            btnAgregarUtiles.Enabled = true;
        }
        public void LimpiarDatosPantalon()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox9);
            txtNombrePantalon.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox10);
            generarCodigos();
            Llenadocbo.ObtenerProductoPantalon(cboPantalon);
            btnAgregarPantalon.Enabled = true;
        }
        public void LimpiarDatosEquipamientoLogistico()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox4);
            txtNombreEquip.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox15);
            generarCodigos();
            Llenadocbo.ObtenerEquipoLogistico(cboEquipamientoLogistico);
            btnNuevoLogistico.Enabled = true;
        }
        public void LimpiarDatosEpp()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox6);
            txtCodEquipProtec.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox16);
            generarCodigos();
            Llenadocbo.ObtenerEpp(cboEpp);
            btnAgregarEquipoPro.Enabled = true;
        }
        public void LimpiarDatosMobiliario()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox17);
            txtNombreMobi.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox18);
            generarCodigos();
            Llenadocbo.ObtenerMobiliario(cboMobiliario);
            btnagregarMobil.Enabled = true;
        }
        public void LimpiarDatosVehiculo()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox19);
            txtNombreVehiculo.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox20);
            generarCodigos();
            Llenadocbo.ObtenerVehiculo(cboVehiculo);
            btnAgregarVehiculo.Enabled = true;
        }

        public void LimpiarDatosAseo()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox21);
            txtNombreUtilesAseo.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox22);
            generarCodigos();
            Llenadocbo.ObtenerUtilesAseo(cboUtilesAseoLogistico);
            btnAgregarUtilesAseo.Enabled = true;
        }

        public void LimpiarDatosArmamento()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox23);
            txtNombreArmamento.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox24);
            generarCodigos();
            Llenadocbo.ObtenerArmamento(cboArmamento);
            btnAgregarArmamento.Enabled = true;
        }

        public void GenerarCodigoTecnologico()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("select count(ID_PRODUCTO_TECNOLOGICO) as 't' from T_MAE_PRODUCTO_TECNOLOGICO ", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtCodEquipoTecnologia.Text = "TEC000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtCodEquipoTecnologia.Text = "TEC00" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtCodEquipoTecnologia.Text = "TEC0" + (numero + 1);
            }
        }
        public void GenerarCodigoPantalon()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("select count(ID_PRODUCTO_UNI_PANTALON) as 't' from T_MAE_UNI_PANTALON ", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtCodPantalon.Text = "PAN000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtCodPantalon.Text = "PAN00" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtCodPantalon.Text = "PAN0" + (numero + 1);
            }
        }
        public void GenerarCodigoCamisas()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("select count(ID_PRODUCTO_UNI_CAMISAS) as 't' from T_MAE_UNI_CAMISAS ", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtcodcamisas.Text = "CAM000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtcodcamisas.Text = "CAM00" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtcodcamisas.Text = "CAM0" + (numero + 1);
            }
        }
        public void GenerarCodigoCalzado()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("select count(ID_PRODUCTO_UNI_CALZADO) as 't' from T_MAE_UNI_CALZADO ", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtCodCalzado.Text = "CAL000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtCodCalzado.Text = "CAL00" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtCodCalzado.Text = "CAL0" + (numero + 1);
            }
        }
        public void GenerarCodigoAccesorio()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("select count(ID_PRODUCTO_UNI_ACCESORIO) as 't' from T_MAE_UNI_ACCESORIO ", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtCodAccesorio.Text = "ACC000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtCodAccesorio.Text = "ACC00" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtCodAccesorio.Text = "ACC0" + (numero + 1);
            }
        }
        public void GenerarCodigoUtilesEscritorio()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("select count(ID_PRODUCTO_UTI_ESCRITORIO) as 't' from T_MAE_UTI_ESCRITORIO ", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtCodigoUtiles.Text = "UTI000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtCodigoUtiles.Text = "UTI00" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtCodigoUtiles.Text = "UTI0" + (numero + 1);
            }
        }
        public void GenerarCodigoEquipamientoLogistico()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("select count(ID_PRODUCTO_EQUIP_LOGISTICO) as 't' from T_MAE_PRODUCTO_EQUIP_LOGISTICO ", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtCodEquipoEquip.Text = "EQL000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtCodEquipoEquip.Text = "EQL00" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtCodEquipoEquip.Text = "EQL0" + (numero + 1);
            }
        }
        public void GenerarCodigoEquipoPersonal()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("select count(ID_PRODUCTO_EQUIP_EPP) as 't' from T_MAE_PRODUCTO_EQUIP_PROTEC_PERSONAL ", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtCodEquipProtec.Text = "EPP000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtCodEquipProtec.Text = "EPP00" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtCodEquipProtec.Text = "EPP0" + (numero + 1);
            }
        }
        public void GenerarCodigoMobiliario()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("select count(ID_PRODUCTO_MOBILIARIO) as 't' from T_MAE_PRODUCTO_MOBILIARIO ", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtCodEquipMobi.Text = "MOB000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtCodEquipMobi.Text = "MOB00" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtCodEquipMobi.Text = "MOB0" + (numero + 1);
            }
        }
        
            public void GenerarCodigoArmamento()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("select count(ID_PRODUCTO_ARMAMENTO) as 't' from T_MAE_ARMAMENTO ", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtCodEquipArmamento.Text = "ARM000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtCodEquipArmamento.Text = "ARM00" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtCodEquipArmamento.Text = "ARM0" + (numero + 1);
            }
        }

        

        public void GenerarCodigoUtilesAseo()
             {
            string resultado = "";
            SqlCommand comando = new SqlCommand("select count(ID_PRODUCTO_UTI_ASEO) as 't' from T_MAE_UTI_ASEO ", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtCodEquipAseo.Text = "ACE000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtCodEquipAseo.Text = "ACE00" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtCodEquipAseo.Text = "ACE0" + (numero + 1);
            }
             }


        public void GenerarCodigoVehiculo()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("select count(ID_PRODUCTO_VEHICULO) as 't' from T_MAE_PRODUCTO_VEHICULO ", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtCodVehiculo.Text = "VEH000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtCodVehiculo.Text = "VEH00" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtCodVehiculo.Text = "VEH0" + (numero + 1);
            }
        }
        private void llenadoUtilesEscritorio()
        {
            Llenadocbo.ObtenerProductoUtilezEscritorio(cboUtilesEscritorio);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidadUtiles);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoUtilez);
        }
        private void llenadoProductoAccesorios()
        {
            Llenadocbo.ObtenerProductoAccesorio(cboAccesorios);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoAccesorio);
            Llenadocbo.ObtenerTipoTelaProducto(cboTipoTelaAccesorio);
            Llenadocbo.ObtenerTallaPantalonProducto(cboTallaAccesorio);
        }
        private void llenadoProductoPantalon()
        {
            Llenadocbo.ObtenerProductoPantalon(cboPantalon);
            Llenadocbo.ObtenerTipoTelaProducto(cboTipoTelaPantalon);
            Llenadocbo.ObtenerTallaPantalonProducto(cboTallaPantalon);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoPantalon);
        }
        private void llenadoProductoTecnologico()
        {
            Llenadocbo.ObtenerProductoTecnologico(cboNombreProductoTecnologico);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProducEquipoTecnologia);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidadEquipoTecnologia);
        }
        private void llenadoDatosCamisas()
        {
            Llenadocbo.ObtenerTallaPrendaProducto(cboTallaPrendaCamisas);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduCamisas);
            Llenadocbo.ObtenerProductoCamisas(cboProductoCamisas);
        }
        private void llenadoDatosCalzado()
        {
            Llenadocbo.ObtenerProductoCalzado(cboCalzado);
            Llenadocbo.ObtenerTallaCalzadoProducto(cboTallaCalzado);
            Llenadocbo.ObtenerTipoCalzadoProducto(cboTipoCalzado);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoCalzado);
            Llenadocbo.ObtenerCuotaProducto(cboNcuota);
        }
        private void llenadoDatosEquipamientoLogistico()
        {
            Llenadocbo.ObtenerEquipoLogistico(cboEquipamientoLogistico);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoEquipo);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidadEquipo);
        }
        private void llenadoDatosEquipoProteccion()
        {
            Llenadocbo.ObtenerEpp(cboEpp);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoEquipoPro);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoEquipoPro);
        }
        private void llenadoDatosEquipoMobiliario()
        {
            Llenadocbo.ObtenerMobiliario(cboMobiliario);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoMobi);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidadMobi);
        }
        private void llenadoDatosVehiculo()
        {
            Llenadocbo.ObtenerVehiculo(cboVehiculo);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoVehiculo);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidadVehiculo);
            Llenadocbo.ObtenerCategoriaVehiculo(cboCategoriaVehiculo);
            Llenadocbo.ObtenerTipoCombustible(cboCombustibleVehiculo);
        }

        private void llenadoDatosUtilesAseo()
        {
            Llenadocbo.ObtenerUtilesAseo(cboUtilesAseoLogistico);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidadAseo);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoAseo);

        }

        private void llenadoDatosArmamento()
        {
            Llenadocbo.ObtenerArmamento(cboArmamento);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidadArmamento);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoArmamento);

        }
        private void bloqueodecodigo()
        {
            txtCodEquipoTecnologia.Enabled = false;
            txtcodcamisas.Enabled = false;
            txtCodSistema.Enabled = false;
            txtCodCalzado.Enabled = false;
            txtCodPantalon.Enabled = false;
            txtCodAccesorio.Enabled = false;
            txtCodigoUtiles.Enabled = false;
            txtCodEquipoEquip.Enabled = false;
            txtCodEquipProtec.Enabled = false;
            txtCodEquipMobi.Enabled = false;
            txtCodVehiculo.Enabled = false;
            txtCodEquipAseo.Enabled = false;
            txtCodEquipArmamento.Enabled = false;
        }
        private void codigomanual()
        {
            txtCodEquipoTecnologia.Enabled = true;
            txtcodcamisas.Enabled = true;
           // txtCodSistema.Enabled = true;
            txtCodCalzado.Enabled = true;
            txtCodPantalon.Enabled = true;
            txtCodAccesorio.Enabled = true;
            txtCodigoUtiles.Enabled = true;
            txtCodEquipoEquip.Enabled = true;
            txtCodEquipProtec.Enabled = true;
            txtCodEquipMobi.Enabled = true;
            txtCodVehiculo.Enabled = true;
            txtCodEquipAseo.Enabled = true;
            txtCodEquipArmamento.Enabled = true;
        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            rbtCodigoSistema.Checked = true;
            llenadoProductoTecnologico();
            llenadoDatosCamisas();
            llenadoDatosCalzado();
            llenadoProductoPantalon();
            llenadoProductoAccesorios();
            llenadoUtilesEscritorio();
            llenadoDatosEquipamientoLogistico();
            llenadoDatosEquipoProteccion();
            llenadoDatosEquipoMobiliario();
            llenadoDatosVehiculo();
            llenadoDatosUtilesAseo();
            llenadoDatosArmamento();
            generarCodigos();
        }
        private void tbpUniforme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("s","ss");
        } 

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Registro de Producto";
            const string mensaje = "Estas seguro que deseas cerra el Registro de Producto";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarDatos.LimpiarGroupBox(groupBox2);
            txtCodEquipoTecnologia.Focus();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
           // string codProducto = cboProducto.SelectedValue.ToString();
        }
        private void btnAgregarProductoTecnologico_Click(object sender, EventArgs e)
        {
            registrarProductoTecnologico();
        }
        private void btnNuevoProductoTecnologico_Click(object sender, EventArgs e)
        {
            LimpiarDatosTecnologico();
        }
        private void btnBuscarProductoTecnologia_Click(object sender, EventArgs e)
        {
            string cod_producto_tecnologia = cboNombreProductoTecnologico.SelectedValue.ToString();
            BuscarProductoTecnologico( cod_producto_tecnologia);
            btnAgregarProductoTecnologico.Enabled = false;
        }
        private void btnActualizarProductoTecnologico_Click(object sender, EventArgs e)
        {
            actualizarProductoTecnologico();
        }
        private void btnAgregarProductoCamisas_Click(object sender, EventArgs e)
        {
           AgregarProductoCamisas();
        }
        private void btnNuevoProductoCamisas_Click(object sender, EventArgs e)
        {
            LimpiarDatosCamisas();
        }
        private void btnActualizarProductoCamisas_Click(object sender, EventArgs e)
        {
            actualizarDatosCamisas();
        }
        private void btnBuscarProductoCamisas_Click(object sender, EventArgs e)
        {
            string cod_uniforme_camisa = cboProductoCamisas.SelectedValue.ToString();
            BuscarProductoCamisas(cod_uniforme_camisa);
            btnAgregarProductoCamisas.Enabled = false;
        }
        private void btnAgregarCalzado_Click(object sender, EventArgs e)
        {
            AgregarProductoCalzado();
        }
        private void btnNuevoCalzado_Click(object sender, EventArgs e)
        {
            LimpiarDatosCalzado();
        }
        private void btnActualizarCalzado_Click(object sender, EventArgs e)
        {
            AgregarActualizarCalzado();
        }
        private void btnBuscarCalzado_Click(object sender, EventArgs e)
        {
            string cod_uniforme_calzado = cboCalzado.SelectedValue.ToString();
            BuscarProductoCalzado(cod_uniforme_calzado);
            btnAgregarCalzado.Enabled = false;
        }
        private void btnNuevoPantalon_Click(object sender, EventArgs e)
        {
            LimpiarDatosPantalon();
        }
        private void btnAgregarPantalon_Click(object sender, EventArgs e)
        {
            AgregarProductoPantalon();
        }
        private void btnActualizarPantalon_Click(object sender, EventArgs e)
        {
            ActulizarPantalon();
        }
        private void btnBuscarPantalon_Click(object sender, EventArgs e)
        {
            string cod_uniforme_pantalon = cboPantalon.SelectedValue.ToString();
            BuscarProductoPantalon(cod_uniforme_pantalon);
            btnAgregarPantalon.Enabled = false;
        }
        private void btnNuevoAccesorio_Click(object sender, EventArgs e)
        {
            LimpiarDatosAccesorios();
        }
        private void btnAgregarAccesorio_Click(object sender, EventArgs e)
        {
            AgregarProductoAccesorio();
        }
        private void btnActualizarAccesorio_Click(object sender, EventArgs e)
        {
            AgregarActualizarAccesorio();
        }
        private void btnBuscarAccesorio_Click(object sender, EventArgs e)
        {
            string cod_uniforme_Accesorio = cboAccesorios.SelectedValue.ToString();
            BuscarProductoAccesorio(cod_uniforme_Accesorio);
            btnAgregarAccesorio.Enabled = false;
        }
        private void btnNuevoUtiles_Click(object sender, EventArgs e)
        {
            LimpiarDatosUtilezEscritorio();
        }

        private void btnAgregarUtiles_Click(object sender, EventArgs e)
        {
            AgregarProductoUtiles();
        }

        private void btnActualizarUtiles_Click(object sender, EventArgs e)
        {
            AgregarActualizarUtiles();
        }

        private void btnBuscarUtilez_Click(object sender, EventArgs e)
        {
            string cod_utiles_escritorio = cboUtilesEscritorio.SelectedValue.ToString();
            BuscarProductoEscritorio(cod_utiles_escritorio);
            btnAgregarUtiles.Enabled = false;
        }

        private void btnNuevoMaterialLogistico_Click(object sender, EventArgs e)
        {
            LimpiarDatosEquipamientoLogistico();
        }

        private void btnNuevoLogistico_Click(object sender, EventArgs e)
        {
            AgregarEquipamientoLogistico();
        }

        private void btnActualizarLogistico_Click(object sender, EventArgs e)
        {
            ActualizarEquipamientoLogistico();
        }

        private void btnBuscarLogistico_Click(object sender, EventArgs e)
        {
            string cod_equi_logistico = cboEquipamientoLogistico.SelectedValue.ToString();
            BuscarProductoEquipoLogistico(cod_equi_logistico);
            btnNuevoLogistico.Enabled = false;
        }

        private void btnAgregarEquipoPro_Click(object sender, EventArgs e)
        {
            AgregarEPP();
        }

        private void btnActualizarEquipoPro_Click(object sender, EventArgs e)
        {
            ActualizarEPP();
        }

        private void btnBuscarEquipoProtec_Click(object sender, EventArgs e)
        {
            string cod_equi_epp = cboEpp.SelectedValue.ToString();
            BuscarProductoEpp(cod_equi_epp);
            btnAgregarEquipoPro.Enabled = false;
        }

        private void btnNuevoEquipoProPe_Click(object sender, EventArgs e)
        {
            LimpiarDatosEpp();
        }

        private void btnNuevoMobil_Click(object sender, EventArgs e)
        {
            LimpiarDatosMobiliario();
        }

        private void btnagregarMobil_Click(object sender, EventArgs e)
        {
            AgregarMobiliario();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarMobiliario();
        }

        private void btnBuscarMobil_Click(object sender, EventArgs e)
        {
            string cod_mobiliario = cboMobiliario.SelectedValue.ToString();
            BuscarProductoMobiliario(cod_mobiliario);
            btnagregarMobil.Enabled = false;
        }

        private void btnNuevoVehicul_Click(object sender, EventArgs e)
        {
            LimpiarDatosVehiculo();
        }

        private void btnNuevoVehiculo_Click(object sender, EventArgs e)
        {
            string cod_vehiculo = cboVehiculo.SelectedValue.ToString();
            BuscarProductoVehiculo(cod_vehiculo);
            btnAgregarVehiculo.Enabled = false;
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            AgregarVehiculo();
        }

        private void btnActualizarVehiculo_Click(object sender, EventArgs e)
        {
            ActualizarVehiculo();
        }

        private void btnAgregarUtilesAseo_Click(object sender, EventArgs e)
        {
            AgregarUtilesAseo();
        }

        private void btnNuevoAseo_Click(object sender, EventArgs e)
        {
            LimpiarDatosAseo();
        }

        private void btnBuscarUtilesAseo_Click(object sender, EventArgs e)
        {
            string cod_aseo = cboUtilesAseoLogistico.SelectedValue.ToString();
            BuscarProductoAseo(cod_aseo);
            btnAgregarUtilesAseo.Enabled = false;
        }

        private void btnActualizarUtilesAseo_Click(object sender, EventArgs e)
        {
            ActualizarUtilesAseo();
        }

        private void btnAgregarArmamento_Click(object sender, EventArgs e)
        {
            AgregarArmamentos();
        }

        private void btnActualizarArmamento_Click(object sender, EventArgs e)
        {
            ActualizarArmamento();
        }

        private void btnNuevoArmamento_Click(object sender, EventArgs e)
        {
            LimpiarDatosArmamento();
        }

        private void btnBuscarArmamento_Click(object sender, EventArgs e)
        {
            string cod_armamento = cboArmamento.SelectedValue.ToString();
            BuscarProductoArmamento(cod_armamento);
            btnAgregarArmamento.Enabled = false;
        }

        private void rbtCodigoSistema_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCodigoSistema.Checked == true)
            {
                bloqueodecodigo();
            }
        }

        private void rbCodigoManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCodigoManual.Checked == true)
            {
                codigomanual();
            }
        }
    }
}
