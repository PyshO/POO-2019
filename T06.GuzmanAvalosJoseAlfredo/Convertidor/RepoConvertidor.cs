using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor
{
    class RepoConvertidor
    {
        public void Obtener_Unidades()
        {
            //Se instancia la clase Principal con sus metodos
            Principal Pr = new Principal();
            Pr.convertidor();

            //Aqui se da bienvenida al programa
            Console.WriteLine("OAAAA");
            Console.WriteLine("Bienvenido a mi convertidor");
            //Calcular la conversion a metros
            Console.WriteLine("Convertir centimetros a metros");
            //Se pide ingresar los datos
            Console.WriteLine("centimetros: ");
            double cool = Convert.ToDouble(Console.ReadLine());
            double cool2 = 100;
            double cool3 = 0;
            //Se realiza la operacion
            double Res = Pr.convertidor(cool, cool2, cool3);
            //Se imprime el resultado
            Console.WriteLine("El total a metros es:" + Res+"m");
            Console.ReadKey();

            //Calcular la conversion a pulgadas
            Console.WriteLine("Convertir metros a pulgadas");
            //Se pide ingresar los datos
            Console.WriteLine("metros: ");
            double mts = Convert.ToDouble(Console.ReadLine());
            double plgs = 39.3701;
            //Se realiza la operacion
            double plgds = Pr.convertidor(mts, plgs);
            //Se imprime el resultado
            Console.WriteLine("El total a Pulgadas es:" + plgds + "plgs");
            Console.ReadKey();

            //Calcular la conversion a mililitros
            Console.WriteLine("Convertir litros a mililitros");
            //Se pide ingresar los datos
            Console.WriteLine("Litros: ");
            double Lit = Convert.ToDouble(Console.ReadLine());
            //Se realiza la operacion
            double Milt = Pr.convertidor(Lit);
            //Se imprime el resultado
            Console.WriteLine("El total a mililitros es:" + Milt + "ml");
            Console.ReadKey();
            Obtener_Unidades();
        }
    }
}
