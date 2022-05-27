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
        Datos.Actualizar actualizar = new Datos.Actualizar();
        Datos.Producto po = new Datos.Producto();
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
        public void LimpiarDatosCamisas()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox1);
            txtNombreCamisas.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox5);
            GenerarCodigoTecnologico();
            GenerarCodigoCamisas();
            GenerarCodigoPrincipal();
            Llenadocbo.ObtenerProductoCamisas(cboProductoCamisas);
        }
        public void LimpiarDatosTecnologico()
        {
            LimpiarDatos.LimpiarGroupBox(groupBox2);
            txtNombreEquipoTecnologia.Focus();
            LimpiarDatos.LimpiarGroupBox(groupBox13);
            GenerarCodigoTecnologico();
            GenerarCodigoCamisas();
            GenerarCodigoPrincipal();
            Llenadocbo.ObtenerProductoTecnologico(cboNombreProductoTecnologico);
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
        private void llenadoDeDatos()
        {
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad1);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad2);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad3);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad4);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad5);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad6);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad7);
            Llenadocbo.ObtenerTallaCalzadoProducto(cboTallaCalzado);
            Llenadocbo.ObtenerTipoCalzadoProducto(cboTipoCalzado);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoCalzado);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoPantalon);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc4);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc5);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc6);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc7);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc8);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc9);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc10);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc11);
            Llenadocbo.ObtenerTipoTelaProducto(cboTipoTelaPantalon);
            Llenadocbo.ObtenerTallaPantalonProducto(cboTallaPantalon);
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
        private void ValidarCamposVacios()
        {
            if(txtCodEquipoTecnologia.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
            if (txtNombreEquipoTecnologia.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un nombre", "Advertencia");
            }
            if (txtModeloEquipoTecnologia.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
            if (txtMarcaEquipoTecnologia.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
            if (txtDescripcionEquipoTecnologia.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
            if (txtNumSerialEquipoTecnologia.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
 
            if (txtPrecioUnitarioEquipoTecnologia.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
            if (cboEstadoProducEquipoTecnologia.SelectedIndex == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
            if (txtObservacionEquipoTecnologia.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
        }

        
        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            txtCodEquipoTecnologia.Enabled = false;
            txtcodcamisas.Enabled = false;
            txtCodSistema.Enabled = false;
            llenadoDeDatos();
            GenerarCodigoPrincipal();
            llenadoProductoTecnologico();
            llenadoDatosCamisas();
            GenerarCodigoTecnologico();
            GenerarCodigoCamisas();
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

        private void dtpFechaRegistro_ValueChanged(object sender, EventArgs e)
        {

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
    }
}