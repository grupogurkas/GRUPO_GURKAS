using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.Reclamo
{
    public partial class frmReclamoEmpleado : Form
    {
        Datos.ConexionMysql conexion = new Datos.ConexionMysql();
        Datos.frmLlenadoDeDatosCentroControl Llenadocbo = new Datos.frmLlenadoDeDatosCentroControl();
        Datos.agregarDatosMysql Registrarmysql = new Datos.agregarDatosMysql();
        Datos.LlenadoDeDatos Llenadocbos = new Datos.LlenadoDeDatos();
        Datos.actualizarmysql actualizarmysql = new Datos.actualizarmysql();
        Datos.registrar registrar = new Datos.registrar();
        public frmReclamoEmpleado()
        {
            InitializeComponent();
        }

        public void traer_Datos()
        {
            MySqlCommand comand;
            string query = "SELECT * FROM  v_reclamos";
            comand = new MySqlCommand(query, conexion.ObtenerConexion());
            comand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter dta = new MySqlDataAdapter(comand);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "NUM TICKECT";
            dt.Columns[1].ColumnName = "FECHA";
            dt.Columns[2].ColumnName = "MARCACION";
            dt.Columns[3].ColumnName = "UNIDAD";
            dt.Columns[4].ColumnName = "SEDE";
            dt.Columns[5].ColumnName = "EMPLEDO";
            dt.Columns[6].ColumnName = "OBSERVACION";
            dt.Columns[7].ColumnName = "ID_ESTADO_TICKEC";
            dt.Columns[8].ColumnName = "COD_EMPLEADO";
            dt.AcceptChanges();
            dgvAsistencia.DataSource = dt;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            traer_Datos();
        }

        private void frmReclamoEmpleado_Load(object sender, EventArgs e)
        {
            Llenadocbos.ObtenerTipoReclamo(cboEstado);
            dgvAsistencia.RowHeadersVisible = false;
            dgvAsistencia.AllowUserToAddRows = false;
        }

        private void dgvAsistencia_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string cod_asistencia = dgvAsistencia.CurrentRow.Cells[0].Value.ToString();
                int id = Convert.ToInt32(cod_asistencia);
                MySqlCommand comand = new MySqlCommand("SELECT * from v_reclamos_busqueda WHERE ID_RECLAMO = " + id, conexion.ObtenerConexion());
                MySqlDataReader recorre = comand.ExecuteReader();
                while (recorre.Read())
                {
                    txtticek.Text = recorre["ID_RECLAMO"].ToString();
                    txtFecha.Text = recorre["Fecha"].ToString();
                    txtMarcacion.Text = recorre["Marcacion"].ToString();
                    txtUnidad.Text = recorre["Unidad"].ToString();
                    txtSede.Text = recorre["Sede"].ToString();
                    txtNombreEmp.Text = recorre["nombre"].ToString();
                    txtMensaje.Text = recorre["Observacion"].ToString();
                    cboEstado.SelectedIndex = Convert.ToInt32(recorre["ID_TICKETS"].ToString());
                    txtCodEmpleado.Text = recorre["COD_EMPLEADO"].ToString();
                }

                txtticek.Enabled = false;
                txtFecha.Enabled = false;
                txtMarcacion.Enabled = false;
                txtUnidad.Enabled = false;
                txtSede.Enabled = false;
                txtNombreEmp.Enabled = false;
                txtMensaje.Enabled = false;
                txtCodEmpleado.Enabled = false;

            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string numticke = txtticek.Text ;
            string fecha = txtFecha.Text;
            string marcacion = txtMarcacion.Text ;
            string unidad = txtUnidad.Text ;
            string sede = txtSede.Text ;
            string nombre = txtNombreEmp.Text ;
            string  mensaje = txtMensaje.Text ;
            int estado = cboEstado.SelectedIndex ;
            string cod_empleado = txtCodEmpleado.Text;
            string observacion = txtObservacion.Text;
            if (estado == 4)
            {
                registrar.RegistrarReclamo(numticke, fecha, marcacion, unidad, sede, nombre,
                   mensaje, estado, cod_empleado, observacion);
                actualizarmysql.ActualizarPersonalUsuario(cod_empleado, numticke, estado);
                MessageBox.Show("Datos actualizado", "Actualizado");
                traer_Datos();
            }
            else if (estado == 2)
            {
                actualizarmysql.ActualizarPersonalUsuario(cod_empleado, numticke, estado);
                MessageBox.Show("Datos actualizado" , "Actualizado");
                traer_Datos();
            }
            else if (estado == 3)
            {
                registrar.RegistrarReclamo(numticke, fecha, marcacion, unidad, sede, nombre,
                mensaje, estado, cod_empleado, observacion);
                actualizarmysql.ActualizarPersonalUsuario(cod_empleado, numticke, estado);
                MessageBox.Show("Datos actualizado", "Actualizado");
                traer_Datos();
            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstado.SelectedIndex == 0)
            {
                txtObservacion.Text = "NO TIENE OBSERVACION";
                txtObservacion.Enabled = false;
            }
            else if (cboEstado.SelectedIndex == 1)
            {
                txtObservacion.Text = "NO TIENE OBSERVACION";
                txtObservacion.Enabled = false;
            }
            else if (cboEstado.SelectedIndex == 2)
            {
                txtObservacion.Text = "NO TIENE OBSERVACION";
                txtObservacion.Enabled = false;
            }
            else if (cboEstado.SelectedIndex == 3)
            {
                txtObservacion.Text = "";
                txtObservacion.Enabled = true;
            }
            else if (cboEstado.SelectedIndex == 4)
            {
                txtObservacion.Text = "NO TIENE OBSERVACION";
                txtObservacion.Enabled = true;
            }
        }
    }
    
}
