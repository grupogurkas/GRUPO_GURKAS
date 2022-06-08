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
        private void frmEntregaMaterial_Load(object sender, EventArgs e)
        {
            txtUsuarioEntrega.Enabled = false;
            string nombre_user = Datos.DatosUsuario._usuario;
            txtUsuarioEntrega.Text = nombre_user;
            timer1.Enabled = true;

            Llenadocbo.ObtenerTipoPuesto(cboTipoPuesto);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoMaterial);
            Llenadocbo.ObtenerPersonalRRHH(cboempleadoActivo);
            Llenadocbo.ObtenerArea(cboAreaLaboral);
            Llenadocbo.ObtenerProducto(cboProducto);
            Llenadocbo.ObtenerUnidadRRHH(cboUnidad);
            Llenadocbo.ObtenerEmpresaRRHH_2(cboEmpresa);



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

        private void btnAgregar_Click(object sender, EventArgs e)
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

            Font tipoTexto = new Font("Arial", 10, FontStyle.Bold);
            Font desp = new Font("Arial", 8, FontStyle.Bold);
            Font nombres = new Font("Arial", 7, FontStyle.Bold);
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
            e.Graphics.DrawRectangle(blackPen, ITEM_);
            e.Graphics.DrawRectangle(blackPen, CODIGO_);
            e.Graphics.DrawRectangle(blackPen, PRODUCTO_);
            e.Graphics.DrawRectangle(blackPen, OBSERVACION_);
            e.Graphics.DrawRectangle(blackPen, CONDICION_);
            e.Graphics.DrawRectangle(blackPen, CANT_);

            e.Graphics.DrawString("CARGO DE ENTREGA", tipoTexto, Brushes.Black, 320, 40);

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

            e.Graphics.DrawString("COD/DNI : ", tipoTexto, Brushes.Black, 30, 240);
            e.Graphics.DrawString(cod_empleado, desp, Brushes.Black, 110, 243);

            e.Graphics.DrawString("NOMBRE : ", tipoTexto, Brushes.Black, 420, 220);
            e.Graphics.DrawString(entrega, nombres, Brushes.Black, 500, 223);

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
            }
         // printPreviewDialog1.ShowDialog();
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
    }
}
