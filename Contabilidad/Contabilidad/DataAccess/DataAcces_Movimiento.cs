using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Contabilidad
{
    public class DataAcces_Movimiento
    {
        SqlTransaction Transaccion;

        public Int32 IUDMovimiento(string Operacion, Movimiento model)
        {
            Int32 newCarID = 0;
            using (SqlConnection connection = new SqlConnection(Helper.cnnVal("contabilidad")))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_movimiento", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    switch (Operacion)
                    {
                        case "I":
                            cmd.Parameters.AddWithValue("@i_operacion", "I");
                            cmd.Parameters.AddWithValue("@i_tipo", model.tipo);
                            cmd.Parameters.AddWithValue("@i_numero", model.numero);
                            cmd.Parameters.AddWithValue("@i_seq", model.seq);
                            cmd.Parameters.AddWithValue("@i_seq", model.cuenta);
                            cmd.Parameters.AddWithValue("@i_centro", model.centro);
                            cmd.Parameters.AddWithValue("@i_nit", model.nit);
                            cmd.Parameters.AddWithValue("@i_fec", model.fec);
                            cmd.Parameters.AddWithValue("@i_valor", model.valor);
                            cmd.Parameters.AddWithValue("@i_documento", model.documento);
                            cmd.Parameters.AddWithValue("@i_explicacion", model.explicacion);
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

        public Int32 IUDMovimiento(string Operacion, Documentos modelDocumentos, Cuenta modelCuenta)
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
                            cmd.Parameters.AddWithValue("@i_cuenta", modelCuenta.cuenta);
                            cmd.Parameters.AddWithValue("@i_descripcion", modelCuenta.descripcion);
                            cmd.Parameters.AddWithValue("@i_afe", modelCuenta.afe);
                            cmd.Parameters.AddWithValue("@i_naturaleza", modelCuenta.naturaleza);
                            break;
                        case "U":
                            cmd.Parameters.AddWithValue("@i_operacion", "U");
                            cmd.Parameters.AddWithValue("@i_id", modelCuenta.id);
                            cmd.Parameters.AddWithValue("@i_cuenta", modelCuenta.cuenta);
                            cmd.Parameters.AddWithValue("@i_descripcion", modelCuenta.descripcion);
                            cmd.Parameters.AddWithValue("@i_afe", modelCuenta.afe);
                            cmd.Parameters.AddWithValue("@i_naturaleza", modelCuenta.naturaleza);
                            break;
                        case "D":
                            cmd.Parameters.AddWithValue("@i_operacion", "D");
                            cmd.Parameters.AddWithValue("@i_id", modelCuenta.id);
                            break;
                    }
                    connection.Open();
                    Transaccion = connection.BeginTransaction();
                    newCarID = Convert.ToInt32(cmd.ExecuteScalar());
                    Transaccion.Commit();
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
    }
}
