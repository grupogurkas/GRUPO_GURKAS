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
        public string _numvale;
        public string _entregad;
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();
        Datos.DataReportes.Logistica.DataLogistica reportelogistica = new Datos.DataReportes.Logistica.DataLogistica();
        private Timer ti;
        private DataTable dt;
        int i = 0;
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;

        public frmDevolucionMaterial()
        {
            InitializeComponent();
        }
        private void buscar_Datos()
        {
           string num_vale_salida = txtNumValeSalida.Text;
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM v_datos_salida_material WHERE NUM_ENTREGA = '" + num_vale_salida + "'", conexion.conexionBD());

                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    cboTipoPuesto.SelectedIndex = Convert.ToInt32((recorre["COD_PUESTO"].ToString()));
                    cboAreaLaboral.SelectedIndex = Convert.ToInt32((recorre["COD_AREA_ENTREGA"].ToString()));
                    cboEmpresa.SelectedIndex = Convert.ToInt32((recorre["COD_EMPRESA"].ToString()));
                    string unidad = recorre["Razon_social"].ToString();
                    cboUnidad.SelectedIndex = cboUnidad.FindStringExact(unidad);
                    string sede = recorre["Nombre_sede"].ToString();
                    cboSede.SelectedIndex = cboSede.FindStringExact(sede);
                    txtInformacionAdicional.Text = recorre["INFORMACION_ADICIONAL"].ToString();
                    dtpFechaAdquisicion.Text = recorre["FECHA_SISTEMA"].ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }
        private void buscar_Datos_producto()
        {
            string num_vale_salida = txtNumValeSalida.Text;
            dgvListaProducto.DataSource = reportelogistica.BuscarMaterialSalida(num_vale_salida);
        }
        private void ocultar_datos()
        {
            lbldireccion.Visible = false;
            lblemp.Visible = false;
            lblnombrear.Visible = false;
            lblruc.Visible = false;
            lblver.Visible = false;
            lbldni.Visible = false;
            lblcodentre.Visible = false;
            lbldnientr.Visible = false;
        }
        private void bloqueo_datos()
        {
            txtResivido.Enabled = false;
            txtNumVale.Enabled = false;
            txtNumValeSalida.Enabled = false;
            txtEntregado.Enabled = false;
            cboTipoPuesto.Enabled = false;
            cboAreaLaboral.Enabled = false;
            cboEmpresa.Enabled = false;
            cboUnidad.Enabled = false;
            cboSede.Enabled = false;
            txtInformacionAdicional.Enabled = false;

        }
        private void frmDevolucionMaterial_Load(object sender, EventArgs e)
        {
            txtEntregado.Text = _entregad;
            txtNumValeSalida.Text = _numvale;
            timer1.Enabled = true;
            string nombre_user = Datos.DatosUsuario._usuario;

           
            txtResivido.Text = nombre_user;
           
            obtener_datos();
            GenerarNumVale();
            Llenadocbo.ObtenerTipoPuesto(cboTipoPuesto);
            Llenadocbo.ObtenerArea(cboAreaLaboral);
            Llenadocbo.ObtenerUnidadRRHH(cboUnidad);
            Llenadocbo.ObtenerEmpresa(cboEmpresa);

            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("CodProducto");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("CondicionEntrega");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Observacion");
            dgvListaProducto.DataSource = dt;

            //llenado del combo del dgv
            DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
            dgvCmb.HeaderText = "Estado";
            Llenadocbo.ObtenerEstadoProductoEntrega(dgvCmb);
            dgvCmb.Name = "Estado";
            dgvListaProducto.Columns.Add(dgvCmb);


            dgvListaProducto.RowHeadersVisible = false;
            dgvListaProducto.AllowUserToAddRows = false;
            bloqueo_datos();
            ocultar_datos();
            buscar_Datos();
            buscar_Datos_producto();


            dgvListaProducto.Rows[0].Cells["Estado"].Value = 1;


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
                txtNumVale.Text = "LOG-D-000000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtNumVale.Text = "LOG-D-00000" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtNumVale.Text = "LOG-D-0000" + (numero + 1);
            }
            if (numero > 9999 && numero < 10000)
            {
                txtNumVale.Text = "LOG-D-000" + (numero + 1);
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
            cboTipoPuesto.SelectedIndex = 0;
            cboAreaLaboral.SelectedIndex = 0;
            cboEmpresa.SelectedIndex = 0;
            cboUnidad.SelectedIndex = 0;
            cboSede.SelectedIndex = 0;
            GenerarNumVale();
            txtInformacionAdicional.Text = "";
            dt.Clear();
        }
    }
}
