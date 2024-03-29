﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.Logistica.Historial
{
    public partial class frmImpresionSalidaMaterial : Form
    {
        public string _num_orden;
        public string _cod_resive;
        public string _nombre_solicitante;
        public string _fecha;

        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LlenadoDatos.llenadoDatosLogistica Llenadocbo = new Datos.LlenadoDatos.llenadoDatosLogistica();
        Datos.DataReportes.Logistica.DataLogistica reportelogistica = new Datos.DataReportes.Logistica.DataLogistica();
        int i = 0;
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;

        public frmImpresionSalidaMaterial()
        {
            InitializeComponent();
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
        private void obtenr_datos_entrega()
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
        private void obtener_imformacio_adicional()
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM v_buscar_vale_entrega_ia WHERE NUM_ENTREGA = '" + _num_orden + "'", conexion.conexionBD());

                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    lblImformacionAdicional.Text = recorre["INFORMACION_ADICIONAL"].ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }


        private void obtener_datos_solicitante()
        {
            string COD_EMPLEADO = _cod_resive;
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM V_DetallePersonal_v2 WHERE COD_EMPLEADO = '" + COD_EMPLEADO + "'", conexion.conexionBD());

                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    lbldni.Text = recorre["DOCT_IDENT"].ToString();
                    lblUnidad.Text = recorre["Razon_social"].ToString();
                    lblSede.Text = recorre["Nombre_sede"].ToString();
                    lblPuesto.Text = recorre["DESCP_PUESTO"].ToString();
                    lblAreaLaboral.Text = "LOGISTICA";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }
        private void buscar_Datos_Salida()
        {
            string num_vale_salida = _num_orden;
            dgvHistorialOrdenes.DataSource = reportelogistica.BuscarDatosSalida(num_vale_salida);
        }

        private void frmImpresionSalidaMaterial_Load(object sender, EventArgs e)
        {
            empresa();
            obtener_datos_solicitante();
            obtenr_datos_entrega();
            obtener_imformacio_adicional();
            buscar_Datos_Salida();
            dgvHistorialOrdenes.RowHeadersVisible = false;
            dgvHistorialOrdenes.AllowUserToAddRows = false;
            btnPDF.Enabled = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image cabezera = Properties.Resources._1logogurkas;
            string TIPO_PERSONAL = lblPuesto.Text;
            string AREA_ENTREGA = lblAreaLaboral.Text;
            string EMPRESA = lblemp.Text;
            string UNIDAD = lblUnidad.Text;
            string SEDE = lblSede.Text;
            string PERSONAL = _nombre_solicitante;
            string entrega = Datos.DatosUsuario._usuario;
            string cod_empleado = _cod_resive;
            string informacion_adicional = lblImformacionAdicional.Text;
            //string fecha = lblFecha.Text;
            string emp = lblemp.Text;
            string ruc = lblruc.Text;
            string dir = lbldireccion.Text;
            string nombre_arc = lblnombrear.Text;
            string ver = lblver.Text;
            string dni = lbldni.Text;

            string dnien = lbldnientr.Text;
            string cod = lblcodentre.Text;
            string num = _num_orden;

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

            string anio = DateTime.Now.Year.ToString();

            e.Graphics.DrawString(" - " + anio, tipoTexto, Brushes.Black, 720, 55);

            e.Graphics.DrawString(dir, datos, Brushes.Black, new RectangleF(260, 60, 300, 30));

            e.Graphics.DrawString("EMPRESA : ", tipoTexto, Brushes.Black, 30, 100);
            e.Graphics.DrawString(EMPRESA, desp, Brushes.Black, 120, 102);

            e.Graphics.DrawString("FECHA   : ", tipoTexto, Brushes.Black, 30, 120);
            e.Graphics.DrawString(_fecha, desp, Brushes.Black, 120, 122);

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
            e.Graphics.DrawString(informacion_adicional, tipoTexto, Brushes.Black, new RectangleF(50, 1070, 700, 50));

            int height = 320;
            for (int l = numberOfItemsPrintedSoFar; l < dgvHistorialOrdenes.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;
                    if (numberOfItemsPrintedSoFar <= dgvHistorialOrdenes.Rows.Count)
                    {
                        height += dgvHistorialOrdenes.Rows[0].Height;
                        //e.Graphics.DrawString(dgvHistorialOrdenes.Rows[l].Cells[0].FormattedValue.ToString(), dgvHistorialOrdenes.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(30, height, 10, 15));
                        e.Graphics.DrawString(dgvHistorialOrdenes.Rows[l].Cells[0].FormattedValue.ToString(), dgvHistorialOrdenes.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(30, height, 30, 30));
                        e.Graphics.DrawString(dgvHistorialOrdenes.Rows[l].Cells[1].FormattedValue.ToString(), dgvHistorialOrdenes.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(77, height, 100, 110));
                        e.Graphics.DrawString(dgvHistorialOrdenes.Rows[l].Cells[2].FormattedValue.ToString(), dgvHistorialOrdenes.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(135, height, 300, 40));
                        e.Graphics.DrawString(dgvHistorialOrdenes.Rows[l].Cells[3].FormattedValue.ToString(), dgvHistorialOrdenes.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(640, height, 100, 100));
                        e.Graphics.DrawString(dgvHistorialOrdenes.Rows[l].Cells[4].FormattedValue.ToString(), dgvHistorialOrdenes.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(750, height, 30, 20));
                        e.Graphics.DrawString(dgvHistorialOrdenes.Rows[l].Cells[5].FormattedValue.ToString(), dgvHistorialOrdenes.Font = new Font("Arial", 6), Brushes.Black, new RectangleF(540, height, 90, 40));
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

        private void BTNPRINT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDocument1;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
               // printPreviewDialog1.ShowDialog();
                printDocument1.Print();
                // registarvale();
                //limpiardatos();
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
