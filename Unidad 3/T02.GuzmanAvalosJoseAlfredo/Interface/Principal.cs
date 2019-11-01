using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Principal
    {
        //Metodo para dar bienvenida la programa
        public void Bienvenido()
        {
            
            Console.WriteLine("Bienvenido a mi programa de interfaces");
            Console.WriteLine("Programa que especifica un transporte(Vehiculo)");
            Console.WriteLine("Programa que calcula el tiempo de una distancia en kilometros");
            Console.ReadKey();
            Menu();
            
        }

        //Metodo para listar los datalles del automovil
        public void Lista()
        {
            
            Automovil A = new Automovil();
            A.Bienvenido();
            A.Detail();
            A.Acelerar();
            A.Aterrizar();
            A.Despegar();
            A.Frenar();
            A.Girar();
            Menu();
        }

        //Metodo para listar los detalles del avion
        public void Lista_Avion()
        {
            Avion V = new Avion();
            V.Bienvenido();
            V.Detail();
            V.Acelerar();
            V.Aterrizar();
            V.Despegar();
            V.Frenar();
            V.Girar();
        }

        //Metodo para pedir al usuario elegir una opcion
        public void Menu()
        {
            //Instanciamos las clases automovil y avion
            Automovil A = new Automovil();
            Avion V = new Avion();
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("opc1.-Detalles de un Automovil");
            Console.WriteLine("opc2.-Calcular tiempo de un Automovil");
            Console.WriteLine("opc3.-Detalles de un Avion");
            Console.WriteLine("opc4.-Calcular tiempo de un Avion"); 

            //Aqui hacemos el case para realizar las operaciones
            string n = Convert.ToString(Console.ReadLine());

            switch (n)
            {
                case "1":
                    Lista();
                    break;

                case "2":
                    A.calcular();
                    break;

                case "3":
                    Lista_Avion();
                    break;

                case "4":
                    V.calcular();
                    break;
            }
            Menu();
        }
    }
}
