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
        Datos.LlenadoDatos.llenadoDatosLogistica Llenadocbo = new Datos.LlenadoDatos.llenadoDatosLogistica();
        Datos.CRUD.Logistica.Actualizar.LogisticaActualizar logisticaActualizar = new Datos.CRUD.Logistica.Actualizar.LogisticaActualizar();
        public frmRecuperarMaterial()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            cboProducto.SelectedIndex = 0;
            txtstock.Text = "0";
            txtcodigo.Text = "S/C";
            cboMterialRecuperado.SelectedIndex = 0;
            txtCodigoRecuperable.Text = "S/C";
            txtstock_recuperable.Text = "0";
            txtresumend.Text = "0";
            txtrecuperabler.Text = "0";
            txtrestanter.Text = "0";
        }
        private void frmRecuperarMaterial_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerProducto(cboProducto);
            Llenadocbo.ObtenerProducto(cboMterialRecuperado);
            txtstock.Enabled = false;
            txtcodigo.Enabled = false;
            txtstock.Text = "0";
            txtcodigo.Text = "S/C";
            txtCodigoRecuperable.Enabled = false;
            txtCodigoRecuperable.Text = "S/C";
            txtstock_recuperable.Text = "0";

            txtresumend.Enabled = false;
            txtrecuperabler.Enabled = false;
            txtrestanter.Enabled = false;

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
                    txtresumend.Text = recorre["CANTIDA_DEVUELTA"].ToString();
                    txtcodigo.Text = cod_producto;
                }
            }
        }

        private void cboMterialRecuperado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedValue.ToString() != null)
            {
                string cod_producto = cboMterialRecuperado.SelectedValue.ToString();
                txtCodigoRecuperable.Text = cod_producto;
            }
        }

        private void txtstock_recuperable_TextChanged(object sender, EventArgs e)
        {
            txtresumend.Text = txtstock.Text;
            txtrecuperabler.Text = txtstock_recuperable.Text;
            try
            {
                int stock_disponible = Convert.ToInt32(txtresumend.Text);
                int stock_recuperable = Convert.ToInt32(txtrecuperabler.Text);
                //  int stock_restante = Convert.ToInt32(txtrestanter.Text);

                int cantidad = stock_disponible - stock_recuperable;
                txtrestanter.Text = cantidad.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("GAAA");
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            int stock_disponible = Convert.ToInt32(txtresumend.Text);
            int stock_recuperable = Convert.ToInt32(txtrecuperabler.Text);
            int stock_restante = Convert.ToInt32(txtrestanter.Text);
            string cod_producto_n = cboProducto.SelectedValue.ToString();
            string cod_producto_r = cboMterialRecuperado.SelectedValue.ToString();

            string producto = cboProducto.GetItemText(cboProducto.SelectedItem).ToUpper();
            string producto_re = cboMterialRecuperado.GetItemText(cboMterialRecuperado.SelectedItem).ToUpper();

            const string titulo = "Recuperar Material";
            string mensaje = "Estas seguro que deseas recuperar la cantidad de " + stock_recuperable.ToString() + " de " + stock_disponible.ToString()
            +" Disponible, del producto : "    + producto;
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                logisticaActualizar.actualizarstockmaterialrecuperable( stock_disponible,  stock_recuperable,  stock_restante,
                cod_producto_n,  cod_producto_r);
                MessageBox.Show("Stock actualizado correptamente", "Correpto");
                limpiar();
            }
        }
    }
}
