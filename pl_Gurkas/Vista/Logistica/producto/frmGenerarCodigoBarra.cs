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

        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();
        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();


        public frmGenerarCodigoBarra()
        {
            InitializeComponent();
        }


        //Datos.Producto Proveedor = new Datos.Proveedor();

        private void frmGenerarCodigoBarra_Load(object sender, EventArgs e)
        {
            llenadoDatosProducto();
            
        }

        private void button43_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            PanelCodigo.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtCodigoBarra.Text, Color.Black, Color.White, 350, 100);
            btnGuardarCodigo.Enabled = true;
        }

        public void BuscarProducto(string cod_producto)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM T_MAE_PRODUCTO WHERE COD_PRODUCTO_MATERIAL = '" + cod_producto + "'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    //txtCodSistema.Text = recorre["COD_PRODUCTO_SISTEMA"].ToString();
                    txtCodigoBarra.Text = recorre["COD_PRODUCTO_MATERIAL"].ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
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
            string cod_producto = cboProducto.GetItemText(cboProducto.SelectedItem);
            //Llenadocbo.ObtenerSedeLogistica(cboSede, cod_unidad);


        }



        }
    }
}
