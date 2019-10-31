using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Contabilidad
{
    public class DataAcces_Cuentas
    {
        public List<Cuenta> GetCuentas()
        {
            
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("contabilidad")))
            {
                var output = connection.Query<Cuenta>($"select * from cuentas order by cuenta, afe, naturaleza").ToList();
                try
                {
                    return output;  
                }
                catch
                {
                    MessageBox.Show("El sistema no tiene conección. Favor verifique");
                    return output;
                }
            }
        }

        public Int32 IUDCuentas(string Operacion, Cuenta model) 
        {
            Int32 newCarID = 0;
            using (SqlConnection connection = new SqlConnection(Helper.cnnVal("contabilidad")))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_cuentas", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    switch (Operacion)
                    {
                        case "I":
                                cmd.Parameters.AddWithValue("@i_operacion", "I");
                                cmd.Parameters.AddWithValue("@i_cuenta", model.cuenta);
                                cmd.Parameters.AddWithValue("@i_descripcion", model.descripcion);
                                cmd.Parameters.AddWithValue("@i_afe", model.afe);
                                cmd.Parameters.AddWithValue("@i_naturaleza", model.naturaleza);
                                break;
                        case "U":
                                cmd.Parameters.AddWithValue("@i_operacion", "U");
                                cmd.Parameters.AddWithValue("@i_id", model.id);
                                cmd.Parameters.AddWithValue("@i_cuenta", model.cuenta);
                                cmd.Parameters.AddWithValue("@i_descripcion", model.descripcion);
                                cmd.Parameters.AddWithValue("@i_afe", model.afe);
                                cmd.Parameters.AddWithValue("@i_naturaleza", model.naturaleza);
                                break;
                        case "D":
                                cmd.Parameters.AddWithValue("@i_operacion", "D");
                                cmd.Parameters.AddWithValue("@i_id", model.id);
                                break;
                    }
                    connection.Open();
                    newCarID = Convert.ToInt32(cmd.ExecuteScalar());
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    DisplaySqlErrors(ex);
                    connection.Close();
                    newCarID = -1;
                }
            }
            return newCarID;
        }

        private static void DisplaySqlErrors(SqlException exception)
        {
            for (int i = 0; i < exception.Errors.Count; i++)
            {
                MessageBox.Show("Index #" + i + "\n" + "Error: " + exception.Errors[i].ToString() + "\n");
            }
        }

       

     
    }
}
