using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Contabilidad
{
    
    public partial class FTipoTransacciones : Form, ITipo_TranRequest
    {
        public tipo_transacciones tipo_TransaccionesV = new tipo_transacciones();
        public FTipoTransacciones()
        {
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            bool output = true;
            if (txtTipoTran.Text.Length == 0)
            {
                output = false;
            }
            if (txtDescripcionTipoTran.Text.Length == 0)
            {
                output = false;
            }
            if (cboSwTipoTran.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }

        private void FTipoTran_Load(object sender, EventArgs e)
        {

        }
        

        private void btoLimpiarTipoTran_Click(object sender, EventArgs e)
        {
            txtIdTipoTran.Text = "";
            txtTipoTran.Text = "";
            txtDescripcionTipoTran.Text = "";
            cboSwTipoTran.SelectedIndex = -1;
            btoIngresarTipoTran.Enabled = true;
            btoModificarTipoTran.Enabled = false;
            btoEliminarTipoTran.Enabled = false;
        }

        public void Tipo_Tran_Complete(tipo_transacciones model)
        {
            txtIdTipoTran.Text = model.id.ToString();
            txtTipoTran.Text = model.tipo.ToString();
            txtDescripcionTipoTran.Text = model.descripcion.ToString();
            switch (Int32.Parse(model.sw))
            {
                case 3:
                    cboSwTipoTran.SelectedIndex = 0;
                    break;
                case 5:
                    cboSwTipoTran.SelectedIndex = 1;
                    break;
                case 6:
                    cboSwTipoTran.SelectedIndex = 2;
                    break;
            }
            btoIngresarTipoTran.Enabled = false;
            btoModificarTipoTran.Enabled = true;
            btoEliminarTipoTran.Enabled = true;
            tipo_TransaccionesV = model;
        }
        
        private void FTipoTransacciones_Load(object sender, EventArgs e)
        {
            cboSwTipoTran.Items.Insert(0, "3 - Compras");
            cboSwTipoTran.Items.Insert(1, "5 - Recibo Caja Deudores (resta cxc)");
            cboSwTipoTran.Items.Insert(2, "6 - Egreso Proveedores (resta cxp)");
        }

        private void btoIngresarTipoTran_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    int intSecuencial = 0;
                    DataAcces_Tipo_Tran db = new DataAcces_Tipo_Tran();
                    string strSw = "";
                    string[] strSwArray = new string[2];
                    strSw = cboSwTipoTran.Text;
                    strSwArray = strSw.Split('-');
                    tipo_transacciones TipoTranModel = new tipo_transacciones(0, txtTipoTran.Text, txtDescripcionTipoTran.Text, strSwArray[0]);
                    intSecuencial = db.IUDTipo_Tran("I", TipoTranModel);
                    if (intSecuencial != -1)
                    {
                        txtIdTipoTran.Text = intSecuencial.ToString();
                        btoIngresarTipoTran.Enabled = false;
                        btoModificarTipoTran.Enabled = true;
                        btoEliminarTipoTran.Enabled = true;
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

        private void btoModificarTipoTran_Click(object sender, EventArgs e)
        {
            char[] charsToTrim = { ' ' };
            string strId = txtIdTipoTran.Text;
            if (strId != "")
            {
                try
                {
                    int secuencial = 0;
                    DataAcces_Tipo_Tran db = new DataAcces_Tipo_Tran();
                    string strSw = "";
                    string [] strSwArray = new string [2];
                    strSw = cboSwTipoTran.Text;
                    strSwArray = strSw.Split('-');
                    tipo_transacciones TipoTranModel = new tipo_transacciones(Int32.Parse(txtIdTipoTran.Text), txtTipoTran.Text, txtDescripcionTipoTran.Text, strSwArray[0]);
                    secuencial = db.IUDTipo_Tran("U", TipoTranModel);
                    if (secuencial == 0)
                    {
                        MessageBox.Show("Datos modificados correctamente");
                        btoLimpiarTipoTran_Click(sender, e);
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

        private void btoEliminarTipoTran_Click(object sender, EventArgs e)
        {
            while (MessageBox.Show("Está seguro de eliminar este Tipo de Transacción?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            Int32 salida = 0;
            char[] charsToTrim = { ' ' };
            string strId = txtIdTipoTran.Text;
            if (strId != "")
            {
                try
                {
                    DataAcces_Tipo_Tran db = new DataAcces_Tipo_Tran();
                    tipo_transacciones TipoTranModel = new tipo_transacciones(Int32.Parse(txtIdTipoTran.Text), "", "", "");
                    salida = db.IUDTipo_Tran("D", TipoTranModel);
                    MessageBox.Show("Datos eliminados correctamente");
                    btoLimpiarTipoTran_Click(sender, e);
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

        private void btoBuscarTipoTran_Click(object sender, EventArgs e)
        {
            FBusqueda FBusqueda1 = new FBusqueda("TipoTran", this);
            FBusqueda1.Show();
        }

        private void btoSalirTipoTran_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoSiguiente_Click(object sender, EventArgs e)
        {
            if (txtTipoTran.Text == "")
            {
                MessageBox.Show("Debe escoger un Tipo de Transacción");
                return;
            }
            FSiguiente FSiguiente1 = new FSiguiente(tipo_TransaccionesV);
            FSiguiente1.Show();
        }
    }
}
