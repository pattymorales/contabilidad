using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad
{
    public partial class FMovimiento : Form, IMovimientoRequest
    {
        public int intIdTipoTran = 0;
        public FMovimiento()
        {
            InitializeComponent();
        }

        private void btoSalirMov_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btoBuscarTipoTranMov_Click(object sender, EventArgs e)
        {
            FBusqueda FBusqueda1 = new FBusqueda("TipoTranMov", this);
            FBusqueda1.Show();
        }

        private void FMovimiento_Load(object sender, EventArgs e)
        {

        }

        public void Movimiento_Complete(tipo_transacciones model)
        {
            intIdTipoTran = model.id;
            txtTipoMov.Text = model.tipo.ToString();
            lblDescripcionTipoMov.Text = model.descripcion.ToString();
            txtSiguienteTipoMov.Text = model.siguiente.ToString();
        }


        private void grdMovimientoMov_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 4 )
            //{
            //    if (grdMovimientoMov.Rows(grdMovimientoMov.CurrentRow.Index).Cells(e.ColumnIndex).Value != "" )
            //    {

            //    }
            //}
        }

        private void grdMovimientoMov_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch ( e.ColumnIndex)
            {
                case 1:
                    FBusqueda FBusquedaCuentaMovimiento = new FBusqueda("CuentaMovimiento", this);
                    FBusquedaCuentaMovimiento.Show();
                    break;
                case 4:
                    FBusqueda FBusquedaCentro = new FBusqueda("Centro", this);
                    FBusquedaCentro.Show();
                    break;
                default:
                    break;
            }
 
        }

        private void grdMovimientoMov_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.F1)
            //{
            //    int indexRow = grdMovimientoMov.CurrentRow.Index;
            //    if (indexRow < grdMovimientoMov.Rows.Count - 1)
            //    {
            //        //String valor= grdMovimientoMov.CurrentCell.Value.ToString();
            //        //String valor =  grdMovimientoMov[1, index].Value.ToString();
            //        grdMovimientoMov.CurrentRow.Selected = true;
            //        String valor = grdMovimientoMov.Rows[indexRow].Cells["grdMovimientoMovColCuenta"].FormattedValue.ToString();
            //        // grdMovimientoMov.CurrentCell = grdMovimientoMov.Rows[index+1].Cells[0];
            //        //String valor= grdMovimientoMov.CurrentCell.Value.ToString();
            //        /*String valor = "" + grdMovimientoMov[1, index].Value.ToString();*/

            //    }
            //    else
            //    {
            //        grdMovimientoMov.CurrentRow.Selected = true;
            //        String valor = grdMovimientoMov.Rows[indexRow].Cells["grdMovimientoMovColCuenta"].FormattedValue.ToString();

            //    }
            //}

            //if (this.grdMovimientoMov.cells .Columns(1).cellvalue(1).tostring() == "241")
            //{
            //    MessageBox.Show("prueba");
            //}
            if (e.KeyData == Keys.F1)
            {
                int indexColumn = grdMovimientoMov.CurrentCell.ColumnIndex;
                if (indexColumn == 0)
                {
                    int indexRow = grdMovimientoMov.CurrentRow.Index;
                    if (indexRow < grdMovimientoMov.Rows.Count - 1)
                    {

                    }
                    else
                    {
                        grdMovimientoMov.CurrentRow.Selected = true;
                        String valor = grdMovimientoMov.Rows[indexRow].Cells["grdMovimientoMovColCuenta"].FormattedValue.ToString();
                    }
                }
            }
        }

        private void grdMovimientoMov_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (grdMovimientoMov.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    grdMovimientoMov.CurrentRow.Selected = true;
            //    txtNotas.Text = grdMovimientoMov.Rows[e.RowIndex].Cells["grdMovimientoMovColCuenta"].FormattedValue.ToString();
            //}
        }

        private void grdMovimientoMov_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 104)
            //{
            //    int indexColumn = grdMovimientoMov.CurrentCell.ColumnIndex;
            //    if (indexColumn == 0 )
            //    {
            //        int indexRow = grdMovimientoMov.CurrentRow.Index;
            //        if (indexRow < grdMovimientoMov.Rows.Count - 1)
            //        {

            //        }
            //        else
            //        {
            //            grdMovimientoMov.CurrentRow.Selected = true;
            //            String valor = grdMovimientoMov.Rows[indexRow].Cells["grdMovimientoMovColCuenta"].FormattedValue.ToString();
            //        }
            //    }
            //}
        }

        private void grdMovimientoMov_CurrentCellChanged(object sender, EventArgs e)
        {
            //if (e.ToString() == "104")
            //{
            //    int indexColumn = grdMovimientoMov.CurrentCell.ColumnIndex;
            //    if (indexColumn == 0)
            //    {
            //        int indexRow = grdMovimientoMov.CurrentRow.Index;
            //        if (indexRow < grdMovimientoMov.Rows.Count - 1)
            //        {

            //        }
            //        else
            //        {
            //            grdMovimientoMov.CurrentRow.Selected = true;
            //            String valor = grdMovimientoMov.Rows[indexRow].Cells["grdMovimientoMovColCuenta"].FormattedValue.ToString();
            //        }
            //    }

            //}
        }

        public void CuentaComplete(Cuenta model)
        {
            txtCuenta.Text = model.cuenta.ToString();
            lblDescripcionCuenta1.Text = model.descripcion.ToString();

        }

        private void btoActualizarMov_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    int secuencial = 0;

                    DataAcces_Movimiento db = new DataAcces_Movimiento();
                    foreach (DataGridViewRow row in grdMovimientoMov.Rows)
                    {
                        //Movimiento movimientoModel = new Movimiento(0, txtCuenta.Text, txtDescripcion.Text, afe, naturaleza);
                        //secuencial = db.IUDCuentas("I", cuentaModel);
                        btoLimpiar_Click(sender, e);
                    }
                }
                catch
                {
                    MessageBox.Show("Datos no válidos. Favor revise su ingreso.");
                }
            }
            else
            {
                MessageBox.Show("Datos no válidos. Favor revise su ingreso.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            double totalDebito = 0;
            double totalCredito = 0;
            foreach (DataGridViewRow row in grdMovimientoMov.Rows)
            {
                int intCuenta = 0;
                string strCuenta = "";
                strCuenta = Convert.ToString(row.Cells[0].Value);
                bool cuentaValidateNumber = int.TryParse(strCuenta, out intCuenta);
                if (cuentaValidateNumber == false)
                {
                    output = false;
                }
                if (strCuenta.Length == 0)
                {
                    output = false;
                }
                totalDebito += Convert.ToDouble(row.Cells[8].Value); 
                totalCredito+= Convert.ToDouble(row.Cells[9].Value);
            }
            if (totalDebito != totalCredito)
            {
                output = false;
            }
            return output;
        }

        private void btoLimpiar_Click(object sender, EventArgs e)
        {
            txtTipoMov.Text = "";
            txtSiguienteTipoMov.Text = "";
        }

        private void btnBuscarCuentas_Click(object sender, EventArgs e)
        {
            FBusqueda FBusquedaCuentaMovimiento = new FBusqueda("CuentaMovimiento", this);
            FBusquedaCuentaMovimiento.Show();
        }

        private void btoBuscarTerceros_Click(object sender, EventArgs e)
        {
            FBusqueda FBusquedaTerceros = new FBusqueda("Tercero", this);
            FBusquedaTerceros.Show();
        }

        private void btoBuscarCentros_Click(object sender, EventArgs e)
        {
            FBusqueda FBusquedaCentros = new FBusqueda("Centro", this);
            FBusquedaCentros.Show();
        }
    }
        
}
