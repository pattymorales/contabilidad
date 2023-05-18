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
       /*FBusqueda FBusqueda1 = new FBusqueda("Cuenta", this);*/
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

        private void centrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCentros FCentros = new FCentros();
            FCentros.MdiParent = this;
            FCentros.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FTerceros FTerceros = new FTerceros();
            FTerceros.MdiParent = this;
            FTerceros.Show();
        }

        private void tipoTransaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTipoTransacciones FTipoTransacciones1 = new FTipoTransacciones();
            FTipoTransacciones1.MdiParent = this;
            FTipoTransacciones1.Show();
        }

        private void movimientoContableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMovimiento FMovimiento1 = new FMovimiento();
            FMovimiento1.MdiParent = this;
            FMovimiento1.Show();
        }
    }
}
