using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrapto
{
   public class Cuadrado:Figura
    {
        //Mandamos llamar los metodos de la clase abstracta
        
        public override double Base_1 { get; set; }
        public override double Altura { get; set; }

        //Creamos metodo del area
        public double AreaCuadrado(double b)
        {
            double res = b * b;
            return res;
        }
    }
}
