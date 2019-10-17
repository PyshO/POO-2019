using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class Cuenta_Ahorro:Cuenta
    {
        //Declaracion de las variables y su encapsulacion
        public DateTime Vencimiento { get; set; }

        //Metodo para ver el ingreso por mes
        public double IngresoXmes()
        {
            return 0;
        }
    }
}
