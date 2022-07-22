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

namespace pl_Gurkas.Vista.Logistica.Inventario
{
    public partial class frmKardex : Form
    {

        Datos.LlenadoDatos.llenadoDatosLogistica Llenadocbo = new Datos.LlenadoDatos.llenadoDatosLogistica();
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();


        public frmKardex()
        {
            InitializeComponent();
        }

        private void frmKardex_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerProducto(cboProductos);
            txtUsuarioEntrega.Enabled = false;
            string nombre_user = Datos.DatosUsuario._usuario;
            txtUsuarioEntrega.Text = nombre_user;
            DateTime fecha_actual = DateTime.Now;
            //string dia = Convert.ToString(fecha_actual.Day);
            string mes = Convert.ToString(fecha_actual.Month);
            string año = Convert.ToString(fecha_actual.Year);
            txtanio.Text = año;
            txtmes.Text = mes;
            txtCantidad.Enabled = false;
            txtanio.Enabled = false;
            txtmes.Enabled = false;
            txtCostoTotal.Enabled = false;
            Llenadocbo.ObtenerUnidadRRHH(cboUnidad);
            Llenadocbo.ObtenerEmpresa(cboEmpresa);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Registro de Producto";
            const string mensaje = "Estas seguro que deseas cerra el Registro de Producto";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboProductos.SelectedValue.ToString() != null)
            {
                try
                {
                    string cod_producto = cboProductos.SelectedValue.ToString();

                    SqlCommand comando = new SqlCommand("select * from T_MAE_PRODUCTO where COD_PRODUCTO_MATERIAL = '" + cod_producto + "'", conexion.conexionBD());

                    SqlDataReader recorre = comando.ExecuteReader();
                    while (recorre.Read())
                    {
                       txtCantidad.Text = recorre["STOCK_ACTUAL"].ToString();
                     ///   txtruc.Text = recorre["ruc"].ToString();
                     //   txtNombreProveedor.Text = recorre["nomb_contacto"].ToString();
                    //    txtDireccion.Text = recorre["direccion"].ToString();
                    //    txtCorreo.Text = recorre["correo"].ToString();
                    //    txtTelefono.Text = recorre["telefono"].ToString();
                     //   txtCelular.Text = recorre["celular"].ToString();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
                }
            }
        }

        private void cboUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUnidad.SelectedValue.ToString() != null)
            {
                string cod_unidad = cboUnidad.SelectedValue.ToString();
                Llenadocbo.ObtenerSedeLogistica(cboSede, cod_unidad);
            }

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "" && txtCostoUnit.Text != "")
            {
                double n1, n2, r;
                n1 = Convert.ToDouble(txtCantidad.Text);
                n2 = Convert.ToDouble(txtCostoUnit.Text);
                r = n1 * n2;
                txtCostoTotal.Text = r.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
