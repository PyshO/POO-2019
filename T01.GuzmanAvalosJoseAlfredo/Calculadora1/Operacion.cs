using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1
{
    class Operacion
    {
        //Aqui se crean los metodos para cada operacion
        public double Sumar(Valores suma)
        {
            double sum = suma.Lado_a + suma.Lado_b;
            Console.WriteLine("El resultado es" + sum);
            Console.ReadKey();
            return sum;
        }

        public double Resta(Valores resta)
        {
            double res = resta.Lado_a - resta.Lado_b;
            Console.WriteLine("El resultado es" + res);
            Console.ReadKey();
            return res;
        }

        public double Multi(Valores multi)
        {
            double mul = multi.Lado_a * multi.Lado_b;
            Console.WriteLine("El resultado es" + mul);
            Console.ReadKey();
            return mul;
        }

        public double Div(Valores div)
        {
            double divi = (div.Lado_a) / (div.Lado_b);
            Console.WriteLine("El resultado es" + divi);
            Console.ReadKey();
            return divi;
        }
    }
}
