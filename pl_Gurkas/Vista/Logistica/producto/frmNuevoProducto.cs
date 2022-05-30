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
        public void actualizarDatosCamisas()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text;
                string cod_camisa = txtcodcamisas.Text;
                string nombre_camisa = txtNombreCamisas.Text;
                int talla_c = cboTallaPrendaCamisas.SelectedIndex;
                string color_c = txtColorCamisas.Text;
                int stock_inicial_c = Convert.ToInt32(txtStockInicialCamisas.Text);
                int estado_c = cboEstadoProduCamisas.SelectedIndex;
                decimal precio_unitario_c = Convert.ToDecimal(txtCostoUniCamisas.Text);
                int stock_actual_c = Convert.ToInt32(txtStockActualCamisas.Text);
                int stock_minimo_c = Convert.ToInt32(txtStockMinimoCamisas.Text);
                string desp_c = txtDescripcionCamisas.Text;
                DateTime f_adquision_c = dtpAdquisicionCamisas.Value;
                DateTime f_registro_c = dtpRegistroCamisas.Value;
                string observacion_c = txtObservacionCamisas.Text;

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
                string cod_sistema = txtCodSistema.Text;
                string cod_camisa = txtcodcamisas.Text;
                string nombre_camisa = txtNombreCamisas.Text;
                int talla_c = cboTallaPrendaCamisas.SelectedIndex;
                string color_c = txtColorCamisas.Text;
                int stock_inicial_c = Convert.ToInt32(txtStockInicialCamisas.Text);
                int estado_c = cboEstadoProduCamisas.SelectedIndex;
                decimal precio_unitario_c = Convert.ToDecimal(txtCostoUniCamisas.Text);
                int stock_actual_c = Convert.ToInt32(txtStockActualCamisas.Text);
                int stock_minimo_c = Convert.ToInt32(txtStockMinimoCamisas.Text);
                string desp_c = txtDescripcionCamisas.Text;
                DateTime f_adquision_c = dtpAdquisicionCamisas.Value;
                DateTime f_registro_c = dtpRegistroCamisas.Value;
                string observacion_c = txtObservacionCamisas.Text;

                logisticaInsertar.RegistrarPrendaCamisas(cod_sistema, cod_camisa, nombre_camisa, talla_c, color_c,
                   stock_inicial_c, estado_c, precio_unitario_c, stock_actual_c, stock_minimo_c, desp_c, f_adquision_c,
                   f_registro_c, observacion_c);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
                LimpiarDatosCamisas();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto", "Error");
            }
        }
        public void ActulizarPantalon()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text;
                string cod_pantalon = txtCodPantalon.Text;
                string nombre_pantalon = txtNombrePantalon.Text;
                int talla_pan = cboTallaPantalon.SelectedIndex;
                string color_pan = txtColorPantalon.Text;
                int stock_inicial_pan = Convert.ToInt32(txtStockIniPantalon.Text);
                int tipo_tela_pan = cboTipoTelaPantalon.SelectedIndex;
                int estado_pan = cboEstadoPantalon.SelectedIndex;
                decimal precio_unitario_pan = Convert.ToDecimal(txtCostoUniPantalon.Text);
                int stock_actual_pan = Convert.ToInt32(txtStockActuPantalon.Text);
                int stock_minimo_pan = Convert.ToInt32(txtStockMinPantalon.Text);
                string desp_pan = txtDespPantalon.Text;
                DateTime f_adquision_pan = dtpAdPantalon.Value;
                DateTime f_registro_pan = dtpRegistroPantalon.Value;
                string observacion_pan = txtObservacionPantalon.Text;

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
                string cod_sistema = txtCodSistema.Text;
                string cod_calzado = txtCodCalzado.Text;
                string nombre_calzado = txtNombreCalzado.Text;
                int talla_cal = cboTallaCalzado.SelectedIndex;
                string color_cal = txtColorCalzado.Text;
                int tipo_calzado = cboTipoCalzado.SelectedIndex;
                int stock_inicial_cal = Convert.ToInt32(txtStockInicialCalzado.Text);
                int estado_cal = cboEstadoCalzado.SelectedIndex;
                decimal precio_unitario_cal = Convert.ToDecimal(txtCostoUniCalzado.Text);
                int stock_actual_cal = Convert.ToInt32(txtStockActualCalzado.Text);
                int stock_minimo_cal = Convert.ToInt32(txtStockMinimoCalzado.Text);
                string desp_cal = txtDespCalzado.Text;
                DateTime f_adquision_cal = dtpAdquiCalzado.Value;
                DateTime f_registro_cal = dtpRegistroCalzado.Value;
                string observacion_cal = txtObservacionCalzado.Text;

                logisticaActualizar.ActualizarPrendaCalzado(cod_sistema, cod_calzado, nombre_calzado, talla_cal, color_cal,
                     tipo_calzado, stock_inicial_cal, estado_cal, precio_unitario_cal, stock_actual_cal, stock_minimo_cal, desp_cal,
                     f_adquision_cal, f_registro_cal, observacion_cal);
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
                string cod_sistema = txtCodSistema.Text;
                string cod_accesorio = txtCodAccesorio.Text;
                string nombre_accesorio = txtNombreAccesorio.Text;
                int talla_acc = cboTallaAccesorio.SelectedIndex;
                string color_acc = txtColorAccesorio.Text;
                int stock_inicial_acc = Convert.ToInt32(txtStockInicalAcessorio.Text);
                int tipo_tela_acc = cboTipoTelaAccesorio.SelectedIndex;
                int estado_acc = cboEstadoAccesorio.SelectedIndex;
                decimal precio_unitario_acc = Convert.ToDecimal(txtCostoUnitarioAccesorio.Text);
                int stock_actual_acc = Convert.ToInt32(txtStockActutalAccesorio.Text);
                int stock_minimo_acc = Convert.ToInt32(txtStockMinimoAccesorio.Text);
                string desp_acc = txtDespAccesorio.Text;
                DateTime f_adquision_acc = dtpAdquAccesorio.Value;
                DateTime f_registro_acc = dtpRegistroAccesorio.Value;
                string observacion_acc = txtObservacionAccesorio.Text;

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
        public void AgregarProductoAccesorio()
        {
            try
            {
                string cod_sistema = txtCodSistema.Text;
                string cod_accesorio = txtCodAccesorio.Text;
                string nombre_accesorio = txtNombreAccesorio.Text;
                int talla_acc = cboTallaAccesorio.SelectedIndex;
                string color_acc = txtColorAccesorio.Text;
                int stock_inicial_acc = Convert.ToInt32(txtStockInicalAcessorio.Text);
                int tipo_tela_acc = cboTipoTelaAccesorio.SelectedIndex;
                int estado_acc = cboEstadoAccesorio.SelectedIndex;
                decimal precio_unitario_acc = Convert.ToDecimal(txtCostoUnitarioAccesorio.Text);
                int stock_actual_acc = Convert.ToInt32(txtStockActutalAccesorio.Text);
                int stock_minimo_acc = Convert.ToInt32(txtStockMinimoAccesorio.Text);
                string desp_acc = txtDespAccesorio.Text;
                DateTime f_adquision_acc = dtpAdquAccesorio.Value;
                DateTime f_registro_acc = dtpRegistroAccesorio.Value;
                string observacion_acc = txtObservacionAccesorio.Text;

                logisticaInsertar.RegistrarPrendaAccesorio( cod_sistema,  cod_accesorio,  nombre_accesorio,  talla_acc,
                        color_acc,  stock_inicial_acc,  tipo_tela_acc,  estado_acc,  precio_unitario_acc,  stock_actual_acc,
                       stock_minimo_acc,  desp_acc,  f_adquision_acc,  f_registro_acc,  observacion_acc);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
                LimpiarDatosAccesorios();
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
                string cod_sistema = txtCodSistema.Text;
                string cod_pantalon = txtCodPantalon.Text;
                string nombre_pantalon = txtNombrePantalon.Text;
                int talla_pan = cboTallaPantalon.SelectedIndex;
                string color_pan = txtColorPantalon.Text;
                int stock_inicial_pan = Convert.ToInt32(txtStockIniPantalon.Text);
                int tipo_tela_pan = cboTipoTelaPantalon.SelectedIndex;
                int estado_pan = cboEstadoPantalon.SelectedIndex;
                decimal precio_unitario_pan = Convert.ToDecimal(txtCostoUniPantalon.Text);
                int stock_actual_pan = Convert.ToInt32(txtStockActuPantalon.Text);
                int stock_minimo_pan = Convert.ToInt32(txtStockMinPantalon.Text);
                string desp_pan = txtDespPantalon.Text;
                DateTime f_adquision_pan = dtpAdPantalon.Value;
                DateTime f_registro_pan = dtpRegistroPantalon.Value;
                string observacion_pan = txtObservacionPantalon.Text;

                logisticaInsertar.RegistrarPrendaPantalon( cod_sistema,  cod_pantalon,  nombre_pantalon,  talla_pan,
                      color_pan, stock_inicial_pan,  tipo_tela_pan,  estado_pan,  precio_unitario_pan,  stock_actual_pan,  
                      stock_minimo_pan,  desp_pan,f_adquision_pan,  f_registro_pan,  observacion_pan);
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
                string cod_sistema = txtCodSistema.Text;
                string cod_calzado = txtCodCalzado.Text;
                string nombre_calzado = txtNombreCalzado.Text;
                int talla_cal = cboTallaCalzado.SelectedIndex;
                string color_cal = txtColorCalzado.Text;
                int tipo_calzado = cboTipoCalzado.SelectedIndex;
                int stock_inicial_cal = Convert.ToInt32(txtStockInicialCalzado.Text);
                int estado_cal = cboEstadoCalzado.SelectedIndex;
                decimal precio_unitario_cal = Convert.ToDecimal(txtCostoUniCalzado.Text);
                int stock_actual_cal = Convert.ToInt32(txtStockActualCalzado.Text);
                int stock_minimo_cal = Convert.ToInt32(txtStockMinimoCalzado.Text);
                string desp_cal = txtDespCalzado.Text;
                DateTime f_adquision_cal = dtpAdquiCalzado.Value;
                DateTime f_registro_cal = dtpRegistroCalzado.Value;
                string observacion_cal = txtObservacionCalzado.Text;

              logisticaInsertar.RegistrarPrendaCalzado( cod_sistema,  cod_calzado,  nombre_calzado,  talla_cal,  color_cal,
                   tipo_calzado,  stock_inicial_cal,  estado_cal,  precio_unitario_cal,  stock_actual_cal,  stock_minimo_cal,  desp_cal,
                   f_adquision_cal,  f_registro_cal,  observacion_cal);
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
                string cod_sistema = txtCodSistema.Text;
                string cod_producto = txtCodEquipoTecnologia.Text;
                string nombre_producto = txtNombreEquipoTecnologia.Text;
                string modelo = txtModeloEquipoTecnologia.Text;
                string marca = txtMarcaEquipoTecnologia.Text;
                string num_serie = txtNumSerialEquipoTecnologia.Text;
                string desp_equipo = txtDescripcionEquipoTecnologia.Text;
                int estado = cboEstadoProducEquipoTecnologia.SelectedIndex;
                decimal precio_unitario = Convert.ToDecimal(txtPrecioUnitarioEquipoTecnologia.Text);
                int tipo_unidad = cboTipoUnidadEquipoTecnologia.SelectedIndex;
                int stock_inicial = Convert.ToInt32(txtStockInicialEquipoTecnologia.Text);
                int stock_actual = Convert.ToInt32(txtStockActualEquipoTecnologia.Text);
                int stock_minimo = Convert.ToInt32(txtStockMinEquipoTecnologia.Text);
                DateTime f_adquision = dtpFechaAdquisicionEquipoTecnologia.Value;
                DateTime f_registro = dtpFechaRegistroEquipoTecnologia.Value;
                string observacion = txtObservacionEquipoTecnologia.Text;

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
                string cod_sistema = txtCodSistema.Text;
                string cod_producto = txtCodEquipoTecnologia.Text;
                string nombre_producto = txtNombreEquipoTecnologia.Text;
                string modelo = txtModeloEquipoTecnologia.Text;
                string marca = txtMarcaEquipoTecnologia.Text;
                string num_serie = txtNumSerialEquipoTecnologia.Text;
                string desp_equipo = txtDescripcionEquipoTecnologia.Text;
                int estado = cboEstadoProducEquipoTecnologia.SelectedIndex;
                decimal precio_unitario = Convert.ToDecimal(txtPrecioUnitarioEquipoTecnologia.Text);
                int tipo_unidad = cboTipoUnidadEquipoTecnologia.SelectedIndex;
                int stock_inicial = Convert.ToInt32(txtStockInicialEquipoTecnologia.Text);
                int stock_actual = Convert.ToInt32(txtStockActualEquipoTecnologia.Text);
                int stock_minimo = Convert.ToInt32(txtStockMinEquipoTecnologia.Text);
                DateTime f_adquision = dtpFechaAdquisicionEquipoTecnologia.Value;
                DateTime f_registro = dtpFechaRegistroEquipoTecnologia.Value;
                string observacion = txtObservacionEquipoTecnologia.Text;

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
        }
        public void LimpiarDatosCamisas()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox1);
            txtNombreCamisas.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox5);
            generarCodigos();
            Llenadocbo.ObtenerProductoCamisas(cboProductoCamisas);
        }
        public void LimpiarDatosTecnologico()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox2);
            txtNombreEquipoTecnologia.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox13);
            generarCodigos();
            Llenadocbo.ObtenerProductoTecnologico(cboNombreProductoTecnologico);
        }
        public void LimpiarDatosCalzado()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox7);
            txtNombreCalzado.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox8);
            generarCodigos();
            Llenadocbo.ObtenerProductoCalzado(cboCalzado);
        }
        public void LimpiarDatosAccesorios()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox11);
            txtNombreAccesorio.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox12);
            generarCodigos();
            Llenadocbo.ObtenerProductoAccesorio(cboAccesorios);
        }
        public void LimpiarDatosPantalon()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox9);
            txtNombrePantalon.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox10);
            generarCodigos();
            Llenadocbo.ObtenerProductoPantalon(cboPantalon);
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
        private void llenadoDeDatos()
        {
          /*  Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidadUtiles);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidadEquipo);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoEquipoPro);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidadMobi);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad6);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad7);
           
            Llenadocbo.ObtenerEstadoProducto(cboEstadoUtilez);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoEquipo);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoEquipoPro);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoMobi);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc10);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc11);*/
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
        }
        private void frmNuevoProducto_Load(object sender, EventArgs e)
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
            txtCodEquipArma.Enabled = false;
            llenadoDeDatos();
            llenadoProductoTecnologico();
            llenadoDatosCamisas();
            llenadoDatosCalzado();
            llenadoProductoPantalon();
            llenadoProductoAccesorios();
            generarCodigos();
        }
        private void tbpUniforme_Click(object sender, EventArgs e)
        {

        }
        private void btnCargarDatos_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            //Abrimos el explorador de archivos de windows
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                ptcImagenCamisas.ImageLocation = abrirImagen.FileName;
                ptcImagenCamisas.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void btnSubirImage(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                try
                {
                    ptcImageTecnologia.Image = Image.FromFile(dialogo.FileName);
                    lblrutaimagenteconologia.Text = dialogo.FileName;
                }
                catch
                {
                    MessageBox.Show("Error" + Image.FromFile(dialogo.FileName));
                }
                
            }    
        }
        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            
        }

      /*  private void btnSave_Click(object sender, EventArgs e)
        {
            string ubicacion = lblrutaimagenteconologia.Text;
            byte[] imagen_byte = System.IO.File.ReadAllBytes(ubicacion);
            string imagen_base64 = Convert.ToBase64String(imagen_byte, 0, imagen_byte.Length);

            // var pic = Convert.FromBase64String(ptcImageTecnologia.);
            //ptcImageTecnologia.Image.Save(ms, ImageFormat.Jpeg);
            // MemoryStream ms = new MemoryStream(pic);

             SqlCommand cmd = new SqlCommand("sp_insertarProducto ", conexion.conexionBD());
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@Imagen", SqlDbType.VarChar).Value = imagen_base64;
             cmd.ExecuteNonQuery();
             MessageBox.Show("Datos registrado correctamente", "Correcto");

        }*/

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
            string codProducto = cboProducto.SelectedValue.ToString();
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
        }
    }
}