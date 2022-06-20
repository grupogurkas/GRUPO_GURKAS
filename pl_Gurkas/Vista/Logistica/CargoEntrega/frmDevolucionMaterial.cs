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

namespace pl_Gurkas.Vista.Logistica.CargoEntrega
{
    public partial class frmDevolucionMaterial : Form
    {


        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.ConexionMysql conexionmysql = new Datos.ConexionMysql();
        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();
        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();
        private Timer ti;
        private DataTable dt;
        int i = 0;
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;

        public frmDevolucionMaterial()
        {
            InitializeComponent();
        }

        private void frmDevolucionMaterial_Load(object sender, EventArgs e)
        {
            txtUsuarioEntrega.Enabled = false;
            txtNumVale.Enabled = false;
            txtstock.Enabled = false;
            txtstock.Text = "0";
            txtstockminimo.Text = "0";
            txtstockminimo.Visible = false;
            string nombre_user = Datos.DatosUsuario._usuario;
            txtUsuarioEntrega.Text = nombre_user;
            timer1.Enabled = true;
            obtener_datos();
            GenerarNumVale();
            Llenadocbo.ObtenerTipoPuesto(cboTipoPuesto);
            Llenadocbo.ObtenerEstadoProductoCompleto(cboEstadoMaterial);
            Llenadocbo.ObtenerPersonalRRHH(cboempleadoActivo);
            Llenadocbo.ObtenerArea(cboAreaLaboral);
            Llenadocbo.ObtenerProducto(cboProducto);
            Llenadocbo.ObtenerUnidadRRHH(cboUnidad);
            Llenadocbo.ObtenerEmpresa(cboEmpresa);

            lbldireccion.Visible = false;
            lblemp.Visible = false;
            lblnombrear.Visible = false;
            lblruc.Visible = false;
            lblver.Visible = false;
            lbldni.Visible = false;
            lblcodentre.Visible = false;
            lbldnientr.Visible = false;

            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("CodProducto");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("CondicionEntrega");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Observacion");
            dgvListaProducto.DataSource = dt;

            DataGridViewButtonColumn btnclm = new DataGridViewButtonColumn();
            btnclm.Name = "Eliminar";
            dgvListaProducto.Columns.Add(btnclm);

            dgvListaProducto.RowHeadersVisible = false;
            dgvListaProducto.AllowUserToAddRows = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Registro de Personal";
            const string mensaje = "Estas seguro que deseas cerra el Registro de Personal";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void obtener_datos()
        {
            try
            {
                string nombre = Datos.DatosUsuario._usuario;

                SqlCommand comando = new SqlCommand("SELECT * FROM T_MAE_PERSONAL WHERE NOMBRE_COMPLETO like '%" + nombre + "%'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    lblcodentre.Text = recorre["COD_EMPLEADO"].ToString();
                    lbldnientr.Text = recorre["DOCT_IDENT"].ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }

        public void GenerarNumVale()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("SELECT ROW_NUMBER()OVER(ORDER BY NUM_ENTREGA)AS 't'  FROM t_entrega_producto_vale GROUP BY NUM_ENTREGA", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            if (resultado.Equals(""))
            {
                resultado = "0";
            }
            int numero = Convert.ToInt32(resultado);
            if (numero < 10)
            {
                txtNumVale.Text = "LOG-000000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtNumVale.Text = "LOG-00000" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtNumVale.Text = "LOG-0000" + (numero + 1);
            }
            if (numero > 9999 && numero < 10000)
            {
                txtNumVale.Text = "LOG-000" + (numero + 1);
            }
        }

        private void cboUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUnidad.SelectedValue.ToString() != null)
            {
                string cod_unidad = cboUnidad.SelectedValue.ToString();
                Llenadocbo.ObtenerSedeLogistica(cboSede, cod_unidad);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Registro de Personal";
            const string mensaje = "Estas seguro que deseas cerra el Registro de Personal";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiardatos();
        }

        private void limpiardatos()
        {
            cboempleadoActivo.SelectedIndex = 0;
            cboTipoPuesto.SelectedIndex = 0;
            cboAreaLaboral.SelectedIndex = 0;
            cboEmpresa.SelectedIndex = 0;
            cboUnidad.SelectedIndex = 0;
            cboSede.SelectedIndex = 0;
            cboProducto.SelectedIndex = 0;
            cboEstadoMaterial.SelectedIndex = 0;
            GenerarNumVale();
            txtInformacionAdicional.Text = "";
            txtObservacion.Text = "";
            txtCantidadTecno.Text = "";
            dt.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int stock_a = Convert.ToInt32(txtstock.Text);
            int cantidad = Convert.ToInt32(txtCantidadTecno.Text);

            if (cboEstadoMaterial.SelectedIndex == 0)
            {
                MessageBox.Show("Debe Seleccionar la condicion del material", "Advertencia");
                cboEstadoMaterial.Focus();
            }
            else if (txtCantidadTecno.Equals(""))
            {
                MessageBox.Show("Ingresar Una cantidad", "Advertencia");
                txtCantidadTecno.Focus();
            }
            else
            {
                if (cantidad <= stock_a)
                {
                    agregardata();
                    txtCantidadTecno.Text = "";
                    cboProducto.SelectedIndex = 0;
                    cboEstadoMaterial.SelectedIndex = 0;
                    txtstock.Text = "0";
                }
                else
                {
                    MessageBox.Show("No se puede agregar el materia ya que supera el stock actual", "error");
                }
            }
        }

        private void agregardata()
        {
            string cod_producto = cboProducto.SelectedValue.ToString();
            string nombre_producto = cboProducto.GetItemText(cboProducto.SelectedItem);
            string cantidad = txtCantidadTecno.Text;
            string observacion = txtObservacion.Text;
            string Condicion_Entrega = cboEstadoMaterial.GetItemText(cboEstadoMaterial.SelectedItem);
            int n = dgvListaProducto.Rows.Count;
            string c = Convert.ToString(n + 1);
            DataRow row = dt.NewRow();
            row["ID"] = c;
            row["CodProducto"] = cod_producto;
            row["Nombre"] = nombre_producto;
            row["CondicionEntrega"] = Condicion_Entrega;
            row["Cantidad"] = cantidad;
            row["Observacion"] = observacion;
            dt.Rows.Add(row);
            if ((n + 1) == 26)
            {
                btnAgregar.Enabled = false;
            }
        }
    }
}
