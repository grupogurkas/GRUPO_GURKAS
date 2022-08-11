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

        private void btnBuscarProductoTecnologia_Click(object sender, EventArgs e)
        {
            string cod_orden_compra = cboNombreProductoTecnologico.SelectedValue.ToString();

            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "sp_buscar_datos_orden_compra @cod_orden_compra";
            comando.Parameters.AddWithValue("cod_orden_compra", cod_orden_compra);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "Cod Producto";
            dt.Columns[1].ColumnName = "Descripcion del Producto";
            dt.Columns[2].ColumnName = "Cantidad Solicitada";
            dt.Columns[3].ColumnName = "Precio Unitario";
            dt.Columns[4].ColumnName = "Precio Total";
            dt.AcceptChanges();
            dgvAsistencia.DataSource = dt;
        }
        private void showDialogs(String message, Color bdColor)
        {
            Vista.MensajeEmergente.DialogForm dialog = new Vista.MensajeEmergente.DialogForm(message, bdColor);
            dialog.Show();
        }
        private void btnActualizarProductoTecnologico_Click(object sender, EventArgs e)
        {

            string cod_orden_compra = cboNombreProductoTecnologico.SelectedValue.ToString();

            const string titulo = "Guardar Datos en el Sistema";
            const string mensaje = "Porfavor verificar  la asistencia antes de guardar en el sistema \n SI  =  GUARDAR IMFORMACION \n NO  =  VERIFICACION DE DATOS";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {

                try
                {
                    SqlCommand comando = new SqlCommand("sp_registar_actualzar_stock @Cod_Producto, @cod_orden_compra, @Descripcion_del_Producto, @Cantidad_Solicitada, @Precio_Unitario,@Precio_Total,@estado_orden,@OrdenCompra", conexion.conexionBD());

                    foreach (DataGridViewRow row in dgvAsistencia.Rows)
                    {
                        if (row.Cells["Cod Producto"].Value != null && row.Cells["Descripcion del Producto"].Value != null
                            && row.Cells["Cantidad Solicitada"].Value != null && row.Cells["Precio Unitario"].Value != null
                             && row.Cells["Precio Total"].Value != null)
                        {
                            comando.Parameters.Clear();
                            comando.Parameters.AddWithValue("@Cod_Producto", Convert.ToString(row.Cells["Cod Producto"].Value));
                            comando.Parameters.AddWithValue("@cod_orden_compra", SqlDbType.VarChar).Value = cod_orden_compra;
                            comando.Parameters.AddWithValue("@Descripcion_del_Producto", Convert.ToString(row.Cells["Descripcion del Producto"].Value));
                            comando.Parameters.AddWithValue("@Cantidad_Solicitada", Convert.ToInt32(row.Cells["Cantidad Solicitada"].Value));
                            comando.Parameters.AddWithValue("@Precio_Unitario", Convert.ToDecimal(row.Cells["Precio Unitario"].Value));
                            comando.Parameters.AddWithValue("@Precio_Total", Convert.ToDecimal(row.Cells["Precio Total"].Value));
                            comando.Parameters.AddWithValue("@estado_orden", SqlDbType.Int).Value = 2;
                            comando.Parameters.AddWithValue("@OrdenCompra", Convert.ToString(row.Cells["OrdenCompra"].Value));
                            comando.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Datos registrado correptamente");
                    //limpiar datos del datagriview 
                    DataTable dt = (DataTable)dgvAsistencia.DataSource;
                    dt.Clear();
                    showDialogs("Datos Registrados", Color.FromArgb(0, 200, 81));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" No se pudo realizar el guardado del la asistencia del personal \n\n Verifique su conexion al Servidor " + ex, "Error");
                    showDialogs("ERROR", Color.FromArgb(255, 53, 71));
                }
            }
            else
            {
                //  obtenerip_nombre();
                MessageBox.Show("Porfavor verificar Datos", "Verificacion de datos");
                showDialogs("Verificacion de datos", Color.FromArgb(255, 187, 51));
            }
        }
    }
}
