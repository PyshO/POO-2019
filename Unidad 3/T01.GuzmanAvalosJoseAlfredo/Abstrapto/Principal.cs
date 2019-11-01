using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrapto
{
    public class Principal
    {
        //Metodo de menu
        public void Menu()
        {
            //Se pide seleccionar una opcion
            Console.WriteLine("Bienvenido a Calcura bases");
            Console.WriteLine("1.-Area de un Cuadrado");
            Console.WriteLine("2.-Area de un Triangulo");
            Console.WriteLine("Eliga una opcion");

            //Switch para hacer las opciones
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Ingrese el Lado Del Cuadrado");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Cuadrado c = new Cuadrado();
                    double res1 = c.AreaCuadrado(b);
                    Console.WriteLine("El area del Cuadrado de {0} es {1}", b, res1);
                    Console.WriteLine("Desea Regresar al menu");
                    //Aqui pedimos si desea volver al menu
                    string q = Console.ReadLine();
                    if (q == "si")
                    {
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Gracias");
                    }
                    break;
                case "2":
                    Console.WriteLine("Ingrese La base Del trinagulo");
                    double bb = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese La base Del trinagulo");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Triangulo t = new Triangulo();
                    double res2 = t.AreaTriangulo(bb, a);
                    Console.WriteLine("El area del Triangulo de base {0} y altura {1} es {2}", bb, a, res2);
                    Console.WriteLine("Desea Regresar al menu");
                    string qq = Console.ReadLine();
                    if (qq == "si")
                    {
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Gracias");
                    }
                    break;
                default:
                    Console.WriteLine("Opcion no Validad");
                    Console.WriteLine("Desea regresar al menu");
                    string w = Console.ReadLine();
                    if (w == "si")
                    {
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Gracias");
                    }
                    break;
            }
        }
        }
}
