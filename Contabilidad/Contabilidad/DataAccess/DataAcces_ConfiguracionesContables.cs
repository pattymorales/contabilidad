using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Dapper;

namespace Contabilidad
{
    class DataAcces_ConfiguracionesContables
    {
        public List<nivelesCuentas> GetNivelesCuentas()
        {

            using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("contabilidad")))
            {
                var output = connection.Query<nivelesCuentas>($"select id , nivel1, nivel2, nivel3, nivel4, nivel5, nivel6, nivel7, nivel8, nivel9, nivel10 from nivelesCuentas").ToList();
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

        public Int32 IUDnivelesCuentas(string Operacion, nivelesCuentas model)
        {
            Int32 newCarID = 0;
            using (SqlConnection connection = new SqlConnection(Helper.cnnVal("contabilidad")))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_nivelesCuentas", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    switch (Operacion)
                    {
                        case "I":
                            cmd.Parameters.AddWithValue("@i_operacion", "I");
                            cmd.Parameters.AddWithValue("@i_nivel1", model.nivel1);
                            cmd.Parameters.AddWithValue("@i_nivel2", model.nivel2);
                            cmd.Parameters.AddWithValue("@i_nivel3", model.nivel3);
                            cmd.Parameters.AddWithValue("@i_nivel4", model.nivel4);
                            cmd.Parameters.AddWithValue("@i_nivel5", model.nivel5);
                            cmd.Parameters.AddWithValue("@i_nivel6", model.nivel6);
                            cmd.Parameters.AddWithValue("@i_nivel7", model.nivel7);
                            cmd.Parameters.AddWithValue("@i_nivel8", model.nivel8);
                            cmd.Parameters.AddWithValue("@i_nivel9", model.nivel9);
                            cmd.Parameters.AddWithValue("@i_nivel10", model.nivel10);
                            break;
                        case "U":
                            cmd.Parameters.AddWithValue("@i_operacion", "U");
                            cmd.Parameters.AddWithValue("@i_id", model.id);
                            cmd.Parameters.AddWithValue("@i_nivel1", model.nivel1);
                            cmd.Parameters.AddWithValue("@i_nivel2", model.nivel2);
                            cmd.Parameters.AddWithValue("@i_nivel3", model.nivel3);
                            cmd.Parameters.AddWithValue("@i_nivel4", model.nivel4);
                            cmd.Parameters.AddWithValue("@i_nivel5", model.nivel5);
                            cmd.Parameters.AddWithValue("@i_nivel6", model.nivel6);
                            cmd.Parameters.AddWithValue("@i_nivel7", model.nivel7);
                            cmd.Parameters.AddWithValue("@i_nivel8", model.nivel8);
                            cmd.Parameters.AddWithValue("@i_nivel9", model.nivel9);
                            cmd.Parameters.AddWithValue("@i_nivel10", model.nivel10);
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
