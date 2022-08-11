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
    public partial class frmDevoluciondeMaterialFueradelSistema : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LlenadoDatos.llenadoDatosLogistica Llenadocbo = new Datos.LlenadoDatos.llenadoDatosLogistica();
        private Timer ti;
        private DataTable dt;
        int i = 0;
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;

        public frmDevoluciondeMaterialFueradelSistema()
        {
            InitializeComponent();
        }
        private void obtenr_datos()
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
            SqlCommand comando = new SqlCommand("SELECT ROW_NUMBER()OVER(ORDER BY NUM_DEVOLUCION)AS 't'  FROM t_devolucion_producto_vale GROUP BY NUM_DEVOLUCION", conexion.conexionBD());

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
        private void cboempleadoActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtEntregado.SelectedValue.ToString() != null)
            {
                string COD_EMPLEADO = txtEntregado.SelectedValue.ToString();
                try
                {
                    SqlCommand comando = new SqlCommand("SELECT * FROM V_DetallePersonal WHERE COD_EMPLEADO = '" + COD_EMPLEADO + "'", conexion.conexionBD());

                    SqlDataReader recorre = comando.ExecuteReader();
                    while (recorre.Read())
                    {
                        lbldni.Text = recorre["DOCT_IDENT"].ToString();
                        string unidad = recorre["Razon_social"].ToString();
                        cboUnidad.SelectedIndex = cboUnidad.FindStringExact(unidad);
                        string sede = recorre["Nombre_sede"].ToString();
                        cboSede.SelectedIndex = cboSede.FindStringExact(sede);
                        cboEmpresa.SelectedIndex = 1;
                        cboTipoPuesto.SelectedIndex = Convert.ToInt32(recorre["ID_PUESTO"].ToString());
                        cboAreaLaboral.SelectedIndex = 10;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
                }
            }
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
                    txtcod_resive.Text = recorre["COD_EMPLEADO"].ToString();
                    lbldnientr.Text = recorre["DOCT_IDENT"].ToString();
                    txtdni_resive.Text = recorre["DOCT_IDENT"].ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }
        private void agregardata()
        {
            string cod_producto = cboProducto.SelectedValue.ToString();
            string nombre_producto = cboProducto.GetItemText(cboProducto.SelectedItem);
            string cantidad = txtCantidadTecno.Text;
            string observacion = txtInformacionAdicional.Text;
            //  string Condicion_Entrega = cboEstadoMaterial.GetItemText(cboEstadoMaterial.SelectedItem);
            string Condicion_Entrega = "DEVOLUCION";
             int n = dgvListaProducto.Rows.Count;
            string c = Convert.ToString(n + 1);
            DataRow row = dt.NewRow();
           // row["ITEM"] = c;
            row["COD_PRODUCTO"] = cod_producto;
            row["DESCRIPCION_PRODUCTO"] = nombre_producto;
            row["CANTIDAD_ENTREGADA"] = cantidad;
            row["CANTIDAD_DEVUELTA_FECHA_1"] = cantidad;
            row["CANTIDAD_DEVUELTA_FECHA_2"] = 0;
            row["CANTIDAD_PENDIENTE"] = 0;
            dt.Rows.Add(row);
            if ((n + 1) == 26)
            {
                btnAgregar.Enabled = false;
            }
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

        private void frmDevoluciondeMaterialFueradelSistema_Load(object sender, EventArgs e)
        {
            txtResivido.Enabled = false;
            txtNumVale.Enabled = false;
            //txtstock.Enabled = false;
           // txtstock.Text = "0";
          //  txtstockminimo.Text = "0";
            //txtstockminimo.Visible = false;
            string nombre_user = Datos.DatosUsuario._usuario;
            txtResivido.Text = nombre_user;
            timer1.Enabled = true;
            obtenr_datos();
            GenerarNumVale();
            obtener_datos_devuelve();
            obtener_datos();
            ocultar_datos();
            txtInformacionAdicional.Text = "---";
            Llenadocbo.ObtenerTipoPuesto(cboTipoPuesto);
            Llenadocbo.ObtenerEstadoProductoEntrega(cboEstado);
            Llenadocbo.ObtenerPersonalRRHH(txtEntregado);
            Llenadocbo.ObtenerArea(cboAreaLaboral);
            Llenadocbo.ObtenerProducto(cboProducto);
            Llenadocbo.ObtenerUnidadRRHH(cboUnidad);
            Llenadocbo.ObtenerEmpresa(cboEmpresa);
            cboEstado.SelectedIndex = 2;
            lbldireccion.Visible = false;
            lblemp.Visible = false;
            lblnombrear.Visible = false;
            lblruc.Visible = false;
            lblver.Visible = false;
            lbldni.Visible = false;
            lblcodentre.Visible = false;
            lbldnientr.Visible = false;

            dt = new DataTable();
           // dt.Columns.Add("ITEM");
            dt.Columns.Add("COD_PRODUCTO");
            dt.Columns.Add("DESCRIPCION_PRODUCTO");
            dt.Columns.Add("CANTIDAD_ENTREGADA");
            dt.Columns.Add("CANTIDAD_DEVUELTA_FECHA_1");
            dt.Columns.Add("CANTIDAD_DEVUELTA_FECHA_2");
            dt.Columns.Add("CANTIDAD_PENDIENTE");
            dgvListaProducto.DataSource = dt;

            DataGridViewButtonColumn btnclm = new DataGridViewButtonColumn();
            btnclm.Name = "Eliminar";
            dgvListaProducto.Columns.Add(btnclm);

            dgvListaProducto.RowHeadersVisible = false;
            dgvListaProducto.AllowUserToAddRows = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregardata();
            txtCantidadTecno.Text = "";
            cboProducto.SelectedIndex = 0;
            txtInformacionAdicional.Text = "";
        }

        private void cboUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUnidad.SelectedValue.ToString() != null)
            {
                string cod_unidad = cboUnidad.SelectedValue.ToString();
                Llenadocbo.ObtenerSedeLogistica(cboSede, cod_unidad);
            }
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image cabezera = Properties.Resources._1logogurkas;

            //string num;
            string num = txtNumVale.Text;

            //num = "ENTREGA";
  


            string TIPO_PERSONAL = cboTipoPuesto.GetItemText(cboTipoPuesto.SelectedItem);
            string AREA_ENTREGA = cboAreaLaboral.GetItemText(cboAreaLaboral.SelectedItem);
            string EMPRESA = cboEmpresa.GetItemText(cboEmpresa.SelectedItem);
            string UNIDAD = cboUnidad.GetItemText(cboUnidad.SelectedItem);
            string SEDE = cboSede.GetItemText(cboSede.SelectedItem);
            string PERSONAL_RESIVE = txtResivido.Text;
            string PERSONAL_entrega = txtEntregado.Text;
            string cod_empleado_RESIVE = txtcod_resive.Text;
            string informacion_adicional = txtInformacionAdicional.Text;
            string fecha = lblFecha.Text;
            string emp = lblemp.Text;
            string ruc = lblruc.Text;
            string dir = lbldireccion.Text;
            string nombre_arc = lblnombrear.Text;
            string ver = lblver.Text;
            string dni_RESIVE = txtdni_resive.Text;

            string dni_ENTREGA = txtdni_entrega.Text;
            string cod_ENTREGA = txtcod_entrega.Text;


            Font tipoTexto = new Font("Arial", 10, FontStyle.Bold);
            Font desp = new Font("Arial", 8, FontStyle.Bold);
            Font nombres = new Font("Arial", 7, FontStyle.Bold);
            Font datos = new Font("Arial", 6, FontStyle.Bold);
            e.Graphics.DrawImage(cabezera, 40, 25);

            Pen blackPen = new Pen(Color.Black, 2);

            Rectangle N1 = new Rectangle(20, 90, 770, 100);
            Rectangle N2 = new Rectangle(20, 190, 390, 20);
            Rectangle N3 = new Rectangle(410, 190, 380, 20);
            Rectangle N4 = new Rectangle(20, 210, 390, 50);
            Rectangle N5 = new Rectangle(410, 210, 380, 50);
            Rectangle N6 = new Rectangle(20, 260, 390, 40);
            Rectangle N7 = new Rectangle(410, 260, 380, 40);
            Rectangle N8 = new Rectangle(20, 1030, 770, 100);
            Rectangle N9 = new Rectangle(20, 20, 230, 60);
            Rectangle N10 = new Rectangle(250, 20, 320, 60);
            Rectangle N11 = new Rectangle(570, 20, 220, 60);
            Rectangle N12 = new Rectangle(570, 20, 220, 30);
            Rectangle CODIGO_ = new Rectangle(20, 310, 70, 715);
            // Rectangle CODIGO_ = new Rectangle(70, 310, 60, 715);110
            Rectangle PRODUCTO_ = new Rectangle(90, 310, 400, 715);
            Rectangle CANT_ENTREGADO_ = new Rectangle(490, 310, 100, 715);
            Rectangle CANT_DEVUELTA_ = new Rectangle(590, 310, 100, 715);
            Rectangle FECHA_1_ = new Rectangle(590, 325, 50, 700);
            Rectangle FECHA_2_ = new Rectangle(640, 325, 50, 700);
            Rectangle CANT_PENDIENTE_ = new Rectangle(690, 310, 100, 715);
            e.Graphics.DrawRectangle(blackPen, N1);
            e.Graphics.DrawRectangle(blackPen, N2);
            e.Graphics.DrawRectangle(blackPen, N3);
            e.Graphics.DrawRectangle(blackPen, N4);
            e.Graphics.DrawRectangle(blackPen, N5);
            e.Graphics.DrawRectangle(blackPen, N6);
            e.Graphics.DrawRectangle(blackPen, N7);
            e.Graphics.DrawRectangle(blackPen, N8);
            e.Graphics.DrawRectangle(blackPen, N9);
            e.Graphics.DrawRectangle(blackPen, N10);
            e.Graphics.DrawRectangle(blackPen, N11);
            e.Graphics.DrawRectangle(blackPen, N12);
            e.Graphics.DrawRectangle(blackPen, CODIGO_);
            // e.Graphics.DrawRectangle(blackPen, CODIGO_);
            e.Graphics.DrawRectangle(blackPen, PRODUCTO_);
            e.Graphics.DrawRectangle(blackPen, CANT_ENTREGADO_);
            e.Graphics.DrawRectangle(blackPen, CANT_DEVUELTA_);
            e.Graphics.DrawRectangle(blackPen, FECHA_1_);
            e.Graphics.DrawRectangle(blackPen, FECHA_2_);
            e.Graphics.DrawRectangle(blackPen, CANT_PENDIENTE_);

            e.Graphics.DrawString("CARGO DE DEVOLUCION", tipoTexto, Brushes.Black, 310, 25);
            e.Graphics.DrawString(emp, nombres, Brushes.Black, 290, 45);
            e.Graphics.DrawString("  RUC " + ruc, nombres, Brushes.Black, 420, 45);
            // e.Graphics.DrawString(dir, datos, Brushes.Black, 250, 60);
            e.Graphics.DrawString(nombre_arc, datos, Brushes.Black, 580, 25);
            e.Graphics.DrawString(ver, datos, Brushes.Black, 580, 35);
            e.Graphics.DrawString(num, tipoTexto, Brushes.Black, 580, 55);

            string anio = DateTime.Now.Year.ToString();

            e.Graphics.DrawString(" - " + anio, tipoTexto, Brushes.Black, 720, 55);

            e.Graphics.DrawString(dir, datos, Brushes.Black, new RectangleF(260, 60, 300, 30));

            e.Graphics.DrawString("EMPRESA : ", tipoTexto, Brushes.Black, 30, 100);
            e.Graphics.DrawString(EMPRESA, desp, Brushes.Black, 120, 102);

            e.Graphics.DrawString("FECHA   : ", tipoTexto, Brushes.Black, 30, 120);
            e.Graphics.DrawString(fecha, desp, Brushes.Black, 120, 122);

            e.Graphics.DrawString("AREA DE ENTREGA : ", tipoTexto, Brushes.Black, 320, 100);
            e.Graphics.DrawString(AREA_ENTREGA, desp, Brushes.Black, 470, 102);

            e.Graphics.DrawString("PUESTO : ", tipoTexto, Brushes.Black, 320, 120);//160
            e.Graphics.DrawString(TIPO_PERSONAL, desp, Brushes.Black, 470, 122);

            e.Graphics.DrawString("UNIDAD : ", tipoTexto, Brushes.Black, 30, 140);
            e.Graphics.DrawString(UNIDAD, desp, Brushes.Black, 120, 142);

            e.Graphics.DrawString("SEDE : ", tipoTexto, Brushes.Black, 30, 160);
            e.Graphics.DrawString(SEDE, desp, Brushes.Black, 120, 162);

            e.Graphics.DrawString("PERSONAL QUE RECIBE", tipoTexto, Brushes.Black, 140, 190);
            e.Graphics.DrawString("PERSONAL QUE ENTREGA", tipoTexto, Brushes.Black, 540, 190);

            e.Graphics.DrawString("NOMBRE : ", tipoTexto, Brushes.Black, 30, 220);
            e.Graphics.DrawString(PERSONAL_RESIVE, nombres, Brushes.Black, 110, 223);

            e.Graphics.DrawString("CODIGO : ", tipoTexto, Brushes.Black, 30, 240);
            e.Graphics.DrawString(cod_empleado_RESIVE, desp, Brushes.Black, 110, 243);
            e.Graphics.DrawString("DNI : ", tipoTexto, Brushes.Black, 200, 240);
            e.Graphics.DrawString(dni_RESIVE, desp, Brushes.Black, 240, 243);

            e.Graphics.DrawString("NOMBRE : ", tipoTexto, Brushes.Black, 420, 220);
            e.Graphics.DrawString(PERSONAL_entrega, nombres, Brushes.Black, 500, 223);

            e.Graphics.DrawString("CODIGO : ", tipoTexto, Brushes.Black, 420, 240);
            e.Graphics.DrawString(cod_ENTREGA, desp, Brushes.Black, 500, 243);
            e.Graphics.DrawString("DNI : ", tipoTexto, Brushes.Black, 600, 240);
            e.Graphics.DrawString(dni_ENTREGA, desp, Brushes.Black, 650, 243);

            e.Graphics.DrawString("FIRMA : _______________________________", tipoTexto, Brushes.Black, 30, 275);
            e.Graphics.DrawString("FIRMA : _______________________________", tipoTexto, Brushes.Black, 420, 275);

            string l1 = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 20, 330);//360

            string g1 = "CODIGO";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 30, 315);

            /* string g2 = "CODIGO";
             e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 72, 315);*/

            string g3 = "DESCRIPCION";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 180, 315);

            string g6 = "CANT. ENTREGADO";
            e.Graphics.DrawString(g6, new System.Drawing.Font("Book Antiqua", 6, FontStyle.Bold), Brushes.Black, 495, 315);

            string g4 = "CANT. DEVUELTA";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 6, FontStyle.Bold), Brushes.Black, 595, 313);

            string g7 = "FECHA 1";
            e.Graphics.DrawString(g7, new System.Drawing.Font("Book Antiqua", 5, FontStyle.Bold), Brushes.Black, 593, 329);

            string g8 = "FECHA 2";
            e.Graphics.DrawString(g8, new System.Drawing.Font("Book Antiqua", 5, FontStyle.Bold), Brushes.Black, 645, 329);

            string g5 = "CANT. PENDIENTE";
            e.Graphics.DrawString(g5, new System.Drawing.Font("Book Antiqua", 6, FontStyle.Bold), Brushes.Black, 695, 315);

            e.Graphics.DrawString("INFORMACIÓN ADICIONAL : ", tipoTexto, Brushes.Black, 50, 1050);
            e.Graphics.DrawString(informacion_adicional, tipoTexto, Brushes.Black, new RectangleF(50, 1070, 700, 50));

            int height = 320;
            for (int l = numberOfItemsPrintedSoFar; l < dgvListaProducto.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;
                    if (numberOfItemsPrintedSoFar <= dgvListaProducto.Rows.Count)
                    {
                        height += dgvListaProducto.Rows[0].Height;
                        //e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[0].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(30, height, 10, 10));
                        //  e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[1].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(30, height, 30, 20));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[1].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(30, height, 100, 100));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[2].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(105, height, 300, 40));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[3].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(540, height, 30, 20));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[4].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(610, height, 100, 100));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[5].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(660, height, 100, 100));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[6].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(730, height, 100, 100));
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }

                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;
                }
            }
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
            // dt.Clear();
        }
        private void agregar_Datos()
        {
            string NUM_DEVOLUCION = txtNumVale.Text;
            string NUM_SALIDA = "FUERA DEL SISTEMA";
            int COD_PUESTO = cboTipoPuesto.SelectedIndex;
            int COD_AREA_ENTREGA = cboAreaLaboral.SelectedIndex;
            string cod = cboEmpresa.SelectedValue.ToString();
            int COD_EMPRESA = Convert.ToInt32(cod);
            string COD_UNIDAD = cboUnidad.SelectedValue.ToString();
            string COD_SEDE = cboSede.SelectedValue.ToString();
            string INFORMACION_ADICIONAL_SALIDA = txtInformacionAdicional.Text;



            string entregado_nombre = txtEntregado.Text;
            string cod_entregado = txtcod_entrega.Text;
            string dni_entregado = txtdni_entrega.Text;

            string nombre_revisa = txtResivido.Text;
            string cod_revisa = txtcod_resive.Text;
            string dni_revisa = txtdni_resive.Text;

            string FECHA_VALE_DEVOLUCION = lblFecha.Text;
            string hora = lblHora.Text;
            string nombre_user = Datos.DatosUsuario._usuario;

            int estado = Convert.ToInt32(cboEstado.SelectedValue.ToString());

            DateTime fecha_registro = dtpFechaAdquisicion.Value;
            try
            {
                SqlCommand comando = new SqlCommand("SP_REINGRESO_MATERIAL @NUM_DEVOLUCION,@NUM_SALIDA,@COD_PUESTO,@COD_AREA_ENTREGA,@COD_EMPRESA,@COD_UNIDAD,@COD_SEDE," +
                    " @INFORMACION_ADICIONAL_SALIDA, @ENTREGADO_NOMBRE, @COD_ENTREGADO, @DNI_ENTREGADO, @RESIVE_NOMBRE, @COD_RESIVE, @DNI_RESIVE, @FECHA_VALE_DEVOLUCION, " +
                    "@ID_CONDICION_PRODUCTO, @COD_PRODUCTO, @DESP_PRODUCTO, @CANTIDAD_ENTREGADA,@CANTIDAD_DEVUELTA,@CANTIDAD_DEVUELTA_2,@CANTIDAD_PENDIENTE, @HORA, @USUARIO, @fecha_sistema", conexion.conexionBD());

                foreach (DataGridViewRow row in dgvListaProducto.Rows)
                {
                    if (row.Cells["COD_PRODUCTO"].Value != null)
                    {

                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@NUM_DEVOLUCION", SqlDbType.Int).Value = NUM_DEVOLUCION;
                        comando.Parameters.AddWithValue("@NUM_SALIDA", SqlDbType.Int).Value = NUM_SALIDA;
                        comando.Parameters.AddWithValue("@COD_PUESTO", SqlDbType.VarChar).Value = COD_PUESTO;
                        comando.Parameters.AddWithValue("@COD_AREA_ENTREGA", SqlDbType.Int).Value = COD_AREA_ENTREGA;
                        comando.Parameters.AddWithValue("@COD_EMPRESA", SqlDbType.Int).Value = COD_EMPRESA;
                        comando.Parameters.AddWithValue("@COD_UNIDAD", SqlDbType.VarChar).Value = COD_UNIDAD;
                        comando.Parameters.AddWithValue("@COD_SEDE", SqlDbType.VarChar).Value = COD_SEDE;
                        comando.Parameters.AddWithValue("@INFORMACION_ADICIONAL_SALIDA", SqlDbType.VarChar).Value = INFORMACION_ADICIONAL_SALIDA;
                        comando.Parameters.AddWithValue("@ENTREGADO_NOMBRE", SqlDbType.VarChar).Value = entregado_nombre;
                        comando.Parameters.AddWithValue("@COD_ENTREGADO", SqlDbType.VarChar).Value = cod_entregado;
                        comando.Parameters.AddWithValue("@DNI_ENTREGADO", SqlDbType.VarChar).Value = dni_entregado;
                        comando.Parameters.AddWithValue("@RESIVE_NOMBRE", SqlDbType.VarChar).Value = nombre_revisa;
                        comando.Parameters.AddWithValue("@COD_RESIVE", SqlDbType.VarChar).Value = cod_revisa;
                        comando.Parameters.AddWithValue("@DNI_RESIVE", SqlDbType.VarChar).Value = dni_revisa;
                        comando.Parameters.AddWithValue("@FECHA_VALE_DEVOLUCION", SqlDbType.VarChar).Value = FECHA_VALE_DEVOLUCION;
                        comando.Parameters.AddWithValue("@ID_CONDICION_PRODUCTO", estado);
                        comando.Parameters.AddWithValue("@COD_PRODUCTO", Convert.ToString(row.Cells["COD_PRODUCTO"].Value));
                        comando.Parameters.AddWithValue("@DESP_PRODUCTO", Convert.ToString(row.Cells["DESCRIPCION_PRODUCTO"].Value));
                        comando.Parameters.AddWithValue("@CANTIDAD_ENTREGADA", Convert.ToInt32(row.Cells["CANTIDAD_ENTREGADA"].Value));
                        comando.Parameters.AddWithValue("@CANTIDAD_DEVUELTA", Convert.ToInt32(row.Cells["CANTIDAD_DEVUELTA_FECHA_1"].Value));
                        comando.Parameters.AddWithValue("@CANTIDAD_DEVUELTA_2", Convert.ToInt32(row.Cells["CANTIDAD_DEVUELTA_FECHA_2"].Value));
                        comando.Parameters.AddWithValue("@CANTIDAD_PENDIENTE", Convert.ToInt32(row.Cells["CANTIDAD_PENDIENTE"].Value));
                        comando.Parameters.AddWithValue("@HORA", SqlDbType.VarChar).Value = hora;
                        comando.Parameters.AddWithValue("@USUARIO", SqlDbType.VarChar).Value = nombre_user;
                        comando.Parameters.AddWithValue("@fecha_sistema", SqlDbType.VarChar).Value = fecha_registro;
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Datos registrado correptamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se pudo realizar el guardado del la asistencia del personal \n\n Verifique su conexion al Servidor " + ex, "Error");
                //showDialogs("ERROR", Color.FromArgb(255, 53, 71));

            }
        }
        private void obtener_datos_devuelve()
        {
            try
            {
                string nombre = txtEntregado.Text;

                SqlCommand comando = new SqlCommand("SELECT * FROM T_MAE_PERSONAL WHERE NOMBRE_COMPLETO like '%" + nombre + "%'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtcod_entrega.Text = recorre["COD_EMPLEADO"].ToString();
                    txtdni_entrega.Text = recorre["DOCT_IDENT"].ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }
        private void imprimir()
        {
            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
             PrintDialog1.AllowSomePages = true;
             PrintDialog1.ShowHelp = true;
             PrintDialog1.Document = printDocument1;
             DialogResult result = PrintDialog1.ShowDialog();
             if (result == DialogResult.OK)
             {
                 //printPreviewDialog1.ShowDialog();
                 printDocument1.Print();

                 agregar_Datos();
                 limpiardatos();
             }
           //  printPreviewDialog1.ShowDialog();
        }

        private void btnCertificadoBasc_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void cboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string cod_empresa = cboEmpresa.GetItemText(cboEmpresa.SelectedItem);

                SqlCommand comando = new SqlCommand("SELECT * FROM T_EMPRESA WHERE NOMBRE_EMPRESA = '" + cod_empresa + "'", conexion.conexionBD());

                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    lblemp.Text = recorre["NOMBRE_EMPRESA"].ToString();
                    lblruc.Text = recorre["RUC"].ToString();
                    lbldireccion.Text = recorre["direccion"].ToString();
                    lblnombrear.Text = recorre["nombre_documento_sig"].ToString();
                    lblver.Text = recorre["vercion_documento_sig"].ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
