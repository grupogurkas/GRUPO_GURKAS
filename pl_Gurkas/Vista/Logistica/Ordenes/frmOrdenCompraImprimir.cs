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
    public partial class frmOrdenCompraImprimir : Form
    {
        public string _num_orden;

        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LlenadoDatos.llenadoDatosLogistica Llenadocbo = new Datos.LlenadoDatos.llenadoDatosLogistica();
        Datos.DataReportes.Logistica.DataLogistica reportelogistica = new Datos.DataReportes.Logistica.DataLogistica();
        int i = 0;
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;

        public frmOrdenCompraImprimir()
        {
            InitializeComponent();
        }
        private void empresa_servicio()
        {
            try
            {
                string num_o_s = lblemp.Text;
                SqlCommand comando = new SqlCommand("SELECT * FROM v_vista_orden_compra_datos WHERE num_orden_compra = '" + _num_orden + "'", conexion.conexionBD());

                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    lblRS.Text = recorre["nombre_proveedor"].ToString();
                    lbldireccionemp.Text = recorre["direccion"].ToString();
                    lblrucemp.Text = recorre["ruc"].ToString();
                    lblcorreoemp.Text = recorre["correo"].ToString();
                    lblTelefonoemp.Text = recorre["telefono"].ToString();
                    lblCelEmp.Text = recorre["celular"].ToString();
                    lblanio.Text = recorre["anio"].ToString();
                    lblorden_servicio.Text = recorre["num_orden_compra"].ToString();
                    lblObservacion.Text = recorre["observacion"].ToString();
                    lblFechaOrden.Text = recorre["fecha_orden_compra"].ToString();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }

        }
        public void calculo()
        {
            double total = 0;
            double igv = 0;
            double subtotal = 0;
            foreach (DataGridViewRow row in dgvHistorialOrdenes.Rows)
            {
                total += Convert.ToDouble(row.Cells["CostoTotal"].Value);
            }
            txtTotal.Text = Convert.ToString(total);
            igv = Math.Round(total / 1.18, 2);
            subtotal = total - igv;
            txtIgv.Text = Convert.ToString(subtotal);
            txtSubTotal.Text = Convert.ToString(igv);
        }
        private void empresa()
        {
            int cod_empresa = Datos.EmpresaID._empresaid;

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
        private void buscar_Datos_producto()
        {
            string num_vale_salida = _num_orden;
            dgvHistorialOrdenes.DataSource = reportelogistica.BuscarCompra(num_vale_salida);
        }

        private void frmOrdenCompraImprimir_Load(object sender, EventArgs e)
        {
            lblemp.Text = _num_orden;
            buscar_Datos_producto();
            empresa();
            empresa_servicio();
            calculo();
            dgvHistorialOrdenes.RowHeadersVisible = false;
            dgvHistorialOrdenes.AllowUserToAddRows = false;
            btnPDF.Enabled = false;
        }

        private void BTNPRINT_Click(object sender, EventArgs e)
        {
            
            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDocument1;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
                this.Close();
                //printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image cabezera = Properties.Resources._1logogurkas;

            string TIPO_PERSONAL = lblRS.Text;
            string RUC = lblrucemp.Text;
            string CONTACTO_PROVEEDOR = lblnombrear.Text;
            string DIRECCION = lbldireccionemp.Text;
            string CORREO = lblcorreoemp.Text;
            string TELEFONO = lblTelefonoemp.Text;
            string CELULAR = lblCelEmp.Text;
            string OBSERVACION = lblObservacion.Text;
            string SUBTOAL = txtSubTotal.Text;
            string IGV = txtIgv.Text;
            string TOTAL = txtTotal.Text;
            string num = lblorden_servicio.Text;
            string fecha = lblFechaOrden.Text;
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
            e.Graphics.DrawString("S/ " + SUBTOAL, tipoTexto, Brushes.Black, 690, 935);
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
            for (int l = numberOfItemsPrintedSoFar; l < dgvHistorialOrdenes.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;
                    if (numberOfItemsPrintedSoFar <= dgvHistorialOrdenes.Rows.Count)
                    {
                        height += dgvHistorialOrdenes.Rows[0].Height;
                       // e.Graphics.DrawString(dgvHistorialOrdenes.Rows[l].Cells[0].FormattedValue.ToString(), dgvHistorialOrdenes.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(30, height, 10, 10));
                        e.Graphics.DrawString(dgvHistorialOrdenes.Rows[l].Cells[0].FormattedValue.ToString(), dgvHistorialOrdenes.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(30, height, 30, 20));
                        e.Graphics.DrawString(dgvHistorialOrdenes.Rows[l].Cells[1].FormattedValue.ToString(), dgvHistorialOrdenes.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(77, height, 100, 100));
                        e.Graphics.DrawString(dgvHistorialOrdenes.Rows[l].Cells[2].FormattedValue.ToString(), dgvHistorialOrdenes.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(135, height, 300, 40));

                        e.Graphics.DrawString(dgvHistorialOrdenes.Rows[l].Cells[3].FormattedValue.ToString(), dgvHistorialOrdenes.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(540, height, 90, 40));
                        e.Graphics.DrawString("S/ " + dgvHistorialOrdenes.Rows[l].Cells[4].FormattedValue.ToString(), dgvHistorialOrdenes.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(640, height, 100, 100));
                        e.Graphics.DrawString("S/ " + dgvHistorialOrdenes.Rows[l].Cells[5].FormattedValue.ToString(), dgvHistorialOrdenes.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(730, height, 50, 20));
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar";
            const string mensaje = "Estas seguro que deseas cerra";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
