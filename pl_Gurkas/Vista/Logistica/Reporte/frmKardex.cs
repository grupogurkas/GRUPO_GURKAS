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

        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.ConexionMysql conexionmysql = new Datos.ConexionMysql();
        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();

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

                    SqlCommand comando = new SqlCommand("select *from t_proveedor where cod_proveedor = '" + cod_provedor + "'", conexion.conexionBD());

                    SqlDataReader recorre = comando.ExecuteReader();
                    while (recorre.Read())
                    {
                        txtProveedor.Text = recorre["nomb_proveedor"].ToString();
                        txtruc.Text = recorre["ruc"].ToString();
                        txtNombreProveedor.Text = recorre["nomb_contacto"].ToString();
                        txtDireccion.Text = recorre["direccion"].ToString();
                        txtCorreo.Text = recorre["correo"].ToString();
                        txtTelefono.Text = recorre["telefono"].ToString();
                        txtCelular.Text = recorre["celular"].ToString();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
                }
            }
        }
    }
}
