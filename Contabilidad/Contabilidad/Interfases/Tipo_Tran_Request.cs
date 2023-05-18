using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad
{
    public interface ITipo_TranRequest
    {
        void Tipo_Tran_Complete(tipo_transacciones model);
    }
    
}
