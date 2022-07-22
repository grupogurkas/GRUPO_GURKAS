using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.Logistica.producto
{
    public partial class frmGenerarCodigoBarra : Form
    {

        Datos.LlenadoDatos.llenadoDatosLogistica Llenadocbo = new Datos.LlenadoDatos.llenadoDatosLogistica();
        public frmGenerarCodigoBarra()
        {
            InitializeComponent();
        }
        private void frmGenerarCodigoBarra_Load(object sender, EventArgs e)
        {
            llenadoDatosProducto();
           txtCodigoBarra.Enabled = false;

        }
        public void generarcodigo()
        {
            if(txtCodigoBarra.Text != "")
            {
                BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                Codigo.IncludeLabel = true;
                PanelCodigo.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtCodigoBarra.Text, Color.Black, Color.White, 350, 100);
                btnGuardarCodigo.Enabled = true;
            }
            
        }
            

        private void button43_Click(object sender, EventArgs e)
        {

           // BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
          //  Codigo.IncludeLabel = true;
          //PanelCodigo.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, cboCodigoBarra.Text, Color.Black, Color.White, 350, 100);
          //  btnGuardarCodigo.Enabled = true;
        }

        private void btnGuardarCodigo_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)PanelCodigo.BackgroundImage.Clone();
            SaveFileDialog Dialogoguardar = new SaveFileDialog();
            Dialogoguardar.AddExtension = true;
            Dialogoguardar.Filter = "Image PNG (*.png) |* .png";
            Dialogoguardar.ShowDialog();
            if (!string.IsNullOrEmpty(Dialogoguardar.FileName))
            {
                imgFinal.Save(Dialogoguardar.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
        }

        private void llenadoDatosProducto()
        {
            Llenadocbo.ObtenerProductosGeneral(cboProducto);


        }
        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cod_producto = cboProducto.SelectedValue.ToString();
            /*Para hacer llamado por Combobox
            Llenadocbo.ObtenerSedeLogistica(cboSede, cod_unidad);*/
            //Para hacer llamado por texto
            txtCodigoBarra.Text = cod_producto;
            generarcodigo();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Registro de Personal";
            const string mensaje = "Estas seguro que deseas cerra el Registro de Personal";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
