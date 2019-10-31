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
    public partial class FBusqueda : Form
    {
        List<Cuenta> acount = new List<Cuenta>();
        public static string SetValueForText1 = "";
        ICuentaRequest callingForm;

        
        public FBusqueda(ICuentaRequest caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void UpdateAcount()
        {
            grdViewDatos.DataSource = acount;
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            DataAcces_Cuentas db = new DataAcces_Cuentas();
            acount = db.GetCuentas();
            UpdateAcount();
        }


        private void btnEscoger_Click(object sender, EventArgs e)
        {
            try
            {
                //set parameters of your event args
                var eventArgs = new DataGridViewCellEventArgs(0, Int32.Parse(grdViewDatos.CurrentRow.Index.ToString()));
                grdViewDatos_CellContentClick(sender, eventArgs);
            }
            catch {
                this.Close();
             }
        }

        private void grdViewDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cuenta modelo = new Cuenta();
                int selectedRow = Convert.ToInt32(grdViewDatos.RowCount);
                if (selectedRow > -1)
                {
                    string selectedId = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[0].Value);
                    modelo.id = Int32.Parse(selectedId);
                    string selectedCuenta = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[1].Value);
                    modelo.cuenta = selectedCuenta;
                    string selectedDescription = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[2].Value);
                    modelo.descripcion = selectedDescription;
                    string selectedAfe = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[3].Value);
                    modelo.afe = Int32.Parse(selectedAfe);
                    string selectedNaturaleza = Convert.ToString(grdViewDatos.Rows[e.RowIndex].Cells[10].Value);
                    modelo.naturaleza = Int32.Parse(selectedNaturaleza);
                    callingForm.CuentaComplete(modelo);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        
    }
}
