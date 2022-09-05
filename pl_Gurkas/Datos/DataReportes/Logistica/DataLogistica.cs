using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl_Gurkas.Datos.DataReportes.Logistica
{
    class DataLogistica
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        public DataTable BuscarProveeedor(string cod_proveedor)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "sp_buscar_proveedor_codigo  @cod_proveedor";
            comando.Parameters.AddWithValue("cod_proveedor", cod_proveedor);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "CODIGO DE PROVEEDOR";
            dt.Columns[1].ColumnName = "NOMBRE DE PROVEEDOR";
            dt.Columns[2].ColumnName = "RUC";
            dt.Columns[3].ColumnName = "PRODUCTO / SERVICIO";
            dt.Columns[4].ColumnName = "CONTACTO";
            dt.Columns[5].ColumnName = "TELEFONO";
            dt.Columns[6].ColumnName = "CELULAR";
            dt.Columns[7].ColumnName = "E-MAIL 1";
            dt.Columns[8].ColumnName = "E-MAIL 2";
            dt.Columns[9].ColumnName = "CERTIF BASC(SI / NO)";
            dt.Columns[10].ColumnName = "OTRAS CERTIF (SI/NO)";
            dt.Columns[11].ColumnName = "AUTENTICIDAD DE LA CERTIFICACIÓN";
            dt.Columns[12].ColumnName = "NÚMERO DE CERTIFICADO";
            dt.Columns[13].ColumnName = "FECHA DE OTORGAMIENTO";
            dt.Columns[14].ColumnName = "FECHA DE TÉRMINO DE VIGENCIA";
            dt.Columns[15].ColumnName = "DIRECCIÓN";
            dt.Columns[16].ColumnName = "WEB";
            dt.Columns[17].ColumnName = "TIPO DE PROVEEDOR";
            dt.Columns[18].ColumnName = "DOC.";
            dt.Columns[19].ColumnName = "DNI / CE";
            dt.Columns[20].ColumnName = "REPRESENTANTE LEGAL";
            dt.Columns[21].ColumnName = "CARGO";
            dt.Columns[22].ColumnName = "PROVEEDOR";
            return dt;
        }
        public DataTable BuscarProveeedorPorRuc(string ruc)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "sp_buscar_proveedor_ruc  @ruc";
            comando.Parameters.AddWithValue("ruc", ruc);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "CODIGO DE PROVEEDOR";
            dt.Columns[1].ColumnName = "NOMBRE DE PROVEEDOR";
            dt.Columns[2].ColumnName = "RUC";
            dt.Columns[3].ColumnName = "PRODUCTO / SERVICIO";
            dt.Columns[4].ColumnName = "CONTACTO";
            dt.Columns[5].ColumnName = "TELEFONO";
            dt.Columns[6].ColumnName = "CELULAR";
            dt.Columns[7].ColumnName = "E-MAIL 1";
            dt.Columns[8].ColumnName = "E-MAIL 2";
            dt.Columns[9].ColumnName = "CERTIF BASC(SI / NO)";
            dt.Columns[10].ColumnName = "OTRAS CERTIF (SI/NO)";
            dt.Columns[11].ColumnName = "AUTENTICIDAD DE LA CERTIFICACIÓN";
            dt.Columns[12].ColumnName = "NÚMERO DE CERTIFICADO";
            dt.Columns[13].ColumnName = "FECHA DE OTORGAMIENTO";
            dt.Columns[14].ColumnName = "FECHA DE TÉRMINO DE VIGENCIA";
            dt.Columns[15].ColumnName = "DIRECCIÓN";
            dt.Columns[16].ColumnName = "WEB";
            dt.Columns[17].ColumnName = "TIPO DE PROVEEDOR";
            dt.Columns[18].ColumnName = "DOC.";
            dt.Columns[19].ColumnName = "DNI / CE";
            dt.Columns[20].ColumnName = "REPRESENTANTE LEGAL";
            dt.Columns[21].ColumnName = "CARGO";
            dt.Columns[22].ColumnName = "PROVEEDOR";
            return dt;
        }

        public DataTable BuscarProducto(string cod_producto)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "sp_buscar_producto_por_nombre  @COD_PRODUCTO_MATERIAL";
            comando.Parameters.AddWithValue("COD_PRODUCTO_MATERIAL", cod_producto);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "CODIGO DE PRODUCTO";
            dt.Columns[1].ColumnName = "NOMBRE DE PRODUCTO";
            dt.Columns[2].ColumnName = "STOCK INICIAL";
            dt.Columns[3].ColumnName = "STOCK ACTUAL";
            dt.Columns[4].ColumnName = "STOCK MINIMO";
            dt.Columns[5].ColumnName = "FECHA DE REGISTRO";
            return dt;
        }

        public DataTable BuscarProductoVale(string cod_producto)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "sp_buscar_producto  @COD_PRODUCTO_MATERIAL";
            comando.Parameters.AddWithValue("COD_PRODUCTO_MATERIAL", cod_producto);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "CODIGO DE PRODUCTO";
            dt.Columns[1].ColumnName = "NOMBRE DE PRODUCTO";
            dt.Columns[2].ColumnName = "STOCK INICIAL";
            dt.Columns[3].ColumnName = "STOCK ACTUAL";
            dt.Columns[4].ColumnName = "STOCK MINIMO";
            dt.Columns[5].ColumnName = "FECHA DE REGISTRO";
            return dt;
        }

        public DataTable BuscarProductoPorCodigo(string cod_producto)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "sp_buscar_producto_por_codigo  @COD_PRODUCTO_MATERIAL";
            comando.Parameters.AddWithValue("COD_PRODUCTO_MATERIAL", cod_producto);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "CODIGO DE PRODUCTO";
            dt.Columns[1].ColumnName = "NOMBRE DE PRODUCTO";
            dt.Columns[2].ColumnName = "STOCK INICIAL";
            dt.Columns[3].ColumnName = "STOCK ACTUAL";
            dt.Columns[4].ColumnName = "STOCK MINIMO";
            dt.Columns[5].ColumnName = "FECHA DE REGISTRO";
            return dt;
        }
        public DataTable BuscarProductoPorCodigoSistema(int cod_producto)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "sp_buscar_producto  @COD_PRODUCTO_MATERIAL";
            comando.Parameters.AddWithValue("COD_PRODUCTO_MATERIAL", cod_producto);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "CODIGO DE PRODUCTO";
            dt.Columns[1].ColumnName = "NOMBRE DE PRODUCTO";
            dt.Columns[2].ColumnName = "STOCK INICIAL";
            dt.Columns[3].ColumnName = "STOCK ACTUAL";
            dt.Columns[4].ColumnName = "STOCK MINIMO";
            dt.Columns[5].ColumnName = "FECHA DE REGISTRO";
            return dt;
        }
        public DataTable BuscarValesSalidaMateria(string cod_empleado)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "sp_buscar_salida_producto  @COD_SOLICITADO";
            comando.Parameters.AddWithValue("COD_SOLICITADO", cod_empleado);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "NUMERO";
            dt.Columns[1].ColumnName = "NUMERO CARGO ENTREGA";
            dt.Columns[2].ColumnName = "ESTADO";
            return dt;
        }
        public DataTable BuscarMaterialSalida(string COD_VALE)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SP_BUSCAR_PRODUCTOS  @NUM_ENTREGA";
            comando.Parameters.AddWithValue("NUM_ENTREGA", COD_VALE);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "ITEM";
            dt.Columns[1].ColumnName = "COD_PRODUCTO";
            dt.Columns[2].ColumnName = "DESCRIPCION_PRODUCTO";
            dt.Columns[3].ColumnName = "CANTIDAD_ENTREGADA";
            dt.Columns[4].ColumnName = "CANTIDAD_DEVUELTA_FECHA_1";
            dt.Columns[5].ColumnName = "CANTIDAD_DEVUELTA_FECHA_2";
            dt.Columns[6].ColumnName = "CANTIDAD_PENDIENTE";
            return dt;
        }
        public DataTable BuscarProveeedorPorEmpresa(int IdEmpresa)
        {
            SqlCommand comando = conexion.conexionBD().CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "sp_buscar_proveedor_empresa  @IdEmpresa";
            comando.Parameters.AddWithValue("IdEmpresa", IdEmpresa);
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(comando);
            dta.Fill(dt);
            dt.Columns[0].ColumnName = "CODIGO DE PROVEEDOR";
            dt.Columns[1].ColumnName = "NOMBRE DE PROVEEDOR";
            dt.Columns[2].ColumnName = "RUC";
            dt.Columns[3].ColumnName = "PRODUCTO / SERVICIO";
            dt.Columns[4].ColumnName = "CONTACTO";
            dt.Columns[5].ColumnName = "TELEFONO";
            dt.Columns[6].ColumnName = "CELULAR";
            dt.Columns[7].ColumnName = "E-MAIL 1";
            dt.Columns[8].ColumnName = "E-MAIL 2";
            dt.Columns[9].ColumnName = "CERTIF BASC(SI / NO)";
            dt.Columns[10].ColumnName = "OTRAS CERTIF (SI/NO)";
            dt.Columns[11].ColumnName = "AUTENTICIDAD DE LA CERTIFICACIÓN";
            dt.Columns[12].ColumnName = "NÚMERO DE CERTIFICADO";
            dt.Columns[13].ColumnName = "FECHA DE OTORGAMIENTO";
            dt.Columns[14].ColumnName = "FECHA DE TÉRMINO DE VIGENCIA";
            dt.Columns[15].ColumnName = "DIRECCIÓN";
            dt.Columns[16].ColumnName = "WEB";
            dt.Columns[17].ColumnName = "TIPO DE PROVEEDOR";
            dt.Columns[18].ColumnName = "DOC.";
            dt.Columns[19].ColumnName = "DNI / CE";
            dt.Columns[20].ColumnName = "REPRESENTANTE LEGAL";
            dt.Columns[21].ColumnName = "CARGO";
            dt.Columns[22].ColumnName = "PROVEEDOR";
            return dt;
        }
    }
}
