using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_Carga_S
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se intancia la clase operacion
            Operacion OP = new Operacion();
            OP.Sumar();

            //Se llaman las variables y se realiza la operacion
            var Rest = OP.Sumar(7, 5);
            var Rest1 = OP.Sumar(8);
            var Rest2 = OP.Sumar();

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
