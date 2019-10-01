using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos_Sobre_Carga
{
    class Operacion
    {
        public double Area(double a, double b, double c)
        {
            double d = (a * b)/2;
            return d;
        }

        public double Area(double a)
        {
            double e = a * a;
            return e;
        }

        public double Area(double a, double b)
        {
            double f = a * b;
            return f;
        }

        public double Area()
        {
            return 0;
        }
    }
}
