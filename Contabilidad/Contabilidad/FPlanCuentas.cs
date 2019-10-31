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
    public partial class FPlanCuentas : Form
    {
        List<Cuenta> acount = new List<Cuenta>();
        public FPlanCuentas()
        {
            InitializeComponent();
        }

        private void FPlanCuentas_Load(object sender, EventArgs e)
        {
            DataAcces_Cuentas dbCuentas = new DataAcces_Cuentas();
            acount = dbCuentas.GetCuentas();
            List<nivelesCuentas> NivelesCuentas = new List<nivelesCuentas>();
            DataAcces_ConfiguracionesContables dbConfiguracionesContable = new DataAcces_ConfiguracionesContables();
            NivelesCuentas = dbConfiguracionesContable.GetNivelesCuentas();
            Int16[] niveles = new Int16[11];

            foreach (nivelesCuentas nivelesCuentasRow in NivelesCuentas)
            {
                niveles[1] = nivelesCuentasRow.nivel1;
                niveles[2] = nivelesCuentasRow.nivel2;
                niveles[3] = nivelesCuentasRow.nivel3;
                niveles[4] = nivelesCuentasRow.nivel4;
                niveles[5] = nivelesCuentasRow.nivel5;
                niveles[6] = nivelesCuentasRow.nivel6;
                niveles[7] = nivelesCuentasRow.nivel7;
                niveles[8] = nivelesCuentasRow.nivel8;
                niveles[9] = nivelesCuentasRow.nivel9;
                niveles[10] = nivelesCuentasRow.nivel10;
            }
            Int16 nivel =0;
            Int32 nivelLenght = 0;
            Int32 nivelPadreLenght = 0;
            foreach (Int16 nivC in niveles)
            { 
                if (nivel == 1)
                {
                    //Nivel1
                    nivelLenght = nivC;
                    foreach (Cuenta CuentaRow in acount)
                    {
                        string var = CuentaRow.cuenta;
                        if (var.Length == nivC)
                        {
                            treeView1.Nodes.Add(CuentaRow.cuenta + " - " + CuentaRow.descripcion);
                        }
                    }
                }
                if (nivel > 1)
                {
                    //Nivel mayor a 1
                    nivelLenght = nivelLenght + nivC;
                    foreach (Cuenta CuentaRow in acount)
                    {
                        string var = CuentaRow.cuenta;
                        if (var.Length == nivelLenght)
                        {
                            InsertCuentas(treeView1, CuentaRow, nivel, nivelLenght, nivelPadreLenght);
                        }
                    }
                }
                nivel++;
                nivelPadreLenght = nivelLenght; 
            }
        }

        private void InsertCuentas( TreeView node, Cuenta CuentaRow,  Int16 nivel, Int32 nivelLenght, Int32 nivelPadreLenght)
        {
            string soloNumCuenta array();
            TreeNodeCollection myNodes = node.Nodes;
            string padre = CuentaRow.cuenta.Substring(0, nivelPadreLenght);
            foreach (TreeNode n in myNodes)
            {
                
                if (padre == n.Text)
                {
                    node.Nodes[n.Index].Nodes.Add(CuentaRow.cuenta + " - " + CuentaRow.descripcion);
                }
                else
                {
                    InsertNodoCuentas(n, CuentaRow, nivel, nivelLenght, nivelPadreLenght);
                }
            }
        }

        private void InsertNodoCuentas(TreeNode node, Cuenta CuentaRow, Int16 nivel, Int32 nivelLenght, Int32 nivelPadreLenght)
        {
            TreeNodeCollection myNodes = node.Nodes;
            string padre = CuentaRow.cuenta.Substring(0, nivelPadreLenght);
            foreach (TreeNode n in myNodes)
            {
                if (n.Nodes.Count == 0)
                {
                    if (padre == n.Text)
                    {
                         node.Nodes[n.Index].Nodes.Add(CuentaRow.cuenta + " - " + CuentaRow.descripcion);
                    }
                }
                else
                {
                    if (padre == n.Text)
                    {
                        node.Nodes[n.Index].Nodes.Add(CuentaRow.cuenta + " - " + CuentaRow.descripcion);
                    }
                    else
                    {
                        InsertNodoCuentas(n, CuentaRow, nivel, nivelLenght, nivelPadreLenght);
                    }
                }
            }
        }

        private List<TreeNode> Descendants( TreeNode node)
        {
            var nodes = node.Nodes.Cast<TreeNode>().ToList();
            return nodes.SelectMany(x => Descendants(x)).Concat(nodes).ToList();
        }
    }
}
