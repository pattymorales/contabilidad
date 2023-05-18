using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad
{
    public class Centro
    {
        public int id { get; set; }
        public string centro { get; set; }
        public string descripcion { get; set; }

        public string fullInfo
        {
            get
            {
                return $"{ centro}{ descripcion} ";
            }
        }

        public Centro()
        {
        }

        public Centro(int Id, string Centro, string Descripcion)
        {
            id = Id;
            centro = Centro;
            descripcion = Descripcion;
        }

       
    }



}
