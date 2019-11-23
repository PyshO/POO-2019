using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos una lista de estudiantes
            var estudiante = new List<Estudiante>();
            var agregar = true;

            while (agregar)
            {
                //Creamos el try para capturar los errores al no escribir ningun dato
                try
                {
                    //instanciamos la clase de estudiante
                    var E = new Estudiante();

                    int S = E.NoControl;
                    bool result;

                    //pedimos al usuario ingresar los datos
                    Console.WriteLine("Ingrese su nombre:");
                    E.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese su semestre:");
                    E.Semestre = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa tu Carrera::");
                    E.Carrera = Console.ReadLine();
                    Console.WriteLine("Ingresa tu telefono:");
                    E.Telefono = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa tu Numero de Control:");

                    //usamos el int.Tryparse por si el usuario escribe algo que no sea numero, en vez de un numero lo convierte a entero y devuelve un 0
                    //El out sirve para regresar solo un valor
                    result = int.TryParse(Console.ReadLine(), out S);

                    //hacemos una condicion donde si result guarda un numero sera verdadero si no
                    if (result == false)
                    {
                        Console.WriteLine("solo se permiten numeros, intente de nuevo:");
                        result = int.TryParse(Console.ReadLine(), out S);
                    }

                    estudiante.Add(E);

                    Console.WriteLine("¿Desea agregar otro usuario?");
                    Console.WriteLine("opc 1-.Si");
                    Console.WriteLine("opc 2-.No");
                    //hacemos la condicion por si el usuario dice que si seguir con el programa, de lo contrario se cierra
                    if (Console.ReadLine() != "si")
                    {
                        agregar = false;
                    }
                }

                //el catch captura errores si no se escrive un valor o diferente al pedido
                catch (Exception)
                {
                    Console.WriteLine("Fallo al agregar usuario, vuelvalo a intentar");
                    Console.ReadKey();
                }
            }
        }
    }
}
