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
            SqlDataAdapter da = new SqlDataAdapter("sp_mostrar_proveedores", conexion.conexionBD());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns[0].ColumnName = "PROVEEDOR";
            dt.Columns[1].ColumnName = "RUC";
            dt.Columns[2].ColumnName = "PRODUCTO / SERVICIO";
            dt.Columns[3].ColumnName = "CONTACTO";
            dt.Columns[4].ColumnName = "TELEFONO";
            dt.Columns[5].ColumnName = "CELULAR";
            dt.Columns[6].ColumnName = "E-MAIL";
            dt.Columns[7].ColumnName = "CERTIF BASC(SI / NO)";
            dt.Columns[8].ColumnName = "OTRAS CERTIF (SI/NO)";
            dt.Columns[9].ColumnName = "AUTENTICIDAD DE LA CERTIFICACIÓN";
            dt.Columns[10].ColumnName = "NÚMERO DE CERTIFICADO";
            dt.Columns[11].ColumnName = "FECHA DE OTORGAMIENTO";
            dt.Columns[12].ColumnName = "FECHA DE TÉRMINO DE VIGENCIA";
            dt.Columns[13].ColumnName = "DIRECCIÓN";
            dt.Columns[14].ColumnName = "WEB";
            dt.Columns[15].ColumnName = "TIPO DE PROVEEDOR";
            dt.Columns[16].ColumnName = "DOC.";
            dt.Columns[17].ColumnName = "DNI / CE";
            dt.Columns[18].ColumnName = "REPRESENTANTE LEGAL";
            dt.Columns[19].ColumnName = "CARGO";
            dt.Columns[20].ColumnName = "PROVEEDOR";
            return dt;
        }
    }
}
