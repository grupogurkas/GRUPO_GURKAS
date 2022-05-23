using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Datos
{
    class llenadoDatosLogistica
    {
        Datos.Conexiondbo conexiondbo = new Datos.Conexiondbo();
        public void ObtenerEmpresaLogistica(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT NOMBRE_EMPRESA FROM T_EMPRESA  ", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "--- Seleccione Una Empresa ---");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de la Empresa \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ObtenerTipoProveedor(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT descpTipoProveedor FROM t_tipo_proveedor  ", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "--- Seleccione Un Tipo de proveedor ---");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de tipo de proveedor \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ObtenerTipoDocumentologistica(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT DESP_TIPO_DOCT FROM T_TIPO_DOCUMENTO", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "--- Seleccione Un Tipo Documento ---");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de los Tipo de documentos \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ObtenerTipoEmpresalogistica(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select desp_empresa_logistica  from T_Empresa_Logistica", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "--- Seleccione Un Tipo de Empresa ---");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de los Tipo de empresa \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ObtenerEstadoProveedorlogistica(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select despc_estado_logistica from t_estado_empresa_logistica", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "--- Seleccione Un Tipo Estado  Empresa ---");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de los Tipo de empresa \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ObtenerEstadoCertifivadologistica(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select desp_estadoCertificado from t_estado_certificado_logistica", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "--- Seleccione Un Tipo de Certificado ---");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de los Tipo de Certificado \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ObtenerDepartamentoLogistica(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT COD_DEPARTAMENTO,DESCP_DEPARTAMENTO FROM t_Departamento", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["DESCP_DEPARTAMENTO"] = "--- Seleccione un Departamento ---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_DEPARTAMENTO";
                cd.DisplayMember = "DESCP_DEPARTAMENTO";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado de los Departamento \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerProvinciaLogistica(ComboBox cd, string Cod_Departamento)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT COD_PROVINCIA,DESCP_provincia FROM t_Provincia where COD_DEPARTAMENTO = @Cod_Departamento", conexiondbo.conexionBD());
                cmd.Parameters.AddWithValue("COD_DEPARTAMENTO", Cod_Departamento);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["DESCP_provincia"] = "--- Seleccione una Provincia ---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PROVINCIA";
                cd.DisplayMember = "DESCP_provincia";
                cd.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado de las Provincia \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerDistritosLogistica(ComboBox cd, string Cod_Provincia)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT COD_distrito,DESCP_Distrito FROM t_Distrito where COD_PROVINCIA = @Cod_Provincia", conexiondbo.conexionBD());
                cmd.Parameters.AddWithValue("COD_PROVINCIA", Cod_Provincia);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["DESCP_Distrito"] = "--- Seleccione un Distrito ---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_distrito";
                cd.DisplayMember = "DESCP_Distrito";



                cd.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado de los Distritos \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerProveedoresLogistico(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select cod_proveedor,nomb_proveedor from t_proveedor ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["nomb_proveedor"] = "---Seleccione un Proveedor---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "cod_proveedor";
                cd.DisplayMember = "nomb_proveedor";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Empleados \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerPersonalLogistica(ComboBox cd)
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

       

        public void ObtenerTipoProveedorLogistica(ComboBox cd, string id_tipoproveedor)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT id_tipoProveedor,descpTipoProveedor FROM t_tipo_proveedor", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["DESCP_Distrito"] = "--- Seleccione un Tipo Proveedor  ---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "id_tipoProveedor";
                cd.DisplayMember = "descpTipoProveedor";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado de los tipo proveedor  \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ObtenerTipoUnidadProducto(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT descp_unidad_producto FROM t_unidad_producto  ", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "--- Seleccione Una Unidad ---");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de tipo de proveedor \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ObtenerEstadoProducto(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT desp_estado_material FROM t_estado_material  ", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "-- Seleccione Un Estado --");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de tipo de proveedor \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


