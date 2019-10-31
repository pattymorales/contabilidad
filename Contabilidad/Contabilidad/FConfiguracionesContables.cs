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
    public partial class FConfiguracionesContables : Form
    {
        DataAcces_ConfiguracionesContables dbConfiguracionesContable = new DataAcces_ConfiguracionesContables();
        List<nivelesCuentas> NivelesCuentas = new List<nivelesCuentas>();
        public FConfiguracionesContables()
        {
            InitializeComponent();
        }

        private void FNivelesCuenta_Load(object sender, EventArgs e)
        {
            NivelesCuentas = dbConfiguracionesContable.GetNivelesCuentas();
            FullGrid();

        }

        private void FullGrid()
        {
            grdNiveles.DataSource = NivelesCuentas;
        }

        private bool ValidateForm()
        {
            bool output = true;
            int nivel = 0;
            bool nivelValidateNumber = int.TryParse(txtNivel1.Text, out nivel);
            if (nivelValidateNumber == false)
            {
                output = false;
            }
            nivelValidateNumber = int.TryParse(txtNivel2.Text, out nivel);
            if (nivelValidateNumber == false)
            {
                output = false;
            }
            nivelValidateNumber = int.TryParse(txtNivel3.Text, out nivel);
            if (nivelValidateNumber == false)
            {
                output = false;
            }
            nivelValidateNumber = int.TryParse(txtNivel4.Text, out nivel);
            if (nivelValidateNumber == false)
            {
                output = false;
            }
            nivelValidateNumber = int.TryParse(txtNivel5.Text, out nivel);
            if (nivelValidateNumber == false)
            {
                output = false;
            }
            nivelValidateNumber = int.TryParse(txtNivel6.Text, out nivel);
            if (nivelValidateNumber == false)
            {
                output = false;
            }
            nivelValidateNumber = int.TryParse(txtNivel7.Text, out nivel);
            if (nivelValidateNumber == false)
            {
                output = false;
            }
            nivelValidateNumber = int.TryParse(txtNivel8.Text, out nivel);
            if (nivelValidateNumber == false)
            {
                output = false;
            }
            nivelValidateNumber = int.TryParse(txtNivel9.Text, out nivel);
            if (nivelValidateNumber == false)
            {
                output = false;
            }
            nivelValidateNumber = int.TryParse(txtNivel10.Text, out nivel);
            if (nivelValidateNumber == false)
            {
                output = false;
            }
            return output;
        }

        private void btoIngresar_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    int secuencial = 0;
                    int selectedRow = Convert.ToInt32(grdNiveles.RowCount);
                    if (selectedRow > 0)
                    {
                        MessageBox.Show("Solo puede tener una configuración ingresada.");
                        return;
                    }
                    nivelesCuentas nivelesCuentasModel = new nivelesCuentas(0, Byte.Parse(txtNivel1.Text), Byte.Parse(txtNivel2.Text), Byte.Parse(txtNivel3.Text), Byte.Parse(txtNivel4.Text), Byte.Parse(txtNivel5.Text), Byte.Parse(txtNivel6.Text), Byte.Parse(txtNivel7.Text), Byte.Parse(txtNivel8.Text), Byte.Parse(txtNivel9.Text), Byte.Parse(txtNivel10.Text));
                    secuencial = dbConfiguracionesContable.IUDnivelesCuentas("I",nivelesCuentasModel);
                    NivelesCuentas = dbConfiguracionesContable.GetNivelesCuentas();
                    FullGrid();
                    btoLimpiar();
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

        private void btoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void grdNiveles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nivelesCuentas modelo = new nivelesCuentas();
                int selectedRow = Convert.ToInt32(grdNiveles.RowCount);
                if (selectedRow > -1)
                {
                    txtId.Text = Convert.ToString(grdNiveles.Rows[e.RowIndex].Cells[0].Value);
                    txtNivel1.Text = Convert.ToString(grdNiveles.Rows[e.RowIndex].Cells[1].Value);
                    txtNivel2.Text = Convert.ToString(grdNiveles.Rows[e.RowIndex].Cells[2].Value);
                    txtNivel3.Text = Convert.ToString(grdNiveles.Rows[e.RowIndex].Cells[3].Value);
                    txtNivel4.Text = Convert.ToString(grdNiveles.Rows[e.RowIndex].Cells[4].Value);
                    txtNivel5.Text = Convert.ToString(grdNiveles.Rows[e.RowIndex].Cells[5].Value);
                    txtNivel6.Text = Convert.ToString(grdNiveles.Rows[e.RowIndex].Cells[6].Value);
                    txtNivel7.Text = Convert.ToString(grdNiveles.Rows[e.RowIndex].Cells[7].Value);
                    txtNivel8.Text = Convert.ToString(grdNiveles.Rows[e.RowIndex].Cells[8].Value);
                    txtNivel9.Text = Convert.ToString(grdNiveles.Rows[e.RowIndex].Cells[9].Value);
                    txtNivel10.Text = Convert.ToString(grdNiveles.Rows[e.RowIndex].Cells[10].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void grdNiveles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btoModificar_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    int secuencial = 0;
                    nivelesCuentas nivelesCuentasModel = new nivelesCuentas(int.Parse(txtId.Text), Byte.Parse(txtNivel1.Text), Byte.Parse(txtNivel2.Text), Byte.Parse(txtNivel3.Text), Byte.Parse(txtNivel4.Text), Byte.Parse(txtNivel5.Text), Byte.Parse(txtNivel6.Text), Byte.Parse(txtNivel7.Text), Byte.Parse(txtNivel8.Text), Byte.Parse(txtNivel9.Text), Byte.Parse(txtNivel10.Text));
                    secuencial = dbConfiguracionesContable.IUDnivelesCuentas("U", nivelesCuentasModel);
                    NivelesCuentas = dbConfiguracionesContable.GetNivelesCuentas();
                    FullGrid();
                    btoLimpiar();
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

        private void btoLimpiar()
        {
            txtNivel1.Text = "";
            txtNivel2.Text = "";
            txtNivel3.Text = "";
            txtNivel4.Text = "";
            txtNivel5.Text = "";
            txtNivel6.Text = "";
            txtNivel7.Text = "";
            txtNivel8.Text = "";
            txtNivel9.Text = "";
            txtNivel10.Text = "";
        }
    }
}
