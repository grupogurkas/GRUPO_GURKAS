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
    public partial class frmRegistrarOrden : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();
        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();
        private Timer ti;
        private DataTable dt;
        int i = 0;
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;

        public frmRegistrarOrden()
        {
            InitializeComponent();
        }
        private void empresa()
        {
            int cod_empresa =Datos.EmpresaID._empresaid;

            SqlCommand comando = new SqlCommand("SELECT * FROM T_EMPRESA WHERE ID_EMPRESA = " + cod_empresa + "", conexion.conexionBD());

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

        public void calculo()
        {
            double total = 0;
            double igv = 0;
            double subtotal = 0;
            foreach (DataGridViewRow row in dgvListaProducto.Rows)
            {
                total += Convert.ToDouble(row.Cells["CostoTotal"].Value);
            }
            txtTotal.Text = Convert.ToString(total);
            igv = Math.Round(total / 1.18, 2);
            subtotal = total - igv;
            txtIgv.Text = Convert.ToString(subtotal);
            txtSubTotal.Text = Convert.ToString(igv);
            cboProducto.SelectedIndex = 0;
            txtCantidadProducto.Text = "";
            txtCostoUnitario.Text = "";
            txtCostoTotal.Text = "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerProveedoresLogistico(cboProveedorActivo);
            Llenadocbo.ObtenerProducto(cboProducto);
            txtNumOrden.Enabled = false;
            timer1.Enabled = true;
            txtCostoTotal.Enabled = false;
            GenerarNumOrden();
            txtCostoTotal.Text = "0";
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("CodProducto");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("CostoUnitario");
            dt.Columns.Add("CostoTotal");
            dgvListaProducto.DataSource = dt;
            empresa();
            lbldireccion.Visible = false;
            lblemp.Visible = false;
            lblnombrear.Visible = false;
            lblruc.Visible = false;
            lblver.Visible = false;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
 
        public void GenerarNumOrden()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("SELECT ROW_NUMBER()OVER(ORDER BY num_orden_compra)AS 't'  FROM t_orden_compra GROUP BY num_orden_compra", conexion.conexionBD());
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
                txtNumOrden.Text = "LOG-C-000000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtNumOrden.Text = "LOG-C-00000" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtNumOrden.Text = "LOG-C-0000" + (numero + 1);
            }
            if (numero > 9999 && numero < 10000)
            {
                txtNumOrden.Text = "LOG-C-000" + (numero + 1);
            }
        }
        private void agregardataProducto()
        {
                string cod_producto = cboProducto.SelectedValue.ToString();
                string nombre_producto = cboProducto.GetItemText(cboProducto.SelectedItem);
                string cantidad = txtCantidadProducto.Text;
                string costo_unitario = txtCostoUnitario.Text;
                string costo_total = txtCostoTotal.Text;
                int n = dgvListaProducto.Rows.Count;
                string c = Convert.ToString(n + 1);
                DataRow row = dt.NewRow();
                row["ID"] = c;
                row["CodProducto"] = cod_producto;
                row["Nombre"] = nombre_producto;
                row["Cantidad"] = cantidad;
                row["CostoUnitario"] = costo_unitario;
                row["CostoTotal"] = costo_total;
                dt.Rows.Add(row);
                if ((n + 1) == 26)
                {
                    btnAgregar.Enabled = false;
                }
        }
        private void txtCostoUnitario_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidadProducto.Text != "" && txtCostoUnitario.Text != "")
            {
                double n1, n2, r;
                n1 = Convert.ToDouble(txtCantidadProducto.Text);
                n2 = Convert.ToDouble(txtCostoUnitario.Text);
                r = n1 * n2;
                txtCostoTotal.Text = r.ToString();
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
                calculo();
            }
            int n = dgvListaProducto.Rows.Count;

            if ((n + 1) < 27)
            {
                btnAgregar.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregardataProducto();
            calculo();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image cabezera = Properties.Resources._1logogurkas;

            string TIPO_PERSONAL = cboProveedorActivo.GetItemText(txtProveedor.Text);
            string RUC = txtruc.Text;
            string CONTACTO_PROVEEDOR = txtNombreProveedor.Text;
            string DIRECCION = txtDireccion.Text;
            string CORREO = txtCorreo.Text;
            string TELEFONO = txtTelefono.Text;
            string CELULAR = txtCelular.Text;
            string OBSERVACION = txtObservacion.Text;
            string SUBTOAL = txtSubTotal.Text;
            string IGV = txtIgv.Text;
            string TOTAL = txtTotal.Text;
            string num = txtNumOrden.Text;
            string fecha = lblFecha.Text;
            string empreas = lblemp.Text;
            string ruc = lblruc.Text;
            string dir = lbldireccion.Text;
            string nombre_arc = lblnombrear.Text;
            string ver = lblver.Text;

            Font tipoTexto = new Font("Arial", 10, FontStyle.Bold);
            Font desp = new Font("Arial", 8, FontStyle.Bold); 
            Font nombres = new Font("Arial", 7, FontStyle.Bold);
            Font datos = new Font("Arial", 6, FontStyle.Bold);
            e.Graphics.DrawImage(cabezera, 40, 25);

            Pen blackPen = new Pen(Color.Black, 2);

            Rectangle N1 = new Rectangle(20, 90, 770, 100);
            Rectangle N2 = new Rectangle(20, 90, 300, 50);
            Rectangle N3 = new Rectangle(20, 140, 300, 50);
            Rectangle N4 = new Rectangle(320, 140, 470, 50);
            Rectangle observaciones = new Rectangle(20, 925, 560, 100);
            Rectangle N9 = new Rectangle(20, 20, 230, 60);
            Rectangle N10 = new Rectangle(250, 20, 320, 60);
            Rectangle N11 = new Rectangle(570, 20, 220, 60);
            Rectangle N12 = new Rectangle(570, 20, 220, 30);
            Rectangle subtotal = new Rectangle(580, 925, 210, 32);
            Rectangle igv = new Rectangle(580, 957, 210, 34);
            Rectangle ITEM_ = new Rectangle(20, 210, 50, 715);
            Rectangle CODIGO_ = new Rectangle(70, 210, 60, 715);
            Rectangle PRODUCTO_ = new Rectangle(130, 210, 400, 715);
            Rectangle OBSERVACION_ = new Rectangle(530, 210, 100, 715);
            Rectangle CONDICION_ = new Rectangle(630, 210, 100, 715);
            Rectangle CANT_ = new Rectangle(730, 210, 60, 715);
            Rectangle RESUMEN_ = new Rectangle(580, 925, 210, 100);

            e.Graphics.DrawRectangle(blackPen, subtotal);
            e.Graphics.DrawRectangle(blackPen, igv);
            e.Graphics.DrawRectangle(blackPen, N1);
            e.Graphics.DrawRectangle(blackPen, N2);
            e.Graphics.DrawRectangle(blackPen, N3);
            e.Graphics.DrawRectangle(blackPen, N4);
            e.Graphics.DrawRectangle(blackPen, observaciones);
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
            e.Graphics.DrawRectangle(blackPen, RESUMEN_);
            e.Graphics.DrawString("ORDEN DE COMPRA", tipoTexto, Brushes.Black, 310, 25);
            e.Graphics.DrawString(empreas, nombres, Brushes.Black, 290, 45);
            e.Graphics.DrawString("  RUC " + ruc, nombres, Brushes.Black, 420, 45);
            e.Graphics.DrawString(nombre_arc, datos, Brushes.Black, 580, 25);
            e.Graphics.DrawString(ver, datos, Brushes.Black, 580, 35);
            e.Graphics.DrawString(num, tipoTexto, Brushes.Black, 580, 55);

            string anio = DateTime.Now.Year.ToString();

            e.Graphics.DrawString(" - " + anio, tipoTexto, Brushes.Black, 720, 55);
            e.Graphics.DrawString(dir, datos, Brushes.Black, new RectangleF(260, 60, 300, 30));
            e.Graphics.DrawString("R.S. : ", tipoTexto, Brushes.Black, 30, 100);
            e.Graphics.DrawString(TIPO_PERSONAL, desp, Brushes.Black, 120, 102);
            e.Graphics.DrawString("RUC : ", tipoTexto, Brushes.Black, 30, 150);
            e.Graphics.DrawString(RUC, desp, Brushes.Black, 120, 152);
            e.Graphics.DrawString("FECHA   : ", tipoTexto, Brushes.Black, 30, 170);
            e.Graphics.DrawString(fecha, desp, Brushes.Black, 120, 172);
            e.Graphics.DrawString("DIRECCION : ", tipoTexto, Brushes.Black, 330, 100);
            e.Graphics.DrawString(DIRECCION, desp, Brushes.Black, 430, 102);
            e.Graphics.DrawString("CONTACTO : ", tipoTexto, Brushes.Black, 330, 150);
            e.Graphics.DrawString(CONTACTO_PROVEEDOR, nombres, Brushes.Black, 430, 152);
            e.Graphics.DrawString("CORREO : ", tipoTexto, Brushes.Black, 330, 170);
            e.Graphics.DrawString(CORREO, desp, Brushes.Black, 430, 172);
            e.Graphics.DrawString("TELEFONO :", tipoTexto, Brushes.Black, 610, 150);
            e.Graphics.DrawString(TELEFONO, desp, Brushes.Black, 700, 152);
            e.Graphics.DrawString("CELULAR : ", tipoTexto, Brushes.Black, 610, 170);
            e.Graphics.DrawString(CELULAR, desp, Brushes.Black, 700, 172);
            e.Graphics.DrawString("SUBTOTAL : ", tipoTexto, Brushes.Black, 580, 935);
            e.Graphics.DrawString("S/ " +SUBTOAL, tipoTexto, Brushes.Black, 690, 935);
            e.Graphics.DrawString("IGV : ", tipoTexto, Brushes.Black, 580, 970);
            e.Graphics.DrawString("S/ " + IGV, tipoTexto, Brushes.Black, 690, 970);
            e.Graphics.DrawString("TOTAL : ", tipoTexto, Brushes.Black, 580, 1000);
            e.Graphics.DrawString("S/ " + TOTAL, tipoTexto, Brushes.Black, 690, 1000);
            e.Graphics.DrawString("_______________________", tipoTexto, Brushes.Black, 50, 1080);
            e.Graphics.DrawString("V°B° JEFE DE LOGISTICA", tipoTexto, Brushes.Black, 50, 1100);
            e.Graphics.DrawString("'Se debe anexar captura de pantalla del correo donde aprueba la GERENCIA GENERAL para que tenga validez dicha orden'", nombres, Brushes.Black, 50, 1130);

            string l1 = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 20, 220);//360
            string g1 = "ITEM";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 7, FontStyle.Bold), Brushes.Black, 30, 215);
            string g2 = "CODIGO";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 7, FontStyle.Bold), Brushes.Black, 72, 215);
            string g3 = "DESCRIPCION";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 7, FontStyle.Bold), Brushes.Black, 180, 215);
            string g4 = "CANTIDAD";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 7, FontStyle.Bold), Brushes.Black, 538, 215);
            string g5 = "COST.UNIT";
            e.Graphics.DrawString(g5, new System.Drawing.Font("Book Antiqua", 7, FontStyle.Bold), Brushes.Black, 645, 215);
            string g6 = "COSTO";
            e.Graphics.DrawString(g6, new System.Drawing.Font("Book Antiqua", 7, FontStyle.Bold), Brushes.Black, 735, 215);
            e.Graphics.DrawString("OBSEVACIONES : ", tipoTexto, Brushes.Black, 40, 935);
            e.Graphics.DrawString(OBSERVACION, tipoTexto, Brushes.Black, new RectangleF(40, 955, 500, 50));

            int height = 220;
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

                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[4].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(540, height, 90, 40));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[5].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(640, height, 100, 100));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[6].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(750, height, 30, 20));
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

        public void registarvaleordencompar()
        {
            string cod_proveedor = cboProveedorActivo.SelectedValue.ToString();
            string nomb_proveedor = txtProveedor.Text;
            string ruc = txtruc.Text;
            string contacto = txtNombreProveedor.Text;
            string direccion = txtDireccion.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string celular = txtCelular.Text;
            string NUM_ORDEN = txtNumOrden.Text;
            string observacion = txtObservacion.Text;
            DateTime fecha_ = dtpFechaAdquisicion.Value;
            string fecha_vale = lblFecha.Text;
            string hora = lblHora.Text;
            string nombre_user = Datos.DatosUsuario._usuario;
            try
            {
                SqlCommand comando = new SqlCommand("sp_registrar_orden @num_orden_compra,@cod_proveedor,@nombre_proveedor,@nombre_contacto,@ruc," +
                    "@direccion,@correo,@telefono,@celular,@fecha_orden_compra,@item_vale,@COD_PRODUCT,@DESP_PRODUCTO,@cantidad_producto,@costo_unitario," +
                    "@costo_total,@observacion,@hora,@usuario,@fecha_registro", conexion.conexionBD());

                foreach (DataGridViewRow row in dgvListaProducto.Rows)
                {
                    if (row.Cells["ID"].Value != null && row.Cells["CodProducto"].Value != null)
                    {
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@num_orden_compra", SqlDbType.VarChar).Value = NUM_ORDEN;
                        comando.Parameters.AddWithValue("@cod_proveedor", SqlDbType.VarChar).Value = cod_proveedor;
                        comando.Parameters.AddWithValue("@nombre_proveedor", SqlDbType.VarChar).Value = nomb_proveedor;
                        comando.Parameters.AddWithValue("@nombre_contacto", SqlDbType.VarChar).Value = contacto;
                        comando.Parameters.AddWithValue("@ruc", SqlDbType.VarChar).Value = ruc;
                        comando.Parameters.AddWithValue("@direccion", SqlDbType.VarChar).Value = direccion;
                        comando.Parameters.AddWithValue("@correo", SqlDbType.VarChar).Value = correo;
                        comando.Parameters.AddWithValue("@telefono", SqlDbType.VarChar).Value = telefono;
                        comando.Parameters.AddWithValue("@celular", SqlDbType.VarChar).Value = celular;
                        comando.Parameters.AddWithValue("@fecha_orden_compra", SqlDbType.VarChar).Value = fecha_vale;
                        comando.Parameters.AddWithValue("@item_vale", Convert.ToInt32(row.Cells["ID"].Value));
                        comando.Parameters.AddWithValue("@COD_PRODUCT", Convert.ToString(row.Cells["CodProducto"].Value));
                        comando.Parameters.AddWithValue("@DESP_PRODUCTO", Convert.ToString(row.Cells["Nombre"].Value));
                        comando.Parameters.AddWithValue("@cantidad_producto", Convert.ToDouble(row.Cells["Cantidad"].Value));
                        comando.Parameters.AddWithValue("@costo_unitario", Convert.ToDouble(row.Cells["CostoUnitario"].Value));
                        comando.Parameters.AddWithValue("@costo_total", Convert.ToDouble(row.Cells["CostoTotal"].Value));
                        comando.Parameters.AddWithValue("@observacion", SqlDbType.VarChar).Value = observacion;
                        comando.Parameters.AddWithValue("@hora", SqlDbType.VarChar).Value = hora;
                        comando.Parameters.AddWithValue("@usuario", SqlDbType.VarChar).Value = nombre_user;
                        comando.Parameters.AddWithValue("@fecha_registro", SqlDbType.DateTime).Value = fecha_;
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Datos registrado correptamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se pudo realizar el guardado del la asistencia del personal \n\n Verifique su conexion al Servidor " + ex, "Error");
            }
        }
        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDocument1;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
                registarvaleordencompar();
                limpiardatos();
            }
           //printPreviewDialog1.ShowDialog();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiardatos();
        }
        private void limpiardatos()
        {
            cboProveedorActivo.SelectedIndex = 0;
            txtProveedor.Text = "";
            txtruc.Text = "";
            txtNombreProveedor.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            GenerarNumOrden();
            
            cboProducto.SelectedIndex = 0;
            txtCantidadProducto.Text = "";
            txtCostoUnitario.Text = "";
            txtCostoTotal.Text = "";
            txtObservacion.Text = "";
            txtSubTotal.Text = "";
            txtIgv.Text = "";
            txtTotal.Text = "";
            dt.Clear();
        }

        private void cboProveedorActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProveedorActivo.SelectedValue.ToString() != null)
            {
                try
                {
                    string cod_provedor = cboProveedorActivo.SelectedValue.ToString();

                    SqlCommand comando = new SqlCommand("select *from t_proveedor where cod_proveedor = '" + cod_provedor + "'", conexion.conexionBD());

                    SqlDataReader recorre = comando.ExecuteReader();
                    while (recorre.Read())
                    {
                        txtProveedor.Text = recorre["nomb_proveedor"].ToString();
                        txtruc.Text = recorre["ruc"].ToString();
                        txtNombreProveedor.Text = recorre["nomb_contacto"].ToString();
                        txtDireccion.Text = recorre["direccion"].ToString();
                        txtCorreo.Text = recorre["correo"].ToString();
                        txtTelefono.Text = recorre["telefono"].ToString();
                        txtCelular.Text = recorre["celular"].ToString();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
                }
            } 
        }

        private void txtCantidadProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidadProducto.Text != "" && txtCostoUnitario.Text != "")
            {
                double n1, n2, r;
                n1 = Convert.ToDouble(txtCantidadProducto.Text);
                n2 = Convert.ToDouble(txtCostoUnitario.Text);
                r = n1 * n2;
                txtCostoTotal.Text = r.ToString();
            }
        }
        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {
            txtObservacion.MaxLength = 264;
        }
    }
}
