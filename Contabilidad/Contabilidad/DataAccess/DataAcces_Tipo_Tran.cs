using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Contabilidad
{
    public class DataAcces_Tipo_Tran
    {
        public List<tipo_transacciones> GetTipo_Tran(string strSw)
        {
            
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("contabilidad")))
            {
                string strMySql = "";
                strMySql = "select * from tipo_transacciones ";
                if (strSw != "")
                {
                    strMySql = strMySql + " where sw = " + strSw;
                }
                strMySql = strMySql + " order by tipo";
                var output = connection.Query<tipo_transacciones>(strMySql).ToList();
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

        public Int32 IUDTipo_Tran(string Operacion, tipo_transacciones model) 
        {
            Int32 newCarID = 0;
            using (SqlConnection connection = new SqlConnection(Helper.cnnVal("contabilidad")))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_tipo_transacciones", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    switch (Operacion)
                    {
                        case "I":
                                cmd.Parameters.AddWithValue("@i_operacion", "I");
                                cmd.Parameters.AddWithValue("@i_tipo", model.tipo);
                                cmd.Parameters.AddWithValue("@i_descripcion", model.descripcion);
                                cmd.Parameters.AddWithValue("@i_sw", model.sw);
                            break;
                        case "U":
                                cmd.Parameters.AddWithValue("@i_operacion", "U");
                                cmd.Parameters.AddWithValue("@i_id", model.id);
                                cmd.Parameters.AddWithValue("@i_tipo", model.tipo);
                                cmd.Parameters.AddWithValue("@i_descripcion", model.descripcion);
                                cmd.Parameters.AddWithValue("@i_sw", model.sw);
                            break;
                        case "D":
                                cmd.Parameters.AddWithValue("@i_operacion", "D");
                                cmd.Parameters.AddWithValue("@i_id", model.id);
                                break;
                        case "S":
                            cmd.Parameters.AddWithValue("@i_operacion", "S");
                            cmd.Parameters.AddWithValue("@i_id", model.id);
                            cmd.Parameters.AddWithValue("@i_siguiente", model.siguiente);
                            break;
                    }
                    SqlParameter RetParam = new SqlParameter("ReturnValue", DBNull.Value);
                    RetParam.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(RetParam);
                    connection.Open();
                    Convert.ToInt32(cmd.ExecuteScalar());
                    newCarID = Convert.ToInt32(cmd.Parameters["ReturnValue"].Value);
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
