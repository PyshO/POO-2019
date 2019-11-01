using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //Clase Interface
    interface ITransporte
    {
        //Creamos los 3 atributos
        string Marca { get; set; }
        string Tipo { get; set; }
        string Modelo { get; set; }

        //Aqui hacemos los metodos
        void Bienvenido();
        double calcular();
        void Acelerar();
        void Girar();
        void Frenar();


    }
}
