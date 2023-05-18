using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad
{
    public class tipo_transacciones
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public string descripcion { get; set; }
        public string sw { get; set; }
        public int siguiente { get; set; }

        public string fullInfo
        {
            get
            {
                return $"{ tipo}{ descripcion}{sw} ";
            }
        }

        public tipo_transacciones()
        {
        }

        public tipo_transacciones(int Id, string Tipo, string Descripcion, string Sw)
        {
            id = Id;
            tipo = Tipo;
            descripcion = Descripcion;
            sw = Sw;
        }
        

    }



}
