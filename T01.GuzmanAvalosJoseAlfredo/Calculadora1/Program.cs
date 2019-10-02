using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui se instancia la clase principal con su metodo Menu
            Principal Pi = new Principal();
            Pi.Bienvenido();
            Console.ReadKey();
        }
    }
}
