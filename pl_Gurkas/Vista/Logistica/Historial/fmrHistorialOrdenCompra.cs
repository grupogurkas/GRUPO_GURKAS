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

namespace pl_Gurkas.Vista.Logistica.Historial
{
    public partial class fmrHistorialOrdenCompra : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.ConexionMysql conexionmysql = new Datos.ConexionMysql();
        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();
        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();

        public fmrHistorialOrdenCompra()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarVale_Click(object sender, EventArgs e)
        {
            Vista.Logistica.Historial.frmBuscarVale frmBuscarVale = new frmBuscarVale();
            frmBuscarVale._codPersonal = cboPersonalActivo.SelectedValue.ToString();
            frmBuscarVale._nomPersonal = "";
            

            frmBuscarVale.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Registro de asistencia del  Personal";
            const string mensaje = "Estas seguro que deseas cerra el Registro de asistencia del Personal";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                DateTime fecha = DateTime.Now;
                string detalle = "Salio del modulo de asistencia";
                string accion = "Cerro el Registro de asistencia del  Personal";

                this.Close();
            }
        }

        private void fmrHistorialOrdenCompra_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerPersonalRRHH(cboPersonalActivo);

        }

        private void cboPersonalActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
           /*if (cboPersonalActivo.SelectedValue.ToString() != null)
            {
                try
                {
                    string cod_provedor = cboPersonalActivo.SelectedValue.ToString();

                    SqlCommand comando = new SqlCommand("select *from t_proveedor where cod_proveedor = '" + cod_provedor + "'", conexion.conexionBD());

                    SqlDataReader recorre = comando.ExecuteReader();
                    while (recorre.Read())
                    {
                        txtNombPersonal.Text = recorre["nomb_proveedor"].ToString();
                        txtCodPersonal.Text = recorre["cod_proveedor"].ToString();

                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
                }
            }*/
        }
    }
}
