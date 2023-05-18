using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Contabilidad
{
    public class DataAcces_Terceros
    {
        public List<Tercero> GetTerceros()
        {
            
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("contabilidad")))
            {
                var outputTerceros = connection.Query<Tercero>($"select * from terceros order by nit").ToList();
                try
                {
                    return outputTerceros;  
                }
                catch
                {
                    MessageBox.Show("El sistema no tiene conección. Favor verifique");
                    return outputTerceros;
                }
            }
        }

        public List<Tercero> GetTerceros(string Nit, string Nombres, string Apellidos)
        {
            string strQuery = "";
            string strWhere = "";
            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("contabilidad")))
            {
                strQuery = "select * from terceros ";
                if (Nit != "")
                {
                    strWhere = " nit like '%" + Nit + "%'";
                }
                if (Nombres != "")
                {
                    if (strWhere != "") { strWhere = strWhere + ", "; }
                    strWhere = " nombres like '%" + Nombres + "%'";
                }
                if (Apellidos != "")
                {
                    if (strWhere != "") { strWhere = strWhere + ", "; }
                    strWhere = " apellidos like '%" + Apellidos + "%'";
                }
                if (strWhere != "")
                {
                    strQuery = strQuery + " Where " + strWhere;
                }
                strQuery = strQuery + " order by nit";
                var outputTerceros = connection.Query<Tercero>(strQuery).ToList();
                try
                {
                    return outputTerceros;
                }
                catch
                {
                    MessageBox.Show("El sistema no tiene conección. Favor verifique");
                    return outputTerceros;
                }
            }
        }

        public Int32 IUDTerceros(string Operacion, Tercero model) 
        {
            Int32 newCarID = 0;
            using (SqlConnection connection = new SqlConnection(Helper.cnnVal("contabilidad")))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_terceros", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    switch (Operacion)
                    {
                        case "I":
                            cmd.Parameters.AddWithValue("@i_operacion", "I");
                            cmd.Parameters.AddWithValue("@i_nit", model.nit);
                            cmd.Parameters.AddWithValue("@i_tipo_identificacion", model.tipo_identificacion);
                            cmd.Parameters.AddWithValue("@i_nombres", model.nombres);
                            cmd.Parameters.AddWithValue("@i_apellidos", model.apellidos);
                            cmd.Parameters.AddWithValue("@i_estado", model.estado);
                            cmd.Parameters.AddWithValue("@i_email", model.email);
                            //// Set Input Output Parameter
                            //SqlParameter InOutParam = new SqlParameter("@o_out", InOutParamValue);
                            //InOutParam.SqlDbType = SqlDbType.Int;
                            //InOutParam.Direction = ParameterDirection.InputOutput;
                            //cmd.Parameters.Add(InOutParam);
                            // Set ReturnValue Parameter
                            break;
                        case "U":
                            cmd.Parameters.AddWithValue("@i_operacion", "U");
                            cmd.Parameters.AddWithValue("@i_id", model.id);
                            cmd.Parameters.AddWithValue("@i_nit", model.nit);
                            cmd.Parameters.AddWithValue("@i_tipo_identificacion", model.tipo_identificacion);
                            cmd.Parameters.AddWithValue("@i_nombres", model.nombres);
                            cmd.Parameters.AddWithValue("@i_apellidos", model.apellidos);
                            cmd.Parameters.AddWithValue("@i_estado", model.estado);
                            cmd.Parameters.AddWithValue("@i_email", model.email);
                            break;
                        case "D":
                            cmd.Parameters.AddWithValue("@i_operacion", "D");
                            cmd.Parameters.AddWithValue("@i_id", model.id);
                            break;
                    }
                    SqlParameter RetParam = new SqlParameter("ReturnValue", DBNull.Value);
                    RetParam.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(RetParam);
                    connection.Open();
                    Convert.ToInt32(cmd.ExecuteScalar());
                    // Start getting the RetrunValue and Output from Stored Procedure
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
