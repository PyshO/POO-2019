using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1
{
    class Principal
    {
        //Aqui creamos los metodos
        public void Bienvenido()
        {
            Console.WriteLine("OAAA");
            Menu();
        }

        public void Salir()
        {
            Environment.Exit(0);
        }

        public void Menu()
        {
            //Se manda a imprimir el menu
            Console.WriteLine("Bienvenido al menu");
            Console.WriteLine("1 SUMAR");
            Console.WriteLine("2 RESTAR");
            Console.WriteLine("3 MULTIPLICAR");
            Console.WriteLine("4 DIVIDIR");
            Console.WriteLine("5 SALIR");
            Console.WriteLine("Desea realizar una operacion?");
            string n = Console.ReadLine();
            Console.WriteLine("Que operacion deseas realizar");
            int x = Convert.ToInt32(Console.ReadLine());

            Operacion Po = new Operacion();
            //Aqui se hace la condicion
            if (n == "si")
            {
                //Aqui se crea un switch para realizar las operaciones dependiento la opcion elegida
                switch (x)
                {

                    case 1:
                        Valores Res_S = new Valores();
                        Console.WriteLine("Agregar valor A");
                        Res_S.Lado_a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Agregar valor B");
                        Res_S.Lado_b = Convert.ToDouble(Console.ReadLine());
                        double P;
                        P= Po.Sumar(Res_S);
                        Console.Clear();
                        break;

                    case 2:
                        Valores Res_R = new Valores();
                        Console.WriteLine("Agregar valor A");
                        Res_R.Lado_a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Agregar valor B");
                        Res_R.Lado_b = Convert.ToDouble(Console.ReadLine());

                        P=Po.Resta(Res_R);
                        Console.Clear();
                        break;

                    case 3:
                        Valores Res_M = new Valores();
                        Console.WriteLine("Agregar valor A");
                        Res_M.Lado_a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Agregar valor B");
                        Res_M.Lado_b = Convert.ToDouble(Console.ReadLine());

                        P=Po.Multi(Res_M);
                        Console.Clear();
                        break;

                    case 4:
                        Valores Res_D = new Valores();
                        Console.WriteLine("Agregar valor A");
                        Res_D.Lado_a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Agregar valor B");
                        Res_D.Lado_b = Convert.ToDouble(Console.ReadLine());

                        P=Po.Div(Res_D);
                        Console.Clear();
                        break;

                    case 5:
                        Salir();
                        break;
                }
                
            }
            Menu();

        }
    }
}
