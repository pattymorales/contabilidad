using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad
{
    public class Cuenta
    {
        public int id { get; set; }
        public string cuenta { get; set; }
        public string descripcion { get; set; }
        public int afe { get; set; }
        public int cco { get; set; }
        public int ter { get; set; }
        public int doc { get; set; }
        public int aju { get; set; }
        public int bas { get; set; }
        public int tei { get; set; }
        public int naturaleza { get; set; }

        public string fullInfo
        {
            get
            {
                return $"{ cuenta}{ descripcion}({ afe}) ";
            }
        }

        public Cuenta()
        {
        }

        public Cuenta(int Id, string Cuenta , string Descripcion, int Afe, int Naturaleza)
        {
            id = Id;
            cuenta = Cuenta;
            descripcion = Descripcion;
            afe = Afe;
            naturaleza = Naturaleza;
        }

       
    }



}
