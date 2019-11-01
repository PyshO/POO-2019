using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //HERENCIA DE LAS INTERFACES ITRANSPORTE Y ITRANSPORTEVOLADOR
    public class Avion : ITransporte, ITransporteVolador
    {
        //MANDAMOS A LLAMAR TODO LO QUE CONTIENE LAS INTERFACES EN ESTE CASO ATRIBUTOS Y METODOS
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public string Modelo { get; set; }

        //Metodo para dar bienvenido al avion
        public void Bienvenido()
        {
            Console.WriteLine("Bienvenido al Avion");
        }

        //Metodos para mostrar los detalles del avion
        public void Detail()
        {
            Marca = "Boeing";
            Modelo = "777";
            Tipo = "Comercial";
            Console.WriteLine("Los detalles del avion son");
            Console.WriteLine("La marca es: " + Marca);
            Console.WriteLine("El modelo es: " + Modelo);
            Console.WriteLine("El tipo es: " + Tipo);

        }
        public void Acelerar()
        {
            Console.WriteLine("El avion acelera");

        }

        public void Aterrizar()
        {
            Console.WriteLine("El avion puede aterrizar");
        }


        public void Despegar()
        {
            Console.WriteLine("El avion puede Despegar");
        }

        public void Frenar()
        {
            Console.WriteLine("El avion puede frenar");
        }

        public void Girar()
        {
            Console.WriteLine("El avion si puede girar");
            Console.ReadKey();
        }

        //mETODO PARA CALCULAR EL TIEMPO EN RECORRER UNA DISTANCIA
        public double calcular()
        {
            Principal P = new Principal();
            Console.WriteLine("Escriba la distancia que desea recorrer en km");
            double Distancia = Convert.ToDouble(Console.ReadLine());
            double Total = 0;
            double TotalH = 0;
            Total = (Distancia * 60) / 800;
            TotalH = Total / 60;
            Console.WriteLine("El tiempo en recorrrer " + Distancia + "km es de " + Total + "minutos");
            Console.WriteLine("El tiempo en recorrrer en horas es de " + TotalH + "hr");
            Console.ReadKey();
            P.Menu();
            return Distancia;
        }
    }
}
