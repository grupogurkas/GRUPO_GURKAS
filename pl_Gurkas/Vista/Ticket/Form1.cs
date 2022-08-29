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

namespace pl_Gurkas.Vista.Ticket
{
    public partial class Form1 : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LlenadoDatos.LlenadoDatosTicket llenadocbo = new Datos.LlenadoDatos.LlenadoDatosTicket();
        Datos.LlenadoDatos.llenadoDatosLogistica Llenadocbo = new Datos.LlenadoDatos.llenadoDatosLogistica();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txthora.Enabled = false;
            txtCodEmpleado.Enabled = false;
            txtTicket.Enabled = false;
            GenerarNumVale();
            txthora.Text = DateTime.Now.ToString("hh:mm tt");
            llenadocbo.ObtenerPersonal(cboempleadoActivo);
        }

        public void GenerarNumVale()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("SELECT ROW_NUMBER()OVER(ORDER BY num_ticket)AS 't'  FROM t_consulta GROUP BY num_ticket", conexion.conexionBD());

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
                txtTicket.Text = "TICKET-000000" + (numero + 1);
            }
            if (numero > 9 && numero < 100)
            {
                txtTicket.Text = "TICKET-00000" + (numero + 1);
            }
            if (numero > 99 && numero < 1000)
            {
                txtTicket.Text = "TICKET-0000" + (numero + 1);
            }
            if (numero > 9999 && numero < 10000)
            {
                txtTicket.Text = "TICKET-000" + (numero + 1);
            }
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
                        txtCodEmpleado.Text = recorre["COD_EMPLEADO"].ToString();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txthora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
