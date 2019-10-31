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
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }


        private void MnuCuentas_Click(object sender, EventArgs e)
        {
            FCuenta FCuenta1 = new FCuenta();
            FCuenta1.MdiParent = this;
            FCuenta1.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void configuracionesContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FConfiguracionesContables FConfiguracionesContables1 = new FConfiguracionesContables();
            FConfiguracionesContables1.MdiParent = this;
            FConfiguracionesContables1.Show();
        }
    }
}
