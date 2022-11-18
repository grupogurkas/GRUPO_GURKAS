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
    public partial class frmHistorialDeProductos : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        public frmHistorialDeProductos()
        {
            InitializeComponent();
        }

        private void frmHistorialDeProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = conexion.conexionBD().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SP_BUSCAR_DATOS_ALMACEN ";
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(comando);
                dta.Fill(dt);
                dt.Columns[0].ColumnName = "Codigo Producto";
                dt.Columns[1].ColumnName = "Nombre Producto";
                dt.Columns[2].ColumnName = "STOCK INICIAL";
                dt.Columns[3].ColumnName = "STOCK ACTUAL";
                dt.Columns[4].ColumnName = "STOCK MINIMO";
                dt.AcceptChanges();
                dgvMarcacionFechaTurno.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro nungun resultado \n\n " + ex, "ERROR");
            }
        }
    }
}
