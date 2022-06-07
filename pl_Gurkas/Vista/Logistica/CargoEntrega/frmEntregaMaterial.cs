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
            


            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("CodProducto");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("CondicionEntrega");
            dt.Columns.Add("ImformacionAdicional");
            dt.Columns.Add("Cantidad");
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


            int height = 450;
            for (int l = numberOfItemsPrintedSoFar; l < dgvListaProducto.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= dgvListaProducto.Rows.Count)
                    {

                        height += dgvListaProducto.Rows[0].Height;
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[0].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(80, height, dgvListaProducto.Columns[0].Width, dgvListaProducto.Rows[0].Height));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[1].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(100, height, dgvListaProducto.Columns[1].Width, dgvListaProducto.Rows[1].Height));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[2].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(200, height, dgvListaProducto.Columns[2].Width, dgvListaProducto.Rows[2].Height));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[3].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(250, height, dgvListaProducto.Columns[2].Width, dgvListaProducto.Rows[2].Height));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[4].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(300, height, dgvListaProducto.Columns[2].Width, dgvListaProducto.Rows[2].Height));
                        e.Graphics.DrawString(dgvListaProducto.Rows[l].Cells[5].FormattedValue.ToString(), dgvListaProducto.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(350, height, dgvListaProducto.Columns[2].Width, dgvListaProducto.Rows[2].Height));
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
            printPreviewDialog1.ShowDialog();
        }
    }
}
