using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_Carga
{
    class Datos
    {
        //Aqui se agregan 1 metodo
        public void Obtener_Datos()
        {
            //Se instancia la clase Operacion con sus metodos de multiplicar
            Operacion OP = new Operacion();
            OP.Multiplicar();

            //Aqui se da bienvenida al programa
            Console.WriteLine("OAAAA");
            Console.WriteLine("Ingrese 2 datos ");

            //Se pide ingresar los datos
            Console.WriteLine("Dato 1");
            double cool = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dato 2");
            double cool2 = Convert.ToDouble(Console.ReadLine());

            //Se realiza la operacion
            double Res = OP.Multiplicar(cool, cool2);

            //Se imprime el resultado
            Console.WriteLine("El resultado es: " + Res);
            Console.ReadKey();
        }
    }
}
