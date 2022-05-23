using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl_Gurkas.Datos
{
    public class Proveedor
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();

        public DataTable MostrarProveedor()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_mostrar_proveedores", conexion.conexionBD());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
