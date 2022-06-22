using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.Logistica.Historial
{
    public partial class frmHistorialOrdenCompra : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.ConexionMysql conexionmysql = new Datos.ConexionMysql();
        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();
        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();
        public frmHistorialOrdenCompra()
        {
            InitializeComponent();
        }

        private void frmHistorialOrdenCompra_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerPersonalRRHH(cboPersonalActivo);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Vista.Logistica.Historial.frmBuscarVale frmBuscarVale = new frmBuscarVale();
            frmBuscarVale.cod_personal = cboPersonalActivo.SelectedValue.ToString();
            frmBuscarVale.nomb_personal = cboPersonalActivo.GetItemText(cboPersonalActivo.SelectedItem);

            frmBuscarVale.ShowDialog();

            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
