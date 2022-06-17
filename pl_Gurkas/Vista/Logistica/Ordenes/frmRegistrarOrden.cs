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
        Datos.ConexionMysql conexionmysql = new Datos.ConexionMysql();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            rdtCompraProducto.Checked = true;
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

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {
            txtObservacion.MaxLength = 18;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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

        public void GenerarNumOrden()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("SELECT ROW_NUMBER()OVER(ORDER BY num_orden)AS 't'  FROM t_orden_producto_numb GROUP BY num_orden", conexion.conexionBD());

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
                txtNumOrden.Text = "LOG-000000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtNumOrden.Text = "LOG-00000" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtNumOrden.Text = "LOG-0000" + (numero + 1);
            }
            if (numero > 9999 && numero < 10000)
            {
                txtNumOrden.Text = "LOG-000" + (numero + 1);
            }
        }

      

        private void agregardataProducto()
        {
           
                string cod_producto = cboProducto.SelectedValue.ToString();
                string nombre_producto = cboProducto.GetItemText(cboProducto.SelectedItem);
                string cantidad = txtCantidadProducto.Text;
                string costo_unitario = txtCostoUnitario.Text;
                string costo_total = txtCostoTotal.Text;
                //string observacion = txtObservacion.Text;
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

        private void agregardataServicio()
        {
   
                string cod_producto = cboProducto.SelectedValue.ToString();
                string nombre_producto = txtProductoServicio.Text;
                string cantidad = txtCantidadProducto.Text;
                string costo_unitario = txtCostoUnitario.Text;
                string costo_total = txtCostoTotal.Text;
                //string observacion = txtObservacion.Text;
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

        private void rdtCompraProducto_CheckedChanged(object sender, EventArgs e)
        {
            if(rdtCompraProducto.Checked == true)
            {
                //txtProductoServicio.Enabled = false;
                txtProductoServicio.Visible = false;
                cboProducto.Visible = true;
            }
        }

        private void rdtServicioProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdtServicioProducto.Checked == true)
            {
                //cboProducto.Enabled = false;
                txtProductoServicio.Visible = true;
                cboProducto.Visible = false;
            }
        }

        private void txtCostoUnitario_TextChanged(object sender, EventArgs e)
        {
            if(txtCostoUnitario.Text != "")
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
            }
            int n = dgvListaProducto.Rows.Count;

            if ((n + 1) < 27)
            {
                btnAgregar.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (rdtCompraProducto.Checked)
            {
                agregardataProducto();
            }
            else if (rdtServicioProducto.Checked)
            {
                agregardataServicio();
            }

            double total = 0;
            double igv = 0;
            double subtotal = 0;
            foreach (DataGridViewRow row in dgvListaProducto.Rows)
            {
                total += Convert.ToDouble(row.Cells["CostoTotal"].Value);
                
            }
            txtTotal.Text = Convert.ToString(total);
            igv = total * 18/100;
            txtIgv.Text = Convert.ToString(igv);
            subtotal = total - igv;
            txtSubTotal.Text = Convert.ToString(subtotal);
            cboProducto.SelectedIndex = 0;
            txtCantidadProducto.Text = "";
            txtCostoUnitario.Text = "";
            txtCostoTotal.Text = "";

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image cabezera = Properties.Resources._1logogurkas;

            string TIPO_PERSONAL = cboProveedorActivo.GetItemText(txtProveedor.Text);
            //string PERSONAL = cboempleadoActivo.GetItemText(cboempleadoActivo.SelectedItem);
            //string entrega = txtUsuarioEntrega.Text;
            //string cod_empleado = cboempleadoActivo.SelectedValue.ToString();
            string RUC = txtruc.Text;
            string CONTACTO_PROVEEDOR = txtNombreProveedor.Text;
            string DIRECCION = txtDireccion.Text;
            string CORREO = txtCorreo.Text;
            string TELEFONO = txtTelefono.Text;
            string CELULAR = txtCelular.Text;
            string OBSERVACION = txtObservacion.Text;


            string num = txtNumOrden.Text;
            string fecha = lblFecha.Text;


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

            e.Graphics.DrawString("ORDEN DE COMPRA/SERVICIO", tipoTexto, Brushes.Black, 310, 25);
            //e.Graphics.DrawString(emp, nombres, Brushes.Black, 290, 45);
            //e.Graphics.DrawString("  RUC " + ruc, nombres, Brushes.Black, 420, 45);
            // e.Graphics.DrawString(dir, datos, Brushes.Black, 250, 60);
            //e.Graphics.DrawString(nombre_arc, datos, Brushes.Black, 580, 25);
            //e.Graphics.DrawString(ver, datos, Brushes.Black, 580, 35);
            e.Graphics.DrawString(num, tipoTexto, Brushes.Black, 580, 55);

            string anio = DateTime.Now.Year.ToString();

            e.Graphics.DrawString(" - " + anio, tipoTexto, Brushes.Black, 720, 55);

            //e.Graphics.DrawString(dir, datos, Brushes.Black, new RectangleF(260, 60, 300, 30));

            e.Graphics.DrawString("NOMBRE : ", tipoTexto, Brushes.Black, 30, 100);
            e.Graphics.DrawString(TIPO_PERSONAL, desp, Brushes.Black, 120, 102);

           // e.Graphics.DrawString("RUC : ", tipoTexto, Brushes.Black, 30, 100);
            //e.Graphics.DrawString(RUC, desp, Brushes.Black, 120, 102);

            e.Graphics.DrawString("FECHA   : ", tipoTexto, Brushes.Black, 30, 120);
            e.Graphics.DrawString(fecha, desp, Brushes.Black, 120, 122);

            e.Graphics.DrawString("CONTACTO : ", tipoTexto, Brushes.Black, 320, 100);
            e.Graphics.DrawString(CONTACTO_PROVEEDOR, nombres, Brushes.Black, 200, 102);

            //e.Graphics.DrawString("CONTACTO PROVEEDOR : ", tipoTexto, Brushes.Black, 320, 100);
            //e.Graphics.DrawString(CONTACTO_PROVEEDOR, desp, Brushes.Black, 470, 102);

            e.Graphics.DrawString("RUC : ", tipoTexto, Brushes.Black, 320, 120);//160
            e.Graphics.DrawString(RUC, desp, Brushes.Black, 470, 122);

            e.Graphics.DrawString("DIRECCION : ", tipoTexto, Brushes.Black, 30, 140);
            e.Graphics.DrawString(DIRECCION, desp, Brushes.Black, 120, 142);

            e.Graphics.DrawString("CORREO : ", tipoTexto, Brushes.Black, 30, 160);
            e.Graphics.DrawString(CORREO, desp, Brushes.Black, 120, 162);

            e.Graphics.DrawString("TELEFONO", tipoTexto, Brushes.Black, 320, 140);
            e.Graphics.DrawString(TELEFONO, desp, Brushes.Black, 470, 142);

            e.Graphics.DrawString("CELULAR : ", tipoTexto, Brushes.Black, 320, 160);
            e.Graphics.DrawString(CELULAR, desp, Brushes.Black, 470, 162);

            /*e.Graphics.DrawString("CODIGO : ", tipoTexto, Brushes.Black, 30, 240);
            e.Graphics.DrawString(cod_empleado, desp, Brushes.Black, 110, 243);
            e.Graphics.DrawString("DNI : ", tipoTexto, Brushes.Black, 200, 240);
            e.Graphics.DrawString(dni, desp, Brushes.Black, 240, 243);

            e.Graphics.DrawString("NOMBRE : ", tipoTexto, Brushes.Black, 420, 220);
            e.Graphics.DrawString(entrega, nombres, Brushes.Black, 500, 223);

            e.Graphics.DrawString("CODIGO : ", tipoTexto, Brushes.Black, 420, 240);
            e.Graphics.DrawString(cod, desp, Brushes.Black, 500, 243);
            e.Graphics.DrawString("DNI : ", tipoTexto, Brushes.Black, 600, 240);
            e.Graphics.DrawString(dnien, desp, Brushes.Black, 650, 243);*/

            e.Graphics.DrawString("FIRMA : _______________________________", tipoTexto, Brushes.Black, 30, 275);
            e.Graphics.DrawString("FIRMA : _______________________________", tipoTexto, Brushes.Black, 420, 275);

            string l1 = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 20, 320);//360

            string g1 = "ITEM";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 30, 315);

            string g2 = "CODIGO";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 72, 315);

            string g3 = "DESCRIPCION";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 180, 315);

            string g6 = "CANTIDAD";
            e.Graphics.DrawString(g6, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 645, 315);

            string g4 = "COST.UNIT";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 800, 315);

            string g5 = "COST.TOTAL";
            e.Graphics.DrawString(g5, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 538, 315);

            e.Graphics.DrawString("INFORMACIÓN ADICIONAL : ", tipoTexto, Brushes.Black, 50, 1050);
            e.Graphics.DrawString(OBSERVACION, tipoTexto, Brushes.Black, new RectangleF(50, 1070, 700, 50));

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
                //registarvale();
                //limpiardatos();
            }
            //printPreviewDialog1.ShowDialog();
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            registrarOrden();
        }

        private void registrarOrden()
        {
            int cod_proveedor = cboProveedorActivo.SelectedIndex;
            string nomb_proveedor = txtProveedor.Text;
            string ruc = txtruc.Text;
            string contacto = txtNombreProveedor.Text;
            string direccion = txtDireccion.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string celular = txtCelular.Text;
            string NUM_ORDEN = txtNumOrden.Text;
            string observacion = txtObservacion.Text;
            string fecha_vale = lblFecha.Text;
            string hora = lblHora.Text;
            string nombre_user = Datos.DatosUsuario._usuario;
           
            try
            {
                SqlCommand comando = new SqlCommand("sp_registrar_orden @num_orden ,@cod_proveedor , @ruc,@nombre_contacto  ,@direccion ,@correo, @telefono, @celular, @ENTREGADO_NOMBRE," +
                    "@COD_ENTREGADO, @DNI_ENTREGADO, @COD_PRODUCT, @cantidad_producto, , @costo_unitario ,@costo_total ,@observacion_producto,   @FECHA_VALE," +
                    "@fecha_orden, @item_vale, @fecha_registro , @fecha_sistema" +
                    ", @hora, @usuario ", conexion.conexionBD());

                foreach (DataGridViewRow row in dgvListaProducto.Rows)
                {
                    if (row.Cells["ID"].Value != null && row.Cells["CodProducto"].Value != null)
                    {  
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@num_orden", SqlDbType.VarChar).Value = NUM_ORDEN;
                        comando.Parameters.AddWithValue("@cod_proveedor", SqlDbType.Int).Value = cod_proveedor;
                        comando.Parameters.AddWithValue("@nombre_contacto", SqlDbType.VarChar).Value = contacto;
                        comando.Parameters.AddWithValue("@ruc", SqlDbType.VarChar).Value = ruc;
                        comando.Parameters.AddWithValue("@direccion", SqlDbType.VarChar).Value = direccion;
                        comando.Parameters.AddWithValue("@correo", SqlDbType.VarChar).Value = correo;
                        comando.Parameters.AddWithValue("@telefono", SqlDbType.VarChar).Value = telefono;
                        comando.Parameters.AddWithValue("@celular", SqlDbType.VarChar).Value = celular;
                        comando.Parameters.AddWithValue("@fecha_orden", SqlDbType.VarChar).Value = fecha_vale;
                        comando.Parameters.AddWithValue("@ITEM_VALE", Convert.ToInt32(row.Cells["ID"].Value));
                        comando.Parameters.AddWithValue("@COD_PRODUCTO", Convert.ToString(row.Cells["CodProducto"].Value));
                        comando.Parameters.AddWithValue("@DESP_PRODUCTO", Convert.ToString(row.Cells["Nombre"].Value));
                        comando.Parameters.AddWithValue("@OBSERVACION_PRODUCTO", Convert.ToString(row.Cells["Cantidad"].Value));
                        comando.Parameters.AddWithValue("@CONDICION_PRODUCTO", Convert.ToString(row.Cells["CostoUnitario"].Value));
                        comando.Parameters.AddWithValue("@CANTIDAD_SOLICITADA", Convert.ToInt32(row.Cells["CostoTotal"].Value));
                        comando.Parameters.AddWithValue("@observacion_producto", SqlDbType.VarChar).Value = observacion;
                        comando.Parameters.AddWithValue("@HORA", SqlDbType.VarChar).Value = hora;
                        comando.Parameters.AddWithValue("@USUARIO", SqlDbType.VarChar).Value = nombre_user;

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
            txtProductoServicio.Text = "";
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

        private void txtIgv_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
