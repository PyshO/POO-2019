using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03.examen
{
    class Principal
    {
        //Arrelo para crear cada metodo
        Tarea[] Lista = new Tarea[2];

        //Metodo para crear tareas
        public void CrearTarea()
        {
            //Aqui realizamos el ciclo for para crear las tareas
            //Se pide ingresar cada dato y asi guardarlo
            //en este caso es un arreglo de 2 ya que solo guardara 2 tareas
            for (int i = 0; i < Lista.Length; i++)
            {
                Tarea Ta = new Tarea();
                Console.WriteLine("Nombre:");
                Ta.Nombre = Console.ReadLine();
                Console.WriteLine("Tarea:");
                Ta.Nom_Tarea = Console.ReadLine();
                Console.WriteLine("Fecha:");
                Ta.Fecha = Console.ReadLine();
                Console.WriteLine("Hora:");
                Ta.Hora = Console.ReadLine();
                Console.WriteLine("elige un status:");
                Console.WriteLine("1.- Sin iniciar");
                Console.WriteLine("2.- En proceso");
                Console.WriteLine("3.- Terminado");
                string m = Console.ReadLine();
                switch(m)
                {
                    case "1":
                        Ta.Status = "Sin iniciar";
                        break;
                    case "2":
                        Ta.Status = "En proceso";
                        break;
                    case "3":
                        Ta.Status = "Terminado";
                        break;
                }

                Lista[i] = Ta;

                Console.Clear();
            }
            Menu();
        }

        //Metodo para mostrar solamente las tareas
        public void Mostrar_Tareas(Tarea[] Ta)
        {
            //Aqui se imprimen solo el nombre de las tareas que existen
            Console.WriteLine("Tareas:");
            for (int i = 0; i < Ta.Length; i++)
            {
                Console.WriteLine("Nombre de la tarea:" + Ta[i].Nom_Tarea);
            }
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        //Metodo para mostrar solo 1 tarea con todos sus datos
        public void Detail_Tarea(Tarea[] Tx)
        {
            //Se pide ingresar el nombre del usuario para asi llamar su tarea
            string nombre;
            Console.WriteLine("Ingrese el nombre del usuario:");
            nombre = Console.ReadLine();

            //Se realiza el ciclo for para mandar a imprimir los datos
            for (int i = 0; i < Tx.Length; i++)
            {
                //Ciclo if para comparar el nombre escrito con el nombre ya registrado
                //Si es asi imprimira todos los datos
                if (Tx[i].Nombre == nombre)
                {
                    Console.WriteLine("El Nombre es:" + Tx[i].Nombre);
                    Console.WriteLine("La Tarea a realizar es:" + Tx[i].Nom_Tarea);
                    Console.WriteLine("en la Fecha de:" + Tx[i].Fecha);
                    Console.WriteLine("a la Hora de:" + Tx[i].Hora);
                    Console.WriteLine("su Status es:" + Tx[i].Status);
                }
            }
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        //Metodo para mostrar solamente el estatus acompañado con la tarea
        public void Mostrar_Status(Tarea[] Ta)
        {
            //ciclo for para mandar a imprimir los datos
            Console.WriteLine("Status:");
            for (int i = 0; i < Ta.Length; i++)
            {
                Console.WriteLine("Nombre de la tarea:" + Ta[i].Nom_Tarea);
                Console.WriteLine("Estatus:" + Ta[i].Status);
            }
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        //Metodo para cambiar el status de una tarea
        public void Cambiar_Status(Tarea[] Ta)
        {
            //Aqui mandamos a pedir que escriba el nombre de la tarea
            string tarea;
            Console.WriteLine("Ingrese el nombre de la tarea:");
            tarea = Console.ReadLine();

            //Ciclo for que imprimira los datos
            for (int i = 0; i < Ta.Length; i++)
            {
                //Una vez escrito el nombre de la tarea se llama el ciclo if para comparar nombre de la tarea
                if (Ta[i].Nom_Tarea == tarea)
                {
                    Console.WriteLine("Nombre:" + Ta[i].Nombre);
                    Console.WriteLine("Tarea:" + Ta[i].Nom_Tarea);
                    Console.WriteLine("Status:" + Ta[i].Status);
                    //Aqui cambiamos el status y asi guardandolo en el registro de la tarea seleccionada
                    Console.WriteLine("Cambiar el Status:");
                    Console.WriteLine("elige un status:");
                    Console.WriteLine("1.- Sin iniciar");
                    Console.WriteLine("2.- En proceso");
                    Console.WriteLine("3.- Terminado");
                    string m = Console.ReadLine();
                    switch (m)
                    {
                        case "1":
                            Ta[i].Status = "Sin iniciar";
                            break;
                        case "2":
                            Ta[i].Status = "En proceso";
                            break;
                        case "3":
                            Ta[i].Status = "Terminado";
                            break;

                    }
                    Console.WriteLine("El nuevo Status es:" + Ta[i].Status);
                }
            }
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        //Clase Menu donde se da bienvenida al programa
        //Aqui es donde se crea el switch para elegir una opcion

        public void Menu()
        {
            Console.WriteLine("OAA");
            Console.WriteLine("Bienvenido a tus tareas");
            Console.WriteLine("Eliga una opcion");
            Console.WriteLine("opc1.- Crear Tareas");
            Console.WriteLine("opc2.- Ver Lista de Tareas");
            Console.WriteLine("opc3.- Detalles de la Tarea");
            Console.WriteLine("opc4.- Lista Estatus");
            Console.WriteLine("opc5.- Cambiar status");
            Console.WriteLine("opc0.- Salir");

            //aqui creamos m para que esta variable sea el numero de la opcion a elegir
            String m = Console.ReadLine();

            switch (m)
            {
                case "1":
                    CrearTarea();
                    break;

                case "2":
                    Mostrar_Tareas(Lista);
                    break;

                case "3":
                    Detail_Tarea(Lista);
                    break;

                case "4":
                    Mostrar_Status(Lista);
                    break;

                case "5":
                    Cambiar_Status(Lista);
                    break;

                default:
                    break;

            }
        }

    }
}


