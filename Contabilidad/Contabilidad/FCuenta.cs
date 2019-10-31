using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Contabilidad
{
    
    public partial class FCuenta : Form, ICuentaRequest
    {
        
        public FCuenta()
        {
            InitializeComponent();
            //Load += new EventHandler(CuentaForm_Load);

        }

        private void btoBuscar_Click(object sender, EventArgs e)
        {
            FBusqueda FBusqueda1 = new FBusqueda(this);
            FBusqueda1.Show();
        }

        private void CuentaForm_Load(object sender, EventArgs e)
        {
        }

        private void btoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpCuenta_Enter(object sender, EventArgs e)
        {

        }
        
        public void CuentaComplete(Cuenta model)
        {
            txtId.Text = model.id.ToString();
            txtCuenta.Text = model.cuenta.ToString();
            txtDescripcion.Text = model.descripcion.ToString();
            string naturaleza = model.naturaleza.ToString();
            if (naturaleza == "0") {
                rbtDebito.Checked = true;
            }
            else
            {
                if (naturaleza == "1")
                {
                    rbtCredito.Checked = true;
                }
            }
            string afe = model.afe.ToString();
            if (afe == "1")
            {
                chkAfectable.Checked = true;
            }
            else
            {
                chkAfectable.Checked = false;
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int cuenta = 0;
            bool cuentaValidateNumber = int.TryParse(txtCuenta.Text, out cuenta);
            if  (cuentaValidateNumber == false)
            {
                output = false;
            }
            if (txtCuenta.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }

        private void btoIngresar_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try {
                    int secuencial = 0;
                    DataAcces_Cuentas db = new DataAcces_Cuentas();
                    int naturaleza = 0;
                    int afe = 0;
                    if (chkAfectable.Checked == true)
                        afe = 1;
                    if (rbtDebito.Checked == true )
                    {
                        naturaleza = 0;
                    }
                    else
                    {
                        if (rbtCredito.Checked == true)
                        {
                            naturaleza = 1;
                        }
                    }
                    Cuenta cuentaModel = new Cuenta(0, txtCuenta.Text, txtDescripcion.Text, afe  , naturaleza);
                    secuencial = db.IUDCuentas("I",cuentaModel);
                    btoLimpiar_Click(sender, e);
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

        private void btoModificar_Click(object sender, EventArgs e)
        {
            char[] charsToTrim = { ' ' };
            string strId = txtId.Text;
            if (strId != "")
            {
                try
                {
                    int secuencial = 0;
                    int naturaleza = 0;
                    int afe = 0;
                    if (chkAfectable.Checked == true)
                        afe = 1;
                    if (rbtDebito.Checked == true)
                    {
                        naturaleza = 0;
                    }
                    else
                    {
                        if (rbtCredito.Checked == true)
                        {
                            naturaleza = 1;
                        }
                    }
                    DataAcces_Cuentas db = new DataAcces_Cuentas();
                    Cuenta cuentaModel = new Cuenta(Int32.Parse(txtId.Text), txtCuenta.Text, txtDescripcion.Text, afe, naturaleza);
                    secuencial = db.IUDCuentas("U",cuentaModel);
                    if (secuencial == 0)
                    {
                        MessageBox.Show("Datos modificados correctamente");
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

        private void btoLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtCuenta.Text = "";
            txtDescripcion.Text = "";
        }

        private void btoEliminar_Click(object sender, EventArgs e)
        {
            Int32 salida = 0;
            char[] charsToTrim = { ' ' };
            string strId = txtId.Text;
            if (strId != "")
            {
                try
                {
                    DataAcces_Cuentas db = new DataAcces_Cuentas();
                    Cuenta cuentaModel = new Cuenta( Int32.Parse(txtId.Text), "", "",0,0);
                    salida = db.IUDCuentas("D", cuentaModel);
                    if (salida > 0 )
                    {
                        MessageBox.Show("Datos eliminados correctamente");
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

        private void btoPlanCuentas_Click(object sender, EventArgs e)
        {
            FPlanCuentas FPlanCuentas1 = new FPlanCuentas();
            FPlanCuentas1.Show();
        }
    }
}
