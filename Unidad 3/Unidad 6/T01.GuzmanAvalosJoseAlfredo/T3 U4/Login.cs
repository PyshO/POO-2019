using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_U4
{
    public class Login
    {
        //Instanciamos la clase usuario y registro y la lista de usarios
        List<Usuario> Usuarios = new List<Usuario>();
        Registro Re = new Registro();
        Usuario U = new Usuario();

        //Metodo para pedir ingresar datos al iniciar sesion
        public void IngresarDatos()
        {
            //creamos la ruta y pedimos ingresar los datos
            string ruta= @"C:\Users\hp\Documents\Datos.txt";
            Console.WriteLine("Escriba usuario");
            U.User = Console.ReadLine();
            Console.WriteLine("Escriba la contraseña");
            U.Password = Console.ReadLine() ;

            //hacemos la implementacion de la Lista Usuarios
            Usuarios.Add(U);
            List<string> datos = Re.ObtenerLineas(ruta);
            ValidarDatos(ruta , datos);
        }

        //creamos el metodo de validar datos para hacer la comparacion de los datos ingresados y asi poder iniciar sesion
        public void ValidarDatos(string ruta, List<string> datos)
        {
            
            foreach (var item in datos)
            {
                string[] info = item.Split(',');
                Usuarios.Add(new Usuario { Nombre = info[0] });
            }

            foreach(var Us in Usuarios)
            {
                if (U.User == Us.User && U.Password == Us.Password)
                {
                    Bienvenido();
                }
            }
        }

        //Metodo para dar bienvenida al iniciar sesion
        public void Bienvenido()
        {
            Console.WriteLine("Has iniciado sesion exitosamente ");
            Console.ReadKey();
        }
    }
}
