using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrapto
{
    public abstract class Figura
    {
        //Creamos los metodos para pedir datos
        public abstract double Base_1 { get; set; }
        public abstract double Altura { get; set; }
    }
}
