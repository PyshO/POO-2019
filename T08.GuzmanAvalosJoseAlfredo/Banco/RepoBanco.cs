using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class RepoBanco
    {
        
        //Se crea el constructor de los datos cuenta
        Datos_Cuenta dc;

        //Metodo para llamar los Datos cuenta
        public RepoBanco()
        {
            dc = new Datos_Cuenta(); 
        }

        //Metodo para llamar o mostrar el menu al programa
        internal void Principal()
        {
            Console.WriteLine("OAAA");
            Console.WriteLine("BIENVENIDO AL BANCOPPEL");
            Menu();
            Console.ReadLine();
        }

        //Metodo para crear el menu
        private void Menu()
        {
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("Opc1.-Cuenta ahorro");
            Console.WriteLine("Opc2.-Pensiones");
            Console.WriteLine("Opc3.-Cuenta Corriente");

            //Aqui se crea el switch para elegir las posibles 3 opciones
            string n = Console.ReadLine();
            switch (n)
            {
                case "1":
                    Console.WriteLine("Bienvenido a la Cuenta ahorro");
                    Obtener_Datos_Ahorro();
                    break;

                case "2":
                    Console.WriteLine("Bienvenido a Pensiones");
                    Obtener_Datos_Pension();
                    break;

                case "3":
                    Console.WriteLine("Bienvenido a la Cuenta Corriente");
                    Obtener_Datos_Corriente();
                    break;

                default:
                    break;
            }

        }

        //Metodo para ingresar a cuenta corriente con el numero de tarjeta y comparar asi este numero
        private void Obtener_Datos_Corriente()
        {
            int Num = ObtenerDatos();
            var listaaaa = dc.Corrientes();
            Cuenta_Corriente pe = new Cuenta_Corriente();

            foreach (var account in listaaaa)
            {
                if (Num == account.Numero)
                {
                    pe = account;
                }

            }

            Console.WriteLine("Bienvenido " + pe.Titular);

            MenuUs(pe);
        }

        //Metodo para pedir ingresar el numero de cuenta
        private int ObtenerDatos()
        {
            Console.WriteLine("Ingrese su numero de cuenta");
            string cue = Console.ReadLine();
            return Convert.ToInt32(cue);
        }

        //Metodo para ingresar a la opcion de Pensiones comparando el numero de tarjeta ingresado con el numero de tarjetas que existen
        private void Obtener_Datos_Pension()
        {
            int Num = ObtenerDatos();
            var listaa = dc.Pensiones();
            Pensiones pe = new Pensiones();

            foreach (var account in listaa)
                {
                if (Num == account.Numero)
                {
                    pe = account;
                }
            }

            Console.WriteLine("Bienvenido " + pe.Titular);

            MenuUs(pe);

        }
        //Metodo para ingresar a la opcion de Cuenta Ahorro comparando el numero de tarjeta ingresado con el numero de tarjetas que existen
        private void Obtener_Datos_Ahorro()
        {
            int Num = ObtenerDatos();
            var listaaa = dc.Ahorros();
            Cuenta_Ahorro pe = new Cuenta_Ahorro();

            foreach (var account in listaaa)
            {
                if (Num == account.Numero)
                {
                    pe = account;
                }
            }

            Console.WriteLine("Bienvenido " + pe.Titular);

            MenuUs(pe);
        }

        //Metodo para crear el menu al ingresar a las opciones elegidas
        private void MenuUs(Cuenta pe)
        {
            
            Console.Clear();
            Console.WriteLine("Bienvenido " + pe.Titular);
            Console.WriteLine("Eliga una opcion");
            Console.WriteLine("opc1.- Consultar saldo");
            Console.WriteLine("opc2.- Transferir Saldo");
            Console.WriteLine("opc3.- Interes por mes");
            Console.WriteLine("opc4.- Ingresar Saldo");
            double x = pe.Saldo;

            //Aqui se crea el switch para dar a elegir y llamar los metodos de la clase Cuenta
            String m = Console.ReadLine();

            switch (m)
            {
                case "1":
                    pe.Consultar(pe);
                    break;

                case "2":

                    pe.Transferir(pe);
                    break;

                case "3":
                    double xt = pe.InteresMes(x);
                    break;

                case "4":
                    break;

                default:
                    break;
                    
            }
        }
    }
}
