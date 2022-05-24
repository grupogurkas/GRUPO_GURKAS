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

namespace pl_Gurkas.Vista.Logistica.producto
{
    
    public partial class frmNuevoProducto : Form
    {
        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();
        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.Actualizar actualizar = new Datos.Actualizar();
        public frmNuevoProducto()
        {
            InitializeComponent();
        }

        /*public void GenerarCodigo()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("select count(cod_proveedor) as 't' from t_proveedor ", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtcodproveedor.Text = "PROV000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtcodproveedor.Text = "PROV00" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtcodproveedor.Text = "PROV0" + (numero + 1);
            }
        }*/

        private void ValidarCamposVacios()
        {
            if(txtCodEquipo.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
            if (txtNombreEquip.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un nombre", "Advertencia");
            }
            if (txtModelo.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
            if (txtMarca.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
            if (txtDescripcion.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
            if (txtStockInicial.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
 
            if (txtPrecioCompra.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
            if (cboEstadoProduc.SelectedIndex == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
            if (txtObservacion.Text.Length == 0)
            {
                MessageBox.Show("Debe Insertar un codigo", "Advertencia");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Registro de Personal";
            const string mensaje = "Estas seguro que deseas cerra el Registro de Personal";
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

       

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad1);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad2);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad3);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad4);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad5);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad6);
            Llenadocbo.ObtenerTipoUnidadProducto(cboTipoUnidad7);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoProduc);
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
            Llenadocbo.ObtenerTipoTelaProducto(cboTipoTela);
            Llenadocbo.ObtenerTipoTelaProducto(cboTipoTela1);
            Llenadocbo.ObtenerTallaPantalonProducto(cboTallaPantalon);
            txtCodSistema.Enabled = false;
            //GenerarCodigo();
        }
        

        private void label11_Click(object sender, EventArgs e)
        {

         }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ValidarCamposVacios();
            string codSistema = txtCodSistema.Text;
            string codEquipo = txtCodEquipo.Text;
            string nomEquipo = txtNombreEquip.Text;
            string modelo = txtModelo.Text;
            string marca = txtMarca.Text;
            string descripcionProduct = txtDescripcion.Text;
            int stockIni = (int)Convert.ToInt64(txtStockInicial.Text);
            //int categoriaProduc = cboCategoria.SelectedIndex;
            //DateTime fechaCompra = dtpFechaCompra.Value;
            //DateTime fechaRegistro = dtpFechaRegistro.Value;
            decimal precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
            int estadoProduct = cboEstadoProduc.SelectedIndex;
            string descripcionProduc = txtDescripcion.Text;


           ;


            //
            const string titulo = "Actualizar datos en el Sistema";
            const string mensaje = "Por favor verificar  la Imformacion antes de guardar en el sistema \n SI  =  GUARDAR IMFORMACION \n NO  =  VERIFICAR DATOS ANTES DE GUARDAR";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                MessageBox.Show("Datos Laborados Actualizado Exitosamente", "Registrado");
            }

            MessageBox.Show("Datos registrado correctamente" + codSistema   +codEquipo ,nomEquipo+ "Correcto");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos.LimpiarGroupBox(groupBox2);
            txtCodSistema.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codProducto = cboProducto.SelectedValue.ToString();


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ValidarCamposVacios();
            ActualizarProducto();


        }

        private void ActualizarProducto()
        {

            string codSistema = txtCodSistema.Text;
            string codEquipo = txtCodEquipo.Text;
            string nomEquipo = txtNombreEquip.Text;
            string modelo = txtModelo.Text;
            string marca = txtMarca.Text;
            string descripcionProduct = txtDescripcion.Text;
            int stockIni = (int)Convert.ToInt64(txtStockInicial.Text);
            //int categoriaProduc = cboCategoria.SelectedIndex;
            //DateTime fechaCompra = dtpFechaCompra.Value;
            //DateTime fechaRegistro = dtpFechaRegistro.Value;
            decimal precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
            int estadoProduct = cboEstadoProduc.SelectedIndex;
            string descripcionProduc = txtDescripcion.Text;
        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {
            //GenerarCodigo();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tbpUniforme_Click(object sender, EventArgs e)
        {

        }
    

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void textBox90_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button56_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarDatos_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            //Abrimos el explorador de archivos de windows
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                ptcImagen.ImageLocation = abrirImagen.FileName;
                ptcImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void cboTipoTela_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btcPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubirImage(object sender, EventArgs e)
        {

        }
    }
}
