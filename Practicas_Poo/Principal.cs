using System;

namespace Practicas_Poo
{
    public class Principal
    {
        //Instanciamos la clase Banco con su constructor de saldo
        Banco ba = new Banco(500000);

        //Creamos el metodo de Menu donde iniciara el programa
        public void Menu()
        {
            //Damos bienvenida al programa a su vez que mostrando el menu
            Console.WriteLine("Bienvenido a su Banco Lombia");
            Console.WriteLine("Bienvenido a su Banco Lombia");
            Console.WriteLine("Opc 1.- Consultar saldo");
            Console.WriteLine("Opc 2.- Retirar Saldo");
            Console.WriteLine("Opc 3.- Depositar saldo");
            Console.WriteLine("Opc 4.- Salir");

            //Creamos la variable donde el usario ingresara un numero para el switch
            int n = Convert.ToInt32(Console.ReadLine());

            //Creamos un switch donde el usuario va elegir una de las 4 opciones
            switch (n)
            {
                case 1:
                    ConsultarSaldo();
                break;

                case 2:
                    RetirarSaldo();
                break;

                case 3:
                    DepositarSaldo();
                break;

                case 4:
                    Environment.Exit(4);
                break;
            }
        }

        //Creamos el metodo para consultar saldo
        public void ConsultarSaldo()
        {
            //Mostramos el primer metodo de operar de la clase banco
            Console.WriteLine(ba.Operar());
            Console.WriteLine("_______________________");
            Menu();
            Console.ReadKey();
        }

        //Creamos el metodo para retirar saldo
        public void RetirarSaldo()
        {
            //Pedimos la cantidad a retirar de la cuenta
            Console.WriteLine("Ingrese la cantidad a retirar");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            //Mostramos el segundo metodo de la clase banco
            Console.WriteLine(ba.Operar(cantidad));
            Console.WriteLine("_______________________");
            Menu();
            Console.ReadKey();
        }

        //Creamos el metodo para Depositar saldo
        public void DepositarSaldo()
        {
            //Pedimos ingresar la cuenta a donde sera transferida la cantidad
            Console.WriteLine("Ingrese el numero de cuenta");
            string NoCuenta = Console.ReadLine();
            //Pedimos ingresar la cantidad a transferir a la cuenta ya escrita
            Console.WriteLine("Ingrese la cantidad a transferir");
            int trans = Convert.ToInt32(Console.ReadLine());

            //Mostramos el tercer metodo de la clase banco
            Console.WriteLine(ba.Operar(trans, NoCuenta));
            Console.WriteLine("_______________________");
            Menu();
            Console.ReadKey();
        }
        
    }
}