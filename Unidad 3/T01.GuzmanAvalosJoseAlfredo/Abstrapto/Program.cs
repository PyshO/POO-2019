using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrapto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos la clase principal con su metodo menu
            Principal p = new Principal();
            p.Menu();
            Console.ReadKey();
        }
    }
}
