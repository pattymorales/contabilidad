using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad
{
    public class nivelesCuentas
    {
        public int id { get; set; }
        public Byte nivel1 { get; set; }
        public Byte nivel2 { get; set; }
        public Byte nivel3 { get; set; }
        public Byte nivel4 { get; set; }
        public Byte nivel5 { get; set; }
        public Byte nivel6 { get; set; }
        public Byte nivel7 { get; set; }
        public Byte nivel8 { get; set; }
        public Byte nivel9 { get; set; }
        public Byte nivel10 { get; set; }

        public nivelesCuentas()
        {
        }

        public nivelesCuentas(int Id, Byte Nivel1, Byte Nivel2, Byte Nivel3, Byte Nivel4, Byte Nivel5, Byte Nivel6, Byte Nivel7, Byte Nivel8, Byte Nivel9, Byte Nivel10)
        {
            id = Id;
            nivel1 = Nivel1;
            nivel2 = Nivel2;
            nivel3 = Nivel3;
            nivel4 = Nivel4;
            nivel5 = Nivel5;
            nivel6 = Nivel6;
            nivel7 = Nivel7;
            nivel8 = Nivel8;
            nivel9 = Nivel9;
            nivel10 = Nivel10;
        }
    }
}
