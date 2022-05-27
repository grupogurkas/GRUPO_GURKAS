using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl_Gurkas.Datos.CRUD.Logistica.Insertar
{
    class LogisticaInsertar
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();

        public void RegistrarEquipoTecnologico(string cod_unidad, double rmv, double sueldo, int puesto)
        {
            SqlCommand cmd = new SqlCommand("sp_insertar_sueldo_unidad_puesto ", conexion.conexionBD());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_unidad", SqlDbType.VarChar).Value = cod_unidad;
            cmd.Parameters.AddWithValue("@mv", SqlDbType.Decimal).Value = rmv;
            cmd.Parameters.AddWithValue("@sueldo", SqlDbType.Decimal).Value = sueldo;
            cmd.Parameters.AddWithValue("@idpuesto", SqlDbType.Int).Value = puesto;
            cmd.ExecuteNonQuery();
        }
    }
}
