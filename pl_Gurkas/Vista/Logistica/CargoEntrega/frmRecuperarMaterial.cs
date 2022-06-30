using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.Logistica.CargoEntrega
{
    public partial class frmRecuperarMaterial : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();

        public frmRecuperarMaterial()
        {
            InitializeComponent();
        }

        private void frmRecuperarMaterial_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerProducto(cboProducto);
            txtstock.Enabled = false;
            txtcodigo.Enabled = false;
            txtstock.Text = "0";
            txtcodigo.Text = "S/C";
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedValue.ToString() != null)
            {
                string cod_producto = cboProducto.SelectedValue.ToString();
                SqlCommand comando = new SqlCommand("SELECT * FROM T_STOCK_DEVUELTO WHERE COD_PRODUCTO_MATERIAL = '" + cod_producto + "'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtstock.Text = recorre["CANTIDA_DEVUELTA"].ToString();
                    txtcodigo.Text = cod_producto;
                }
            }
        }
    }
}
