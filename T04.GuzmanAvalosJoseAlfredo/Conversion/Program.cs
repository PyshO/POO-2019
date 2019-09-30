using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int Total_Centavo;
            int Pesos = 0;
            int Centavos = 0;

            Solucion Co = new Solucion();
            

            Console.WriteLine("Bienvenido al programa");
            Console.WriteLine("Ingrese los centavos");
            Total_Centavo = Convert.ToInt32(Console.ReadLine());
            Co.Convertir(Total_Centavo, out Pesos, out Centavos);
            Console.WriteLine("El total en pesos es: " + Pesos);
            Console.WriteLine("El total en centavos es: " + Centavos);
            Console.ReadKey();

        }
    }
}
