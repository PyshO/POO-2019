using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class Pensiones:Cuenta
    {
        //Declaracion de variables
        public DateTime Vencimiento { get; set; }
        public int Cotizacion { get; set; }
        public int No_Cuenta { get; set; }

    }
}
