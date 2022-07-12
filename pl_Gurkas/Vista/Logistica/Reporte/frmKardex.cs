using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
