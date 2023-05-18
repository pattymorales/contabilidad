using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad
{
    public interface IMovimientoRequest
    {
        void CuentaComplete(Cuenta model);
        void Movimiento_Complete(tipo_transacciones model);
    }
}
