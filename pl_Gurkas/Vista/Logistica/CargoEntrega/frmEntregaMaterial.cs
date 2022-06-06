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
        public frmEntregaMaterial()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
        }


        private void eventoTimer(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            lblRelog.Text = hoy.ToString("hh:mm:ss tt");
        }

        private void frmEntregaMaterial_Load(object sender, EventArgs e)
        {
            txtUsuarioEntrega.Enabled = false;
            string nombre_user = Datos.DatosUsuario._usuario;
            txtUsuarioEntrega.Text = nombre_user;


            Llenadocbo.ObtenerTipoPuesto(cboTipoPuesto);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoMaterial);
            Llenadocbo.ObtenerPersonalRRHH(cboempleadoActivo);
            Llenadocbo.ObtenerArea(cboAreaLaboral);
            Llenadocbo.ObtenerProducto(cboProducto);
            Llenadocbo.ObtenerUnidadRRHH(cboUnidad);
            Llenadocbo.ObtenerEmpresaRRHH_2(cboEmpresa);

         /*   DataGridViewButtonColumn btnclm = new DataGridViewButtonColumn();
            btnclm.Name = "Eliminar";
            dgvListaProducto.Columns.Add(btnclm);*/


            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("CodProducto");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("CondicionEntrega");
            dt.Columns.Add("ImformacionAdicional");
            dt.Columns.Add("Cantidad");
            dgvListaProducto.DataSource = dt;

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
            if (this.dgvListaProducto.Columns[e.ColumnIndex].DisplayIndex == 0)
            {
                dgvListaProducto.Rows.Remove(dgvListaProducto.CurrentRow);
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
            string imfor_adicional = txtInformacionAdicional.Text;
            string Condicion_Entrega = cboEstadoMaterial.GetItemText(cboEstadoMaterial.SelectedItem);
            int n = dgvListaProducto.Rows.Count;
            string c = Convert.ToString(n + 1);
            DataRow row = dt.NewRow();
            row["ID"] = c;
            row["CodProducto"] = cod_producto;
            row["Nombre"] = nombre_producto;
            row["CondicionEntrega"] = Condicion_Entrega;
            row["ImformacionAdicional"] = imfor_adicional;
            row["Cantidad"] = cantidad;
            dt.Rows.Add(row);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image cabezera = Properties.Resources.ENTREGA_CABEZERA_3;
            Image pie_pagina = Properties.Resources.fimar;

            string TIPO_PERSONAL = cboTipoPuesto.GetItemText(cboTipoPuesto.SelectedItem);
            string AREA_ENTREGA = cboAreaLaboral.GetItemText(cboAreaLaboral.SelectedItem);
            string EMPRESA = cboEmpresa.GetItemText(cboEmpresa.SelectedItem);
            string UNIDAD = cboUnidad.GetItemText(cboUnidad.SelectedItem);
            string SEDE = cboSede.GetItemText(cboSede.SelectedItem);

            Font tipoTexto = new Font("Arial", 10, FontStyle.Bold);
            e.Graphics.DrawImage(cabezera, 30, 20);

            e.Graphics.DrawString("TIPO DE PERSONAL : ", tipoTexto, Brushes.Black, 50, 160);
            e.Graphics.DrawString(TIPO_PERSONAL, tipoTexto, Brushes.Black, 200, 160);

            e.Graphics.DrawString("AREA DE ENTREGA : ", tipoTexto, Brushes.Black, 50, 190);
            e.Graphics.DrawString(AREA_ENTREGA, tipoTexto, Brushes.Black, 200, 190);

            e.Graphics.DrawString("EMPRESA : ", tipoTexto, Brushes.Black, 50, 220);
            e.Graphics.DrawString(EMPRESA, tipoTexto, Brushes.Black, 200, 220);

            e.Graphics.DrawString("UNIDA : ", tipoTexto, Brushes.Black, 50, 250);
            e.Graphics.DrawString(UNIDAD, tipoTexto, Brushes.Black, 200, 250);

            e.Graphics.DrawString("SEDE : ", tipoTexto, Brushes.Black, 50, 280);
            e.Graphics.DrawString(SEDE, tipoTexto, Brushes.Black, 200, 280);
       
            e.Graphics.DrawImage(pie_pagina, 100, 1000);


            int width = 0;
            int height = 0;
            int x = 0;
            int y = 0;
            int rowheight = 0;
            int columnwidth = 0;

            //region Draw Column 1 
            StringFormat str = new StringFormat();
            str.Alignment = StringAlignment.Near;
            str.LineAlignment = StringAlignment.Center;
            str.Trimming = StringTrimming.EllipsisCharacter;

            e.Graphics.FillRectangle(Brushes.LightGray, 
                new Rectangle(100, 100, dgvListaProducto.Columns[0].Width, dgvListaProducto.Rows[0].Height));
            e.Graphics.DrawRectangle(Pens.Black, 100, 100, dgvListaProducto.Columns[0].Width, dgvListaProducto.Rows[0].Height);
            e.Graphics.DrawString(dgvListaProducto.Columns[0].HeaderText, dgvListaProducto.Font, Brushes.Black,
                new RectangleF(100, 100, dgvListaProducto.Columns[0].Width, dgvListaProducto.Rows[0].Height), str);

            //region Draw Column 2 /* https://www.c-sharpcorner.com/article/how-to-print-grid-view-c-sharp-more-pages-basic-curd-application-ms-access-database/ */
            e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(100 + dgvListaProducto.Columns[0].Width, 100, dgvListaProducto.Columns[0].Width, dgvListaProducto.Rows[0].Height));
            e.Graphics.DrawRectangle(Pens.Black, 100 + dgvListaProducto.Columns[0].Width, 100, dgvListaProducto.Columns[0].Width, dgvListaProducto.Rows[0].Height);
            e.Graphics.DrawString(dgvListaProducto.Columns[1].HeaderText, dgvListaProducto.Font, Brushes.Black, new RectangleF(100 + dgvListaProducto.Columns[0].Width, 100, dgvListaProducto.Columns[0].Width, dgvListaProducto.Rows[0].Height), str);


            //region Draw Column 3  /* https://www.codeproject.com/Articles/43569/Printing-a-datagridview-in-C-NET-2-0 */
            e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(100 + dgvListaProducto.Columns[0].Width, 100, dgvListaProducto.Columns[0].Width, dgvListaProducto.Rows[0].Height));
            e.Graphics.DrawRectangle(Pens.Black, 100 + dgvListaProducto.Columns[0].Width, 
                100, dgvListaProducto.Columns[0].Width, dgvListaProducto.Rows[0].Height);
            e.Graphics.DrawString(dgvListaProducto.Columns[2].HeaderText, 
                dgvListaProducto.Font, Brushes.Black,
                new RectangleF(100 + dgvListaProducto.Columns[0].Width, 100, dgvListaProducto.Columns[0].Width, 
                dgvListaProducto.Rows[0].Height), str);


            width = 100 + dgvListaProducto.Columns[0].Width;
            height = 100;
            while (i < dgvListaProducto.Rows.Count)
            {
                if (height > e.MarginBounds.Height)
                {
                    height = 100;
                    width = 100;
                    e.HasMorePages = true;
                    return;
                }

                height += dgvListaProducto.Rows[i].Height;
                e.Graphics.DrawRectangle(Pens.Black, 100, height, dgvListaProducto.Columns[0].Width, dgvListaProducto.Rows[0].Height);
                e.Graphics.DrawString(dgvListaProducto.Rows[i].Cells[0].FormattedValue.ToString(), dgvListaProducto.Font,
                    Brushes.Black, new RectangleF(100, height, dgvListaProducto.Columns[0].Width, dgvListaProducto.Rows[0].Height), str);

                e.Graphics.DrawRectangle(Pens.Black, 100 + dgvListaProducto.Columns[0].Width, height, dgvListaProducto.Columns[0].Width,
                    dgvListaProducto.Rows[0].Height);
                e.Graphics.DrawString(dgvListaProducto.Rows[i].Cells[1].Value.ToString(), dgvListaProducto.Font, Brushes.Black,
                    new RectangleF(100 + dgvListaProducto.Columns[0].Width, height, dgvListaProducto.Columns[0].Width,
                    dgvListaProducto.Rows[0].Height), str);

                width += dgvListaProducto.Columns[0].Width;
                i++;
            }

            /*
                         Bitmap bmp;

            int height = dgvListaProducto.Height;
            dgvListaProducto.Height = dgvListaProducto.RowCount * dgvListaProducto.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvListaProducto.Width, dgvListaProducto.Height);
            dgvListaProducto.DrawToBitmap(bmp, new Rectangle(0, 0, dgvListaProducto.Width, dgvListaProducto.Height));
            dgvListaProducto.Height = height;
            e.Graphics.DrawImage(bmp, 0, 0);
             */
        }

        private void btnCertificadoBasc_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
