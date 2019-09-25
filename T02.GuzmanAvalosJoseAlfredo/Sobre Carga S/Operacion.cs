using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_Carga_S
{
    class Operacion
    {
        //Aqui se crean los 3 metodos
        public double Sumar(double a, double b)
        {
            double c = a + b;
            return c;
        }

        public double Sumar(double a)
        {
            return a;
        }

        public double Sumar()
        {
            return 0;
        }
    }
}
