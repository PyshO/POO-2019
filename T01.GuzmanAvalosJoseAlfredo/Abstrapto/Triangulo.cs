using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrapto
{
    public class Triangulo:Figura
    {
        //Mandamos llamar los metodos de la clase abstracta
        public override double Base_1 { get; set; }
        public override double Altura { get; set; }

        //Creamos el metodo para calcular area del tiangulo
        public double AreaTriangulo(double a, double b)
        {
            double res = (a * b) / 2;
            return res;
        }
    }
}
