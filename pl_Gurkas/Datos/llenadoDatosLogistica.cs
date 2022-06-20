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
        int id_empresa = Datos.EmpresaID._empresaid;
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
        public void ObtenerCategoriaVehiculo(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT desp_vehiculo FROM T_TIPO_VEHICULO  ", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "--- Seleccione Una Categoria ---");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de tipo de Categoria \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ObtenerTipoCombustible(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT desp_combustible FROM T_COMBUSTIBLE  ", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "--- Seleccione Un Tipo Combustible ---");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de tipo de Combustible \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ObtenerEstadoProducto(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT desp_estado_material FROM t_estado_material  where id_estado_material in (1,2) ", conexiondbo.conexionBD());
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

        public void ObtenerEstadoProductoCompleto(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT desp_estado_material FROM t_estado_material  where id_estado_material in (3) ", conexiondbo.conexionBD());
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

        public void ObtenerCuotaProducto(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select detalle_cuotas from t_cuotas_descuento_calzado", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "-- Seleccione N° Cuotas --");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de cuotas \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ObtenerTallaPrendaProducto(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT DESP_TALLA_PRENDA FROM T_TALLA_PRENDA  ", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "-- Seleccione Una Talla --");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de tipo de proveedor \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ObtenerTipoPrendaProducto(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT desp_tipo_prenda FROM t_tipo_prenda  ", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "-- Seleccione Una Talla --");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de tipo de proveedor \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ObtenerTallaCalzadoProducto(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT desp_talla_calzado FROM t_talla_calzado  ", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "-- Seleccione Una Talla --");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de tipo de proveedor \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ObtenerTipoCalzadoProducto(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT desp_tipo_calzado FROM t_tipo_zapato  ", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "-- Seleccione Un Tipo Calzado --");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de tipo de proveedor \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ObtenerTipoTelaProducto(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT desp_tipo_prenda FROM t_tipo_prenda  ", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "-- Seleccione Un Tipo Prenda --");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de tipo de proveedor \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ObtenerProductoCamisas(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_PRODUCTO_UNI_CAMISAS,NOMBRE_CAMISAS from T_MAE_UNI_CAMISAS ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_CAMISAS"] = "---Seleccione un Modelo Camisa---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PRODUCTO_UNI_CAMISAS";
                cd.DisplayMember = "NOMBRE_CAMISAS";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Empleados \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerProductoTecnologico(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_PRODUCTO_TECNOLOGICO,NOMBRE_EQUIPO from T_MAE_PRODUCTO_TECNOLOGICO ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_EQUIPO"] = "---Seleccione un Producto---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PRODUCTO_TECNOLOGICO";
                cd.DisplayMember = "NOMBRE_EQUIPO";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Empleados \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerProductoPantalon(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_PRODUCTO_UNI_PANTALON,NOMBRE_PANTALON from T_MAE_UNI_PANTALON ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_PANTALON"] = "---Seleccione un Producto---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PRODUCTO_UNI_PANTALON";
                cd.DisplayMember = "NOMBRE_PANTALON";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Empleados \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerProductoCalzado(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_PRODUCTO_UNI_CALZADO,NOMBRE_CALZADO from T_MAE_UNI_CALZADO ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_CALZADO"] = "---Seleccione un Producto---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PRODUCTO_UNI_CALZADO";
                cd.DisplayMember = "NOMBRE_CALZADO";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Empleados \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerEquipoLogistico(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_PRODUCTO_EQUIP_LOGISTICO,NOMBRE_EQUIP_LOGISTICO from T_MAE_PRODUCTO_EQUIP_LOGISTICO ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_EQUIP_LOGISTICO"] = "---Seleccione un Producto---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PRODUCTO_EQUIP_LOGISTICO";
                cd.DisplayMember = "NOMBRE_EQUIP_LOGISTICO";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Empleados \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerEpp(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_PRODUCTO_EPP,NOMBRE_EQUIP_EPP from T_MAE_PRODUCTO_EQUIP_PROTEC_PERSONAL ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_EQUIP_EPP"] = "---Seleccione un Producto---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PRODUCTO_EPP";
                cd.DisplayMember = "NOMBRE_EQUIP_EPP";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Empleados \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerMobiliario(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_PRODUCTO_MOBILIARIO,NOMBRE_EQUIP_MOBILIARIO from T_MAE_PRODUCTO_MOBILIARIO ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_EQUIP_MOBILIARIO"] = "---Seleccione un Producto---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PRODUCTO_MOBILIARIO";
                cd.DisplayMember = "NOMBRE_EQUIP_MOBILIARIO";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Empleados \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerVehiculo(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_PRODUCTO_VEHICULO,NOMBRE_EQUIP_VEHICULO from T_MAE_PRODUCTO_VEHICULO ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_EQUIP_VEHICULO"] = "---Seleccione un Vehiculo---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PRODUCTO_VEHICULO";
                cd.DisplayMember = "NOMBRE_EQUIP_VEHICULO";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Vehiculo \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerProductoAccesorio(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_PRODUCTO_UNI_ACCESORIO,NOMBRE_ACCESORIO from T_MAE_UNI_ACCESORIO ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_ACCESORIO"] = "---Seleccione un Producto---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PRODUCTO_UNI_ACCESORIO";
                cd.DisplayMember = "NOMBRE_ACCESORIO";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Empleados \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerProductoUtilezEscritorio(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_PRODUCTO_UTI_ESCRITORIO,NOMBRE_UTI_ESCRITORIO from T_MAE_UTI_ESCRITORIO ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_UTI_ESCRITORIO"] = "---Seleccione un Producto---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PRODUCTO_UTI_ESCRITORIO";
                cd.DisplayMember = "NOMBRE_UTI_ESCRITORIO";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Empleados \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerTallaPantalonProducto(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT DESP_TALLA_PRENDA FROM T_TALLA_PRENDA  ", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "-- Seleccione Un Tipo Prenda --");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de tipo de proveedor \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ObtenerTipoPuesto(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT DESCP_PUESTO FROM T_PUESTO  ", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "-- Seleccione Tipo De Puesto --");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de tipo de proveedor \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ObtenerPersonalRRHH(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select Cod_empleado,NOMBRE_COMPLETO from T_MAE_PERSONAL WHERE ID_EMPRESA = " + id_empresa + " order by APELLIDO_PATERNO asc", conexiondbo.conexionBD());
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

        public void ObtenerArea(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT desp_area FROM t_area_laboral  ", conexiondbo.conexionBD());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr[0].ToString());
                }
                cd.Items.Insert(0, "-- Seleccione Un Tipo Prenda --");
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de tipo de proveedor \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ObtenerProducto(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_PRODUCTO_MATERIAL,NOMBRE_PRODUCTO from T_MAE_PRODUCTO ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_PRODUCTO"] = "---Seleccione un Producto---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PRODUCTO_MATERIAL";
                cd.DisplayMember = "NOMBRE_PRODUCTO";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Empleados \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ObtenerUnidadRRHH(ComboBox cd)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT cod_unidad,razon_social FROM t_unidad where ID_ESTADO_UNIDAD = 2 order by Razon_social asc", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["razon_social"] = "--- Seleccione una Unidad ---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "cod_unidad";
                cd.DisplayMember = "razon_social";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado de las Unidades \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ObtenerSedeLogistica(ComboBox cd, string cod_unidad)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_SEDE , NOMBRE_SEDE from T_SEDE where COD_UNIDAD = @COD_UNIDAD and ID_ESTADO_SEDE = 2 ", conexiondbo.conexionBD());
                cmd.Parameters.AddWithValue("COD_UNIDAD", cod_unidad);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_SEDE"] = "--- Seleccione una sede ---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_SEDE";
                cd.DisplayMember = "NOMBRE_SEDE";
                cd.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado de las sedes \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerCodigoBarra(ComboBox cd, string cod_producto)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_PRODUCTO_MATERIAL from T_MAE_PRODUCTO where NOMBRE_PRODUCTO = @NOMBRE_PRODUCTO ", conexiondbo.conexionBD());
                cmd.Parameters.AddWithValue("NOMBRE_PRODUCTO", cod_producto);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                //fila["NOMBRE_SEDE"] = "--- Seleccione una sede ---";
                dt.Rows.InsertAt(fila, 1);
                cd.ValueMember = "COD_PRODUCTO_MATERIAL";
                cd.DisplayMember = "COD_PRODUCTO_MATERIAL";
                cd.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado de las sedes \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ObtenerEmpresa(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ID_EMPRESA,NOMBRE_EMPRESA FROM T_EMPRESA where ID_EMPRESA = " + id_empresa, conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_EMPRESA"] = "--- Seleccione una Empresa ---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "ID_EMPRESA";
                cd.DisplayMember = "NOMBRE_EMPRESA";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede obtener la imformacion de la Empresa \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ObtenerUnidadRRHHEmpresa(ComboBox cd, int empresa)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT COD_UNIDAD,RAZON_SOCIAL FROM T_UNIDAD where ID_ESTADO_UNIDAD = 2 and ID_EMPRESA =" + empresa + " order by RAZON_SOCIAL asc", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["RAZON_SOCIAL"] = "--- Seleccione una Unidad ---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_UNIDAD";
                cd.DisplayMember = "RAZON_SOCIAL";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado de las Unidades \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ObtenerUtilesAseo(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_PRODUCTO_UTI_ASEO,NOMBRE_UTI_ASEO from T_MAE_UTI_ASEO ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_UTI_ASEO"] = "---Seleccione un Producto---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PRODUCTO_UTI_ASEO";
                cd.DisplayMember = "NOMBRE_UTI_ASEO";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Utiles de Aseo \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ObtenerArmamento(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_PRODUCTO_ARMAMENTO,NOMBRE_ARMAMENTO from T_MAE_ARMAMENTO ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_ARMAMENTO"] = "---Seleccione un Producto---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PRODUCTO_ARMAMENTO";
                cd.DisplayMember = "NOMBRE_ARMAMENTO";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Utiles de Aseo \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerProductosGeneral(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COD_PRODUCTO_MATERIAL,NOMBRE_PRODUCTO from T_MAE_PRODUCTO ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["NOMBRE_PRODUCTO"] = "---Seleccione un Producto---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PRODUCTO_MATERIAL";
                cd.DisplayMember = "NOMBRE_PRODUCTO";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Utiles de Aseo \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ObtenerCodigoProducto(ComboBox cd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select  COD_PRODUCTO_MATERIAL , COD_PRODUCTO_SISTEMA from T_MAE_PRODUCTO ", conexiondbo.conexionBD());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.NewRow();
                fila["COD_PRODUCTO_SISTEMA"] = "---Seleccione un Codigo---";
                dt.Rows.InsertAt(fila, 0);
                cd.ValueMember = "COD_PRODUCTO_MATERIAL";
                cd.DisplayMember = "COD_PRODUCTO_SISTEMA";
                cd.DataSource = dt;
                cd.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("No se puede obtener el listado del Utiles de Aseo \n\n" + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    

}


