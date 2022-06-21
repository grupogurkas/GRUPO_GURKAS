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
    public partial class frmBuscarVale : Form
    {
        Datos.DataReportes.Logistica.DataLogistica datosLogistica = new Datos.DataReportes.Logistica.DataLogistica();
        public string _nomPersonal;
        public string _codPersonal;
        private DataTable dt;


        public frmBuscarVale()
        {
            InitializeComponent();
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmBuscarVale_Load(object sender, EventArgs e)
        {
            txtNombPersonal.Text = _nomPersonal;
            txtCodPersonal.Text = _codPersonal;


            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("CodProducto");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("CondicionEntrega");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Observacion");
            dgvBuscarVale.DataSource = dt;

            DataGridViewButtonColumn btnclm = new DataGridViewButtonColumn();
            btnclm.Name = "Eliminar";
            dgvBuscarVale.Columns.Add(btnclm);

            dgvBuscarVale.RowHeadersVisible = false;
            dgvBuscarVale.AllowUserToAddRows = false;

            string cod_personal = txtCodPersonal.Text;
            dgvBuscarVale.DataSource = datosLogistica.BuscarVale(cod_personal);
        }
    }
}
