using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl_Gurkas.Datos
{
    class Conexiondbo
    {
        public SqlConnection conexionBD()
        {
            SqlConnection cn = new SqlConnection("Data Source=DCGURKAS;Initial Catalog=GRUPO_GURKAS;User ID=sa;Password=Gurkas2019");
            //SqlConnection cn = new SqlConnection("Data Source=SQL8004.site4now.net,1433;Initial Catalog=db_a8a63c_bdgurkas;User ID=db_a8a63c_bdgurkas_admin;Password=Gurkas2019");
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
            else
            {
                cn.Open();
            }
            return cn;
        }
    }
}
