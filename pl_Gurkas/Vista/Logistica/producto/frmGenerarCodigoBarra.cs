using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.Logistica.producto
{
    public partial class frmGenerarCodigoBarra : Form
    {

        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();

        public frmGenerarCodigoBarra()
        {
            InitializeComponent();
        }


        //Datos.Producto Proveedor = new Datos.Proveedor();

        private void frmGenerarCodigoBarra_Load(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            PanelCodigo.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtCodigoBarra.Text, Color.Black, Color.White, 350, 100);
            btnGuardarCodigo.Enabled = true;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
