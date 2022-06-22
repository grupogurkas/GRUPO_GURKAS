using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.Logistica.CargoEntrega
{
    public partial class frmBuscarEmpleado : Form
    {
        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();
        public frmBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void frmBuscarEmpleado_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerPersonalRRHH(cboPersonalActivo);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Vista.Logistica.CargoEntrega.frmHistorialProductoEmpleado frmBuscarValeSalida = new Vista.Logistica.CargoEntrega.frmHistorialProductoEmpleado();
            frmBuscarValeSalida.cod_personal = cboPersonalActivo.SelectedValue.ToString();
            frmBuscarValeSalida.nomb_personal = cboPersonalActivo.GetItemText(cboPersonalActivo.SelectedItem);
            frmBuscarValeSalida.ShowDialog();
        }
    }
}
