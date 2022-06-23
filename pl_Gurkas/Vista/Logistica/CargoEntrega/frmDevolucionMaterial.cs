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
            dgvListaProducto.RowHeadersVisible = false;
            dgvListaProducto.AllowUserToAddRows = false;
        }
        private void llenado_datos()
        {
            Llenadocbo.ObtenerTipoPuesto(cboTipoPuesto);
            Llenadocbo.ObtenerArea(cboAreaLaboral);
            Llenadocbo.ObtenerUnidadRRHH(cboUnidad);
            Llenadocbo.ObtenerEmpresa(cboEmpresa);
        }
        private void seleccionar_primer_valor()
        {
            int n = dgvListaProducto.Rows.Count;
            int a = n + 1;
            int i = 0;
            try
            {
                while (i < a)
                {
                    dgvListaProducto.Rows[i].Cells["Estado"].Value = 1;
                    i++;
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void frmDevolucionMaterial_Load(object sender, EventArgs e)
        {
            //llenado del combo del dgv
            DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
            dgvCmb.HeaderText = "Estado";
            Llenadocbo.ObtenerEstadoProductoEntrega(dgvCmb);
            dgvCmb.Name = "Estado";
            dgvListaProducto.Columns.Add(dgvCmb);

            txtEntregado.Text = _entregad;
            txtNumValeSalida.Text = _numvale;
            timer1.Enabled = true;
            string nombre_user = Datos.DatosUsuario._usuario;
            txtResivido.Text = nombre_user;
           
            obtener_datos();
            obtener_datos_devuelve();
            GenerarNumVale();
            llenado_datos();
            bloqueo_datos();
            ocultar_datos();
            buscar_Datos();
            buscar_Datos_producto();
            seleccionar_primer_valor();
        }
        private void imprimir()
        {

            /*System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDocument1;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printPreviewDialog1.ShowDialog();
                //printDocument1.Print();
               // registarvale();
               // limpiardatos();
            }*/
            printPreviewDialog1.ShowDialog();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimir();
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
                    txtcod_resive.Text= recorre["COD_EMPLEADO"].ToString();
                    lbldnientr.Text = recorre["DOCT_IDENT"].ToString();
                    txtdni_resive.Text = recorre["DOCT_IDENT"].ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
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

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image cabezera = Properties.Resources._1logogurkas;


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

            e.Graphics.DrawString("PERSONAL QUE RECIBE", tipoTexto, Brushes.Black, 150, 190);
            e.Graphics.DrawString("PERSONAL QUE ENTREGA", tipoTexto, Brushes.Black, 550, 190);

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
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[1].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(30, height, 30, 20));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[2].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(77, height, 100, 100));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[3].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(135, height, 300, 40));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[4].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(750, height, 30, 20));
                        //  e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[5].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(750, height, 30, 20));
                        //  e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[6].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(540, height, 90, 40));//(640, height, 100, 100));
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
    }
}
