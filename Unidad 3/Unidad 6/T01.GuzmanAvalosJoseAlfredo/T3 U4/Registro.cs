using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_U4
{
    public class Registro
    {
        //Metodo para registrar a un usuario
        public void RegistrarUsuario(Usuario U, string Path)
        {
            //creamos nueva variable para guardar todos los dtatos y asi ponerlos en el nuevo archivo txt
            string Data = (U.Nombre + "," + U.User + "," + U.Password);

            var datos = ObtenerLineas(Path);

            if(datos !=null)
            {
                datos.Add(Data);
                File.WriteAllLines(Path, datos);
            }
            else
            {
                File.WriteAllText(Path, Data);
            }  
        }

        //Creamos el metodo Obtener Lineas para ir creando la lista de usuarios
        public List<string> ObtenerLineas(string ruta)
        {
            //Creamos una variable con un arreglo infinito y asi guardarlo en el archivo ya creado
            string[] Datos = null;

            if (File.Exists(ruta))
            {
                Datos = File.ReadAllLines(ruta);
            }
            else
            {
                Console.WriteLine("El archivo no existe");
                return null;
            }

            //Aqui creamos una lista con todos los datos y los mandamos a mostrar
            List<string> datos = new List<string>();

            foreach(var item in Datos)
            {
                datos.Add(item);
            }
            return datos;
        } 
    }
}
