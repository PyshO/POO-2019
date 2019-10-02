using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1
{
    class Valores
    {
        //Declaramos variables
        private double lado_a;
        private double lado_b;
        private string operacion;
        private double resultado;

        //Encapsulacion
        public double Lado_a
        {
            get { return lado_a; }
            set { lado_a = value; }
        }

        public double Lado_b
        {
            get { return lado_b; }
            set { lado_b = value; }
        }

        public string Operacion
        {
            get { return operacion; }
            set { operacion = value; }
        }

        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }
    }
}
