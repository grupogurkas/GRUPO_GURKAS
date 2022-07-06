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
    public partial class frmDestruccion : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.ConexionMysql conexionmysql = new Datos.ConexionMysql();
        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();
        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();
        private Timer ti;
        private DataTable dt;
        public string cantidadrest;
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;


        public frmDestruccion()
        {
            InitializeComponent();
        }

        private void Destruccion_Load(object sender, EventArgs e)
        {
            generarnumero();
            txtUsuarioEntrega.Enabled = false;
            txtstock.Enabled = false;
            txtstock.Text = "0";
            txtRestante.Text = "0";
            txtRestante.Visible = true;
            txtvale.Enabled = false;
            txtObservacion.Text = "EN BASE";
            string nombre_user = Datos.DatosUsuario._usuario;
            txtUsuarioEntrega.Text = nombre_user;
            Llenadocbo.ObtenerPersonalAdmi(cboPersonalAdm);
            Llenadocbo.ObtenerEstadoProductoCompleto(cboEstadoMaterial);
            Llenadocbo.ObtenerArea(cboAreaLaboral);
            Llenadocbo.ObtenerProducto(cboProducto);
            lbldireccion.Visible = false;
            lblemp.Visible = false;
            lblnombrear.Visible = false;
            lblruc.Visible = false;
            lblver.Visible = false;
            lbldni.Visible = false;
            lblcodentre.Visible = false;
            lbldnientr.Visible = false;
            txtstock.Text = cantidadrest;
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
            timer1.Enabled = true;
            dgvListaProducto.RowHeadersVisible = false;
            dgvListaProducto.AllowUserToAddRows = false;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Registro de Personal";
            const string mensaje = "Estas seguro que deseas cerra el Registro Destruccion";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDocument1;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
                //registarvaleordencompar();
                //limpiardatos();
                //printPreviewDialog1.ShowDialog();

            }
        }

        private void generarnumero()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("SELECT ROW_NUMBER()OVER(ORDER BY NUM_ENTREGA)AS 't'  FROM t_destruccion_producto_vale GROUP BY NUM_ENTREGA", conexion.conexionBD());

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
                txtvale.Text = "N°- 00000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtvale.Text = "N°- 0000" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtvale.Text = "N°- 000" + (numero + 1);
            }
            if (numero > 9999 && numero < 10000)
            {
                txtvale.Text = "N°- 00" + (numero + 1);
            }
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image cabezera = Properties.Resources._1logogurkas;


            string AREA_ENTREGA = cboAreaLaboral.GetItemText(cboAreaLaboral.SelectedItem);
            string PERSONAL = cboPersonalAdm.GetItemText(cboPersonalAdm.SelectedItem);
            string entrega = txtUsuarioEntrega.Text;
            string DIRECCION = txtDireccion.Text;
            string informacion_adicional = txtInformacionAdicional.Text;
            string fecha = lblFecha.Text;
            string emp = lblemp.Text;
            string ruc = lblruc.Text;
            string dir = lbldireccion.Text;
            string nombre_arc = lblnombrear.Text;
            string hora = lblHora.Text;
            string ver = lblver.Text;
            string dni = lbldni.Text;
            string dnien = lbldnientr.Text;
            string cod = lblcodentre.Text;
            string num = txtvale.Text;


            Font tipoTexto = new Font("Arial", 10, FontStyle.Bold);
            Font desp = new Font("Arial", 8, FontStyle.Bold);
            Font nombres = new Font("Arial", 7, FontStyle.Bold);
            Font datos = new Font("Arial", 6, FontStyle.Bold);
            e.Graphics.DrawImage(cabezera, 40, 25);

            Pen blackPen = new Pen(Color.Black, 2);

            Rectangle N1 = new Rectangle(20, 85, 770, 90);
            Rectangle N2 = new Rectangle(20, 90, 300, 50);
            Rectangle N3 = new Rectangle(20, 140, 300, 50);
            Rectangle N4 = new Rectangle(320, 140, 470, 50);
            Rectangle observaciones = new Rectangle(20, 650, 380, 220);
            Rectangle N9 = new Rectangle(20, 20, 230, 60);
            Rectangle N10 = new Rectangle(250, 20, 320, 60);
            Rectangle N11 = new Rectangle(570, 20, 220, 60);
            Rectangle N12 = new Rectangle(570, 20, 220, 30);
            Rectangle ITEM_ = new Rectangle(20, 180, 50, 480);
            Rectangle CODIGO_ = new Rectangle(70, 180, 60, 480);
            Rectangle PRODUCTO_ = new Rectangle(130, 180, 400, 480);
            Rectangle OBSERVACION_ = new Rectangle(530, 180, 100, 480);
            Rectangle CONDICION_ = new Rectangle(630, 180, 100, 480);
            Rectangle CANT_ = new Rectangle(730, 180, 60, 480);
            Rectangle IMAGE_ = new Rectangle(450, 700, 340, 340);
            e.Graphics.DrawRectangle(blackPen, N1);
            //e.Graphics.DrawRectangle(blackPen, N2);
            //e.Graphics.DrawRectangle(blackPen, N3);
            //e.Graphics.DrawRectangle(blackPen, N4);
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
            e.Graphics.DrawRectangle(blackPen, IMAGE_);
            e.Graphics.DrawString("ACTA DE DESTRUCCION", tipoTexto, Brushes.Black, 310, 25);
            e.Graphics.DrawString(nombre_arc, datos, Brushes.Black, 580, 25);
            e.Graphics.DrawString(ver, datos, Brushes.Black, 580, 35);
            e.Graphics.DrawString(num, tipoTexto, Brushes.Black, 580, 55);

            string anio = DateTime.Now.Year.ToString();

            e.Graphics.DrawString("-" + anio, tipoTexto, Brushes.Black, 720, 55);

            e.Graphics.DrawString(dir, datos, Brushes.Black, new RectangleF(260, 60, 300, 30));

            e.Graphics.DrawString(dir, datos, Brushes.Black, new RectangleF(260, 60, 300, 30));
            e.Graphics.DrawString("Area : ", tipoTexto, Brushes.Black, 30, 100);
            e.Graphics.DrawString(AREA_ENTREGA, desp, Brushes.Black, 120, 102);
            e.Graphics.DrawString("FECHA  : ", tipoTexto, Brushes.Black, 30, 120);
            e.Graphics.DrawString(fecha, desp, Brushes.Black, 120, 122);
            e.Graphics.DrawString("HORA   : ", tipoTexto, Brushes.Black, 30, 145);
            e.Graphics.DrawString(hora, desp, Brushes.Black, 120, 147);
            e.Graphics.DrawString("DIRECCION : ", tipoTexto, Brushes.Black, 330, 100);
            e.Graphics.DrawString(DIRECCION, desp, Brushes.Black, 430, 102);
            e.Graphics.DrawString("Encargado Destruccion : ", tipoTexto, Brushes.Black, 330, 120);
            e.Graphics.DrawString(entrega, nombres, Brushes.Black, 500, 122);
            e.Graphics.DrawString("Personal Que Evidencia : ", tipoTexto, Brushes.Black, 330, 145);
            e.Graphics.DrawString(PERSONAL, desp, Brushes.Black, 500, 147);

            string l1 = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 20, 195);//360

            string g1 = "ITEM";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 30, 190);

            string g2 = "CODIGO";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 72, 190);

            string g3 = "DESCRIPCION";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 200, 190);

            string g6 = "OBSERVACION";
            e.Graphics.DrawString(g6, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 538, 190);

            string g4 = "CONDICION";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 645, 190);

            string g5 = "CANT.";
            e.Graphics.DrawString(g5, new System.Drawing.Font("Book Antiqua", 8, FontStyle.Bold), Brushes.Black, 735, 190);
            //int y = 20;
            //e.Graphics.DrawString("Informacion : ", tipoTexto, Brushes.Black, 40, 935);
            e.Graphics.DrawImage(pictureBox2.Image, new Rectangle(450, 700, 340, 340));
            e.Graphics.DrawString("Informacion : ", tipoTexto, Brushes.Black, 40, 710);
            e.Graphics.DrawString(informacion_adicional, tipoTexto, Brushes.Black, new RectangleF(40, 725, 500, 50));
            e.Graphics.DrawString("_______________________", tipoTexto, Brushes.Black, 40, 1000);
            e.Graphics.DrawString("V°B° JEFE DE LOGISTICA", tipoTexto, Brushes.Black, 40, 1020);
            e.Graphics.DrawString("_______________________", tipoTexto, Brushes.Black, 240, 1000);
            e.Graphics.DrawString("PERSONAL QUE EVIDENCIA", tipoTexto, Brushes.Black, 240, 1020);

            int height = 190;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiardatos();
        }
        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog Imagen = new OpenFileDialog();

            if (Imagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = Imagen.FileName;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void limpiardatos()
        {
            cboAreaLaboral.SelectedIndex = 0;
            txtDireccion.Text = "";
            cboAreaLaboral.SelectedIndex = 0;
            cboProducto.SelectedIndex = 0;
            cboEstadoMaterial.SelectedIndex = 0;
            txtInformacionAdicional.Text = "";
            txtObservacion.Text = "";
            txtstock.Text = "";
            txtCantidadTecno.Text = "";
            //pictureBox2.Image = ;
            dt.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
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
    }
}
