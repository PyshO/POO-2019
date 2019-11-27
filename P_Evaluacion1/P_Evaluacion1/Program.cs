using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Evaluacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos la clase de operacion
            Operacion Op = new Operacion();
            Menu();

            //Creamos el metodo de menu para iniciar el programa
            void Menu()
            {
                //Pedimos al usuario ingresar la id y asi llamar al metodo de buscar persona
                Console.WriteLine("Bienvenido a mi programa");
                Console.WriteLine("Escribe la Id de la persona a buscar");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                Op.BuscarPersona(n);
            }
        }
    }
}
