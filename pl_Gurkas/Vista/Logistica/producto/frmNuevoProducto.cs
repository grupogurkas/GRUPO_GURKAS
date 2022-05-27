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

        public frmNuevoProducto()
        {
            InitializeComponent();
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
        private void llenadoDeDatos()
        {
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidadEquipoTecnologia);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad1);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad2);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad3);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad4);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad5);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad6);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad7);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProducEquipoTecnologia);
            Llenadocbo.ObtenerTallaPrendaProducto(cboTallaPrenda);
            Llenadocbo.ObtenerTallaCalzadoProducto(cboTallaCalzado);
            Llenadocbo.ObtenerTipoCalzadoProducto(cboTipoCalzado);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc1);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc2);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc3);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc4);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc5);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc6);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc7);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc8);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc9);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc10);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc11);
            Llenadocbo.ObtenerTipoTelaProducto(cboTipoTela1);
            Llenadocbo.ObtenerTallaPantalonProducto(cboTallaPantalon);
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
            txtCodSistema.Enabled = false;
            llenadoDeDatos();
            GenerarCodigoPrincipal();
            GenerarCodigoTecnologico();
        }
        private void tabPage1_Click_1(object sender, EventArgs e)
        {
            //GenerarCodigo();
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
                //  DateTime fecha = DateTime.Now;
                //  obtenerip_nombre();
                // string username = Code.nivelUser._nombre;
                // string detalle = "Cerrar Registro de Personal";
                // string cod_buscado = "Cerro el registro de Personal";
                // registrar.RegistrarRRHH(fecha, nombrepc, username, ipuser, cod_buscado, detalle);
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

                logisticaInsertar.RegistrarEquipoTecnologico( cod_sistema,  cod_producto,  nombre_producto,  modelo, 
                    marca,  num_serie,  desp_equipo,  estado,  precio_unitario,  tipo_unidad,stock_inicial,  
                    stock_actual,  stock_minimo,  f_adquision,  f_registro,  observacion);
                MessageBox.Show("Datos registrado correptamente", "Correpto");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se puede Regristrar el producto", "Error");
            }
        }
    }
}