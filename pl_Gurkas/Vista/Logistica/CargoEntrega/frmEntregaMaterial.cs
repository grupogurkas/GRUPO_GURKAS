using System;
using System.Collections;
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

    public partial class frmEntregaMaterial : Form

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

        public frmEntregaMaterial()
        {
            InitializeComponent();
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



        private void registarvale()
        {
            int cod_puesto = cboTipoPuesto.SelectedIndex;
            int cod_area_entrega = cboAreaLaboral.SelectedIndex;
            string cod = cboEmpresa.SelectedValue.ToString();
            int c = Convert.ToInt32(cod);
            string NUM_VALE = txtNumVale.Text;
            string cod_unidad = cboUnidad.SelectedValue.ToString();
            string cod_sede = cboSede.SelectedValue.ToString();
            string imformacion_adicional = txtInformacionAdicional.Text;
            string entregado_nombre = txtUsuarioEntrega.Text;
            string cod_entregado = lblcodentre.Text;
            string dni_entregado = lbldnientr.Text;
            string solicitante_nombre = cboempleadoActivo.GetItemText(cboempleadoActivo.SelectedItem);
            string cod_solicitante = cboempleadoActivo.SelectedValue.ToString();
            string dni_solicitante = lbldni.Text;
            string fecha_vale = lblFecha.Text;
            string hora = lblHora.Text;
            string nombre_user = Datos.DatosUsuario._usuario;
            try
            {
                SqlCommand comando = new SqlCommand("sp_insertar_salida_producto @NUM_ENTREGA ,@COD_PUESTO ,@COD_AREA_ENTREGA ,@COD_EMPRESA  ,@COD_UNIDAD ,@COD_SEDE, @INFORMACION_ADICIONAL, @ENTREGADO_NOMBRE, @COD_ENTREGADO," +
                    "@DNI_ENTREGADO, @SOLICITADO_NOMBRE, @COD_SOLICITADO, @DNI_SOLICITADO, @FECHA_VALE," +
                    "@ITEM_VALE, @COD_PRODUCTO, @DESP_PRODUCTO,  @OBSERVACION_PRODUCTO , @CONDICION_PRODUCTO" +
                    ", @CANTIDAD_SOLICITADA, @HORA, @USUARIO ", conexion.conexionBD());

                foreach (DataGridViewRow row in dgvListaProducto.Rows)
                {
                    if (row.Cells["ID"].Value != null && row.Cells["CodProducto"].Value != null)
                    {
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@COD_PUESTO", SqlDbType.Int).Value = cod_puesto;
                        comando.Parameters.AddWithValue("@COD_AREA_ENTREGA", SqlDbType.Int).Value = cod_area_entrega;
                        comando.Parameters.AddWithValue("@NUM_ENTREGA", SqlDbType.VarChar).Value = NUM_VALE;
                        comando.Parameters.AddWithValue("@COD_EMPRESA", SqlDbType.Int).Value = c;
                        comando.Parameters.AddWithValue("@COD_UNIDAD", SqlDbType.VarChar).Value = cod_unidad;
                        comando.Parameters.AddWithValue("@COD_SEDE", SqlDbType.VarChar).Value = cod_sede;
                        comando.Parameters.AddWithValue("@INFORMACION_ADICIONAL", SqlDbType.VarChar).Value = imformacion_adicional;
                        comando.Parameters.AddWithValue("@ENTREGADO_NOMBRE", SqlDbType.VarChar).Value = entregado_nombre;
                        comando.Parameters.AddWithValue("@COD_ENTREGADO", SqlDbType.VarChar).Value = cod_entregado;
                        comando.Parameters.AddWithValue("@DNI_ENTREGADO", SqlDbType.VarChar).Value = dni_entregado;
                        comando.Parameters.AddWithValue("@SOLICITADO_NOMBRE", SqlDbType.VarChar).Value = solicitante_nombre;
                        comando.Parameters.AddWithValue("@COD_SOLICITADO", SqlDbType.VarChar).Value = cod_solicitante;
                        comando.Parameters.AddWithValue("@DNI_SOLICITADO", SqlDbType.VarChar).Value = dni_solicitante;
                        comando.Parameters.AddWithValue("@FECHA_VALE", SqlDbType.VarChar).Value = fecha_vale;
                        comando.Parameters.AddWithValue("@ITEM_VALE", Convert.ToInt32(row.Cells["ID"].Value));
                        comando.Parameters.AddWithValue("@COD_PRODUCTO", Convert.ToString(row.Cells["CodProducto"].Value));
                        comando.Parameters.AddWithValue("@DESP_PRODUCTO", Convert.ToString(row.Cells["Nombre"].Value));
                        comando.Parameters.AddWithValue("@OBSERVACION_PRODUCTO", Convert.ToString(row.Cells["Observacion"].Value));
                        comando.Parameters.AddWithValue("@CONDICION_PRODUCTO", Convert.ToString(row.Cells["CondicionEntrega"].Value));
                        comando.Parameters.AddWithValue("@CANTIDAD_SOLICITADA", Convert.ToInt32(row.Cells["Cantidad"].Value));
                        comando.Parameters.AddWithValue("@HORA", SqlDbType.VarChar).Value = hora;
                        comando.Parameters.AddWithValue("@USUARIO", SqlDbType.VarChar).Value = nombre_user;
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
        private void frmEntregaMaterial_Load(object sender, EventArgs e)
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
            obtenr_datos();
            GenerarNumVale();
            Llenadocbo.ObtenerTipoPuesto(cboTipoPuesto);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoMaterial);
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
                //  DateTime fecha = DateTime.Now;
                //  obtenerip_nombre();
                // string username = Code.nivelUser._nombre;
                // string detalle = "Cerrar Registro de Personal";
                // string cod_buscado = "Cerro el registro de Personal";
                // registrar.RegistrarRRHH(fecha, nombrepc, username, ipuser, cod_buscado, detalle);
                this.Close();
            }
        }

        private void dgvListaProducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Image someImage = Properties.Resources.delete_16;

            if (e.ColumnIndex >= 0 && this.dgvListaProducto.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celboton = this.dgvListaProducto.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                e.Graphics.DrawImage(someImage, e.CellBounds.Left + 15, e.CellBounds.Top + 3);
                this.dgvListaProducto.Rows[e.RowIndex].Height = someImage.Height + 10;
                this.dgvListaProducto.Columns[e.ColumnIndex].Width = someImage.Width + 31;

                e.Handled = true;
            }
        }

        private void dgvListaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvListaProducto.Columns[e.ColumnIndex].DisplayIndex == 6)
            {
                dgvListaProducto.Rows.Remove(dgvListaProducto.CurrentRow);
            }
            int n = dgvListaProducto.Rows.Count;

            if ((n + 1) < 27)
            {
                btnAgregar.Enabled = true;
            }
        }
        private void cboUnidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboUnidad.SelectedValue.ToString() != null)
            {
                string cod_unidad = cboUnidad.SelectedValue.ToString();
                Llenadocbo.ObtenerSedeLogistica(cboSede, cod_unidad);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int stock_a = Convert.ToInt32(txtstock.Text);
            int cantidad = Convert.ToInt32(txtCantidadTecno.Text);

            if(cantidad <= stock_a){
                agregardata();
                txtCantidadTecno.Text = "";
                cboProducto.SelectedIndex = 0;
                cboEstadoMaterial.SelectedIndex = 0;
                txtstock.Text = "0";
            }
            else
            {
                MessageBox.Show("No se puede agregar el materia ya que supera el stock actual","error");
            }

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image cabezera = Properties.Resources._1logogurkas;


            string TIPO_PERSONAL = cboTipoPuesto.GetItemText(cboTipoPuesto.SelectedItem);
            string AREA_ENTREGA = cboAreaLaboral.GetItemText(cboAreaLaboral.SelectedItem);
            string EMPRESA = cboEmpresa.GetItemText(cboEmpresa.SelectedItem);
            string UNIDAD = cboUnidad.GetItemText(cboUnidad.SelectedItem);
            string SEDE = cboSede.GetItemText(cboSede.SelectedItem);
            string PERSONAL = cboempleadoActivo.GetItemText(cboempleadoActivo.SelectedItem);
            string entrega = txtUsuarioEntrega.Text;
            string cod_empleado = cboempleadoActivo.SelectedValue.ToString();
            string informacion_adicional = txtInformacionAdicional.Text;
            string fecha = lblFecha.Text;
            string emp = lblemp.Text;
            string ruc = lblruc.Text;
            string dir = lbldireccion.Text;
            string nombre_arc = lblnombrear.Text;
            string ver = lblver.Text;
            string dni = lbldni.Text;

            string dnien = lbldnientr.Text;
            string cod = lblcodentre.Text;
            string num = txtNumVale.Text;

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
            Rectangle ITEM_ = new Rectangle(20, 310, 50, 715);
            Rectangle CODIGO_ = new Rectangle(70, 310, 60, 715);
            Rectangle PRODUCTO_ = new Rectangle(130, 310, 400, 715);
            Rectangle OBSERVACION_ = new Rectangle(530, 310, 100, 715);
            Rectangle CONDICION_ = new Rectangle(630, 310, 100, 715);
            Rectangle CANT_ = new Rectangle(730, 310, 60, 715);
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
            e.Graphics.DrawRectangle(blackPen, ITEM_);
            e.Graphics.DrawRectangle(blackPen, CODIGO_);
            e.Graphics.DrawRectangle(blackPen, PRODUCTO_);
            e.Graphics.DrawRectangle(blackPen, OBSERVACION_);
            e.Graphics.DrawRectangle(blackPen, CONDICION_);
            e.Graphics.DrawRectangle(blackPen, CANT_);

            e.Graphics.DrawString("CARGO DE ENTREGA", tipoTexto, Brushes.Black, 310, 25);
            e.Graphics.DrawString(emp, nombres, Brushes.Black, 290, 45);
            e.Graphics.DrawString("  RUC " + ruc, nombres, Brushes.Black, 420, 45);
            // e.Graphics.DrawString(dir, datos, Brushes.Black, 250, 60);
            e.Graphics.DrawString(nombre_arc, datos, Brushes.Black, 580, 25);
            e.Graphics.DrawString(ver, datos, Brushes.Black, 580, 35);
            e.Graphics.DrawString(num, tipoTexto, Brushes.Black, 580, 55);

            string anio =  DateTime.Now.Year.ToString();

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

            e.Graphics.DrawString("SOLICITANTE", tipoTexto, Brushes.Black, 150, 190);
            e.Graphics.DrawString("DESPACHO", tipoTexto, Brushes.Black, 550, 190);

            e.Graphics.DrawString("NOMBRE : ", tipoTexto, Brushes.Black, 30, 220);
            e.Graphics.DrawString(PERSONAL, nombres, Brushes.Black, 110, 223);

            e.Graphics.DrawString("CODIGO : ", tipoTexto, Brushes.Black, 30, 240);
            e.Graphics.DrawString(cod_empleado, desp, Brushes.Black, 110, 243);
            e.Graphics.DrawString("DNI : ", tipoTexto, Brushes.Black, 200, 240);
            e.Graphics.DrawString(dni, desp, Brushes.Black, 240, 243);

            e.Graphics.DrawString("NOMBRE : ", tipoTexto, Brushes.Black, 420, 220);
            e.Graphics.DrawString(entrega, nombres, Brushes.Black, 500, 223);

            e.Graphics.DrawString("CODIGO : ", tipoTexto, Brushes.Black, 420, 240);
            e.Graphics.DrawString(cod, desp, Brushes.Black, 500, 243);
            e.Graphics.DrawString("DNI : ", tipoTexto, Brushes.Black, 600, 240);
            e.Graphics.DrawString(dnien, desp, Brushes.Black, 650, 243); 

            e.Graphics.DrawString("FIRMA : _______________________________", tipoTexto, Brushes.Black, 30, 275);
            e.Graphics.DrawString("FIRMA : _______________________________", tipoTexto, Brushes.Black, 420, 275);

            string l1 = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 20, 320);//360

            string g1 = "ITEM";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 30, 315);

            string g2 = "CODIGO";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 72, 315);

            string g3 = "DESCRIPCION";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 200, 315);

            string g6 = "OBSERVACION";
            e.Graphics.DrawString(g6, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 538, 315);

            string g4 = "CONDICION";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 645, 315);

            string g5 = "CANT.";
            e.Graphics.DrawString(g5, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 735, 315);

            e.Graphics.DrawString("INFORMACIÓN ADICIONAL : ", tipoTexto, Brushes.Black, 50, 1050);
            e.Graphics.DrawString(informacion_adicional, tipoTexto, Brushes.Black,new RectangleF(50, 1070, 700, 50));

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
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[0].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(30, height, 10, 10));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[1].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(30, height, 30, 20));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[2].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(77, height, 100, 100));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[3].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(135, height, 300, 40));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[4].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(640, height, 100, 100));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[5].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(750, height, 30, 20));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[6].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(540, height, 90, 40));
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

        private void btnCertificadoBasc_Click(object sender, EventArgs e)
        {
           System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
             PrintDialog1.AllowSomePages = true;
             PrintDialog1.ShowHelp = true;
             PrintDialog1.Document = printDocument1;
             DialogResult result = PrintDialog1.ShowDialog();
             if (result == DialogResult.OK)
             {
                    printDocument1.Print();
                    registarvale();
                    limpiardatos();
             }
            //printPreviewDialog1.ShowDialog();
        }

        private void txtInformacionAdicional_TextChanged(object sender, EventArgs e)
        {
            txtInformacionAdicional.MaxLength = 264;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {
            txtObservacion.MaxLength = 18;
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

        private void cboempleadoActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempleadoActivo.SelectedValue.ToString() != null)
            {
                string COD_EMPLEADO = cboempleadoActivo.SelectedValue.ToString();
                try
                {
                    SqlCommand comando = new SqlCommand("SELECT * FROM T_MAE_PERSONAL WHERE COD_EMPLEADO = '" + COD_EMPLEADO + "'", conexion.conexionBD());

                    SqlDataReader recorre = comando.ExecuteReader();
                    while (recorre.Read())
                    {
                        lbldni.Text = recorre["DOCT_IDENT"].ToString();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
                }
            }
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            registarvale();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiardatos();
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedValue.ToString() != null)
            {
                string cod_producto = cboProducto.SelectedValue.ToString();
                SqlCommand comando = new SqlCommand("SELECT * FROM T_MAE_PRODUCTO WHERE COD_PRODUCTO_MATERIAL = '" + cod_producto + "'", conexion.conexionBD());
                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtstock.Text = recorre["STOCK_ACTUAL"].ToString();
                    txtstockminimo.Text = recorre["STOCK_MINIMO"].ToString();
                }

                SqlCommand comando_2 = new SqlCommand("SELECT * FROM v_cuotas_calzado WHERE COD_PRODUCTO_UNI_CALZADO = '" + cod_producto + "'", conexion.conexionBD());
                SqlDataReader recorre_2 = comando_2.ExecuteReader();
                while (recorre_2.Read())
                {
                    string cuo = recorre_2["detalle_cuotas"].ToString();
                    string des = recorre_2["descuento_por_cuota"].ToString();
                  

                    txtObservacion.Text ="S/"+ des + " ("+cuo+")";
                }

                int stock_a = Convert.ToInt32(txtstock.Text);
                int stock_m = Convert.ToInt32(txtstockminimo.Text);
                if (stock_a > stock_m)
                {
                    txtstock.BackColor = Color.FromArgb(195, 241, 202);
                }
                else if (stock_a < 10)
                {
                    txtstock.BackColor = Color.FromArgb(255, 200, 206);
                }
                else if (stock_a < stock_m)
                {
                    txtstock.BackColor = Color.FromArgb(254, 235, 156);
                }
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
