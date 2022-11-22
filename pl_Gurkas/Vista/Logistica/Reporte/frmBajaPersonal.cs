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

namespace pl_Gurkas.Vista.Logistica.Reporte
{
    public partial class frmBajaPersonal : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        public frmBajaPersonal()
        {
            InitializeComponent();
        }

        private void frmBajaPersonal_Load(object sender, EventArgs e)
        {

        }
        private void ConsultarAgentesRetirados(DateTime f1 ,DateTime f2)
        {

            try
            {
                SqlCommand comando = conexion.conexionBD().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "sp_agentes_retirados_consulta  @f_inicio,@f_fin";
                comando.Parameters.AddWithValue("f_inicio", f1);
                comando.Parameters.AddWithValue("f_fin", f2);
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(comando);
                dta.Fill(dt);
                dt.Columns[0].ColumnName = "Cod Producto";
                dt.Columns[1].ColumnName = "Nombre Producto";
                dt.Columns[2].ColumnName = "Nombre del Agente";
                dt.Columns[3].ColumnName = "Estado";
                dt.Columns[4].ColumnName = "Fecha Baja";
                dt.AcceptChanges();
                dgvReporteGeneral.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro nungun resultado \n\n " + ex, "ERROR");
            }

        }
        private void btnConsultarPersonalEmpresa_Click(object sender, EventArgs e)
        {
            ConsultarAgentesRetirados(dtpFechaInicio.Value, dtpFechaFin.Value);
        }
    }
}
