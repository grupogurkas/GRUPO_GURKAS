using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace pl_Gurkas.Datos.LlenadoDatos
{
    class LlenadoDatosTicket
    {
        Datos.Conexiondbo conexiondbo = new Datos.Conexiondbo();


        public void ObtenerPersonal(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select Cod_empleado,NOMBRE_COMPLETO from T_MAE_PERSONAL  order by APELLIDO_PATERNO asc", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_COMPLETO"] = "---Seleccione un Empleado---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "Cod_empleado";
                cd.DisplayMember = "NOMBRE_COMPLETO";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Empleados \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ObtenerEstado(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ID_CONDICION_PRODUCTO,DESP_CONDICION_PRODUCTO FROM T_CONDICION_PRODUCTO ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["DESP_CONDICION_PRODUCTO"] = "--- Seleccione un Estado ---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "ID_CONDICION_PRODUCTO";
                cd.DisplayMember = "DESP_CONDICION_PRODUCTO";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de la Empresa \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }


}
