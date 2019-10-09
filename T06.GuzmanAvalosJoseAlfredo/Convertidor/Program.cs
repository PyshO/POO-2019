using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se instancia la clase de Repo
            RepoConvertidor La = new RepoConvertidor();
            La.Obtener_Unidades();
        }
    }
}
