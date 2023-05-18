using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilidad
{
    public class Movimiento
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public int numero { get; set; }
        public int seq { get; set; }
        public string cuenta { get; set; }
        public string centro { get; set; }
        public string nit { get; set; }
        public string fec { get; set; }
        public double valor { get; set; }
        public string documento { get; set; }
        public string explicacion { get; set; }
        public string concilio { get; set; }
        public tipo_transacciones tipo_transaccionesBase { get; private set; }
        public Cuenta CuentaBase { get; private set; }

        public Movimiento(tipo_transacciones tipo_transacciones, Cuenta Cuenta)
        {
            tipo_transaccionesBase = tipo_transacciones;
            CuentaBase = Cuenta;
        }
        
        public Movimiento(string Tipo, int numero,int seq ,string cuenta, string centro, string nit, string fec , double valor , string documento, string explicacion)
        {
            tipo = Tipo;
            numero = numero;
            seq =seq;
            cuenta =cuenta;
            centro = centro;
            nit =nit;
            fec =fec;
            valor = valor;
            documento = documento;
            explicacion = explicacion;
            concilio = concilio;
        }
    }
}
