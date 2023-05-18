using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad
{
    public class Tercero
    {
        public int id { get; set; }
        public string nit { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string tipo_identificacion { get; set; }
        public string estado { get; set; }
        public string email { get; set; }
        public string fullInfo
        {
            get
            {
                return $"{id}{tipo_identificacion}{nit}{nombres}{apellidos}{email}{estado}";
            }
        }

        public Tercero()
        {
        }

        public Tercero(int Id, string TipoIdentificacion, string Nit, string Nombres, string Apellidos, string Estado, string Email)
        {
            id = Id;
            tipo_identificacion = TipoIdentificacion;
            nit = Nit;
            nombres = Nombres;
            apellidos = Apellidos;
            estado = Estado;
            email = Email;
        }

        public Tercero(string Nit)
        {
            nit = Nit;
        }

        public Tercero(int Id)
        {
            id = Id;
        }
    
    }



}
