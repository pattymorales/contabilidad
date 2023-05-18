using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Contabilidad.DataAccess
{
    public class DataAcces_Documentos
    {
        public Int32 IUDDocumentos(string Operacion, Documentos model)
        {
            Int32 newCarID = 0;
            using (SqlConnection connection = new SqlConnection(Helper.cnnVal("contabilidad")))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_documentos", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    switch (Operacion)
                    {
                        case "I":
                            cmd.Parameters.AddWithValue("@i_operacion", "I");
                            cmd.Parameters.AddWithValue("@i_tipo", model.tipo);
                            cmd.Parameters.AddWithValue("@i_numero", model.numero);
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
