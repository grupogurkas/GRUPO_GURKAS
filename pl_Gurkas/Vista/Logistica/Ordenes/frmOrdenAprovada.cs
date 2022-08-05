using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.Logistica.Ordenes
{
    public partial class frmOrdenAprovada : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LlenadoDatos.llenadoDatosLogistica Llenadocbo = new Datos.LlenadoDatos.llenadoDatosLogistica();

        public frmOrdenAprovada()
        {
            InitializeComponent();
        }

        private void frmOrdenAprovada_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerOrdenCompr(cboNombreProductoTecnologico);
            DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
            dgvCmb.HeaderText = "OrdenCompra";
            Llenadocbo.ObtenerOrdenesComprar(dgvCmb);
            dgvCmb.Name = "OrdenCompra";
            dgvAsistencia.Columns.Add(dgvCmb);

            //dgvPersonalEstatura.RowHeadersVisible = false;
            //dgvPersonalEstatura.AllowUserToAddRows = false;
        }
    }
}
