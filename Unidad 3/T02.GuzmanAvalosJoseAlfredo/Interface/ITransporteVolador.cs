using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //SEGUNDA INTERFACE HEREDADA DE ITRANSPORTE 
    interface ITransporteVolador:ITransporte
    {
        void Despegar();
        void Aterrizar();
    }
}
