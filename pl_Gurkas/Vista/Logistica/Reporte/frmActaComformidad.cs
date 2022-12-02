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

namespace pl_Gurkas.Vista.Logistica.Reporte
{
    public partial class frmActaComformidad : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LlenadoDatos.llenadoDatosLogistica Llenadocbo = new Datos.LlenadoDatos.llenadoDatosLogistica();
        private Timer ti;
        private DataTable dt;
        int i = 0;
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;

        public frmActaComformidad()
        {
            InitializeComponent();
        }

        private void frmActaComformidad_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerPersonalRRHH(cboempleadoActivo);
            Llenadocbo.ObtenerUnidadActaComformidad(cboUnidad);
            txtDNI.Enabled = false;
            cboUnidad.Enabled = false;
            timer1.Enabled = true;
            txtDetalleDescuento.MaxLength = 73;
            //lblFecha.Visible = false;
        }

        private void cboempleadoActivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempleadoActivo.SelectedValue.ToString() != null)
            {
                string COD_EMPLEADO = cboempleadoActivo.SelectedValue.ToString();
                try
                {
                    SqlCommand comando = new SqlCommand("SELECT * FROM V_DetallePersonal WHERE COD_EMPLEADO = '" + COD_EMPLEADO + "'", conexion.conexionBD());

                    SqlDataReader recorre = comando.ExecuteReader();
                    while (recorre.Read())
                    {
                        txtDNI.Text = recorre["DOCT_IDENT"].ToString();
                        string unidad = recorre["Razon_social"].ToString();
                        cboUnidad.SelectedIndex = cboUnidad.FindStringExact(unidad);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image cabezera = Properties.Resources._1logogurkas;
 
            string fecha = lblfecha2.Text;
            string APELLIDOS_NOMBRES = (cboempleadoActivo.GetItemText(cboempleadoActivo.SelectedItem)).ToUpper(); ;
            string UNIDAD = (cboUnidad.GetItemText(cboUnidad.SelectedItem)).ToUpper(); ;
            string DNI = txtDNI.Text;
            string DETALLE_DESCUENTO = txtDetalleDescuento.Text;
            string CONCEPTO = txtConcepto.Text;
            string OBSERVACIONES = txtObservaciones.Text;
            string MONTO = txtmonto.Text;
            string TOTAL = txtTotal.Text;

            string informacion_adicional = "";
           
            string dir = "";
            string nombre_arc = "";
            string ver = "";
            string num = "";

            Font tipoTexto = new Font("Arial", 10, FontStyle.Bold);
            Font desp = new Font("Arial", 8, FontStyle.Bold);
            Font nombres = new Font("Arial", 7, FontStyle.Bold);
            Font datos = new Font("Arial", 6, FontStyle.Bold);
            e.Graphics.DrawImage(cabezera, 40, 25);

            Pen blackPen = new Pen(Color.Black, 2);

            Rectangle N9 = new Rectangle(20, 20, 230, 60);
            Rectangle N10 = new Rectangle(250, 20, 320, 60);
            Rectangle N11 = new Rectangle(570, 20, 220, 60);
            Rectangle N12 = new Rectangle(570, 20, 220, 30);

            Rectangle N1 = new Rectangle(20, 90, 770, 100);

            Rectangle N4 = new Rectangle(20, 210, 770, 100);
            Rectangle N2 = new Rectangle(20, 210, 770, 20);
            Rectangle N3 = new Rectangle(20, 230, 770, 20);

            Rectangle N5 = new Rectangle(20, 340, 770, 210);
            Rectangle N6 = new Rectangle(20, 390, 770, 20);
            Rectangle N7 = new Rectangle(20, 410, 770, 20);
            Rectangle N8 = new Rectangle(20, 430, 770, 20);
            Rectangle N13 = new Rectangle(20, 450, 770, 20);
            Rectangle N14 = new Rectangle(20, 470, 770, 20);


            Rectangle N15 = new Rectangle(20, 580, 770, 210);

            Rectangle N16 = new Rectangle(20, 830, 770, 210);
            Rectangle N17 = new Rectangle(20, 880, 770, 20);
            Rectangle N18 = new Rectangle(20, 900, 770, 20);
            Rectangle N19 = new Rectangle(20, 920, 770, 20);
            Rectangle N20 = new Rectangle(20, 940, 770, 20);
            Rectangle N21 = new Rectangle(20, 960, 770, 20);

            /*CABEZERA*/
            e.Graphics.DrawRectangle(blackPen, N9);
            e.Graphics.DrawRectangle(blackPen, N10);
            e.Graphics.DrawRectangle(blackPen, N11);
            e.Graphics.DrawRectangle(blackPen, N12);

            /*DATOS*/
            e.Graphics.DrawRectangle(blackPen, N1);

            /*OPERACIONES*/
            e.Graphics.DrawRectangle(blackPen, N2);
            e.Graphics.DrawRectangle(blackPen, N3);
            e.Graphics.DrawRectangle(blackPen, N4);

            /*RRHH*/
            e.Graphics.DrawRectangle(blackPen, N5);
            e.Graphics.DrawRectangle(blackPen, N6);
            e.Graphics.DrawRectangle(blackPen, N7); 
            e.Graphics.DrawRectangle(blackPen, N8);
            e.Graphics.DrawRectangle(blackPen, N13);
            e.Graphics.DrawRectangle(blackPen, N14);

            /*LOGISTICA*/
            e.Graphics.DrawRectangle(blackPen, N15);

            /*PLANILLAS*/
            e.Graphics.DrawRectangle(blackPen, N16);
            e.Graphics.DrawRectangle(blackPen, N17);
            e.Graphics.DrawRectangle(blackPen, N18);
            e.Graphics.DrawRectangle(blackPen, N19);
            e.Graphics.DrawRectangle(blackPen, N20);
            e.Graphics.DrawRectangle(blackPen, N21);

            e.Graphics.DrawString("ACTA DE CONFORMIDAD DEL PERSONAL ", tipoTexto, Brushes.Black, 265, 25);
           // e.Graphics.DrawString(emp, nombres, Brushes.Black, 290, 45);
            e.Graphics.DrawString("DEBAJA PARA ENTREGA DE LIQUIDACION ", tipoTexto, Brushes.Black, 265, 45);
            // e.Graphics.DrawString(dir, datos, Brushes.Black, 250, 60);
            e.Graphics.DrawString(nombre_arc, datos, Brushes.Black, 580, 25);
            e.Graphics.DrawString(ver, datos, Brushes.Black, 580, 35);
            e.Graphics.DrawString(num, tipoTexto, Brushes.Black, 580, 55);

            string anio = DateTime.Now.Year.ToString();

            e.Graphics.DrawString(" - " + anio, tipoTexto, Brushes.Black, 720, 55);

            e.Graphics.DrawString(dir, datos, Brushes.Black, new RectangleF(260, 60, 300, 30));

            e.Graphics.DrawString("APELLIDOS Y NOMBRES : ", tipoTexto, Brushes.Black, 30, 100);
            e.Graphics.DrawString(APELLIDOS_NOMBRES, desp, Brushes.Black, 220, 102);

            e.Graphics.DrawString("FECHA   : ", tipoTexto, Brushes.Black, 30, 120);
            e.Graphics.DrawString(fecha, desp, Brushes.Black, 120, 122);

            e.Graphics.DrawString("UNIDAD : ", tipoTexto, Brushes.Black, 30, 140);
            e.Graphics.DrawString(UNIDAD, desp, Brushes.Black, 120, 142);

            e.Graphics.DrawString("DNI : ", tipoTexto, Brushes.Black, 30, 160);
            e.Graphics.DrawString(DNI, desp, Brushes.Black, 120, 162);


            e.Graphics.DrawString("CONFORMIDAD DE AREA DE OPERACIONES", tipoTexto, Brushes.Black, 30, 195);


            e.Graphics.DrawString("OBSERVACIONES", tipoTexto, Brushes.Black, 30, 250);
            e.Graphics.DrawString("NOMBRE Y FIRMA DEL RESPONSABLE: ______________________________________________________________", 
                tipoTexto, Brushes.Black, 30, 290);

            string g1 = "CONFORMIDAD DEL AREA DE RRHH:";
            e.Graphics.DrawString(g1, tipoTexto, Brushes.Black, 30, 315);
            e.Graphics.DrawString("DETALLE DE DESCUENTO: ", tipoTexto, Brushes.Black, 30, 350);
            e.Graphics.DrawString("CONCEPTO: ", tipoTexto, Brushes.Black, 30, 370);
            e.Graphics.DrawString("MONTO: ", tipoTexto, Brushes.Black, 300, 370);
            e.Graphics.DrawString("TOTAL: ", tipoTexto, Brushes.Black, 450, 370);
            e.Graphics.DrawString("OBSERVACIONES: ", tipoTexto, Brushes.Black, 30, 490);
            e.Graphics.DrawString("NOMBRE Y FIRMA DEL RESPONSABLE: ______________________________________________________________",
                tipoTexto, Brushes.Black, 30, 530);

            string g2 = "CONFORMIDAD DEL AREA DE LOGISTICA:";
            e.Graphics.DrawString(g2, tipoTexto, Brushes.Black, 30, 560);
            e.Graphics.DrawString("DETALLE DE DESCUENTO: ", tipoTexto, Brushes.Black, 30, 590);
            e.Graphics.DrawString(DETALLE_DESCUENTO, tipoTexto, Brushes.Black, 215, 590);
            e.Graphics.DrawString("CONCEPTO: ", tipoTexto, Brushes.Black, 30, 610);
            e.Graphics.DrawString(CONCEPTO, tipoTexto, Brushes.Black, new RectangleF(30, 630, 700, 50));
            e.Graphics.DrawString("MONTO: ", tipoTexto, Brushes.Black, 300, 610);
            e.Graphics.DrawString(MONTO, tipoTexto, Brushes.Black, 370, 610);
            e.Graphics.DrawString("TOTAL: ", tipoTexto, Brushes.Black, 450, 610);
            e.Graphics.DrawString(TOTAL, tipoTexto, Brushes.Black, 520, 610);
            e.Graphics.DrawString("OBSERVACIONES: ", tipoTexto, Brushes.Black, 30, 730);
            e.Graphics.DrawString(OBSERVACIONES, tipoTexto, Brushes.Black, 160, 730);
            e.Graphics.DrawString("NOMBRE Y FIRMA DEL RESPONSABLE: ______________________________________________________________",
                tipoTexto, Brushes.Black, 30, 770);


            string g3 = "CONFORMIDAD DEL AREA DE PLANILLAS:";
            e.Graphics.DrawString(g3, tipoTexto, Brushes.Black, 30, 810);
            e.Graphics.DrawString("DETALLE DE DESCUENTO: ", tipoTexto, Brushes.Black, 30, 840);
            e.Graphics.DrawString("CONCEPTO: ", tipoTexto, Brushes.Black, 30, 860);
            e.Graphics.DrawString("MONTO: ", tipoTexto, Brushes.Black, 300, 860);
            e.Graphics.DrawString("TOTAL: ", tipoTexto, Brushes.Black, 450, 860);
            e.Graphics.DrawString("OBSERVACIONES: ", tipoTexto, Brushes.Black, 30, 990);
            e.Graphics.DrawString("NOMBRE Y FIRMA DEL RESPONSABLE: ______________________________________________________________",
                tipoTexto, Brushes.Black, 30, 1020);

            e.Graphics.DrawString("TOTAL A DESCONTAR : ", tipoTexto, Brushes.Black, 30, 1050);
            e.Graphics.DrawString(informacion_adicional, tipoTexto, Brushes.Black, new RectangleF(50, 1070, 700, 50));

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
                 printPreviewDialog1.ShowDialog();
                //printDocument1.Print();

            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblfecha2.Text = DateTime.Now.ToLongDateString();
        }
    }
}
