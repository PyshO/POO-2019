using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui creamos el objeto Paciente
            Paciente Pa = new Paciente();
            Pa.Id = 322;
            Pa.Nombre = "JUAN";
            Pa.Tipo = "enfermo";
            Pa.Fecha = "10/enero/1979";
            Pa.Telefono = "654-456-6512";
            Pa.Email = "juanitoLocote@gmail.com";

            //Mandamos a imprimir el objeto
            Console.WriteLine("La id del Paciente es: " + Pa.Id);
            Console.WriteLine("El nombre del Paciente es: " + Pa.Nombre);
            Console.WriteLine("El Tipo del Paciente es: " + Pa.Tipo);
            Console.WriteLine("La fecha de nacimineto es: " + Pa.Fecha);
            Console.WriteLine("El Telefono/nac del Paciente es: " + Pa.Telefono);
            Console.WriteLine("El Email del Paciente es: " + Pa.Email);
            Console.ReadKey();

            //Aqui se crea el objeto Hombre
            Hombre hom = new Hombre();
            hom.Id = 3223;
            hom.Nombre = "Pedro";
            hom.Fecha = "14/enero/1934";
            hom.Telefono = "674-856-6612";
            hom.Email = "PedroLocote@gmail.com";

            //Mandamos a imprimir
            Console.WriteLine("____________________________________");
            Console.WriteLine("La id del Hombre es: " + hom.Id);
            Console.WriteLine("El nombre del Hombre es: " + hom.Nombre);
            Console.WriteLine("La fecha/nac del Hombre es: " + hom.Fecha);
            Console.WriteLine("El Telefono del Hombre es: " + hom.Telefono);
            Console.WriteLine("El Email del Hombre es: " + hom.Email);
            Console.ReadKey();

            //Creamos el objeto Mujer
            Mujer mu = new Mujer();
            mu.Id = 3223;
            mu.Nombre = "Ana";
            mu.Fecha = "14/enero/1934";
            mu.Telefono = "674-856-6612";
            mu.Email = "AnaLocota@gmail.com";

            //Imprimimos
            Console.WriteLine("____________________________________");
            Console.WriteLine("La id de la mujer es: " + mu.Id);
            Console.WriteLine("El nombre de la mujer es: " + mu.Nombre);
            Console.WriteLine("La fecha/nac de la mujer es: " + mu.Fecha);
            Console.WriteLine("El Telefono de la mujer es: " + mu.Telefono);
            Console.WriteLine("El Email de la mujer es: " + mu.Email);
            Console.ReadKey();

            //Creamos el objeto Medico
            Medico me = new Medico();
            me.Id = 322;
            me.Nombre = "Miguel";
            me.Tipo = "enfermo";
            me.Fecha = "10/enero/1979";
            me.Telefono = "654-456-6512";
            me.Email = "MiguelLocote@gmail.com";

            //Imprimimos
            Console.WriteLine("____________________________________");
            Console.WriteLine("La id del Medico es: " + me.Id);
            Console.WriteLine("El nombre del Medico es: " + me.Nombre);
            Console.WriteLine("El Tipo del Medico es: " + me.Tipo);
            Console.WriteLine("La fecha/nac de Medico es: " + me.Fecha);
            Console.WriteLine("El Telefono del Medico es: " + me.Telefono);
            Console.WriteLine("El Email del Medico es: " + me.Email);
            Console.ReadKey();

            //Creamos el objeto Cirujano
            Cirujano ci = new Cirujano();
            ci.Id = 322;
            ci.Nombre = "Julio";
            ci.Area = "Plastico";
            ci.Fecha = "10/enero/1979";
            ci.Telefono = "654-456-6512";
            ci.Email = "JulioLocote@gmail.com";

            //Imprimimos
            Console.WriteLine("____________________________________");
            Console.WriteLine("La id del cirujano es: " + ci.Id);
            Console.WriteLine("El nombre del cirujano es: " + ci.Nombre);
            Console.WriteLine("El area del cirujano es: " + ci.Area);
            Console.WriteLine("La fecha/nac de cirujano es: " + ci.Fecha);
            Console.WriteLine("El Telefono del cirujano es: " + ci.Telefono);
            Console.WriteLine("El Email del cirujano es: " + ci.Email);
            Console.ReadKey();

            //Creamos el objeto Medico Familiar
            Medico_Familiar mf = new Medico_Familiar();
            mf.Id = 322;
            mf.Nombre = "Klever";
            mf.Area = "Niños";
            mf.Fecha = "10/enero/1979";
            mf.Telefono = "654-456-6512";
            mf.Email = "KleverLocote@gmail.com";

            //Imprimimos
            Console.WriteLine("____________________________________");
            Console.WriteLine("La id del medico familiar es: " + mf.Id);
            Console.WriteLine("El nombre del medico familiar es: " + mf.Nombre);
            Console.WriteLine("El area del medico familiar es: " + mf.Area);
            Console.WriteLine("La fecha/nac de medico familiar es: " + mf.Fecha);
            Console.WriteLine("El Telefono del medico familiar es: " + mf.Telefono);
            Console.WriteLine("El Email del medico familiar es: " + mf.Email);
            Console.ReadKey();

            //Creamos el objeto Enfermero
            Enfermero en = new Enfermero();
            en.Id = 322;
            en.Nombre = "Marta";
            en.Area = "Docencia";
            en.Fecha = "10/enero/1979";
            en.Telefono = "654-456-6512";
            en.Email = "MartaLocota@gmail.com";

            //Imprimimos
            Console.WriteLine("____________________________________");
            Console.WriteLine("La id de la enfermera es: " + en.Id);
            Console.WriteLine("El nombre de la enfermera es: " + en.Nombre);
            Console.WriteLine("El area de la enfermera es: " + en.Area);
            Console.WriteLine("La fecha/nac de la enfermera es: " + en.Fecha);
            Console.WriteLine("El Telefono de la enfermera es: " + en.Telefono);
            Console.WriteLine("El Email de la enfermera es: " + en.Email);
            Console.ReadKey();
        }

    }
}
