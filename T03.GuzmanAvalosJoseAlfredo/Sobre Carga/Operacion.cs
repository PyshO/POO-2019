using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_Carga
{
    class Operacion
    {
        //Aqui se crean los 3 metodos
        public double Multiplicar(double a, double b)
        {
            double c = a * b;
            return c;
        }

        public double Multiplicar(double a)
        {
            return a;
        }

        public double Multiplicar()
        {
            return 0;
        }
    }
}
