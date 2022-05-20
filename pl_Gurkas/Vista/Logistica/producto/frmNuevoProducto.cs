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

        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.Actualizar actualizar = new Datos.Actualizar();
        public frmNuevoProducto()
        {
            InitializeComponent();
        }

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
            if (cboCategoria.SelectedIndex == 0)
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

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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
            int categoriaProduc = cboCategoria.SelectedIndex;
            DateTime fechaCompra = dtpFechaCompra.Value;
            DateTime fechaRegistro = dtpFechaRegistro.Value;
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

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
            int categoriaProduc = cboCategoria.SelectedIndex;
            DateTime fechaCompra = dtpFechaCompra.Value;
            DateTime fechaRegistro = dtpFechaRegistro.Value;
            decimal precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
            int estadoProduct = cboEstadoProduc.SelectedIndex;
            string descripcionProduc = txtDescripcion.Text;
        }

        private void cboEstadoProduc_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            PanelCodigo.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128,txtCodigoBarra.Text,Color.Black,Color.White,350,100);
            btnGuardarCodigo.Enabled = true;

            
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            //Abrimos el explorador de archivos de windows
            if(abrirImagen.ShowDialog() == DialogResult.OK)
            {
                ptcImagen.ImageLocation = abrirImagen.FileName;
                ptcImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {
            //GenerarCodigo();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCodigo_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)PanelCodigo.BackgroundImage.Clone();
            SaveFileDialog Dialogoguardar = new SaveFileDialog();
            Dialogoguardar.AddExtension = true;
            Dialogoguardar.Filter = "Image PNG (*.png) |* .png";
            Dialogoguardar.ShowDialog();
            if(!string.IsNullOrEmpty(Dialogoguardar.FileName))
            {
                imgFinal.Save(Dialogoguardar.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
        }
    }
}
