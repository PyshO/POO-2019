using System;

namespace Practicas_Poo
{
    public class Banco
    {

        //Creamos un constructor
        public Banco(int saldo)
        {
            Saldo = saldo;
        }

        //Creamos una variable llamada Saldo y la instanciamos
        public int Saldo {get; set;}

        //Este metodo nos permite consultar el saldo de la cuenta
        public string Operar()
        {
            return "Su saldo actual es: $" + Saldo;
        }

        //Este metodo nos permite hacer un retiro de saldo de la cuenta
        public string Operar(int Retiro)
        {
            Saldo = Saldo - Retiro;
            return "Se ha hecho un retiro de su cuenta con un valor de $" + Retiro;
        }

        //Este metodo nos permite hacer un deposito a otra cuenta
        public string Operar(int Deposito, string NoCuenta)
        {
            Saldo = Saldo - Deposito;
            return "Se ha transferido a la cuenta " + NoCuenta + "Una cantidad de $" + Deposito;
        }
    }
}