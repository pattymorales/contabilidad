using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Contabilidad
{
    
    public partial class FCentros : Form, ICentroRequest
    {
        
        public FCentros()
        {
            InitializeComponent();
        }

       
        private void btoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateForm()
        {
            bool output = true;
            if (txtCentro.Text.Length == 0)
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
                    DataAcces_Centros db = new DataAcces_Centros();
                    Centro centroModel = new Centro(0, txtCentro.Text, txtDescripcionCentro.Text);
                    secuencial = db.IUDCentros("I",centroModel);
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
            string strId = txtIdCentro.Text;
            if (strId != "")
            {
                try
                {
                    int secuencial = 0;
                    DataAcces_Centros db = new DataAcces_Centros();
                    Centro centroModel = new Centro(Int32.Parse(txtIdCentro.Text), txtCentro.Text, txtDescripcionCentro.Text);
                    secuencial = db.IUDCentros("U",centroModel);
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
            txtIdCentro.Text = "";
            txtCentro.Text = "";
            txtDescripcionCentro.Text = "";
        }

        private void btoEliminar_Click(object sender, EventArgs e)
        {
            Int32 salida = 0;
            char[] charsToTrim = { ' ' };
            string strId = txtIdCentro.Text;
            if (strId != "")
            {
                try
                {
                    DataAcces_Centros db = new DataAcces_Centros();
                    Centro centroModel = new Centro( Int32.Parse(txtIdCentro.Text), "", "");
                    salida = db.IUDCentros("D", centroModel);
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
        

        private void FCentro_Load(object sender, EventArgs e)
        {

        }
        

        private void btoIngresarCentros_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    int intSecuencial = 0;
                    DataAcces_Centros db = new DataAcces_Centros();
                    Centro centroModel = new Centro(0, txtCentro.Text, txtDescripcionCentro.Text);
                    intSecuencial = db.IUDCentros("I", centroModel);
                    if (intSecuencial != -1)
                    {
                        txtIdCentro.Text = intSecuencial.ToString();
                        btoIngresarCentros.Enabled = false;
                        btoModificarCentros.Enabled = true;
                        btoEliminarCentros.Enabled = true;
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

        private void btoLimpiarCentros_Click(object sender, EventArgs e)
        {
            txtIdCentro.Text = "";
            txtCentro.Text = "";
            txtDescripcionCentro.Text = "";
            btoIngresarCentros.Enabled = true;
            btoModificarCentros.Enabled = false;
            btoEliminarCentros.Enabled = false;
        }

        public void CentroComplete(Centro model)
        {
            txtIdCentro.Text = model.id.ToString();
            txtCentro.Text = model.centro.ToString();
            txtDescripcionCentro.Text = model.descripcion.ToString();
            btoIngresarCentros.Enabled = false;
            btoModificarCentros.Enabled = true;
            btoEliminarCentros.Enabled = true;
        }

        private void btoBuscarCentros_Click(object sender, EventArgs e)
        {
            FBusqueda FBusqueda1 = new FBusqueda( "Centro", this);
            FBusqueda1.Show();
        }

        private void btoSalirCentros_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoModificarCentros_Click(object sender, EventArgs e)
        {
            char[] charsToTrim = { ' ' };
            string strId = txtIdCentro.Text;
            if (strId != "")
            {
                try
                {
                    int secuencial = 0;
                    DataAcces_Centros db = new DataAcces_Centros();
                    Centro centroModel = new Centro(Int32.Parse(txtIdCentro.Text), txtCentro.Text, txtDescripcionCentro.Text);
                    secuencial = db.IUDCentros("U", centroModel);
                    if (secuencial == 0)
                    {
                        MessageBox.Show("Datos modificados correctamente");
                        btoLimpiarCentros_Click(sender, e);
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

        private void btoEliminarCentros_Click(object sender, EventArgs e)
        {
            while (MessageBox.Show("Está seguro de eliminar este centro?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            Int32 salida = 0;
            char[] charsToTrim = { ' ' };
            string strId = txtIdCentro.Text;
            if (strId != "")
            {
                try
                {
                    DataAcces_Centros db = new DataAcces_Centros();
                    Centro centroModel = new Centro(Int32.Parse(txtIdCentro.Text), "", "");
                    salida = db.IUDCentros("D", centroModel);
                    MessageBox.Show("Datos eliminados correctamente");
                    btoLimpiarCentros_Click(sender, e);
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
    }
}
