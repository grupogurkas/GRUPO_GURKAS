﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace pl_Gurkas.Vista.Logistica.entrada
{
    public partial class frmEntradaProducto : Form
    {  Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.ConexionMysql conexionmysql = new Datos.ConexionMysql();
        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();
        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();
        private Timer ti;
      

        public frmEntradaProducto()
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

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void origendatos()
        {
            //dgvListaProducto.DataSource = ClasDA.ConsultarEXISTENAGOTADMedicamentos();

        }

        private void frmEntradaProducto_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerTipoPuesto(cboTipoPuesto);
            Llenadocbo.ObtenerEstadoProducto(cboEstadoMaterial);
            Llenadocbo.ObtenerPersonalRRHH(cboempleadoActivo);
            Llenadocbo.ObtenerArea(cboAreaLaboral);
            Llenadocbo.ObtenerProducto(cboProducto);
            Llenadocbo.ObtenerUnidadRRHH(cboUnidad);
            Llenadocbo.ObtenerEmpresaRRHH_2(cboEmpresa);

            //cargarGrid();



            //dataGridView1.Columns[5].Name = "ID";
            //dataGridView1.Columns[6].Name = "ID";
            dgvListaProducto.ColumnCount = 5;

            ArrayList AL = new ArrayList();
            AL.Add("1");
            AL.Add("Laptop Core I3");
            AL.Add("HP");
            AL.Add("1");
            AL.Add("10/10/2022");
            dgvListaProducto.Rows.Add(AL.ToArray());

  
            dgvListaProducto.Columns[0].Name = "ID";
            dgvListaProducto.Columns[1].Name = "Nombre";
            dgvListaProducto.Columns[2].Name = "Marca";
            dgvListaProducto.Columns[3].Name = "Cantidad";
            dgvListaProducto.Columns[4].Name = "Fecha";


            DataGridViewButtonColumn btnclm = new DataGridViewButtonColumn();
            btnclm.Name = "Eliminar";
            dgvListaProducto.Columns.Add(btnclm);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string codEmpleado = cboempleadoActivo.SelectedValue.ToString();

                SqlCommand comando = new SqlCommand("SELECT * FROM T_MAE_PERSONAL WHERE Cod_empleado = '" + codEmpleado + "'", conexion.conexionBD());

                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    //txtNombrePersonal.Text = recorre["NOMBRE_COMPLETO"].ToString();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dgvListaProducto.Columns[e.ColumnIndex].DisplayIndex == 5)
            {
                dgvListaProducto.Rows.Remove(dgvListaProducto.CurrentRow);
            }
        }

        private void dgvListaProducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
          /*  if(e.ColumnIndex >= 0 && this.dgvListaProducto.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >=0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celboton = this.dgvListaProducto.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
               // Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\icono.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 15, e.CellBounds.Top + 3);

                this.dgvListaProducto.Rows[e.RowIndex].Height = icoAtomico.Height + 10;
                this.dgvListaProducto.Columns[e.ColumnIndex].Width = icoAtomico.Width + 31;

                e.Handled = true;

            }*/
        }

        private void dtpFechaAdquisicion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUnidad.SelectedValue.ToString() != null)
            {
                string cod_unidad = cboUnidad.SelectedValue.ToString();
                Llenadocbo.ObtenerSedeLogistica(cboSede, cod_unidad);

            }
        }
    }
}
