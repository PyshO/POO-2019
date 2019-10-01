using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricos_Sobre_Carga
{
    class Lados
    {
        public void Obtener_Lados()
        {
            //Se instancia la clase Operacion con sus metodos de multiplicar
            Operacion OP = new Operacion();
            OP.Area();

            //Aqui se da bienvenida al programa
            Console.WriteLine("OAAAA");
            //Calcular Area de Triangulo
            Console.WriteLine("Calcular area de un triangulo");
            Console.WriteLine("Ingrese 2 lados ");
            //Se pide ingresar los datos
            Console.WriteLine("lado A: ");
            double cool = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("lado B: ");
            double cool2 = Convert.ToDouble(Console.ReadLine());
            double cool3 = 2;
            //Se realiza la operacion
            double Res = OP.Area(cool, cool2, cool3);
            //Se imprime el resultado
            Console.WriteLine("El area del triangulo es: " + Res);
            Console.ReadKey();


            //Calcular Area de un Cuadrado
            Console.WriteLine("Calcular area de un cuadrado");
            Console.WriteLine("Ingrese 1 lado ");
            //Se pide ingresar los datos
            Console.WriteLine("lado A: ");
            double cua = Convert.ToDouble(Console.ReadLine());
            //Se realiza la operacion
            double Area = OP.Area(cua);
            //Se imprime el resultado
            Console.WriteLine("El area del cuadrado es: " + Area);
            Console.ReadKey();


            //Calcular Area de un Rectangulo
            Console.WriteLine("Calcular area de un Rectangulo");
            Console.WriteLine("Ingrese 2 lados ");

            //Se pide ingresar los datos
            Console.WriteLine("lado A: ");
            double rec1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("lado B: ");
            double rec2 = Convert.ToDouble(Console.ReadLine());

            //Se realiza la operacion
            double AreaR = OP.Area(rec1, rec2);

            //Se imprime el resultado
            Console.WriteLine("El area del Rectangulo es: " + AreaR);
            Console.ReadKey();
        }
    
    }
}
