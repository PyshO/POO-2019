using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //HERENCIA DE LAS INTERFACES ITRANSPORTE Y ITRANSPORTEVOLADOR
    public class Automovil : ITransporte,ITransporteVolador
    {
        //MANDAMOS A LLAMAR TODO LO QUE CONTIENE LAS INTERFACES EN ESTE CASO ATRIBUTOS Y METODOS
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public string Modelo { get; set; }

        //Metodo para dar bienvenida
        public void Bienvenido()
        {
            Console.WriteLine("Bienvenido al automovil");
        }

        //Metodos para mostrar detalles del automovil
        public void Detail()
        {
            Marca = "Nissan";
            Modelo = "GTR NISMO";
            Tipo = "Deportivo";
            Console.WriteLine("Los detalles del automovil son");
            Console.WriteLine("La marca es: " + Marca);
            Console.WriteLine("El modelo es: " + Modelo);
            Console.WriteLine("El tipo es: " + Tipo);
        }
        public void Acelerar()
        {
            Console.WriteLine("El carro acelera");
        }

        public void Aterrizar()
        {
            Console.WriteLine("El carro no puede aterrizar");
        }


        public void Despegar()
        {
            Console.WriteLine("El carro no puede Despegar");
        }

        public void Frenar()
        {
            Console.WriteLine("El carro puede frenar");
        }

        public void Girar()
        {
            Console.WriteLine("El carro si puede girar");
            Console.ReadKey();

        }

        //Metodo para calcular el tiempo en recorrer una distancia
        public double calcular()
        {
            Principal P = new Principal();
            Console.WriteLine("Escriba la distancia que desea recorrer en km");
            double Distancia = Convert.ToDouble(Console.ReadLine());
            double Total = 0;
            double TotalH = 0;
            Total = (Distancia * 60) / 200;
            TotalH = Total / 60;
            Console.WriteLine("El tiempo en recorrrer " + Distancia + "km es de " + Total + "minutos");
            Console.WriteLine("El tiempo en recorrrer en horas es de " + TotalH + "hr");
            Console.ReadKey();
            P.Menu();
            return Distancia;
        }
    }
}
