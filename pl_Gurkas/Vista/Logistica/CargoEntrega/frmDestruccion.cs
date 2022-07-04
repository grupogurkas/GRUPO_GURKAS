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


        public frmDestruccion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Destruccion_Load(object sender, EventArgs e)
        {
            //txtRestante.Text = cantidadrest;
            txtUsuarioEntrega.Enabled = false;
            //txtNumVale.Enabled = false;
            txtstock.Enabled = false;
            txtstock.Text = "0";
            txtRestante.Text = "0";
            txtRestante.Visible = true;
            string nombre_user = Datos.DatosUsuario._usuario;
            txtUsuarioEntrega.Text = nombre_user;
            //timer1.Enabled = true;
            //obtener_datos();
            //GenerarNumVale();
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

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          

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
            //PrintDialog1.Document = printDocument1;}
            printPreviewDialog1.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font tipotexto = new Font("Arial", 10, FontStyle.Bold);

            e.Graphics.DrawImage(pictureBox2.Image, 50, 20);
           // e.Graphics.DrawString()
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

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

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
