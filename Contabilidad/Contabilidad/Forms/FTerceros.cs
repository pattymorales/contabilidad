using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Contabilidad
{
    
    public partial class FTerceros : Form, ITerceroRequest
    {
        
        public FTerceros()
        {
            InitializeComponent();
        }

        public void TerceroComplete(Tercero model)
        {
            txtIdTercero.Text = model.id.ToString();
            switch (model.tipo_identificacion)
            {
                case "R":
                    cboTipoIdentificacionTercero.SelectedIndex = 0;
                    break;
                case "C":
                    cboTipoIdentificacionTercero.SelectedIndex = 1;
                    break;
                case "P":
                    cboTipoIdentificacionTercero.SelectedIndex = 2;
                    break;
            }
            txtNitTercero.Text = model.nit;
            txtNombresTercero.Text = model.nombres;
            txtApellidosTercero.Text = model.apellidos;
            txtEmailTercero.Text = model.email;
            if (model.estado == "True")
            {
                cboEstadoTercero.SelectedIndex = 0;
            }
            else
            {
                cboEstadoTercero.SelectedIndex = 1;
            }
            btoIngresarTercero.Enabled = false;
            btoModificarTercero.Enabled = true;
            btoEliminarTercero.Enabled = true;
        }

        private void btoBuscarTerceros_Click(object sender, EventArgs e)
        {
            Tercero terceroModel = new Tercero(0, "", txtNitTercero.Text, txtNombresTercero.Text, txtApellidosTercero.Text, "", txtEmailTercero.Text);
            FBusqueda FBusqueda2 = new FBusqueda("Tercero", this, terceroModel);
            FBusqueda2.Show();
        }

        private void btoIngresarTercero_Click(object sender, EventArgs e)
        {
            if (ValidateForm(sender))
            {
                try
                {
                    int intSecuencial = 0;
                    string strTipoIdentificacion = "";
                    string strEstado = "";
                    DataAcces_Terceros db = new DataAcces_Terceros();
                    switch (cboTipoIdentificacionTercero.Text)
                    {
                        case "RUC":
                            strTipoIdentificacion = "R";
                            break;
                        case "CEDULA":
                            strTipoIdentificacion = "C";
                            break;
                        case "PASAPORTE":
                            strTipoIdentificacion = "P";
                            break;
                    }
                    switch (cboEstadoTercero.Text)
                    {
                        case "ACTIVO":
                            strEstado = "1";
                            break;
                        case "INACTIVO":
                            strEstado = "0";
                            break;
                    }
                    Tercero terceroModel = new Tercero(0, strTipoIdentificacion, txtNitTercero.Text, txtNombresTercero.Text, txtApellidosTercero.Text, strEstado, txtEmailTercero.Text);
                    intSecuencial = db.IUDTerceros("I", terceroModel);
                    //btoLimpiarTercero_Click(sender, e);
                    if (intSecuencial != -1)
                    {
                        txtIdTercero.Text = intSecuencial.ToString();
                        btoIngresarTercero.Enabled = false;
                        btoModificarTercero.Enabled = true;
                        btoEliminarTercero.Enabled = true;
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

        private bool ValidateForm(object sender)
        {
            bool output = true;
            double nitTercero = 0;
            bool nitValidateNumber = double.TryParse(txtNitTercero.Text, out nitTercero);
            string strText = (sender as Button).Text;
            if (strText == "Modificar" || strText == "Eliminar")
            {
                if (txtIdTercero.Text.Length == 0)
                {
                    MessageBox.Show("Para modificar o eliminar, debe escoger un tercero");
                    output = false;
                }
            }
            if (strText == "Modificar" || strText == "Ingresar")
            {
                if (txtNitTercero.Text.Length == 0)
                {
                    output = false;
                }
                switch (cboTipoIdentificacionTercero.Text)
                {
                    case "RUC":
                        if (txtNitTercero.Text.Length != 13)
                        {
                            MessageBox.Show("La longitud de la identificación debe ser de 13 digitos");
                            output = false;
                        }
                        if (nitValidateNumber == false)
                        {
                            output = false;
                        }
                        break;
                    case "CEDULA":
                        if (txtNitTercero.Text.Length != 10)
                        {
                            MessageBox.Show("La longitud de la identificación debe ser de 10 digitos");
                            output = false;
                        }
                        if (nitValidateNumber == false)
                        {
                            output = false;
                        }
                        break;
                    case "PASAPORTE":
                        break;
                    default:
                        MessageBox.Show("Debe seleccionar el tipo de identificación");
                        output = false;
                        break;
                }
                if (cboEstadoTercero.Text == "")
                {
                    MessageBox.Show("Debe ingresar el estado");
                    output = false;
                }
            }
            return output;
        }

        private void btoLimpiarTercero_Click(object sender, EventArgs e)
        {
            txtIdTercero.Text = "";
            cboTipoIdentificacionTercero.SelectedIndex = 0;
            txtNitTercero.Text = "";
            txtNombresTercero.Text = "";
            txtApellidosTercero.Text = "";
            txtNombresTercero.Text = "";
            txtEmailTercero.Text = "";
            cboEstadoTercero.SelectedIndex = 0;
            btoIngresarTercero.Enabled = true;
            btoModificarTercero.Enabled = false;
            btoEliminarTercero.Enabled = false;
        }

        private void FTerceros_Load(object sender, EventArgs e)
        {
            cboTipoIdentificacionTercero.Items.Add("RUC");
            cboTipoIdentificacionTercero.Items.Add("CEDULA");
            cboTipoIdentificacionTercero.Items.Add("PASAPORTE");
            cboEstadoTercero.Items.Add("ACTIVO");
            cboEstadoTercero.Items.Add("INACTIVO");

        }

        private void cboTipoIdentificacionTercero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoIdentificacionTercero.Text == "RUC")
            {
                txtApellidosTercero.Text = "";
                txtApellidosTercero.Enabled = false;
            }
            else
            {
                txtApellidosTercero.Enabled = true;
            }
        }

        private void btoModificarTercero_Click(object sender, EventArgs e)
        {
            if (ValidateForm(sender))
            {
                try
                {
                    int secuencial = 0;
                    string strTipoIdentificacion = "";
                    string strEstado = "";
                    DataAcces_Terceros db = new DataAcces_Terceros();
                    switch (cboTipoIdentificacionTercero.Text)
                    {
                        case "RUC":
                            strTipoIdentificacion = "R";
                            break;
                        case "CEDULA":
                            strTipoIdentificacion = "C";
                            break;
                        case "PASAPORTE":
                            strTipoIdentificacion = "P";
                            break;
                    }
                    switch (cboEstadoTercero.Text)
                    {
                        case "ACTIVO":
                            strEstado = "1";
                            break;
                        case "INACTIVO":
                            strEstado = "0";
                            break;
                    }
                    Tercero terceroModel = new Tercero(Int32.Parse(txtIdTercero.Text), strTipoIdentificacion, txtNitTercero.Text, txtNombresTercero.Text, txtApellidosTercero.Text, strEstado, txtEmailTercero.Text);
                    secuencial = db.IUDTerceros("U", terceroModel);
                    //btoLimpiarTercero_Click(sender, e);
                    btoIngresarTercero.Enabled = false;
                    btoModificarTercero.Enabled = false;
                    btoEliminarTercero.Enabled = true;
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

        private void btoSalirTercero_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoEliminarTercero_Click(object sender, EventArgs e)
        {
            while(MessageBox.Show("Está seguro de eliminar este tercero?", "", MessageBoxButtons.YesNo) == DialogResult.No){
                return;
            }
            if (ValidateForm(sender))
            {
                try
                {
                    int secuencial = 0;
                    DataAcces_Terceros db = new DataAcces_Terceros();
                    Tercero terceroModel = new Tercero(Int32.Parse(txtIdTercero.Text));
                    secuencial = db.IUDTerceros("D", terceroModel);
                    btoLimpiarTercero_Click(sender, e);
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
