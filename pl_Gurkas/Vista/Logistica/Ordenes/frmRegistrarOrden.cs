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

namespace pl_Gurkas.Vista.Logistica.Ordenes
{
    public partial class frmRegistrarOrden : Form
    {


        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.ConexionMysql conexionmysql = new Datos.ConexionMysql();
        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();
        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();
        private Timer ti;
        private DataTable dt;
        int i = 0;
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;
        public frmRegistrarOrden()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerProveedoresLogistico(cboProveedorActivo);
            Llenadocbo.ObtenerProducto(cboProducto);
            txtNumOrden.Enabled = false;
            txtCostoTotal.Enabled = false;

        }




        private void groupBox2_Enter(object sender, EventArgs e)
        {

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {
            txtObservacion.MaxLength = 18;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cod_provedor = cboProveedorActivo.SelectedValue.ToString();

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

        public void GenerarNumOrden()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("SELECT ROW_NUMBER()OVER(ORDER BY NUM_ENTREGA)AS 't'  FROM t_entrega_producto_vale GROUP BY NUM_ENTREGA", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            if (resultado.Equals(""))
            {
                resultado = "0";
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtNumOrden.Text = "LOG-000000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtNumOrden.Text = "LOG-00000" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtNumOrden.Text = "LOG-0000" + (numero + 1);
            }
            if (numero > 9999 && numero < 10000)
            {
                txtNumOrden.Text = "LOG-000" + (numero + 1);
            }
        }


    }
}
