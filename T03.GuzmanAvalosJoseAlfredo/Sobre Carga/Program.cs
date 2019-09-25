using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_Carga
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se intancia la clase operacion
            Operacion OP = new Operacion();
            OP.Multiplicar();

            //Se llaman las variables y se realiza la operacion
            var Rest= OP.Multiplicar(2, 3);
            var Rest1 = OP.Multiplicar(5);
            var Rest2 = OP.Multiplicar();

            //Se manda a imprimir el resultado
            Console.WriteLine("El resultado 1 es: " + Rest);
            Console.WriteLine("El resultado 2 es: " + Rest1);
            Console.WriteLine("El resultado 3 es: " + Rest2);

            Console.ReadKey();

            //Se instancia la clase de datos
            Datos D = new Datos();
            D.Obtener_Datos();

        }
    }
}
