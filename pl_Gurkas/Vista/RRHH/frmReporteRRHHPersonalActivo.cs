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

namespace pl_Gurkas.Vista.RRHH
{
    public partial class frmReporteRRHHPersonalActivo : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();
        Datos.LLenadoDatosRRHH Llenadocbo = new Datos.LLenadoDatosRRHH();
        Datos.registrar registrar = new Datos.registrar();
        Datos.Actualizar actualizar = new Datos.Actualizar();
        ExportacionExcel.RRHH.ExportarDataExcelRRHH Excel = new ExportacionExcel.RRHH.ExportarDataExcelRRHH();
        public frmReporteRRHHPersonalActivo()
        {
            InitializeComponent();
        }

        private void frmReporteRRHHPersonalActivo_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerEmpresaRRHHGeneral(cboEmpresa);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id_empresa = cboEmpresa.SelectedIndex;
            try
            {
                SqlCommand comando = conexion.conexionBD().CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "sp_personal_activo  @id_empresa";
                comando.Parameters.AddWithValue("id_empresa", id_empresa);
                comando.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(comando);
                dta.Fill(dt);
                dt.Columns[0].ColumnName = "Cod Empleado";
                dt.Columns[1].ColumnName = "Apellido Paterno";
                dt.Columns[2].ColumnName = "Apellido Materno";
                dt.Columns[3].ColumnName = "Nombre Completo";
                dt.Columns[4].ColumnName = "Fecha Inicio Laboral";
                dt.Columns[5].ColumnName = "Fecha Nacimiento";
                dt.Columns[6].ColumnName = "Unidad";
                dt.Columns[7].ColumnName = "Turno";
                dt.Columns[8].ColumnName = "Puesto";
                dt.Columns[9].ColumnName = "Tipo Documento";
                dt.Columns[10].ColumnName = "Doct Identidad";
                dt.Columns[11].ColumnName = "Estado";
                dt.Columns[12].ColumnName = "Empresa";
                dt.Columns[13].ColumnName = "Direccion";
                dt.Columns[14].ColumnName = "Telefono";
                dt.Columns[15].ColumnName = "Celular";
                dt.Columns[16].ColumnName = "Correo";
                dt.Columns[17].ColumnName = "Provincia";
                dt.Columns[18].ColumnName = "Departamento";
                dt.Columns[19].ColumnName = "Distrito";
                dt.AcceptChanges();
                dgvRegistroPersonal.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro nungun resultado \n\n " + ex, "ERROR");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string empresa = cboEmpresa.GetItemText(cboEmpresa.SelectedItem);
            Excel.ExportarDatosPersonalActivo(dgvRegistroPersonal, progressBar1,empresa);
        }
    }
}
