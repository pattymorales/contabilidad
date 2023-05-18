using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad
{
    public class Documentos
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public int numero { get; set; }
        public tipo_transacciones tipo_transaccionesBase { get; private set; }

        public Documentos(tipo_transacciones tipo_transacciones, int numero)
        {
            tipo_transaccionesBase = tipo_transacciones;
            numero = numero;
        }
    }
}
