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
    public partial class FSiguiente : Form
    {
        public static string strTipoCall = "";
        private tipo_transacciones tipo_transacciones2 = new tipo_transacciones();
        int intSiguiente = 0;
        int intId = 0;
        public FSiguiente(tipo_transacciones tipo_transacciones1)
        {
            InitializeComponent();
            tipo_transacciones2 = tipo_transacciones1;
        }

        private void FSiguiente_Load(object sender, EventArgs e)
        {
            txtSiguiente.Text = Convert.ToString(tipo_transacciones2.siguiente);
            lblTipo.Text = tipo_transacciones2.tipo;
            lblDescripcion.Text= tipo_transacciones2.descripcion;
            
        }

        private void btoGrabar_Click(object sender, EventArgs e)
        {
            int intSecuencial = 0;
            DataAcces_Tipo_Tran dbCTipo_Tran = new DataAcces_Tipo_Tran();
            tipo_transacciones2.siguiente = Int32.Parse(txtSiguiente.Text);
            intSecuencial = dbCTipo_Tran.IUDTipo_Tran("S", tipo_transacciones2);
            if (intSecuencial != -1)
            {
                MessageBox.Show("Registro modificado correctamente");
            }
        }

        private void btoSalirSiguiente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
