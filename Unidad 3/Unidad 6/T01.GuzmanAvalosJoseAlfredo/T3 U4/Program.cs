using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_U4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos las 3 clases
            Usuario U = new Usuario();
            Registro Re = new Registro();
            Login Lo = new Login();

            //Iniciamos con el metodo del Menu
            Menu();

            //Metodo Menu para iniciar el programa
            void Menu()
            {

                Console.WriteLine("Bienvenido");
                Console.WriteLine("Opc1: Registrarse");
                Console.WriteLine("Opc2: Agregar Otro Usuario");
                Console.WriteLine("Opc3: Iniciar sesion");

                //Aqui creamos el switch pidiendo escribir un numero y asi llamar los metodos
                string n = Console.ReadLine();
                switch (n)
                {
                    case "1":
                        Registrese();
                        break;
                    case "2":
                        Agregar();
                        break;
                    case "3":
                        IniciarSesion();
                        break;
                }
            }

            //Metodo para Registrar un nuevo Usuario
            void Registrese()
            {
                //Pedimos ingresar todos los datos
                Console.WriteLine("Escriba su Nombre");
                U.Nombre = Console.ReadLine();
                Console.WriteLine("Escriba su Usuario");
                U.User = Console.ReadLine();
                Console.WriteLine("Escriba su Contraseña");
                U.Password = Console.ReadLine();

                //Creamos la ruta donde se guardara el archivo txt
                string Path = @"C:\Users\hp\Documents\Datos.txt";

                //Llamamos el metodo Registrar Usuario 
                Re.RegistrarUsuario(U, Path);
                Menu();
            }

            //Metodo para agregar otro Usuario
            void Agregar()
            {
                //Llamaos el metodo Registrese para pedir de nuevo los datos al igual creamos nueva ruta
                Registrese();
                string ruta = @"C:\Users\hp\Documents\Datos.txt"; 

                //Llamamos el metodo Obtener Lineas
                Re.ObtenerLineas(ruta);
                Menu();
            }

            //Metodo para Iniciar sesion
            void IniciarSesion()
            { 
                //Llamamos el metodo Ingresar Datos
                Lo.IngresarDatos();
                Menu();
            }

        }
    }
}
