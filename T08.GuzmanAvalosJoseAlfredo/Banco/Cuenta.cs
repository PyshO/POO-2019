using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class Cuenta
    {
        //Aqui se declaras y encapsulan las variables de la clase madre
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double Interes { get; set; }


        //Metodo para ingresar saldo
        public bool Ingreso()
        {
            return false;
        }

        //Metodo para ver Intereses por mes
        public double InteresMes(double interes)
        {
            var InMes = Interes * (0.16);
            Console.WriteLine("Su interes por mes es de $" + InMes);
            return InMes;
        }

        //Metodo para consultar el saldo
        public void Consultar(Cuenta cuenta)
        {
            Console.WriteLine("Su Saldo Actual es de $" + Saldo);
        }

        //Metodo para mandar la transferencia de saldo
        public void Transferir(Cuenta cuenta)
        {
            Console.WriteLine("Su saldo es de $" + Saldo);
            Console.WriteLine("___________________________");
            Console.WriteLine("Ingrese la cantidad a transferir");
            double Trans = Convert.ToDouble(Console.ReadLine());
            double Total = Saldo - Trans;
            Console.WriteLine("Usted a transferido $" + Trans);
            Console.WriteLine("El saldo total de tu cuenta es de $" + Total);
        }
    }
}
