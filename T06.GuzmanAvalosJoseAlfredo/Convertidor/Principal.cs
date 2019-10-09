using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor
{
    class Principal
    {
        //Aqui se hacen los 3 metodos con sus sobreccargas

            //Aqui el metodo para convertir cm a m
        public double convertidor(double a, double b, double c)
        {
            double d = a / b;
            return d;
        }

        //Metodo para convertir m a plgds
        public double convertidor(double a, double b=39.3701)
        {
            double f = a * b;
            return f;
        }

        //Metodo para convertir lt a ml
        public double convertidor(double a)
        {
            double e = a*1000;
            return e;
        }

        public double convertidor()
        {
            return 0;
        }
    }
}
