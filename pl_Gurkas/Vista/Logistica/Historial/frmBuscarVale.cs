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
    public partial class frmBuscarVale : Form
    {
        public string cod_personal;
        public string nomb_personal;
        private DataTable dt;
        Datos.DataReportes.Logistica.DataLogistica datosLogistica = new Datos.DataReportes.Logistica.DataLogistica();
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();

        public frmBuscarVale()
        {
            InitializeComponent();
        }

        private void frmBuscarVale_Load(object sender, EventArgs e)
        {
            textBox1.Text = cod_personal;
            textBox2.Text = nomb_personal;




            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nombre Personal");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("CondicionEntrega");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Observacion");
            dgvListarVale.DataSource = dt;
            dgvListarVale.RowHeadersVisible = false;
            dgvListarVale.AllowUserToAddRows = false;

            //string cod_personal = cboPersonalActivo.SelectedValue.ToString();
            //dgvListarVale.DataSource = datosLogistica.BuscarProductoVale(cod_personal);
        }
    }
}
