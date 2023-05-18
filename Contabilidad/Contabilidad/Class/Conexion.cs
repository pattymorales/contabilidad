using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Contabilidad
{
    public class Conexion
    {

        public Conexion()
        {
            using (SqlConnection connection = new SqlConnection(Helper.cnnVal("contabilidad")))
            {
                connection.Open();
            }
        }

        //Public SqlConnection SqlCon 
        //Public SqlCommand SqlCmd 
        //Public SqlDataAdapter SqlDa
        //Public DataSet Ds
        //Public SqlTransaction Transaccion
    }
}
